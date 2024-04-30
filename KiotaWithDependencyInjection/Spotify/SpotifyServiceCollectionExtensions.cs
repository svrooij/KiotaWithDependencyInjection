using KiotaWithDependencyInjection.Kiota;
using Microsoft.Extensions.Options;
using Spotify;

namespace KiotaWithDependencyInjection.Spotify;

public static class SpotifyServiceCollectionExtensions
{
    /// <summary>
    /// Adds the Spotify client to the service collection.
    /// </summary>
    /// <param name="services"><see cref="IServiceCollection"/> to add the Spotify client to</param>
    /// <param name="configurationSectionName">Name of the configuration section</param>
    /// <returns></returns>
    public static IServiceCollection AddSpotifyClient(this IServiceCollection services, string configurationSectionName = "Spotify")
    {
        // Argument validation
        ArgumentNullException.ThrowIfNull(services);
        ArgumentException.ThrowIfNullOrWhiteSpace(configurationSectionName);

        // Register the settings and make sure they are valid on start
        // This will throw an exception if the settings are not valid
        // and is a good way to fail fast instead of at runtime.
        services.AddOptions<SpotifySettings>()
            .BindConfiguration(configurationSectionName)
            .ValidateDataAnnotations()
            .ValidateOnStart();

        // Register the factory, `AddHttpClient<T>` is a build-in extension that registeres the <T> as a transient service, and allows you to configure the http client.
        services.AddHttpClient<SpotifyFactory>((sp, client) =>
        {
            // Load the settings from the service provider
            // And set the base url if it's not null
            var settings = sp.GetRequiredService<IOptions<SpotifySettings>>().Value;
            if (settings.BaseUrl != null)
                client.BaseAddress = new Uri(settings.BaseUrl);

            // You can configure anything you want here, like headers, timeouts, etc.

        }).AddKiotaHandlers(); // This line is important, because Kiota uses handlers to do all sort of things like retry and header inspection.

        // Register the access token provider, which needs it's own http client to get a token.
        services.AddHttpClient<SpotifyAccessTokenProvider>();

        // Register the client actual client, using the factory pattern to create it.
        // `<SpotifyClient>` is just for clearity, it's not required.
        services.AddTransient<SpotifyClient>(sp =>
        {
            var factory = sp.GetRequiredService<SpotifyFactory>();
            return factory.Create();
        });

        // Or if you prefer a one-liner as me.
        //services.AddTransient(sp => sp.GetRequiredService<SpotifyFactory>().Create());


        // Return the services, as convention.
        return services;
    }
}
