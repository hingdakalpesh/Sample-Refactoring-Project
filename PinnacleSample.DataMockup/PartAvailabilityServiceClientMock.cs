using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinnacleSample.DataMockup
{
    public class PartAvailabilityServiceClientMock : IPartAvailabilityService
    {
        public int GetAvailability(string StockCode)
        {
            Random random = new Random();
            return random.Next(0, 100);
        }
    }
}
