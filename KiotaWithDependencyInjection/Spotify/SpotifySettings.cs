using System.ComponentModel.DataAnnotations;

namespace KiotaWithDependencyInjection.Spotify;

public class SpotifySettings
{
    [Required]
    public string? ClientId { get; set; }
    [Required]
    public string? ClientSecret { get; set; }
    public string? BaseUrl { get; set; }
}
