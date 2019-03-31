using System.Collections.Generic;
using EntityFramework.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public CityInfoContext _ctx;
        public ValuesController(CityInfoContext ctx)
        {
            _ctx = ctx;

        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            return new string[] { "value1", "value2" };
        }
    }
}

