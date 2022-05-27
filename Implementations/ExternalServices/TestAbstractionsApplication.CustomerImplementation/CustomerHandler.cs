using TestAbstractionsApplication.Common.Customer.Types;
using TestAbstractionsApplication.Common.Customer.Types.Models;
using TestAbstractionsApplication.Common.CustomerBaseImplementation;
using TestAbstractionsApplication.Common.Types.DataModels;

namespace TestAbstractionsApplication.CustomerImplementation
{
    public class CustomerHandler : CustomerBaseHandler
    {
        public async override Task<IData> GetData()
        {
            var comapy = new CustomerData()
            {
                Id = Guid.NewGuid(),
                DataModelTyped = new CustomerDataModel()
                {
                    Name = "TestCustomer",
                    CreateOn = DateTime.Now.AddDays(-100),
                    AddressTyped = new CustomerAddress()
                    {
                        Country = "GR",
                        Street = "Customer",
                        ZipCode = "12345",
                        Number = 11,
                        ActiveFrom = DateTime.Now.AddDays(-100),
                        ActiveTo = DateTime.Now.AddDays(-1),
                        IsPermanentAddress = true,
                        PersonsInApartment=4
                    }
                }
            };
            return comapy as IData;
        }
    }
}