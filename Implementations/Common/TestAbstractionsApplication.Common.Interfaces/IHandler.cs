using TestAbstractionsApplication.Common.Types.DataModels;

namespace TestAbstractionsApplication.Common.Interfaces
{
    public interface IHandler
    {
        string HandlerType { get; }

        Task<IData> GetData();

    }
}
