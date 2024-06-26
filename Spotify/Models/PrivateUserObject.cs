// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Spotify.Models {
    public class PrivateUserObject : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The country of the user, as set in the user&apos;s account profile. An [ISO 3166-1 alpha-2 country code](http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2). _This field is only available when the current user has granted access to the [user-read-private](/documentation/general/guides/authorization-guide/#list-of-scopes) scope._</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country { get; set; }
#nullable restore
#else
        public string Country { get; set; }
#endif
        /// <summary>The name displayed on the user&apos;s profile. `null` if not available.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The user&apos;s email address, as entered by the user when creating their account. _**Important!** This email address is unverified; there is no proof that it actually belongs to the user._ _This field is only available when the current user has granted access to the [user-read-email](/documentation/general/guides/authorization-guide/#list-of-scopes) scope._</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The user&apos;s explicit content settings. _This field is only available when the current user has granted access to the [user-read-private](/documentation/general/guides/authorization-guide/#list-of-scopes) scope._</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ExplicitContentSettingsObject? ExplicitContent { get; set; }
#nullable restore
#else
        public ExplicitContentSettingsObject ExplicitContent { get; set; }
#endif
        /// <summary>Known external URLs for this user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ExternalUrlObject? ExternalUrls { get; set; }
#nullable restore
#else
        public ExternalUrlObject ExternalUrls { get; set; }
#endif
        /// <summary>Information about the followers of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FollowersObject? Followers { get; set; }
#nullable restore
#else
        public FollowersObject Followers { get; set; }
#endif
        /// <summary>A link to the Web API endpoint for this user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Href { get; set; }
#nullable restore
#else
        public string Href { get; set; }
#endif
        /// <summary>The [Spotify user ID](/documentation/web-api/#spotify-uris-and-ids) for the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The user&apos;s profile image.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ImageObject>? Images { get; set; }
#nullable restore
#else
        public List<ImageObject> Images { get; set; }
#endif
        /// <summary>The user&apos;s Spotify subscription level: &quot;premium&quot;, &quot;free&quot;, etc. (The subscription level &quot;open&quot; can be considered the same as &quot;free&quot;.) _This field is only available when the current user has granted access to the [user-read-private](/documentation/general/guides/authorization-guide/#list-of-scopes) scope._</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Product { get; set; }
#nullable restore
#else
        public string Product { get; set; }
#endif
        /// <summary>The object type: &quot;user&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Uri { get; set; }
#nullable restore
#else
        public string Uri { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PrivateUserObject"/> and sets the default values.
        /// </summary>
        public PrivateUserObject()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PrivateUserObject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PrivateUserObject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivateUserObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"country", n => { Country = n.GetStringValue(); } },
                {"display_name", n => { DisplayName = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"explicit_content", n => { ExplicitContent = n.GetObjectValue<ExplicitContentSettingsObject>(ExplicitContentSettingsObject.CreateFromDiscriminatorValue); } },
                {"external_urls", n => { ExternalUrls = n.GetObjectValue<ExternalUrlObject>(ExternalUrlObject.CreateFromDiscriminatorValue); } },
                {"followers", n => { Followers = n.GetObjectValue<FollowersObject>(FollowersObject.CreateFromDiscriminatorValue); } },
                {"href", n => { Href = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"images", n => { Images = n.GetCollectionOfObjectValues<ImageObject>(ImageObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"product", n => { Product = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
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
            writer.WriteStringValue("country", Country);
            writer.WriteStringValue("display_name", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteObjectValue<ExplicitContentSettingsObject>("explicit_content", ExplicitContent);
            writer.WriteObjectValue<ExternalUrlObject>("external_urls", ExternalUrls);
            writer.WriteObjectValue<FollowersObject>("followers", Followers);
            writer.WriteStringValue("href", Href);
            writer.WriteStringValue("id", Id);
            writer.WriteCollectionOfObjectValues<ImageObject>("images", Images);
            writer.WriteStringValue("product", Product);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("uri", Uri);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
