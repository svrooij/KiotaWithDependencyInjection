// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Spotify.Me.Following.Contains;
using Spotify.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Spotify.Me.Following {
    /// <summary>
    /// Builds and executes requests for operations under \me\following
    /// </summary>
    public class FollowingRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The contains property</summary>
        public ContainsRequestBuilder Contains
        {
            get => new ContainsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="FollowingRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FollowingRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/following?type={type}{&after*,limit*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="FollowingRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FollowingRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/following?type={type}{&after*,limit*}", rawUrl)
        {
        }
        /// <summary>
        /// Remove the current user as a follower of one or more artists or other Spotify users.
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Following401Error">When receiving a 401 status code</exception>
        /// <exception cref="Following403Error">When receiving a 403 status code</exception>
        /// <exception cref="Following429Error">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> DeleteAsync(FollowingDeleteRequestBody body, Action<RequestConfiguration<FollowingRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> DeleteAsync(FollowingDeleteRequestBody body, Action<RequestConfiguration<FollowingRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToDeleteRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", Following401Error.CreateFromDiscriminatorValue},
                {"403", Following403Error.CreateFromDiscriminatorValue},
                {"429", Following429Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the current user&apos;s followed artists.
        /// </summary>
        /// <returns>A <see cref="FollowingGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Following401Error">When receiving a 401 status code</exception>
        /// <exception cref="Following403Error">When receiving a 403 status code</exception>
        /// <exception cref="Following429Error">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<FollowingGetResponse?> GetAsFollowingGetResponseAsync(Action<RequestConfiguration<FollowingRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<FollowingGetResponse> GetAsFollowingGetResponseAsync(Action<RequestConfiguration<FollowingRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", Following401Error.CreateFromDiscriminatorValue},
                {"403", Following403Error.CreateFromDiscriminatorValue},
                {"429", Following429Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<FollowingGetResponse>(requestInfo, FollowingGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the current user&apos;s followed artists.
        /// </summary>
        /// <returns>A <see cref="FollowingResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Following401Error">When receiving a 401 status code</exception>
        /// <exception cref="Following403Error">When receiving a 403 status code</exception>
        /// <exception cref="Following429Error">When receiving a 429 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsFollowingGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<FollowingResponse?> GetAsync(Action<RequestConfiguration<FollowingRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<FollowingResponse> GetAsync(Action<RequestConfiguration<FollowingRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", Following401Error.CreateFromDiscriminatorValue},
                {"403", Following403Error.CreateFromDiscriminatorValue},
                {"429", Following429Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<FollowingResponse>(requestInfo, FollowingResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Add the current user as a follower of one or more artists or other Spotify users.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Following401Error">When receiving a 401 status code</exception>
        /// <exception cref="Following403Error">When receiving a 403 status code</exception>
        /// <exception cref="Following429Error">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PutAsync(FollowingPutRequestBody body, Action<RequestConfiguration<FollowingRequestBuilderPutQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PutAsync(FollowingPutRequestBody body, Action<RequestConfiguration<FollowingRequestBuilderPutQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", Following401Error.CreateFromDiscriminatorValue},
                {"403", Following403Error.CreateFromDiscriminatorValue},
                {"429", Following429Error.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Remove the current user as a follower of one or more artists or other Spotify users.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(FollowingDeleteRequestBody body, Action<RequestConfiguration<FollowingRequestBuilderDeleteQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(FollowingDeleteRequestBody body, Action<RequestConfiguration<FollowingRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/me/following?ids={ids}&type={type}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Get the current user&apos;s followed artists.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<FollowingRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<FollowingRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Add the current user as a follower of one or more artists or other Spotify users.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(FollowingPutRequestBody body, Action<RequestConfiguration<FollowingRequestBuilderPutQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(FollowingPutRequestBody body, Action<RequestConfiguration<FollowingRequestBuilderPutQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, "{+baseurl}/me/following?ids={ids}&type={type}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="FollowingRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public FollowingRequestBuilder WithUrl(string rawUrl)
        {
            return new FollowingRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Remove the current user as a follower of one or more artists or other Spotify users.
        /// </summary>
        public class FollowingRequestBuilderDeleteQueryParameters 
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
            [Obsolete("This property is deprecated, use TypeAsItemType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("type")]
            public string? Type { get; set; }
#nullable restore
#else
            [QueryParameter("type")]
            public string Type { get; set; }
#endif
            [QueryParameter("type")]
            public ItemType? TypeAsItemType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class FollowingRequestBuilderDeleteRequestConfiguration : RequestConfiguration<FollowingRequestBuilderDeleteQueryParameters> 
        {
        }
        /// <summary>
        /// Get the current user&apos;s followed artists.
        /// </summary>
        public class FollowingRequestBuilderGetQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("after")]
            public string? After { get; set; }
#nullable restore
#else
            [QueryParameter("after")]
            public string After { get; set; }
#endif
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            [Obsolete("This property is deprecated, use TypeAsItemType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("type")]
            public string? Type { get; set; }
#nullable restore
#else
            [QueryParameter("type")]
            public string Type { get; set; }
#endif
            [QueryParameter("type")]
            public ItemType? TypeAsItemType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class FollowingRequestBuilderGetRequestConfiguration : RequestConfiguration<FollowingRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Add the current user as a follower of one or more artists or other Spotify users.
        /// </summary>
        public class FollowingRequestBuilderPutQueryParameters 
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
            [Obsolete("This property is deprecated, use TypeAsItemType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("type")]
            public string? Type { get; set; }
#nullable restore
#else
            [QueryParameter("type")]
            public string Type { get; set; }
#endif
            [QueryParameter("type")]
            public ItemType? TypeAsItemType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class FollowingRequestBuilderPutRequestConfiguration : RequestConfiguration<FollowingRequestBuilderPutQueryParameters> 
        {
        }
    }
}
