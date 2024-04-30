using Microsoft.Kiota.Http.HttpClientLibrary.Middleware;
using Microsoft.Kiota.Http.HttpClientLibrary.Middleware.Options;

namespace KiotaWithDependencyInjection.Kiota;

/// <summary>
/// Service collection extensions for Kiota handlers.
/// </summary>
public static class KiotaServiceCollectionExtensions
{
    /// <summary>
    /// Adds the Kiota handlers to the service collection.
    /// </summary>
    /// <param name="services"><see cref="IServiceCollection"/> to add the services to</param>
    /// <returns><see cref="IServiceCollection"/> as per convention</returns>
    /// <remarks>The handlers are added to the http client by the <see cref="AddKiotaHandlers(IHttpClientBuilder)"/> call, which requires them to be pre-registered in DI</remarks>
    public static IServiceCollection AddKiotaHandlers(this IServiceCollection services)
    {
        services.AddTransient<UriReplacementHandler<UriReplacementHandlerOption>>();
        services.AddTransient<RetryHandler>();
        services.AddTransient<RedirectHandler>();
        services.AddTransient<ParametersNameDecodingHandler>();
        services.AddTransient<UserAgentHandler>();
        services.AddTransient<HeadersInspectionHandler>();
        return services;
    }

    /// <summary>
    /// Adds the Kiota handlers to the http client builder.
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    /// <remarks>
    /// Requires the handlers to be registered in DI by <see cref="AddKiotaHandlers(IServiceCollection)"/>.
    /// The order in which the handlers are added is important, as it defines the order in which they will be executed.
    /// <see href="https://github.com/microsoft/kiota-http-dotnet/blob/c1c295d3b0ebb2182b66d9a6858241117b59b540/src/KiotaClientFactory.cs#L50-L62">KiotaClientFactory.cs</see> for the default order.
    /// </remarks>
    public static IHttpClientBuilder AddKiotaHandlers(this IHttpClientBuilder builder)
    {
        builder.AddHttpMessageHandler<UriReplacementHandler<UriReplacementHandlerOption>>();
        builder.AddHttpMessageHandler<RetryHandler>();
        builder.AddHttpMessageHandler<RedirectHandler>();
        builder.AddHttpMessageHandler<ParametersNameDecodingHandler>();
        builder.AddHttpMessageHandler<UserAgentHandler>();
        builder.AddHttpMessageHandler<HeadersInspectionHandler>();
        return builder;
    }
}
