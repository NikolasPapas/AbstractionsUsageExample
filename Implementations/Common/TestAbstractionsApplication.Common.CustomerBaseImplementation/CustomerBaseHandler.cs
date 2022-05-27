using TestAbstractionsApplication.Common.Interfaces;
using TestAbstractionsApplication.Common.Types.DataModels;

namespace TestAbstractionsApplication.Common.CustomerBaseImplementation
{
    public abstract class CustomerBaseHandler : IHandler
    {
        public const string Type = "Customer";
        public string HandlerType => Type;
        public abstract Task<IData> GetData();
    }
}