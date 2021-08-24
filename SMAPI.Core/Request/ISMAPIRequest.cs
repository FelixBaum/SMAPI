#region [using directives]
using System;
#endregion

namespace SMAPI.Core.Request 
{
    public interface ISMAPIRequest 
    {
        eSMAPIRequestType RequestType { get; set; }

        string Url { get; set; }
    }
}