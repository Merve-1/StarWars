using AutoMapper;
using Backend.Application.DTOs;
using Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<Person, PersonDto>().ReverseMap();
            CreateMap<Film, FilmDto>().ReverseMap();
            CreateMap<Planet, PlanetDto>().ReverseMap();
            CreateMap<Species, SpeciesDto>().ReverseMap();
            CreateMap<Starship, StarshipDto>().ReverseMap();
            CreateMap<Vehicle, VehicleDto>().ReverseMap();
        }
    }
}
