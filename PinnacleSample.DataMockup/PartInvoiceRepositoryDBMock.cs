using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinnacleSample.DataMockup
{
    //mock implementation of PartInvoiceRepositoryDB for the use of testing
    public class PartInvoiceRepositoryDBMock : IPartInvoiceRepositoryDB
    {
        public void Add(PartInvoice invoice)
        {
            if (PartInvoiceDataStore.partInvoices is null)
            {
                PartInvoiceDataStore.partInvoices = new List<PartInvoice>();
            }
            PartInvoiceDataStore.partInvoices.Add(invoice);
        }
    }
}
