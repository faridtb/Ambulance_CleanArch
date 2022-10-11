using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Car : BaseEntity
    {
        public string Brand { get; set; }
        public string LicensePlate { get; set; }
    }
}
