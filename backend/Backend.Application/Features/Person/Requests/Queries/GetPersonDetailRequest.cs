using Backend.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Features.Person.Requests.Queries
{
    public class GetPersonDetailRequest: IRequest<PersonDto>
    {
        public int Id { get; set; }
    }
}
