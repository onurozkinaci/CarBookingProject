﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entites
{
    public class Feature
    {
        public int FeatureId { get; set; }
        public string Name { get; set; }
        public List<CarFeature> CarFeatures { get; set; } //many to many rel.
    }
}
