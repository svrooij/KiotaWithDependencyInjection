// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Spotify.Models {
    public class AudioAnalysisObject : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The time intervals of the bars throughout the track. A bar (or measure) is a segment of time defined as a given number of beats.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TimeIntervalObject>? Bars { get; set; }
#nullable restore
#else
        public List<TimeIntervalObject> Bars { get; set; }
#endif
        /// <summary>The time intervals of beats throughout the track. A beat is the basic time unit of a piece of music; for example, each tick of a metronome. Beats are typically multiples of tatums.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TimeIntervalObject>? Beats { get; set; }
#nullable restore
#else
        public List<TimeIntervalObject> Beats { get; set; }
#endif
        /// <summary>The meta property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AudioAnalysisObject_meta? Meta { get; set; }
#nullable restore
#else
        public AudioAnalysisObject_meta Meta { get; set; }
#endif
        /// <summary>Sections are defined by large variations in rhythm or timbre, e.g. chorus, verse, bridge, guitar solo, etc. Each section contains its own descriptions of tempo, key, mode, time_signature, and loudness.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SectionObject>? Sections { get; set; }
#nullable restore
#else
        public List<SectionObject> Sections { get; set; }
#endif
        /// <summary>Each segment contains a roughly conisistent sound throughout its duration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SegmentObject>? Segments { get; set; }
#nullable restore
#else
        public List<SegmentObject> Segments { get; set; }
#endif
        /// <summary>A tatum represents the lowest regular pulse train that a listener intuitively infers from the timing of perceived musical events (segments).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TimeIntervalObject>? Tatums { get; set; }
#nullable restore
#else
        public List<TimeIntervalObject> Tatums { get; set; }
#endif
        /// <summary>The track property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AudioAnalysisObject_track? Track { get; set; }
#nullable restore
#else
        public AudioAnalysisObject_track Track { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AudioAnalysisObject"/> and sets the default values.
        /// </summary>
        public AudioAnalysisObject()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AudioAnalysisObject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AudioAnalysisObject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AudioAnalysisObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"bars", n => { Bars = n.GetCollectionOfObjectValues<TimeIntervalObject>(TimeIntervalObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"beats", n => { Beats = n.GetCollectionOfObjectValues<TimeIntervalObject>(TimeIntervalObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"meta", n => { Meta = n.GetObjectValue<AudioAnalysisObject_meta>(AudioAnalysisObject_meta.CreateFromDiscriminatorValue); } },
                {"sections", n => { Sections = n.GetCollectionOfObjectValues<SectionObject>(SectionObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"segments", n => { Segments = n.GetCollectionOfObjectValues<SegmentObject>(SegmentObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tatums", n => { Tatums = n.GetCollectionOfObjectValues<TimeIntervalObject>(TimeIntervalObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"track", n => { Track = n.GetObjectValue<AudioAnalysisObject_track>(AudioAnalysisObject_track.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<TimeIntervalObject>("bars", Bars);
            writer.WriteCollectionOfObjectValues<TimeIntervalObject>("beats", Beats);
            writer.WriteObjectValue<AudioAnalysisObject_meta>("meta", Meta);
            writer.WriteCollectionOfObjectValues<SectionObject>("sections", Sections);
            writer.WriteCollectionOfObjectValues<SegmentObject>("segments", Segments);
            writer.WriteCollectionOfObjectValues<TimeIntervalObject>("tatums", Tatums);
            writer.WriteObjectValue<AudioAnalysisObject_track>("track", Track);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
