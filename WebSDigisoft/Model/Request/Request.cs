using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSDigisoft.Model.Request
{
    public class Request
    {

        public int Code { get; set; }
        public string message { get; set; }
        public object data { get; set; }

        public Request()
        {
            this.Code = 0;
        }
    }
}
