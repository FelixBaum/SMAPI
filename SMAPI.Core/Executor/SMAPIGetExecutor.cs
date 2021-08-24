#region [using directives]
using System;
using System.Threading.Tasks;
using SMAPI.Core.Request;
using SMAPI.Core.Response;
#endregion

namespace SMAPI.Core.Executor
{
    public class SMAPIGetExecutor : SMAPIBaseExecutor
    {
        #region - methods -

        #region - public methods -

        #region [Execute]
        public override async Task<ISMAPIResponse> Execute(ISMAPIRequest Request)
        {
            try 
            {
                var Client = GetHttpClient();
                var GetTask = Client.GetAsync(Request.Url);

                var ResponseMessage = await GetTask;

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #endregion

        #endregion
    }
}