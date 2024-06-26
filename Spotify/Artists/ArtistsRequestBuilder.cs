// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Spotify.Artists.Item;
using Spotify.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Spotify.Artists {
    /// <summary>
    /// Builds and executes requests for operations under \artists
    /// </summary>
    public class ArtistsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the Spotify.artists.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="ArtistsItemRequestBuilder"/></returns>
        public ArtistsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new ArtistsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="ArtistsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ArtistsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/artists?ids={ids}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ArtistsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ArtistsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/artists?ids={ids}", rawUrl)
        {
        }
        /// <summary>
        /// Get Spotify catalog information for several artists based on their Spotify IDs.
        /// </summary>
        /// <returns>A <see cref="ArtistsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Artists401Error">When receiving a 401 status code</exception>
        /// <exception cref="Artists403Error">When receiving a 403 status code</exception>
        /// <exception cref="Artists429Error">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ArtistsGetResponse?> GetAsArtistsGetResponseAsync(Action<RequestConfiguration<ArtistsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ArtistsGetResponse> GetAsArtistsGetResponseAsync(Action<RequestConfiguration<ArtistsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", Artists401Error.CreateFromDiscriminatorValue},
                {"403", Artists403Error.CreateFromDiscriminatorValue},
                {"429", Artists429Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ArtistsGetResponse>(requestInfo, ArtistsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get Spotify catalog information for several artists based on their Spotify IDs.
        /// </summary>
        /// <returns>A <see cref="ArtistsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Artists401Error">When receiving a 401 status code</exception>
        /// <exception cref="Artists403Error">When receiving a 403 status code</exception>
        /// <exception cref="Artists429Error">When receiving a 429 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsArtistsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ArtistsResponse?> GetAsync(Action<RequestConfiguration<ArtistsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ArtistsResponse> GetAsync(Action<RequestConfiguration<ArtistsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", Artists401Error.CreateFromDiscriminatorValue},
                {"403", Artists403Error.CreateFromDiscriminatorValue},
                {"429", Artists429Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ArtistsResponse>(requestInfo, ArtistsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get Spotify catalog information for several artists based on their Spotify IDs.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ArtistsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ArtistsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="ArtistsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ArtistsRequestBuilder WithUrl(string rawUrl)
        {
            return new ArtistsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get Spotify catalog information for several artists based on their Spotify IDs.
        /// </summary>
        public class ArtistsRequestBuilderGetQueryParameters 
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
        public class ArtistsRequestBuilderGetRequestConfiguration : RequestConfiguration<ArtistsRequestBuilderGetQueryParameters> 
        {
        }
    }
}
