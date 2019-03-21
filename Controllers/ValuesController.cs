using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace I18NApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IStringLocalizer<ValuesController> _localizer;

        public ValuesController(IStringLocalizer<ValuesController> localizer)
        {
            _localizer = localizer;
        }
        // GET api/values
        [HttpGet]
        public string Get()
        {
            var value = _localizer.GetText("About Title", 1);
           
            return value;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
        public static class Locali
    {
        public static string GetText<T>(this IStringLocalizer<T> localizer, string id, params object[] args) 
        {
            return string.Format(localizer[id], args);
        }
    }
}
