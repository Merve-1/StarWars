using Backend.Application.DTOs.Common;
using Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.DTOs
{
    public class PlanetDto : BaseDto
    {
        public string Name { get; set; }
        public int RotationPeriod { get; set; }
        public int OrbitalPeriod { get; set; }
        public int diameter { get; set; }
        public string Climate { get; set; }
        public string Terrain { get; set; }
        public string Gravity { get; set; }
        public int SurfaceWater { get; set; }
        public string Population { get; set; }
        public ICollection<PersonDto> Residents { get; set; } = new List<PersonDto>();
        public ICollection<FilmDto> Films { get; set; } = new List<FilmDto>();
    }
}
