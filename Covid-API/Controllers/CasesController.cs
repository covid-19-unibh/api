using Covid_API.Models;
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
        public ActionResult<IEnumerable<CasesDto>> Get()
        {
            List<Cases> cases = _casesService.Get();

            return Cast(cases);
        }

        private List<CasesDto> Cast(List<Cases> cases)
        {
            List<CasesDto> casesDtoList = new List<CasesDto>();

            var dict = new Utils.Locations().Location;

            foreach (var item in cases)
            {
                try
                {
                    casesDtoList.Add(new CasesDto
                    {
                        ObjectId = item.ObjectId,
                        Neighborhood = item.neighborhood,
                        Serious = item.serious,
                        NonSerious = item.nonSerious,
                        Deaths = item.deaths,
                        Location = dict[item.neighborhood]
                    });
                }
                catch (System.Exception)
                {
                    continue;
                }
            }

            return casesDtoList;
        }
    }
}
