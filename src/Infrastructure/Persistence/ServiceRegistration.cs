using Application.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Data;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection servicecollection)
        {
            servicecollection.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(@"Server=(LocalDb)\Faradheus;Database=Ambulance;Trusted_Connection=True;MultipleActiveResultSets=true"));
            servicecollection.AddTransient<IRegistrationRepository, RegistrationRepository>();
        }
    }
}
