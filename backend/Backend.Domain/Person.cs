using Backend.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Backend.Domain
{
    public class Person : BaseDomainEntity
    {
        public string Name { get; set; }
        public int? Height { get; set; }
        public int? Mass { get; set; }
        public string HairColor { get; set; }
        public string SkinColor { get; set; }
        public string EyeColor { get; set; }
        public string BirthYear {  get; set; }
        public string Gender { get; set; }
        public int? HomeworldId { get; set; }
        public Planet Homeworld {  get; set; }
        public ICollection<Film> Films { get; set; } = new List<Film>();
        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public ICollection<Starship> Starships { get; set; } = new List<Starship>();
        public ICollection<Species> Species { get; set; } = new List<Species>();
    }
}
