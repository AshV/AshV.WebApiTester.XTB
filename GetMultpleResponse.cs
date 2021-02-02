using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshV.WebApiTester.XTB
{
    public class GetMultpleResponse
    {
        public string odatacontext { get; set; }
        public Value[] value { get; set; }
    }

    public class Value
    {

    }
}
