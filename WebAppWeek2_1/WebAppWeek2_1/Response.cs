using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppWeek2_1
{
    public class Response
    {
        public List<Answer> results { get; set; }
        public Response()
        {
            results = new List<Answer>();
        }
    }
}
