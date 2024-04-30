// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Spotify.Me.Tracks.Contains;
using Spotify.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Spotify.Me.Tracks {
    /// <summary>
    /// Builds and executes requests for operations under \me\tracks
    /// </summary>
    public class TracksRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The contains property</summary>
        public ContainsRequestBuilder Contains
        {
            get => new ContainsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="TracksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TracksRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/tracks{?limit*,market*,offset*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="TracksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TracksRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/tracks{?limit*,market*,offset*}", rawUrl)
        {
        }
        /// <summary>
        /// Remove one or more tracks from the current user&apos;s &apos;Your Music&apos; library.
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Tracks401Error">When receiving a 401 status code</exception>
        /// <exception cref="Tracks403Error">When receiving a 403 status code</exception>
        /// <exception cref="Tracks429Error">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> DeleteAsync(TracksDeleteRequestBody body, Action<RequestConfiguration<TracksRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> DeleteAsync(TracksDeleteRequestBody body, Action<RequestConfiguration<TracksRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToDeleteRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", Tracks401Error.CreateFromDiscriminatorValue},
                {"403", Tracks403Error.CreateFromDiscriminatorValue},
                {"429", Tracks429Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a list of the songs saved in the current Spotify user&apos;s &apos;Your Music&apos; library.
        /// </summary>
        /// <returns>A <see cref="PagingSavedTrackObject"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="PagingSavedTrackObject401Error">When receiving a 401 status code</exception>
        /// <exception cref="PagingSavedTrackObject403Error">When receiving a 403 status code</exception>
        /// <exception cref="PagingSavedTrackObject429Error">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PagingSavedTrackObject?> GetAsync(Action<RequestConfiguration<TracksRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<PagingSavedTrackObject> GetAsync(Action<RequestConfiguration<TracksRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", PagingSavedTrackObject401Error.CreateFromDiscriminatorValue},
                {"403", PagingSavedTrackObject403Error.CreateFromDiscriminatorValue},
                {"429", PagingSavedTrackObject429Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<PagingSavedTrackObject>(requestInfo, PagingSavedTrackObject.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Save one or more tracks to the current user&apos;s &apos;Your Music&apos; library.
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Tracks401Error">When receiving a 401 status code</exception>
        /// <exception cref="Tracks403Error">When receiving a 403 status code</exception>
        /// <exception cref="Tracks429Error">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> PutAsync(TracksPutRequestBody body, Action<RequestConfiguration<TracksRequestBuilderPutQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> PutAsync(TracksPutRequestBody body, Action<RequestConfiguration<TracksRequestBuilderPutQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", Tracks401Error.CreateFromDiscriminatorValue},
                {"403", Tracks403Error.CreateFromDiscriminatorValue},
                {"429", Tracks429Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Remove one or more tracks from the current user&apos;s &apos;Your Music&apos; library.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(TracksDeleteRequestBody body, Action<RequestConfiguration<TracksRequestBuilderDeleteQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(TracksDeleteRequestBody body, Action<RequestConfiguration<TracksRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/me/tracks?ids={ids}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Get a list of the songs saved in the current Spotify user&apos;s &apos;Your Music&apos; library.
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
        /// Save one or more tracks to the current user&apos;s &apos;Your Music&apos; library.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(TracksPutRequestBody body, Action<RequestConfiguration<TracksRequestBuilderPutQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(TracksPutRequestBody body, Action<RequestConfiguration<TracksRequestBuilderPutQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, "{+baseurl}/me/tracks?ids={ids}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
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
        /// Remove one or more tracks from the current user&apos;s &apos;Your Music&apos; library.
        /// </summary>
        public class TracksRequestBuilderDeleteQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("ids")]
            public string? Ids { get; set; }
#nullable restore
#else
            [QueryParameter("ids")]
            public string Ids { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class TracksRequestBuilderDeleteRequestConfiguration : RequestConfiguration<TracksRequestBuilderDeleteQueryParameters> 
        {
        }
        /// <summary>
        /// Get a list of the songs saved in the current Spotify user&apos;s &apos;Your Music&apos; library.
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
        /// <summary>
        /// Save one or more tracks to the current user&apos;s &apos;Your Music&apos; library.
        /// </summary>
        public class TracksRequestBuilderPutQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("ids")]
            public string? Ids { get; set; }
#nullable restore
#else
            [QueryParameter("ids")]
            public string Ids { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class TracksRequestBuilderPutRequestConfiguration : RequestConfiguration<TracksRequestBuilderPutQueryParameters> 
        {
        }
    }
}
