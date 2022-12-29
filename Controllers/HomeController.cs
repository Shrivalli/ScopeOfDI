using Microsoft.AspNetCore.Mvc;
using ScopeOfAPI.Repository;

namespace ScopeOfAPI.Controllers
{
    [Route("api/Home")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITransientService _transientService1;
        private readonly ITransientService _transientService2;
        private readonly IScopedService _scopedService1;
        private readonly IScopedService _scopedService2;
        private readonly ISingletonService _singletonService1;
        private readonly ISingletonService _singletonService2;

        public HomeController(ILogger<HomeController> logger,
                    ITransientService transientService1,
                    ITransientService transientService2,
                    IScopedService scopedService1,
                    IScopedService scopedService2,
                    ISingletonService singletonService1,
                    ISingletonService singletonService2)
        {
            _logger = logger;
            _transientService1 = transientService1;
            _transientService2 = transientService2;
            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;
            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
        }
        [HttpGet]
        public ActionResult Index()
        {
            Sample s = new Sample();
            s.transient1 = _transientService1.getvariablevalue().ToString();
            s.transient2 = _transientService2.getvariablevalue().ToString();
            s.scoped1 = _scopedService1.getvariablevalue().ToString();
            s.scoped2 = _scopedService2.getvariablevalue().ToString();
            s.singleton1 = _singletonService1.getvariablevalue().ToString();
            s.singleton2 = _singletonService2.getvariablevalue().ToString();
            s.message="Thanks";
            return Ok(s);

        }
    }
}
