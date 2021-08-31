#region [using directives]
using System.Collections.Generic;
#endregion

namespace SMAPI.Core.Response
{
    public interface ISMAPIResponse
    {
        int StatusCode { get; set; }

        string ReasonPhrase { get; set; }

        Dictionary<string, IEnumerable<string>> Headers { get; set; }

        byte[] Body { get; set; }

        long ResponseTime { get; set; }
    }
}