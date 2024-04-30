using KiotaWithDependencyInjection.Kiota;
using Microsoft.Extensions.Options;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Spotify;

namespace KiotaWithDependencyInjection.Spotify;

/// <summary>
/// A factory to create instances of <see cref="SpotifyClient"/> with a pre-defined configuration.
/// </summary>
/// 
public class SpotifyFactory
{
    // We are only using the HttpClient and Setting at this point, but you can add more dependencies here.
    private readonly HttpClient _httpClient;
    private readonly SpotifyAccessTokenProvider _authProvider;

    /// <summary>
    /// Initializes a new instance of <see cref="SpotifyFactory"/>.
    /// </summary>
    /// <param name="httpClient">Pre-configured <see cref="HttpClient"/></param>
    /// <param name="authProvider"><see cref="SpotifyAccessTokenProvider"/> with information to access the api</param>
    public SpotifyFactory(HttpClient httpClient, SpotifyAccessTokenProvider authProvider)
    {
        _httpClient = httpClient;
        _authProvider = authProvider;
    }

    /// <summary>
    /// Creates a new instance of <see cref="SpotifyClient"/>, used as a factory for the client.
    /// </summary>
    /// <returns></returns>
    public SpotifyClient Create()
    {
        var httpClientRequestAdapter = new HttpClientRequestAdapter(new BaseBearerTokenAuthenticationProvider(_authProvider), httpClient: _httpClient);
        return new SpotifyClient(httpClientRequestAdapter);
    }
}
