using Application.Dto;
using Application.Interfaces.Repository;
using AutoMapper;
using MediatR;
using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Queries.GetAllRegistrations
{
    public class GetAllRegistrationsQuery : IRequest<List<RegistrationReturnDto>>
    {


        public class GetAllRegistrationsQueryHandler : IRequestHandler<GetAllRegistrationsQuery, List<RegistrationReturnDto>>
        {

            private readonly IRegistrationRepository registrationRepository;
            private readonly IMapper mapper;

            public GetAllRegistrationsQueryHandler(IRegistrationRepository registrationRepository, IMapper mapper)
            {
                this.registrationRepository = registrationRepository;
                this.mapper = mapper;
            }

            public async Task<List<RegistrationReturnDto>> Handle(GetAllRegistrationsQuery request, CancellationToken cancellationToken)
            {
                var registrations = await registrationRepository.GetAllAsync();

                var registrationsReturn = mapper.Map<List<RegistrationReturnDto>>(registrations);

                return registrationsReturn;
            }
        }

    }
}
