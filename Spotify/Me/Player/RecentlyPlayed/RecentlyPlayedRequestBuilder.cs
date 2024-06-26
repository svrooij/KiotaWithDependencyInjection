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
namespace Spotify.Me.Player.RecentlyPlayed {
    /// <summary>
    /// Builds and executes requests for operations under \me\player\recently-played
    /// </summary>
    public class RecentlyPlayedRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="RecentlyPlayedRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RecentlyPlayedRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/player/recently-played{?after*,before*,limit*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="RecentlyPlayedRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RecentlyPlayedRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/player/recently-played{?after*,before*,limit*}", rawUrl)
        {
        }
        /// <summary>
        /// Get tracks from the current user&apos;s recently played tracks._**Note**: Currently doesn&apos;t support podcast episodes._
        /// </summary>
        /// <returns>A <see cref="CursorPagingPlayHistoryObject"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="CursorPagingPlayHistoryObject401Error">When receiving a 401 status code</exception>
        /// <exception cref="CursorPagingPlayHistoryObject403Error">When receiving a 403 status code</exception>
        /// <exception cref="CursorPagingPlayHistoryObject429Error">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CursorPagingPlayHistoryObject?> GetAsync(Action<RequestConfiguration<RecentlyPlayedRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<CursorPagingPlayHistoryObject> GetAsync(Action<RequestConfiguration<RecentlyPlayedRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", CursorPagingPlayHistoryObject401Error.CreateFromDiscriminatorValue},
                {"403", CursorPagingPlayHistoryObject403Error.CreateFromDiscriminatorValue},
                {"429", CursorPagingPlayHistoryObject429Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<CursorPagingPlayHistoryObject>(requestInfo, CursorPagingPlayHistoryObject.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get tracks from the current user&apos;s recently played tracks._**Note**: Currently doesn&apos;t support podcast episodes._
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<RecentlyPlayedRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<RecentlyPlayedRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="RecentlyPlayedRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RecentlyPlayedRequestBuilder WithUrl(string rawUrl)
        {
            return new RecentlyPlayedRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get tracks from the current user&apos;s recently played tracks._**Note**: Currently doesn&apos;t support podcast episodes._
        /// </summary>
        public class RecentlyPlayedRequestBuilderGetQueryParameters 
        {
            [QueryParameter("after")]
            public int? After { get; set; }
            [QueryParameter("before")]
            public int? Before { get; set; }
            [QueryParameter("limit")]
            public int? Limit { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class RecentlyPlayedRequestBuilderGetRequestConfiguration : RequestConfiguration<RecentlyPlayedRequestBuilderGetQueryParameters> 
        {
        }
    }
}
