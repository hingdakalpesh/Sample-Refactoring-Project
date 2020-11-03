using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinnacleSample.DataMockup
{
    public static class CustomerDataStore
    {
        public static List<Customer> customers;
        static CustomerDataStore()
        {
            customers = new List<Customer>();
            customers.Add(new Customer { ID = 1, Name = "Kalpesh", Address = "" });
            customers.Add(new Customer { ID = 2, Name = "Tariq", Address = "" });
            customers.Add(new Customer { ID = 3, Name = "Harry", Address = "" });
            customers.Add(new Customer { ID = 4, Name = "Stuart", Address = "" });
            customers.Add(new Customer { ID = 5, Name = "Steph", Address = "" });
        }
    }
}
