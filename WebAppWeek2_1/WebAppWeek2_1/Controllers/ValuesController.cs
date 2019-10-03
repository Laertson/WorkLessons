using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppWeek2_1.Controllers
{
    [Route("api")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
         // POST api/numbers
        [HttpPost("numbers")]
        public Response Post([FromBody] Numbers a)
        {
            Response res = new Response();
            // Get an array of n random integers.
            List<int> uniqval = new List<int>();

            foreach (int value in a.numbers)
            {
                if (!uniqval.Contains(value)) { uniqval.Add(value); }
            }

            foreach (int uniq in uniqval)
            {
                int[] matchedItems = Array.FindAll(a.numbers, x => x == uniq);
                Answer temp = new Answer { value = uniq, times = matchedItems.Length };
                res.results.Add(temp);
            }
            return res;
        }
    }
}
