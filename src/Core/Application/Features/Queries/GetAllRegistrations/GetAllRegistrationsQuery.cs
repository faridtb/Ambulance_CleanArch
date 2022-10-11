using Application.Dto;
using Application.Interfaces.Repository;
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

            public GetAllRegistrationsQueryHandler(IRegistrationRepository registrationRepository)
            {
                this.registrationRepository = registrationRepository;
            }

            public Task<List<RegistrationReturnDto>> Handle(GetAllRegistrationsQuery request, CancellationToken cancellationToken)
            {
                var registrations = registrationRepository.GetAllAsync();
            }
        }

    }
}
