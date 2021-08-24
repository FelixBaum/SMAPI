#region [using directives]
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
            var Executor = __GetExecutor(Request.RequestType);
            return Executor.Execute(Request);
        }
        #endregion

        #endregion

        #region - private methods -

        #region [__GetExecutor]
        private SMAPIBaseExecutor __GetExecutor(eSMAPIRequestType RequestType)
        {
            switch (RequestType) 
            {
                case eSMAPIRequestType.GET:
                    return null;
                default:
                    return null;
            }
        }
        #endregion

        #endregion

        #endregion
    }
}