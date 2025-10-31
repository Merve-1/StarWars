using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Domain
{
    public class Starship
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int CostInCredits { get; set; }
        public int Length { get; set; }
        public int MaxAtmospheringSpeed { get; set; }
        public string Crew {  get; set; }
        public int Passangers { get; set; }
        public int CargoCapacity { get; set; }
        public string consumables { get; set; }
        public double HyperdriveRating { get; set; }
        public int MGLT {  get; set; }
        public string StarshipClass { get; set; }

        public ICollection<Person> Pilots { get; set; } = new List<Person>();
        public ICollection<Film> Films { get; set; } = new List<Film>();
    }
}
