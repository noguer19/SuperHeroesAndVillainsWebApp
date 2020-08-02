using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAssessmentLuisCarlosNoguera.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PlaceOfBirth { get; set; }
        public CharacterImage Image { get; set; }
        public CharacterAppearance Appearance { get; set; }
    }
}
