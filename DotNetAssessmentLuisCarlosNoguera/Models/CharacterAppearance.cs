using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAssessmentLuisCarlosNoguera.Models
{
    public class CharacterAppearance
    {
        public string Gender { get; set; }
        public string Race { get; set; }
        public ICollection<string> Height { get; set; }
        public ICollection<string> Weight { get; set; }

        [JsonProperty(propertyName: "eye-color")]
        public string EyeColor { get; set; }

        [JsonProperty(propertyName: "hair-color")]
        public string HairColor { get; set; }
    }
}
