using TestAbstractionsApplication.Common.Interfaces;
using TestAbstractionsApplication.Common.Types.DataModels;

namespace TestAbstractionsApplication.Common.CompanyBaseImplementation
{
    public abstract class CompanyBaseHandler : IHandler
    {
        public const string Type = "Company";
        public string HandlerType => Type;

        public abstract Task<IData> GetData();
    }
}