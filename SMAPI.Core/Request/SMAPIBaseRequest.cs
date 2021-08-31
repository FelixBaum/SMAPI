using System.Collections.Generic;
using System.Net.Http;

namespace SMAPI.Core.Request
{
    public class SMAPIBaseRequest : ISMAPIRequest
    {
        public HttpMethod RequestType { get; set; }

        public string Url { get; set; }

        public Dictionary<string, string> Headers { get; set; }

        public HttpContent Content { get; set; }
    }
}