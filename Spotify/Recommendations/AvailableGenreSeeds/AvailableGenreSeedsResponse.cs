// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Spotify.Recommendations.AvailableGenreSeeds {
    [Obsolete("This class is obsolete. Use AvailableGenreSeedsGetResponse instead.")]
    public class AvailableGenreSeedsResponse : AvailableGenreSeedsGetResponse, IParsable 
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AvailableGenreSeedsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AvailableGenreSeedsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AvailableGenreSeedsResponse();
        }
    }
}
