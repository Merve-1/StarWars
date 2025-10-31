using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Domain
{
    public class Species
    {
        public string Name { get; set; }
        public string Classification { get; set; }
        public string Designation { get; set; }
        public double AverageHeight { get; set; }
        public string SkinColors { get; set; }
        public string HairColors { get; set; }
        public string EyeColors { get; set; }
        public string AverageLifespan { get; set; }
        public int? HomeworldId { get; set; }
        public Planet Homeworld { get; set; }
        public string Language { get; set; }
    }
}
