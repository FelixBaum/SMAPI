#region [using directives]
using System.Net.Http;
using System.Threading.Tasks;
using SMAPI.Core.Request;
using SMAPI.Core.Response;
#endregion

namespace SMAPI.Core.Executor
{
    public abstract class SMAPIBaseExecutor
    {
        #region - methods -

        #region - public methods -

        #region [Execute]
        public abstract Task<ISMAPIResponse> Execute(ISMAPIRequest Request);
        #endregion

        #endregion

        #region - protected methods -

        #region [GetHttpClient]
        protected HttpClient GetHttpClient() 
        {
            var Client = new HttpClient();
            return Client;
        }
        #endregion

        #endregion

        #region - private methods -

        #endregion

        #endregion
    }
}