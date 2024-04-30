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
namespace Spotify.Chapters.Item {
    /// <summary>
    /// Builds and executes requests for operations under \chapters\{id}
    /// </summary>
    public class ChaptersItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="ChaptersItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChaptersItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/chapters/{id}{?market*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ChaptersItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChaptersItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/chapters/{id}{?market*}", rawUrl)
        {
        }
        /// <summary>
        /// Get Spotify catalog information for a single chapter.&lt;br /&gt;**Note: Chapters are only available for the US, UK, Ireland, New Zealand and Australia markets.**
        /// </summary>
        /// <returns>A <see cref="ChapterObject"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ChapterObject401Error">When receiving a 401 status code</exception>
        /// <exception cref="ChapterObject403Error">When receiving a 403 status code</exception>
        /// <exception cref="ChapterObject429Error">When receiving a 429 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ChapterObject?> GetAsync(Action<RequestConfiguration<ChaptersItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ChapterObject> GetAsync(Action<RequestConfiguration<ChaptersItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"401", ChapterObject401Error.CreateFromDiscriminatorValue},
                {"403", ChapterObject403Error.CreateFromDiscriminatorValue},
                {"429", ChapterObject429Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ChapterObject>(requestInfo, ChapterObject.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get Spotify catalog information for a single chapter.&lt;br /&gt;**Note: Chapters are only available for the US, UK, Ireland, New Zealand and Australia markets.**
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ChaptersItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ChaptersItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="ChaptersItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ChaptersItemRequestBuilder WithUrl(string rawUrl)
        {
            return new ChaptersItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get Spotify catalog information for a single chapter.&lt;br /&gt;**Note: Chapters are only available for the US, UK, Ireland, New Zealand and Australia markets.**
        /// </summary>
        public class ChaptersItemRequestBuilderGetQueryParameters 
        {
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
        public class ChaptersItemRequestBuilderGetRequestConfiguration : RequestConfiguration<ChaptersItemRequestBuilderGetQueryParameters> 
        {
        }
    }
}
