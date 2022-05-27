using TestAbstractionsApplication.Common.BaseAImplementation;
using TestAbstractionsApplication.Common.Employer.Types;
using TestAbstractionsApplication.Common.Employer.Types.Models;
using TestAbstractionsApplication.Common.Types.DataModels;

namespace TestAbstractionsApplication.EmployerImplementation
{
    public class EmployerHandler : EmployerBaseHandler
    {
        public async override Task<IData> GetData()
        {
            var comapy = new EmployerData()
            {
                Id = Guid.NewGuid(),
                DataModelTyped = new EmployerDataModel()
                {
                    Name = "TestEmployer",
                    CreateOn = DateTime.Now.AddDays(-100),
                    AddressTyped = new EmployerAddress()
                    {
                        Country = "GR",
                        Street = "Employer",
                        ZipCode = "12345",
                        Number = 11,
                        ActiveFrom = DateTime.Now.AddDays(-10),
                        ActiveTo = DateTime.Now.AddDays(+10),
                        IsWorkingFromHome = true,
                        WorkingHoures = WorkingHoures.FullTime
                    }
                }
            };
            return comapy as IData;
        }
    }
}