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
namespace Spotify.Albums.Item.Tracks {
    /// <summary>
    /// Builds and executes requests for operations under \albums\{id}\tracks
    /// </summary>
    public class TracksRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="TracksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TracksRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/albums/{id}/tracks{?limit*,market*,offset*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="TracksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TracksRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/albums/{id}/tracks{?limit*,market*,offset*}", rawUrl)
        {
        }
        /// <summary>
        /// Get Spotify catalog information about an album’s tracks.Optional parameters can be used to limit the number of tracks returned.
        /// </summary>
        /// <returns>A <see cref="PagingSimplifiedTrackObject"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="PagingSimplifiedTrackObject401Error">When receiving a 401 status code</exception>
        /// <exception cref="PagingSimplifiedTrackObject403Error">When receiving a 403 status code</exception>
        /// <exception cref="PagingSimplifiedTrackObject429Error">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PagingSimplifiedTrackObject?> GetAsync(Action<RequestConfiguration<TracksRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<PagingSimplifiedTrackObject> GetAsync(Action<RequestConfiguration<TracksRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", PagingSimplifiedTrackObject401Error.CreateFromDiscriminatorValue},
                {"403", PagingSimplifiedTrackObject403Error.CreateFromDiscriminatorValue},
                {"429", PagingSimplifiedTrackObject429Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<PagingSimplifiedTrackObject>(requestInfo, PagingSimplifiedTrackObject.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get Spotify catalog information about an album’s tracks.Optional parameters can be used to limit the number of tracks returned.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<TracksRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<TracksRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="TracksRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public TracksRequestBuilder WithUrl(string rawUrl)
        {
            return new TracksRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get Spotify catalog information about an album’s tracks.Optional parameters can be used to limit the number of tracks returned.
        /// </summary>
        public class TracksRequestBuilderGetQueryParameters 
        {
            [QueryParameter("limit")]
            public int? Limit { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("market")]
            public string? Market { get; set; }
#nullable restore
#else
            [QueryParameter("market")]
            public string Market { get; set; }
#endif
            [QueryParameter("offset")]
            public int? Offset { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class TracksRequestBuilderGetRequestConfiguration : RequestConfiguration<TracksRequestBuilderGetQueryParameters> 
        {
        }
    }
}