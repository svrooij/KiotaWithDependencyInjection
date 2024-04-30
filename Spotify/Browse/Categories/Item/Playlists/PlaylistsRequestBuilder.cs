// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Spotify.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Spotify.Browse.Categories.Item.Playlists {
    /// <summary>
    /// Builds and executes requests for operations under \browse\categories\{category_id}\playlists
    /// </summary>
    public class PlaylistsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="PlaylistsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PlaylistsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/browse/categories/{category_id}/playlists{?country*,limit*,offset*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="PlaylistsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PlaylistsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/browse/categories/{category_id}/playlists{?country*,limit*,offset*}", rawUrl)
        {
        }
        /// <summary>
        /// Get a list of Spotify playlists tagged with a particular category.
        /// </summary>
        /// <returns>A <see cref="PagingFeaturedPlaylistObject"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="PagingFeaturedPlaylistObject401Error">When receiving a 401 status code</exception>
        /// <exception cref="PagingFeaturedPlaylistObject403Error">When receiving a 403 status code</exception>
        /// <exception cref="PagingFeaturedPlaylistObject429Error">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PagingFeaturedPlaylistObject?> GetAsync(Action<RequestConfiguration<PlaylistsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<PagingFeaturedPlaylistObject> GetAsync(Action<RequestConfiguration<PlaylistsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", PagingFeaturedPlaylistObject401Error.CreateFromDiscriminatorValue},
                {"403", PagingFeaturedPlaylistObject403Error.CreateFromDiscriminatorValue},
                {"429", PagingFeaturedPlaylistObject429Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<PagingFeaturedPlaylistObject>(requestInfo, PagingFeaturedPlaylistObject.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a list of Spotify playlists tagged with a particular category.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<PlaylistsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<PlaylistsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="PlaylistsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public PlaylistsRequestBuilder WithUrl(string rawUrl)
        {
            return new PlaylistsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get a list of Spotify playlists tagged with a particular category.
        /// </summary>
        public class PlaylistsRequestBuilderGetQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("country")]
            public string? Country { get; set; }
#nullable restore
#else
            [QueryParameter("country")]
            public string Country { get; set; }
#endif
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            [QueryParameter("offset")]
            public int? Offset { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class PlaylistsRequestBuilderGetRequestConfiguration : RequestConfiguration<PlaylistsRequestBuilderGetQueryParameters> 
        {
        }
    }
}
