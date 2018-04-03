using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Minke.TheBlood.IDal;

namespace Minke.TheBlood.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IBloodStock _bloodStock;
        private IRegions _iRegions;
        public ValuesController(IBloodStock iBloodStock,IRegions iRegions)
        {
            _bloodStock = iBloodStock;
            _iRegions = iRegions;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var it = _iRegions.GetList();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
           var it= _iRegions.GetList();
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
