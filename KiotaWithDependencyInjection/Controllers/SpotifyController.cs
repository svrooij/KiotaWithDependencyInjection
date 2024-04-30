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

    [HttpGet("search")]
    public async Task<IActionResult> SearchAsync([FromQuery] string query)
    {
        if (string.IsNullOrWhiteSpace(query))
        {
            return BadRequest("Query parameter is required");
        }
        _logger.LogInformation($"Searching for {query}");
        var searchResults = await _spotifyClient.Search.GetAsSearchGetResponseAsync(req =>
        {
            req.QueryParameters.Q = query;
        });
        return Ok(searchResults);
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

    [HttpGet("eminem")]
    public async Task<IActionResult> GetEminemAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Getting Eminem");
        var response = await _spotifyClient.Artists.GetAsArtistsGetResponseAsync(req =>
        {
            req.QueryParameters.Ids = "7dGJo4pcD2V6oG8kP0tJRR";
        }, cancellationToken);
        return Ok(response?.Artists);
    }
}
