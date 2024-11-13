using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicapServicesApp
{
    public class ServiceRequest
    {
        public string Id {get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        
        public DateTime DateSubmitted { get; set; }

    }
}
