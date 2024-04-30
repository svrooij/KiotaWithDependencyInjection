using System.Text.Json.Serialization;

namespace KiotaWithDependencyInjection.Spotify;

public class AccessTokenResult
{
    [JsonPropertyName("access_token")]
    public required string AccessToken { get; set; }
    [JsonPropertyName("token_type")]
    public required string TokenType { get; set; }
    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; set; }
}
