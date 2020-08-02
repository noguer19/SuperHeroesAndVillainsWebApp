using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAssessmentLuisCarlosNoguera.Models
{
    public class CharacterConnections
    {
        [JsonProperty(propertyName: "group-affiliation")]
        public string GroupAffiliations { get; set; }
        public string Relatives { get; set; }
    }
}
