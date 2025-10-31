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
    public  class GetPersonRequestListHandler : IRequestHandler<GetPersonListRequest, List<PersonDto>>
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;
        public GetPersonRequestListHandler(IPersonRepository personRepository,IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }
        public async Task<List<PersonDto>> Handle(GetPersonListRequest request, CancellationToken cancellationToken)
        {
            var person = await _personRepository.GetAll();
            return _mapper.Map<List<PersonDto>>(person);
        }
    }
}
