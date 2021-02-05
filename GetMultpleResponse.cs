using System.Collections.Generic;

namespace AshV.WebApiTester.XTB
{
    public class GetMultpleResponse
    {
        public string odatacontext { get; set; }
        public List<dynamic> value { get; set; }
    }
}