using DotNetCoreInjectionApiWithInjectionTypedFactories.Factories;
using DotNetCoreInjectionApiWithInjectionTypedFactories.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DotNetCoreInjectionApiWithInjectionTypedFactories.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SeasonAspNetCoreInjectionTypedFactoriesController : ControllerBase
    {
        private readonly IServiceFactory _serviceFactory;
        private readonly IWinterService _winterService;
        private readonly ISpringService _springService;
        private readonly ISummerService _summerService;
        private readonly IAutumnService _autumnService;

        public SeasonAspNetCoreInjectionTypedFactoriesController(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;

            _winterService = _serviceFactory.CreateWinterService();
            _springService = _serviceFactory.CreateSpringService();
            _summerService = _serviceFactory.CreateSummerService();
            _autumnService = _serviceFactory.CreateAutumnService();
        }

        [HttpGet]
        public string[] Get()
        {
            var result = _winterService.GetMonths().Concat(_springService.GetMonths()).Concat(_summerService.GetMonths()).Concat(_autumnService.GetMonths());
            return result.ToArray();
        }
    }
}
