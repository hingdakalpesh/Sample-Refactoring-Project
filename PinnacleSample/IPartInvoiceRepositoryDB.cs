using System.Threading.Tasks;

namespace PinnacleSample
{
    //interface extracted from PartInvoiceRepositoryDB class
    public interface IPartInvoiceRepositoryDB
    {
        void Add(PartInvoice invoice);
    }
}