using System.Threading.Tasks;

namespace PinnacleSample
{
    //interface extracted from CustomerRepositoryDB class
    public interface ICustomerRepositoryDB
    {
        Customer GetByName(string name);
    }
}