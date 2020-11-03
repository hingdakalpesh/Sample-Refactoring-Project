using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinnacleSample.DataMockup
{
    //mock implementation of CustomerRepositoryDB for the use of testing
    public class CustomerRepositoryDBMock : ICustomerRepositoryDB
    {
        public Customer GetByName(string name)
        {
            var customer = CustomerDataStore.customers.FirstOrDefault(c => c.Name == name);
            return customer;
        }
    }
}
