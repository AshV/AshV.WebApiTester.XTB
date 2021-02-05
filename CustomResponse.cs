using System;
using System.Collections.Generic;
using System.Net.Http;

namespace AshV.WebApiTester.XTB
{
    public class CustomResponse
    {
        public HttpResponseMessage Response { get; set; }

        public string ResponseBody { get; set; }

        public string Endpoint { get; set; }

        public string ApiVersion { get; set; }

        public double TimeSpent { get; set; }

        public List<KeyValuePair<string, string>> Headers { get; set; }

        public long Size { get; set; }
        public long ResponseSize { get; set; }
        public long ContentSize { get; set; }

        public DateTime StartedAt { get; set; }
        public DateTime FinishedAt { get; set; }
    }
}