// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Spotify.Models {
    public class SimplifiedPlaylistObject : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>`true` if the owner allows other users to modify the playlist.</summary>
        public bool? Collaborative { get; set; }
        /// <summary>The playlist description. _Only returned for modified, verified playlists, otherwise_ `null`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Known external URLs for this playlist.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ExternalUrlObject? ExternalUrls { get; set; }
#nullable restore
#else
        public ExternalUrlObject ExternalUrls { get; set; }
#endif
        /// <summary>A link to the Web API endpoint providing full details of the playlist.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Href { get; set; }
#nullable restore
#else
        public string Href { get; set; }
#endif
        /// <summary>The [Spotify ID](/documentation/web-api/#spotify-uris-and-ids) for the playlist.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Images for the playlist. The array may be empty or contain up to three images. The images are returned by size in descending order. See [Working with Playlists](/documentation/general/guides/working-with-playlists/). _**Note**: If returned, the source URL for the image (`url`) is temporary and will expire in less than a day._</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ImageObject>? Images { get; set; }
#nullable restore
#else
        public List<ImageObject> Images { get; set; }
#endif
        /// <summary>The name of the playlist.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The user who owns the playlist</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FeaturedPlaylists? Owner { get; set; }
#nullable restore
#else
        public FeaturedPlaylists Owner { get; set; }
#endif
        /// <summary>The playlist&apos;s public/private status: `true` the playlist is public, `false` the playlist is private, `null` the playlist status is not relevant. For more about public/private status, see [Working with Playlists](/documentation/general/guides/working-with-playlists/)</summary>
        public bool? Public { get; set; }
        /// <summary>The version identifier for the current playlist. Can be supplied in other requests to target a specific playlist version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SnapshotId { get; set; }
#nullable restore
#else
        public string SnapshotId { get; set; }
#endif
        /// <summary>A collection containing a link ( `href` ) to the Web API endpoint where full details of the playlist&apos;s tracks can be retrieved, along with the `total` number of tracks in the playlist. Note, a track object may be `null`. This can happen if a track is no longer available.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlaylistTracksRefObject? Tracks { get; set; }
#nullable restore
#else
        public PlaylistTracksRefObject Tracks { get; set; }
#endif
        /// <summary>The object type: &quot;playlist&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the playlist.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Uri { get; set; }
#nullable restore
#else
        public string Uri { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="SimplifiedPlaylistObject"/> and sets the default values.
        /// </summary>
        public SimplifiedPlaylistObject()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SimplifiedPlaylistObject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SimplifiedPlaylistObject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SimplifiedPlaylistObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"collaborative", n => { Collaborative = n.GetBoolValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"external_urls", n => { ExternalUrls = n.GetObjectValue<ExternalUrlObject>(ExternalUrlObject.CreateFromDiscriminatorValue); } },
                {"href", n => { Href = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"images", n => { Images = n.GetCollectionOfObjectValues<ImageObject>(ImageObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"owner", n => { Owner = n.GetObjectValue<FeaturedPlaylists>(FeaturedPlaylists.CreateFromDiscriminatorValue); } },
                {"public", n => { Public = n.GetBoolValue(); } },
                {"snapshot_id", n => { SnapshotId = n.GetStringValue(); } },
                {"tracks", n => { Tracks = n.GetObjectValue<PlaylistTracksRefObject>(PlaylistTracksRefObject.CreateFromDiscriminatorValue); } },
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
            writer.WriteBoolValue("collaborative", Collaborative);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<ExternalUrlObject>("external_urls", ExternalUrls);
            writer.WriteStringValue("href", Href);
            writer.WriteStringValue("id", Id);
            writer.WriteCollectionOfObjectValues<ImageObject>("images", Images);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<FeaturedPlaylists>("owner", Owner);
            writer.WriteBoolValue("public", Public);
            writer.WriteStringValue("snapshot_id", SnapshotId);
            writer.WriteObjectValue<PlaylistTracksRefObject>("tracks", Tracks);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("uri", Uri);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
