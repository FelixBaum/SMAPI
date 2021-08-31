#region [using directives]
using System;
using System.Collections.Generic;
using System.Net.Http;
#endregion

namespace SMAPI.Core.Request 
{
    public interface ISMAPIRequest 
    {
        HttpMethod RequestType { get; set; }

        string Url { get; set; }

        Dictionary<string, string> Headers { get; set; }

        HttpContent Content { get; set; }
    }
}