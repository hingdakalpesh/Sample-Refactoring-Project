using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PinnacleSample.DataMockup;

namespace PinnacleSample.Test
{
    [TestClass]
    public class PartInvoiceTests
    {
        [TestMethod]
        public void CreatePartInvoiceShouldSucceed()
        {
            //Arrange:
            string stockCode = "XX";
            int quantity = 10;
            string customerName = "Kalpesh";
            CreatePartInvoiceResult expected = new CreatePartInvoiceResult(true);
            PartInvoiceController controller = new PartInvoiceController(new CustomerRepositoryDBMock(), new PartInvoiceRepositoryDBMock(), new PartAvailabilityServiceProviderMock());

            //Act
            CreatePartInvoiceResult actual = controller.CreatePartInvoice(stockCode, quantity, customerName);

            //Assert
            Assert.AreEqual(expected.Success, actual.Success);
        }

        [TestMethod]
        public void CreatePartInvoiceShouldFail()
        {
            //Arrange:
            string stockCode = null;
            int quantity = 10;
            string customerName = "Kalpesh";
            CreatePartInvoiceResult expected = new CreatePartInvoiceResult(false);
            PartInvoiceController controller = new PartInvoiceController(new CustomerRepositoryDBMock(), new PartInvoiceRepositoryDBMock(), new PartAvailabilityServiceProviderMock());

            //Act
            CreatePartInvoiceResult actual = controller.CreatePartInvoice(stockCode, quantity, customerName);

            //Assert
            Assert.AreEqual(expected.Success, actual.Success);
        }
    }
    
}
