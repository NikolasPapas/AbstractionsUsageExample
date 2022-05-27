using TestAbstractionsApplication.Common.Types.Requests;
using TestAbstractionsApplication.Common.Types.Responses;

namespace TestAbstractionsApplication.Common.Interfaces
{
    public interface IMainService
    {
        /// <summary>
        /// return to Controller the data for tha request id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetDataResponse> GetData(GetDataRequest request);
    }
}