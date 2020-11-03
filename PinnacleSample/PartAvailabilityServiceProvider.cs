using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinnacleSample
{
    public class PartAvailabilityServiceProvider : IPartAvailabilityServiceFactory
    {
        PartAvailabilityServiceClient partAvailabilityServiceClient = null;

        public IPartAvailabilityService CreateClient()
        {
            partAvailabilityServiceClient = new PartAvailabilityServiceClient();
            return partAvailabilityServiceClient;
        }

        public void CloseClient()
        {
            if (partAvailabilityServiceClient != null)
            {
                partAvailabilityServiceClient.Close();
            }
        }
    }
}
