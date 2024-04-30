# Using Kiota with Dependency Injection

This sample demonstrates how to use [Kiota](https://learn.microsoft.com/en-us/openapi/kiota/overview?wt.mc_id=SEC-MVP-5004985)_ with [Microsoft.Extensions.DependencyInjection](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection?wt.mc_id=SEC-MVP-5004985).

Because this implementation uses the `HttpClientFactory` you will never have to worry about running out of sockets, as the `HttpClientFactory` will manage the sockets for you.
This implementation will also work directly in Blazor WebAssembly, because the HttpClientFactory is set up to work with Blazor and we are having issues with the implementation for managing the sockets in for instance the Graph client.

Why did you pick Spotify as an example? Because it is a public api that requires an access token, which shows all the steps required to connect this to a real-world scenario.

## Prerequisites

To run this project yourself, you will need to:

- Have .NET8 SDK installed.
- Create a [Spotify application](https://developer.spotify.com/documentation/web-api/tutorials/getting-started)
- Edit the User secrets of the project and add:

```json
{
  "Spotify:ClientId": "YOUR_CLIENT_ID",
  "Spotify:ClientSecret": "YOUR CLIENT_SECRET"
}
```

No need to worry, the project will throw an error if you forgot this step.

## Project structure

- `KiotaWithDependencyInjection` [source](./KiotaWithDependencyInjection) is the main project that demonstrates how to use Kiota with Microsoft.Extensions.DependencyInjection.
- `Spotify` [source](./Spotify) contains the generated code from the Spotify API OpenAPI specification.

## KiotaWithDependencyInjection

This project is where the magic happens.

### Kiota folder [source](./KiotaWithDependencyInjection/Kiota)

In the `Kiota` folder, you will find the `KiotaServiceCollectionExtensions` class, which contains the extension methods to register the Kiota handlers in the `IServiceCollection`.
Be sure to call the `AddKiotaHandlers` method in the `Program.cs` file to register the Kiota handlers, this needs to be called only once, even if you use multiple Kiota clients.

```csharp
var builder = WebApplication.CreateBuilder(args);

...
builder.Services.AddKiotaHandlers();
```

which is short for:

```csharp
using Microsoft.Kiota.Http.HttpClientLibrary.Middleware;
using Microsoft.Kiota.Http.HttpClientLibrary.Middleware.Options;
...
builder.Services.AddTransient<UriReplacementHandler<UriReplacementHandlerOption>>();
builder.Services.AddTransient<RetryHandler>();
builder.Services.AddTransient<RedirectHandler>();
builder.Services.AddTransient<ParametersNameDecodingHandler>();
builder.Services.AddTransient<UserAgentHandler>();
builder.Services.AddTransient<HeadersInspectionHandler>();
```

It also has the `AddKiotaHandlers` extension method for the `IHttpClientBuilder` which adds all the Kiota handlers to that specific http client.

```csharp
builder.Services.AddHttpClient<SpotifyFactory>((sp, client) =>
{
...
}).AddKiotaHandlers(); // This line
```

Which is short for:

```csharp
using Microsoft.Kiota.Http.HttpClientLibrary.Middleware;
using Microsoft.Kiota.Http.HttpClientLibrary.Middleware.Options;
...
builder.Services.AddHttpClient<SpotifyFactory>((sp, client) =>
{
...
}).AddHttpMessageHandler<UriReplacementHandler<UriReplacementHandlerOption>>()
  .AddHttpMessageHandler<RetryHandler>()
  .AddHttpMessageHandler<RedirectHandler>()
  .AddHttpMessageHandler<ParametersNameDecodingHandler>()
  .AddHttpMessageHandler<UserAgentHandler>()
  .AddHttpMessageHandler<HeadersInspectionHandler>();
```

### Spotify folder [source](./KiotaWithDependencyInjection/Spotify)

- `AccessTokenResult` model that is used to parse the access token response from the spotify api.
- `SpotifyAccessTokenProvider` class that is responsible for getting the access token from the Spotify API and attaching it to the request.
- `SpotifyFactory` class that implements the factory pattern to create the spotify client, it is registered in the `IServiceCollection` itself to be able to inject all the dependencies.
- `SpotifyServiceCollectionExtensions` static class that adds the `.AddSpotifyClient` extension method to the `IServiceCollection` to register the Spotify client.
- `SpotifySettings` class that holds the settings required to talk to Spotify, which are validated at startup.

## SpotifyController [source](./KiotaWithDependencyInjection/Controllers/SpotifyController.cs)]

This is the controller that demonstrates how to use the Spotify client, it is injected in the constructor (as you would do with any other dependency) and used in several methods.

```csharp
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Spotify;

namespace KiotaWithDependencyInjection.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SpotifyController : ControllerBase
{
    private readonly ILogger<SpotifyController> _logger;
    private readonly SpotifyClient _spotifyClient;

    public SpotifyController(ILogger<SpotifyController> logger, SpotifyClient spotifyClient)
    {
        _logger = logger;
        _spotifyClient = spotifyClient;
    }

    [HttpGet("artist/{id}")]
    public async Task<IActionResult> GetArtistAsync([FromRoute] string id, CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            return BadRequest("Id parameter is required");
        }
        _logger.LogInformation($"Getting artist with id {id}");
        var response = await _spotifyClient.Artists.GetAsArtistsGetResponseAsync(req =>
        {
            req.QueryParameters.Ids = id;
        }, cancellationToken);
        return Ok(response?.Artists);
    }
}
```

