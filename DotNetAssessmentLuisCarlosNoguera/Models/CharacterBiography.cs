using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DotNetAssessmentLuisCarlosNoguera.Models
{
    public class CharacterBiography
    {
        [JsonProperty(propertyName: "full-name")]
        public string FullName { get; set; }

        [JsonProperty(propertyName: "alter-egos")]
        public string AlterEgos { get; set; }
        public ICollection<string> Aliases { get; set; }

        [JsonProperty(propertyName: "place-of-birth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty(propertyName: "first-appearance")]
        public string FirstAppearance { get; set; }
        public string Publisher { get; set; }
        public string Alignment { get; set; }
    }
}
