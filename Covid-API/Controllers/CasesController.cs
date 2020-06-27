using Covid_API.Models.MongoDB;
using Covid_API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Covid_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CasesController : ControllerBase
    {
        private readonly CasesService _casesService;

        public CasesController(CasesService casesService)
        {
            _casesService = casesService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cases>> Get() => _casesService.Get();
    }
}
