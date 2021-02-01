using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AshV.WebApiTester.XTB
{
    public class CustomResponse
    {
        public HttpResponseMessage Response { get; set; }

        public string ResponseBody { get; set; }

        public string Endpoint { get; set; }

        public string ApiVersion { get; set; }

        public double TimeSpent { get; set; }
        public double TimeSpentHead { get; set; }
        public double TimeSpentBody { get; set; }

        public Dictionary<string, List<string>> Headers { get; set; }
        public Dictionary<string, List<string>> ResponseHeaders { get; set; }
        public Dictionary<string, List<string>> ContentHeaders { get; set; }

        public long Size { get; set; }
        public long ResponseSize { get; set; }
        public long ContentSize { get; set; }
    }
}
