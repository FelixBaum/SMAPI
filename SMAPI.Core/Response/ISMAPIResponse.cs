#region [using directives]
using System.Collections.Generic;
#endregion

namespace SMAPI.Core.Response
{
    public interface ISMAPIResponse
    {
        int StatusCode { get; set; }

        Dictionary<string, string> Headers { get; set; }

        byte[] Body { get; set; }
    }
}