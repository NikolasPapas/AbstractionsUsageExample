using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using TestAbstractionsApplication.Common.Interfaces;
using TestAbstractionsApplication.Common.Types.Requests;
using TestAbstractionsApplication.Common.Types.Responses;

namespace TestAbstractionsApplication.Common.Implementations
{
    public class MainService : IMainService
    {
        private readonly IHandlerFactory _handlerFactory;
        private readonly ILogger<MainService> _logger;
        public MainService(
            IHandlerFactory handlerFactory,
            ILogger<MainService> logger)
        {
            _handlerFactory = handlerFactory;
            _logger = logger;
        }

        public async Task<GetDataResponse> GetData(GetDataRequest request)
        {
            var handler = _handlerFactory.Create(request.Type);
            if (handler != null)
                return new GetDataResponse() { Data = (await handler.GetData()) };
            return null;
        }
    }
}