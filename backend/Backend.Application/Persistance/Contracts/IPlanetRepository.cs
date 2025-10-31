using Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Persistance.Contracts
{
    public interface IPlanetRepository : IGenericRepository<Planet>
    {
    }
}
