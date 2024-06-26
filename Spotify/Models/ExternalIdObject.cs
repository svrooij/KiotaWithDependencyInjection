// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Spotify.Models {
    public class ExternalIdObject : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>[International Article Number](http://en.wikipedia.org/wiki/International_Article_Number_%28EAN%29)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ean { get; set; }
#nullable restore
#else
        public string Ean { get; set; }
#endif
        /// <summary>[International Standard Recording Code](http://en.wikipedia.org/wiki/International_Standard_Recording_Code)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Isrc { get; set; }
#nullable restore
#else
        public string Isrc { get; set; }
#endif
        /// <summary>[Universal Product Code](http://en.wikipedia.org/wiki/Universal_Product_Code)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Upc { get; set; }
#nullable restore
#else
        public string Upc { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ExternalIdObject"/> and sets the default values.
        /// </summary>
        public ExternalIdObject()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ExternalIdObject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ExternalIdObject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExternalIdObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"ean", n => { Ean = n.GetStringValue(); } },
                {"isrc", n => { Isrc = n.GetStringValue(); } },
                {"upc", n => { Upc = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ean", Ean);
            writer.WriteStringValue("isrc", Isrc);
            writer.WriteStringValue("upc", Upc);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
