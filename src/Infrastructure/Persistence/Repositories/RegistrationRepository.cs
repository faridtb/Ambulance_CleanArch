using Application.Interfaces.Repository;
using Domain.Entities;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class RegistrationRepository : GenericRepository<Registration>, IRegistrationRepository
    {
        public RegistrationRepository(AppDbContext context) : base(context)
        {

        }
    }
}
