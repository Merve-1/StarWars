using AutoMapper;
using Backend.Application.DTOs;
using Backend.Application.Features.Person.Requests.Queries;
using Backend.Application.Persistance.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Features.Person.Handlers.Queries
{
    public class GetPersonDetailRequestHandler : IRequestHandler<GetPersonDetailRequest, PersonDto>
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public GetPersonDetailRequestHandler(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task<PersonDto> Handle(GetPersonDetailRequest request, CancellationToken cancellationToken)
        {
            var person = await _personRepository.Get(request.Id);
            return _mapper.Map<PersonDto>(person);
        }
    }
}
