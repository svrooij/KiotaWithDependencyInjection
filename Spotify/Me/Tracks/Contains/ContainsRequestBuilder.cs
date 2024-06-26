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
namespace Spotify.Me.Tracks.Contains {
    /// <summary>
    /// Builds and executes requests for operations under \me\tracks\contains
    /// </summary>
    public class ContainsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="ContainsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContainsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/tracks/contains?ids={ids}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ContainsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContainsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/tracks/contains?ids={ids}", rawUrl)
        {
        }
        /// <summary>
        /// Check if one or more tracks is already saved in the current Spotify user&apos;s &apos;Your Music&apos; library.
        /// </summary>
        /// <returns>A List&lt;bool&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Contains401Error">When receiving a 401 status code</exception>
        /// <exception cref="Contains403Error">When receiving a 403 status code</exception>
        /// <exception cref="Contains429Error">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<bool?>?> GetAsync(Action<RequestConfiguration<ContainsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<bool?>> GetAsync(Action<RequestConfiguration<ContainsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", Contains401Error.CreateFromDiscriminatorValue},
                {"403", Contains403Error.CreateFromDiscriminatorValue},
                {"429", Contains429Error.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendPrimitiveCollectionAsync<bool?>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Check if one or more tracks is already saved in the current Spotify user&apos;s &apos;Your Music&apos; library.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ContainsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ContainsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="ContainsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ContainsRequestBuilder WithUrl(string rawUrl)
        {
            return new ContainsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Check if one or more tracks is already saved in the current Spotify user&apos;s &apos;Your Music&apos; library.
        /// </summary>
        public class ContainsRequestBuilderGetQueryParameters 
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
        public class ContainsRequestBuilderGetRequestConfiguration : RequestConfiguration<ContainsRequestBuilderGetQueryParameters> 
        {
        }
    }
}
