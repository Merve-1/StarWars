using Backend.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Domain
{
    public class Vehicle: BaseDomainEntity
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int CostInCredits { get; set; }
        public double length { get; set; }
        public string MaxAtmospheringSpeed { get; set; }
        public int Crew {  get; set; }
        public int  Passangers { get; set; }
        public int CargoCapacity { get; set; }
        public string Consumables { get; set; }
        public string VechicleClass { get; set; }
        public ICollection<Person> Pilots { get; set; } = new List<Person>();
        public ICollection<Film> Films { get; set; } = new List<Film>();

    }
}
