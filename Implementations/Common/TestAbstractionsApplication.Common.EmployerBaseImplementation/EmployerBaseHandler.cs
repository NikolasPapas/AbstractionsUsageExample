using TestAbstractionsApplication.Common.Interfaces;
using TestAbstractionsApplication.Common.Types.DataModels;

namespace TestAbstractionsApplication.Common.BaseAImplementation
{
    public abstract class EmployerBaseHandler : IHandler
    {
        public const string Type = "Employer";
        public string HandlerType => Type;

        public abstract Task<IData> GetData();
    }
}