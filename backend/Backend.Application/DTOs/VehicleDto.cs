using Backend.Application.DTOs.Common;
using Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.DTOs
{
    public class VehicleDto : BaseDto
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int CostInCredits { get; set; }
        public double length { get; set; }
        public string MaxAtmospheringSpeed { get; set; }
        public int Crew { get; set; }
        public int Passangers { get; set; }
        public int CargoCapacity { get; set; }
        public string Consumables { get; set; }
        public string VechicleClass { get; set; }
        public ICollection<PersonDto> Pilots { get; set; } = new List<PersonDto>();
        public ICollection<FilmDto> Films { get; set; } = new List<FilmDto>();
    }
}
