// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Spotify.Models {
    public class CurrentlyPlayingContextObject : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Allows to update the user interface based on which playback actions are available within the current context.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DisallowsObject? Actions { get; set; }
#nullable restore
#else
        public DisallowsObject Actions { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A Context Object. Can be `null`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ContextObject? Context { get; set; }
#nullable restore
#else
        public ContextObject Context { get; set; }
#endif
        /// <summary>The object type of the currently playing item. Can be one of `track`, `episode`, `ad` or `unknown`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrentlyPlayingType { get; set; }
#nullable restore
#else
        public string CurrentlyPlayingType { get; set; }
#endif
        /// <summary>The device that is currently active.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceObject? Device { get; set; }
#nullable restore
#else
        public DeviceObject Device { get; set; }
#endif
        /// <summary>If something is currently playing, return `true`.</summary>
        public bool? IsPlaying { get; set; }
        /// <summary>The currently playing track or episode. Can be `null`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CurrentlyPlayingContextObject_item? Item { get; set; }
#nullable restore
#else
        public CurrentlyPlayingContextObject_item Item { get; set; }
#endif
        /// <summary>Progress into the currently playing track or episode. Can be `null`.</summary>
        public int? ProgressMs { get; set; }
        /// <summary>off, track, context</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RepeatState { get; set; }
#nullable restore
#else
        public string RepeatState { get; set; }
#endif
        /// <summary>If shuffle is on or off.</summary>
        public bool? ShuffleState { get; set; }
        /// <summary>Unix Millisecond Timestamp when data was fetched.</summary>
        public int? Timestamp { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="CurrentlyPlayingContextObject"/> and sets the default values.
        /// </summary>
        public CurrentlyPlayingContextObject()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CurrentlyPlayingContextObject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CurrentlyPlayingContextObject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CurrentlyPlayingContextObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"actions", n => { Actions = n.GetObjectValue<DisallowsObject>(DisallowsObject.CreateFromDiscriminatorValue); } },
                {"context", n => { Context = n.GetObjectValue<ContextObject>(ContextObject.CreateFromDiscriminatorValue); } },
                {"currently_playing_type", n => { CurrentlyPlayingType = n.GetStringValue(); } },
                {"device", n => { Device = n.GetObjectValue<DeviceObject>(DeviceObject.CreateFromDiscriminatorValue); } },
                {"is_playing", n => { IsPlaying = n.GetBoolValue(); } },
                {"item", n => { Item = n.GetObjectValue<CurrentlyPlayingContextObject_item>(CurrentlyPlayingContextObject_item.CreateFromDiscriminatorValue); } },
                {"progress_ms", n => { ProgressMs = n.GetIntValue(); } },
                {"repeat_state", n => { RepeatState = n.GetStringValue(); } },
                {"shuffle_state", n => { ShuffleState = n.GetBoolValue(); } },
                {"timestamp", n => { Timestamp = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DisallowsObject>("actions", Actions);
            writer.WriteObjectValue<ContextObject>("context", Context);
            writer.WriteStringValue("currently_playing_type", CurrentlyPlayingType);
            writer.WriteObjectValue<DeviceObject>("device", Device);
            writer.WriteBoolValue("is_playing", IsPlaying);
            writer.WriteObjectValue<CurrentlyPlayingContextObject_item>("item", Item);
            writer.WriteIntValue("progress_ms", ProgressMs);
            writer.WriteStringValue("repeat_state", RepeatState);
            writer.WriteBoolValue("shuffle_state", ShuffleState);
            writer.WriteIntValue("timestamp", Timestamp);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="EpisodeObject"/>, <see cref="TrackObject"/>
        /// </summary>
        public class CurrentlyPlayingContextObject_item : IComposedTypeWrapper, IParsable 
        {
            /// <summary>Composed type representation for type <see cref="Spotify.Models.EpisodeObject"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public Spotify.Models.EpisodeObject? EpisodeObject { get; set; }
#nullable restore
#else
            public Spotify.Models.EpisodeObject EpisodeObject { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="Spotify.Models.TrackObject"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public Spotify.Models.TrackObject? TrackObject { get; set; }
#nullable restore
#else
            public Spotify.Models.TrackObject TrackObject { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="CurrentlyPlayingContextObject_item"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static CurrentlyPlayingContextObject_item CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("type")?.GetStringValue();
                var result = new CurrentlyPlayingContextObject_item();
                if("EpisodeObject".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.EpisodeObject = new Spotify.Models.EpisodeObject();
                }
                else if("TrackObject".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.TrackObject = new Spotify.Models.TrackObject();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(EpisodeObject != null)
                {
                    return EpisodeObject.GetFieldDeserializers();
                }
                else if(TrackObject != null)
                {
                    return TrackObject.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(EpisodeObject != null)
                {
                    writer.WriteObjectValue<Spotify.Models.EpisodeObject>(null, EpisodeObject);
                }
                else if(TrackObject != null)
                {
                    writer.WriteObjectValue<Spotify.Models.TrackObject>(null, TrackObject);
                }
            }
        }
    }
}
