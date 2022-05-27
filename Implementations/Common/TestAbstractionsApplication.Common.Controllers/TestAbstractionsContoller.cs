using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestAbstractionsApplication.Common.Interfaces;
using TestAbstractionsApplication.Common.Types.Requests;
using TestAbstractionsApplication.Common.Types.Responses;

namespace TestAbstractionsApplication.Common.Controllers
{
    [Route("testAbstractions")]
    [ApiController]
    public class TestAbstractionsContoller : ControllerBase
    {
        private readonly IMainService _mainService;
        private readonly ILogger<TestAbstractionsContoller> _logger;

        public TestAbstractionsContoller(IMainService mainService, ILogger<TestAbstractionsContoller> logger)
        {
            _mainService = mainService;
            _logger = logger;
        }

        /// <summary>
        /// tha values of the type = Company | Employer | Customer
        /// </summary>
        /// <param name="request"> Get tha Type of Instance you wont </param>
        /// <returns>the data of that instsance</returns>
        [HttpPost]
        [Route("getData")]
        public async Task<GetDataResponse> GetData(GetDataRequest request)
        {
            return await _mainService.GetData(request);
        }
    }
}