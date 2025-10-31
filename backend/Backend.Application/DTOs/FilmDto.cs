using Backend.Application.DTOs.Common;
using Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.DTOs
{
    public class FilmDto : BaseDto 
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public string ReleaseDate { get; set; }

        public ICollection<PersonDto> Characters { get; set; } = new List<PersonDto>();
        public ICollection<PlanetDto> Planets { get; set; } = new List<PlanetDto>();
        public ICollection<StarshipDto> Starships { get; set; } = new List<StarshipDto>();
        public ICollection<VehicleDto> Vehicles { get; set; } = new List<VehicleDto>();
        public ICollection<SpeciesDto> Species { get; set; } = new List<SpeciesDto>();
    }
}
