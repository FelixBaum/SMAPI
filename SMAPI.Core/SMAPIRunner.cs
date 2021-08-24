#region [using directives]
using System;
using System.Threading.Tasks;
using SMAPI.Core.Executor;
using SMAPI.Core.Request;
using SMAPI.Core.Response;
#endregion

namespace SMAPI.Core
{
    public class SMAPIRunner
    {
        #region - methods -

        #region - public methods -

        #region [RunRequest]
        public Task<ISMAPIResponse> RunRequest(ISMAPIRequest Request) 
        {
            __ValidateRequest(Request);

            var Executor = __GetExecutor(Request.RequestType);
            return Executor.Execute(Request);
        }
        #endregion

        #endregion

        #region - private methods -

        #region [__ValidateRequest]
        private void __ValidateRequest(ISMAPIRequest Request)
        {
            if (Request == null)
                throw new ArgumentNullException("Request");

            if (Request.Url == null || Request.Url.Trim().Equals(string.Empty))
                throw new ArgumentNullException("Request.Url");
        }
        #endregion

        #region [__GetExecutor]
        private SMAPIBaseExecutor __GetExecutor(eSMAPIRequestType RequestType)
        {
            switch (RequestType) 
            {
                case eSMAPIRequestType.GET:
                    return new SMAPIGetExecutor();
                default:
                    return null;
            }
        }
        #endregion

        #endregion

        #endregion
    }
}