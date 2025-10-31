using Backend.Application.DTOs.Common;
using Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.DTOs
{
    public class PersonDto : BaseDto
    {
        public string Name { get; set; }
        public int? Height { get; set; }
        public int? Mass { get; set; }
        public string HairColor { get; set; }
        public string SkinColor { get; set; }
        public string EyeColor { get; set; }
        public string BirthYear { get; set; }
        public string Gender { get; set; }
        public int? HomeworldId { get; set; }
        public Planet Homeworld { get; set; }
        public ICollection<FilmDto> Films { get; set; } = new List<FilmDto>();
        public ICollection<VehicleDto> Vehicles { get; set; } = new List<VehicleDto>();
        public ICollection<StarshipDto> Starships { get; set; } = new List<StarshipDto>();
        public ICollection<SpeciesDto> Species { get; set; } = new List<SpeciesDto>();
    }
}
