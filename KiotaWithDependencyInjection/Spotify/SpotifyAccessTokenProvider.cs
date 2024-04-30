using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Microsoft.Kiota.Abstractions.Authentication;

namespace KiotaWithDependencyInjection.Spotify;

/// <summary>
/// An access token provider for Spotify.
/// </summary>
public class SpotifyAccessTokenProvider : IAccessTokenProvider
{
    private readonly SpotifySettings _settings;
    private readonly HttpClient _httpClient;
    private readonly IMemoryCache? _memoryCache;

    /// <summary>
    /// Initializes a new instance of <see cref="SpotifyAccessTokenProvider"/>.
    /// </summary>
    /// <param name="options">Required settings (validated at startup)</param>
    /// <param name="httpClient">Pre-configured httpclient</param>
    /// <param name="memoryCache">(optional) Memory cache to cache the token.</param>
    public SpotifyAccessTokenProvider(IOptions<SpotifySettings> options,  HttpClient httpClient, IMemoryCache? memoryCache)
    {
        _settings = options.Value;
        _memoryCache = memoryCache;
        _httpClient = httpClient;
    }

    /// <inheritdoc/>
    public AllowedHostsValidator AllowedHostsValidator => new AllowedHostsValidator(["accounts.spotify.com", "api.spotify.com"]);

    /// <inheritdoc/>
    public Task<string> GetAuthorizationTokenAsync(Uri uri, Dictionary<string, object>? additionalAuthenticationContext = null, CancellationToken cancellationToken = default)
    {
        if (AllowedHostsValidator.IsUrlHostValid(uri))
        {
            return GetAccessTokenAsync(cancellationToken);
        }
        throw new InvalidOperationException("The provided URL is not allowed");
    }

    private async Task<string> GetAccessTokenAsync(CancellationToken cancellationToken)
    {
        if (_memoryCache?.TryGetValue("SpotifyAccessToken", out string? token) == true)
        {
            return token!;
        }
        var request = new HttpRequestMessage(HttpMethod.Post, "https://accounts.spotify.com/api/token");
        //request.Headers.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{_settings.ClientId}:{_settings.ClientSecret}")));
        request.Content = new FormUrlEncodedContent(new Dictionary<string, string>
        {
            ["grant_type"] = "client_credentials",
            ["client_id"] = _settings.ClientId!,
            ["client_secret"] = _settings.ClientSecret!
        });
        var response = await _httpClient.SendAsync(request, cancellationToken);
        response.EnsureSuccessStatusCode();
        var tokenResponse = await response.Content.ReadFromJsonAsync<AccessTokenResult>(cancellationToken);
        _memoryCache?.Set("SpotifyAccessToken", tokenResponse!.AccessToken, TimeSpan.FromSeconds(tokenResponse.ExpiresIn - 300));
        return tokenResponse!.AccessToken;
    }
}
