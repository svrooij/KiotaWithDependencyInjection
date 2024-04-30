// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Spotify.Audiobooks.Item;
using Spotify.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Spotify.Audiobooks {
    /// <summary>
    /// Builds and executes requests for operations under \audiobooks
    /// </summary>
    public class AudiobooksRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the Spotify.audiobooks.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="AudiobooksItemRequestBuilder"/></returns>
        public AudiobooksItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new AudiobooksItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="AudiobooksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AudiobooksRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/audiobooks?ids={ids}{&market*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="AudiobooksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AudiobooksRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/audiobooks?ids={ids}{&market*}", rawUrl)
        {
        }
        /// <summary>
        /// Get Spotify catalog information for several audiobooks identified by their Spotify IDs.&lt;br /&gt;**Note: Audiobooks are only available for the US, UK, Ireland, New Zealand and Australia markets.**
        /// </summary>
        /// <returns>A <see cref="AudiobooksGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Audiobooks401Error">When receiving a 401 status code</exception>
        /// <exception cref="Audiobooks403Error">When receiving a 403 status code</exception>
        /// <exception cref="Audiobooks429Error">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<AudiobooksGetResponse?> GetAsAudiobooksGetResponseAsync(Action<RequestConfiguration<AudiobooksRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<AudiobooksGetResponse> GetAsAudiobooksGetResponseAsync(Action<RequestConfiguration<AudiobooksRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", Audiobooks401Error.CreateFromDiscriminatorValue},
                {"403", Audiobooks403Error.CreateFromDiscriminatorValue},
                {"429", Audiobooks429Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<AudiobooksGetResponse>(requestInfo, AudiobooksGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get Spotify catalog information for several audiobooks identified by their Spotify IDs.&lt;br /&gt;**Note: Audiobooks are only available for the US, UK, Ireland, New Zealand and Australia markets.**
        /// </summary>
        /// <returns>A <see cref="AudiobooksResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Audiobooks401Error">When receiving a 401 status code</exception>
        /// <exception cref="Audiobooks403Error">When receiving a 403 status code</exception>
        /// <exception cref="Audiobooks429Error">When receiving a 429 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsAudiobooksGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<AudiobooksResponse?> GetAsync(Action<RequestConfiguration<AudiobooksRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<AudiobooksResponse> GetAsync(Action<RequestConfiguration<AudiobooksRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", Audiobooks401Error.CreateFromDiscriminatorValue},
                {"403", Audiobooks403Error.CreateFromDiscriminatorValue},
                {"429", Audiobooks429Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<AudiobooksResponse>(requestInfo, AudiobooksResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get Spotify catalog information for several audiobooks identified by their Spotify IDs.&lt;br /&gt;**Note: Audiobooks are only available for the US, UK, Ireland, New Zealand and Australia markets.**
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AudiobooksRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AudiobooksRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="AudiobooksRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AudiobooksRequestBuilder WithUrl(string rawUrl)
        {
            return new AudiobooksRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get Spotify catalog information for several audiobooks identified by their Spotify IDs.&lt;br /&gt;**Note: Audiobooks are only available for the US, UK, Ireland, New Zealand and Australia markets.**
        /// </summary>
        public class AudiobooksRequestBuilderGetQueryParameters 
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("market")]
            public string? Market { get; set; }
#nullable restore
#else
            [QueryParameter("market")]
            public string Market { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class AudiobooksRequestBuilderGetRequestConfiguration : RequestConfiguration<AudiobooksRequestBuilderGetQueryParameters> 
        {
        }
    }
}
