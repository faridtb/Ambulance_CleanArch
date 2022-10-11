using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class RegistrationInfo : BaseEntity
    {
        public string photo { get; set; }
        public bool IsHospitalization { get; set; }

        public int RegistrationId { get; set; }
        public Registration Registration { get; set; }


        public int CallResultId { get; set; }
        public CallResult CallResult { get; set; }

    }
}
