// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Spotify.Models {
    public class AudiobookBase : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The author(s) for the audiobook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthorObject>? Authors { get; set; }
#nullable restore
#else
        public List<AuthorObject> Authors { get; set; }
#endif
        /// <summary>A list of the countries in which the audiobook can be played, identified by their [ISO 3166-1 alpha-2](http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AvailableMarkets { get; set; }
#nullable restore
#else
        public List<string> AvailableMarkets { get; set; }
#endif
        /// <summary>The copyright statements of the audiobook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CopyrightObject>? Copyrights { get; set; }
#nullable restore
#else
        public List<CopyrightObject> Copyrights { get; set; }
#endif
        /// <summary>A description of the audiobook. HTML tags are stripped away from this field, use `html_description` field in case HTML tags are needed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The edition of the audiobook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Edition { get; set; }
#nullable restore
#else
        public string Edition { get; set; }
#endif
        /// <summary>Whether or not the audiobook has explicit content (true = yes it does; false = no it does not OR unknown).</summary>
        public bool? Explicit { get; set; }
        /// <summary>External URLs for this audiobook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ExternalUrlObject? ExternalUrls { get; set; }
#nullable restore
#else
        public ExternalUrlObject ExternalUrls { get; set; }
#endif
        /// <summary>A link to the Web API endpoint providing full details of the audiobook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Href { get; set; }
#nullable restore
#else
        public string Href { get; set; }
#endif
        /// <summary>A description of the audiobook. This field may contain HTML tags.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlDescription { get; set; }
#nullable restore
#else
        public string HtmlDescription { get; set; }
#endif
        /// <summary>The [Spotify ID](/documentation/web-api/#spotify-uris-and-ids) for the audiobook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The cover art for the audiobook in various sizes, widest first.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ImageObject>? Images { get; set; }
#nullable restore
#else
        public List<ImageObject> Images { get; set; }
#endif
        /// <summary>A list of the languages used in the audiobook, identified by their [ISO 639](https://en.wikipedia.org/wiki/ISO_639) code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Languages { get; set; }
#nullable restore
#else
        public List<string> Languages { get; set; }
#endif
        /// <summary>The media type of the audiobook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MediaType { get; set; }
#nullable restore
#else
        public string MediaType { get; set; }
#endif
        /// <summary>The name of the audiobook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The narrator(s) for the audiobook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<NarratorObject>? Narrators { get; set; }
#nullable restore
#else
        public List<NarratorObject> Narrators { get; set; }
#endif
        /// <summary>The publisher of the audiobook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Publisher { get; set; }
#nullable restore
#else
        public string Publisher { get; set; }
#endif
        /// <summary>The number of chapters in this audiobook.</summary>
        public int? TotalChapters { get; set; }
        /// <summary>The object type.</summary>
        public AudiobookBase_type? Type { get; set; }
        /// <summary>The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the audiobook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Uri { get; set; }
#nullable restore
#else
        public string Uri { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AudiobookBase"/> and sets the default values.
        /// </summary>
        public AudiobookBase()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AudiobookBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AudiobookBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AudiobookBase();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"authors", n => { Authors = n.GetCollectionOfObjectValues<AuthorObject>(AuthorObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"available_markets", n => { AvailableMarkets = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"copyrights", n => { Copyrights = n.GetCollectionOfObjectValues<CopyrightObject>(CopyrightObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"edition", n => { Edition = n.GetStringValue(); } },
                {"explicit", n => { Explicit = n.GetBoolValue(); } },
                {"external_urls", n => { ExternalUrls = n.GetObjectValue<ExternalUrlObject>(ExternalUrlObject.CreateFromDiscriminatorValue); } },
                {"href", n => { Href = n.GetStringValue(); } },
                {"html_description", n => { HtmlDescription = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"images", n => { Images = n.GetCollectionOfObjectValues<ImageObject>(ImageObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"languages", n => { Languages = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"media_type", n => { MediaType = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"narrators", n => { Narrators = n.GetCollectionOfObjectValues<NarratorObject>(NarratorObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"total_chapters", n => { TotalChapters = n.GetIntValue(); } },
                {"type", n => { Type = n.GetEnumValue<AudiobookBase_type>(); } },
                {"uri", n => { Uri = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AuthorObject>("authors", Authors);
            writer.WriteCollectionOfPrimitiveValues<string>("available_markets", AvailableMarkets);
            writer.WriteCollectionOfObjectValues<CopyrightObject>("copyrights", Copyrights);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("edition", Edition);
            writer.WriteBoolValue("explicit", Explicit);
            writer.WriteObjectValue<ExternalUrlObject>("external_urls", ExternalUrls);
            writer.WriteStringValue("href", Href);
            writer.WriteStringValue("html_description", HtmlDescription);
            writer.WriteStringValue("id", Id);
            writer.WriteCollectionOfObjectValues<ImageObject>("images", Images);
            writer.WriteCollectionOfPrimitiveValues<string>("languages", Languages);
            writer.WriteStringValue("media_type", MediaType);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<NarratorObject>("narrators", Narrators);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteIntValue("total_chapters", TotalChapters);
            writer.WriteEnumValue<AudiobookBase_type>("type", Type);
            writer.WriteStringValue("uri", Uri);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}