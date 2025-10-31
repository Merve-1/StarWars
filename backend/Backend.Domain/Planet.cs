using Backend.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Domain
{
    public class Planet: BaseDomainEntity
    {
        public string Name { get; set; }
        public int RotationPeriod { get; set; }
        public int OrbitalPeriod { get; set; }
        public int diameter { get; set; }
        public string Climate { get; set; }
        public string Terrain { get; set; }
        public string  Gravity { get; set; }
        public int SurfaceWater { get; set; }
        public string Population { get; set; }
        public ICollection<Person> Residents { get; set; } = new List<Person>();
        public ICollection<Film> Films { get; set; } = new List<Film>();

    }
}
