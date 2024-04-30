// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Spotify.Browse.Categories.Item;
using Spotify.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Spotify.Browse.Categories {
    /// <summary>
    /// Builds and executes requests for operations under \browse\categories
    /// </summary>
    public class CategoriesRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the Spotify.browse.categories.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="WithCategory_ItemRequestBuilder"/></returns>
        public WithCategory_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("category_id", position);
                return new WithCategory_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="CategoriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CategoriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/browse/categories{?country*,limit*,locale*,offset*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="CategoriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CategoriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/browse/categories{?country*,limit*,locale*,offset*}", rawUrl)
        {
        }
        /// <summary>
        /// Get a list of categories used to tag items in Spotify (on, for example, the Spotify player’s “Browse” tab).
        /// </summary>
        /// <returns>A <see cref="CategoriesGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Categories401Error">When receiving a 401 status code</exception>
        /// <exception cref="Categories403Error">When receiving a 403 status code</exception>
        /// <exception cref="Categories429Error">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CategoriesGetResponse?> GetAsCategoriesGetResponseAsync(Action<RequestConfiguration<CategoriesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<CategoriesGetResponse> GetAsCategoriesGetResponseAsync(Action<RequestConfiguration<CategoriesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", Categories401Error.CreateFromDiscriminatorValue},
                {"403", Categories403Error.CreateFromDiscriminatorValue},
                {"429", Categories429Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<CategoriesGetResponse>(requestInfo, CategoriesGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a list of categories used to tag items in Spotify (on, for example, the Spotify player’s “Browse” tab).
        /// </summary>
        /// <returns>A <see cref="CategoriesResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Categories401Error">When receiving a 401 status code</exception>
        /// <exception cref="Categories403Error">When receiving a 403 status code</exception>
        /// <exception cref="Categories429Error">When receiving a 429 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsCategoriesGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CategoriesResponse?> GetAsync(Action<RequestConfiguration<CategoriesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<CategoriesResponse> GetAsync(Action<RequestConfiguration<CategoriesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", Categories401Error.CreateFromDiscriminatorValue},
                {"403", Categories403Error.CreateFromDiscriminatorValue},
                {"429", Categories429Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<CategoriesResponse>(requestInfo, CategoriesResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a list of categories used to tag items in Spotify (on, for example, the Spotify player’s “Browse” tab).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CategoriesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CategoriesRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="CategoriesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CategoriesRequestBuilder WithUrl(string rawUrl)
        {
            return new CategoriesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get a list of categories used to tag items in Spotify (on, for example, the Spotify player’s “Browse” tab).
        /// </summary>
        public class CategoriesRequestBuilderGetQueryParameters 
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("locale")]
            public string? Locale { get; set; }
#nullable restore
#else
            [QueryParameter("locale")]
            public string Locale { get; set; }
#endif
            [QueryParameter("offset")]
            public int? Offset { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class CategoriesRequestBuilderGetRequestConfiguration : RequestConfiguration<CategoriesRequestBuilderGetQueryParameters> 
        {
        }
    }
}