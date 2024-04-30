// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Spotify.Models {
    public class SectionObject : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The confidence, from 0.0 to 1.0, of the reliability of the section&apos;s &quot;designation&quot;.</summary>
        public double? Confidence { get; set; }
        /// <summary>The duration (in seconds) of the section.</summary>
        public double? Duration { get; set; }
        /// <summary>The estimated overall key of the section. The values in this field ranging from 0 to 11 mapping to pitches using standard Pitch Class notation (E.g. 0 = C, 1 = C♯/D♭, 2 = D, and so on). If no key was detected, the value is -1.</summary>
        public int? Key { get; set; }
        /// <summary>The confidence, from 0.0 to 1.0, of the reliability of the key. Songs with many key changes may correspond to low values in this field.</summary>
        public double? KeyConfidence { get; set; }
        /// <summary>The overall loudness of the section in decibels (dB). Loudness values are useful for comparing relative loudness of sections within tracks.</summary>
        public double? Loudness { get; set; }
        /// <summary>Indicates the modality (major or minor) of a section, the type of scale from which its melodic content is derived. This field will contain a 0 for &quot;minor&quot;, a 1 for &quot;major&quot;, or a -1 for no result. Note that the major key (e.g. C major) could more likely be confused with the minor key at 3 semitones lower (e.g. A minor) as both keys carry the same pitches.</summary>
        public double? Mode { get; set; }
        /// <summary>The confidence, from 0.0 to 1.0, of the reliability of the `mode`.</summary>
        public double? ModeConfidence { get; set; }
        /// <summary>The starting point (in seconds) of the section.</summary>
        public double? Start { get; set; }
        /// <summary>The overall estimated tempo of the section in beats per minute (BPM). In musical terminology, tempo is the speed or pace of a given piece and derives directly from the average beat duration.</summary>
        public double? Tempo { get; set; }
        /// <summary>The confidence, from 0.0 to 1.0, of the reliability of the tempo. Some tracks contain tempo changes or sounds which don&apos;t contain tempo (like pure speech) which would correspond to a low value in this field.</summary>
        public double? TempoConfidence { get; set; }
        /// <summary>An estimated time signature. The time signature (meter) is a notational convention to specify how many beats are in each bar (or measure). The time signature ranges from 3 to 7 indicating time signatures of &quot;3/4&quot;, to &quot;7/4&quot;.</summary>
        public int? TimeSignature { get; set; }
        /// <summary>The confidence, from 0.0 to 1.0, of the reliability of the `time_signature`. Sections with time signature changes may correspond to low values in this field.</summary>
        public double? TimeSignatureConfidence { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="SectionObject"/> and sets the default values.
        /// </summary>
        public SectionObject()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SectionObject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SectionObject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SectionObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"confidence", n => { Confidence = n.GetDoubleValue(); } },
                {"duration", n => { Duration = n.GetDoubleValue(); } },
                {"key", n => { Key = n.GetIntValue(); } },
                {"key_confidence", n => { KeyConfidence = n.GetDoubleValue(); } },
                {"loudness", n => { Loudness = n.GetDoubleValue(); } },
                {"mode", n => { Mode = n.GetDoubleValue(); } },
                {"mode_confidence", n => { ModeConfidence = n.GetDoubleValue(); } },
                {"start", n => { Start = n.GetDoubleValue(); } },
                {"tempo", n => { Tempo = n.GetDoubleValue(); } },
                {"tempo_confidence", n => { TempoConfidence = n.GetDoubleValue(); } },
                {"time_signature", n => { TimeSignature = n.GetIntValue(); } },
                {"time_signature_confidence", n => { TimeSignatureConfidence = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("confidence", Confidence);
            writer.WriteDoubleValue("duration", Duration);
            writer.WriteIntValue("key", Key);
            writer.WriteDoubleValue("key_confidence", KeyConfidence);
            writer.WriteDoubleValue("loudness", Loudness);
            writer.WriteDoubleValue("mode", Mode);
            writer.WriteDoubleValue("mode_confidence", ModeConfidence);
            writer.WriteDoubleValue("start", Start);
            writer.WriteDoubleValue("tempo", Tempo);
            writer.WriteDoubleValue("tempo_confidence", TempoConfidence);
            writer.WriteIntValue("time_signature", TimeSignature);
            writer.WriteDoubleValue("time_signature_confidence", TimeSignatureConfidence);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
