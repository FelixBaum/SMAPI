using System.Collections.Generic;

namespace SMAPI.Core.Response
{
    public class SMAPIBaseResponse : ISMAPIResponse
    {
        public SMAPIBaseResponse()
        {
            Headers = new Dictionary<string, IEnumerable<string>>();
        }

        public int StatusCode { get; set; }
        public string ReasonPhrase { get; set; }
        public Dictionary<string, IEnumerable<string>> Headers { get; set; }
        public byte[] Body { get; set; }
        public long ResponseTime { get; set; }
    }
}