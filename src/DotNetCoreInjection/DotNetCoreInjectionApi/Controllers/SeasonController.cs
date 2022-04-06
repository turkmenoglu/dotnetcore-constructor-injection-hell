using DotNetCoreInjectionApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DotNetCoreInjectionApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SeasonController : ControllerBase
    {
        private readonly IWinterService _winterService;
        private readonly ISpringService _springService;
        private readonly ISummerService _summerService;
        private readonly IAutumnService _autumnService;

        public SeasonController(IWinterService winterService, ISpringService springService, ISummerService summerService, IAutumnService autumnService)
        {
            _winterService = winterService;
            _springService = springService;
            _summerService = summerService;
            _autumnService = autumnService;
        }

        [HttpGet]
        public string[] Get()
        {
            var result = _winterService.GetMonths().Concat(_springService.GetMonths()).Concat(_summerService.GetMonths()).Concat(_autumnService.GetMonths());
            return result.ToArray();
        }
    }
}
