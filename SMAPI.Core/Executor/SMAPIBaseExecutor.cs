#region [using directives]
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using SMAPI.Core.Request;
using SMAPI.Core.Response;
#endregion

namespace SMAPI.Core.Executor
{
    public class SMAPIBaseExecutor
    {
        #region - methods -

        #region - public methods -

        #region [Execute]
        public async Task<ISMAPIResponse> Execute(ISMAPIRequest Request)
        {
            try 
            {
                var Client = __GetHttpClient();
                var RequestMessage = __MapRequest(Request);

                var Watch = Stopwatch.StartNew();
                var SendTask = Client.SendAsync(RequestMessage);
                var ResponseMessage = await SendTask;
                Watch.Stop();

                return __MapResponse(ResponseMessage, Watch.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #endregion

        #region - private methods -

        #region [__GetHttpClient]
        private HttpClient __GetHttpClient() 
        {
            var Client = new HttpClient();
            return Client;
        }
        #endregion

        #region [__MapRequest]
        private HttpRequestMessage __MapRequest(ISMAPIRequest Request)
        {
            var RequestMessage = new HttpRequestMessage(Request.RequestType, Request.Url);

            if (Request.RequestType != HttpMethod.Get)
                RequestMessage.Content = Request.Content;

            if (Request.Headers != null && Request.Headers.Count > 0)
                foreach (var Header in Request.Headers)
                    RequestMessage.Headers.Add(Header.Key, Header.Value);

            return RequestMessage;
        }
        #endregion

        #region [__MapResponse]
        private ISMAPIResponse __MapResponse(HttpResponseMessage ResponseMessage, long ResponseTime)
        {
            var Response = new SMAPIBaseResponse();

            Response.StatusCode = (int)ResponseMessage.StatusCode;
            Response.ReasonPhrase = ResponseMessage.ReasonPhrase;
            Response.ResponseTime = ResponseTime;

            if (ResponseMessage.Headers != null)
                foreach (var Header in ResponseMessage.Headers)
                    Response.Headers.Add(Header.Key, Header.Value);

            if (ResponseMessage.Content != null)
                Response.Body = ResponseMessage.Content.ReadAsByteArrayAsync().Result;

            return Response;
        }
        #endregion

        #endregion

        #endregion
    }
}