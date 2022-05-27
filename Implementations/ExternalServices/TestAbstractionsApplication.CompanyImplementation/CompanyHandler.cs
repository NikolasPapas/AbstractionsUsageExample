using TestAbstractionsApplication.Common.Company.Types;
using TestAbstractionsApplication.Common.Company.Types.Models;
using TestAbstractionsApplication.Common.CompanyBaseImplementation;
using TestAbstractionsApplication.Common.Types.DataModels;

namespace TestAbstractionsApplication.CompanyImplementation
{
    public class CompanyHandler : CompanyBaseHandler
    {
        public async override Task<IData> GetData()
        {
            var comapy = new CompanyData()
            {
                Id = Guid.NewGuid(),
                DataModelTyped = new CompanyDataModel()
                {
                    Name = "TestCompany",
                    CreateOn = DateTime.Now.AddDays(-100),
                    AddressTyped = new CompanyAddress()
                    {
                        Country = "GR",
                        Street = "Company",
                        ZipCode = "12345",
                        Number = 11,
                        ActiveFrom = DateTime.Now.AddDays(-100),
                        ActiveTo = DateTime.Now.AddDays(+100),
                        IsHeadQuarters = true,
                    }
                }
            };
            return comapy as IData;
        }
    }
}