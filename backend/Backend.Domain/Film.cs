using Backend.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Domain
{
    public class Film: BaseDomainEntity
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public string ReleaseDate { get; set; }

        public ICollection<Person> Characters { get; set; } = new List<Person>();
        public ICollection<Planet> Planets { get; set; } = new List<Planet>();
        public ICollection<Starship> Starships { get; set; } = new List<Starship>();
        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public ICollection<Species> Species { get; set; } = new List<Species>();

    }
}
