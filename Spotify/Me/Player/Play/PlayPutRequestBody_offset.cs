// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Spotify.Me.Player.Play {
    /// <summary>
    /// Optional. Indicates from where in the context playback should start. Only available when context_uri corresponds to an album or playlist object&quot;position&quot; is zero based and can’t be negative. Example: `&quot;offset&quot;: {&quot;position&quot;: 5}`&quot;uri&quot; is a string representing the uri of the item to start at. Example: `&quot;offset&quot;: {&quot;uri&quot;: &quot;spotify:track:1301WleyT98MSxVHPZCA6M&quot;}`
    /// </summary>
    public class PlayPutRequestBody_offset : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="PlayPutRequestBody_offset"/> and sets the default values.
        /// </summary>
        public PlayPutRequestBody_offset()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PlayPutRequestBody_offset"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PlayPutRequestBody_offset CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlayPutRequestBody_offset();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
