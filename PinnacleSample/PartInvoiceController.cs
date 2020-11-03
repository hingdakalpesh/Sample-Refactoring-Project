using System.Threading.Tasks;

namespace PinnacleSample
{
    public class PartInvoiceController
    {
        private readonly ICustomerRepositoryDB _CustomerRepository;
        private readonly IPartInvoiceRepositoryDB _PartInvoiceRepository;
        private readonly IPartAvailabilityServiceFactory _PartAvailabilityServiceFactory;
        private Customer _Customer;

        //public constructor available to external callers
        public PartInvoiceController(): this(new CustomerRepositoryDB(), new PartInvoiceRepositoryDB(), new PartAvailabilityServiceProvider())
        {
        }

        //internal constructor visible to PinnacleSample.Test
        //provides DI capabilities for tests to mock the dependecies. 
        internal PartInvoiceController(ICustomerRepositoryDB customerRepository, IPartInvoiceRepositoryDB partInvoiceRepository, IPartAvailabilityServiceFactory partAvailabilityServiceFactory)
        {
            _CustomerRepository = customerRepository;
            _PartInvoiceRepository = partInvoiceRepository;
            _PartAvailabilityServiceFactory = partAvailabilityServiceFactory;
        }

        public CreatePartInvoiceResult CreatePartInvoice(string stockCode, int quantity, string customerName)
        {
            //validate inputs
            if (IsStockCodeValid(stockCode) &&
                IsQuantityValid(quantity) &&
                IsCustomerValid(customerName))
            {
                if (IsAvailable(stockCode))
                {
                    PartInvoice _PartInvoice = new PartInvoice
                    {
                        StockCode = stockCode,
                        Quantity = quantity,
                        CustomerID = _Customer.ID
                    };
                    _PartInvoiceRepository.Add(_PartInvoice);

                    return new CreatePartInvoiceResult(true);
                }
                return new CreatePartInvoiceResult(false);
            }
            return new CreatePartInvoiceResult(false);
        }

        //extracted methods from CreatePartInvoice() for better readablility and testablility - start
        internal bool IsStockCodeValid(string stockCode)
        {
            if (string.IsNullOrEmpty(stockCode))
            {
                return false;
            }
            return true;
        }

        internal bool IsQuantityValid(int quantity)
        {
            if (quantity <= 0)
            {
                return false;
            }
            return true;
        }

        internal bool IsCustomerValid(string customerName)
        {
            _Customer = _CustomerRepository.GetByName(customerName);
            if (_Customer.ID <= 0)
            {
                return false;
            }
            return true;
        }

        internal bool IsAvailable(string stockCode)
        {
            try
            {
                IPartAvailabilityService _PartAvailabilityServiceClient = _PartAvailabilityServiceFactory.CreateClient();
                int availability = _PartAvailabilityServiceClient.GetAvailability(stockCode);
                if (availability <= 0)
                {
                    return false;
                }
                return true;
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                _PartAvailabilityServiceFactory.CloseClient();
            }
        }
        //extracted methods from CreatePartInvoice() for better readablility and testablility - end
    }
}
