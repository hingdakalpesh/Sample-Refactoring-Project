using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinnacleSample
{
    //Wrapper interface for PartAvailabilityService
    public interface IPartAvailabilityServiceFactory
    {
        IPartAvailabilityService CreateClient();
        void CloseClient();
    }
}
