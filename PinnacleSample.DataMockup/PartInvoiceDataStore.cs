using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PinnacleSample.DataMockup
{
    public static class PartInvoiceDataStore
    {
        public static List<PartInvoice> partInvoices;

        static PartInvoiceDataStore()
        {
            partInvoices = new List<PartInvoice>();
        }
    }
}
