﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAssessmentLuisCarlosNoguera.Models
{
    public class SearchResponseViewModel : ResponseViewModel
    {
        public List<Character> Results { get; set; }
    }
}
