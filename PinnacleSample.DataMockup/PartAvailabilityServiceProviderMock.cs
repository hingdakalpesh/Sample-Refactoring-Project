using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinnacleSample.DataMockup
{
    public class PartAvailabilityServiceProviderMock : IPartAvailabilityServiceFactory
    {
        IPartAvailabilityService partAvailabilityService;
        
        public IPartAvailabilityService CreateClient()
        {
            partAvailabilityService = new PartAvailabilityServiceClientMock();
            return partAvailabilityService;
        }
        
        public void CloseClient()
        {
            partAvailabilityService = null;
        }

    }
}
