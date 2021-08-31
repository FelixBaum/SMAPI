using System;
using System.Net.Http;
using SMAPI.Core;
using SMAPI.Core.Request;

namespace SMAPI.Core.Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var Request = new SMAPIBaseRequest();
            Request.RequestType = HttpMethod.Get;
            Request.Url = "https://www.google.de";

            var Runner = new SMAPIRunner();

            var Response = Runner.RunRequest(Request).Result;
            Console.WriteLine(Response.ResponseTime);
        }
    }
}
