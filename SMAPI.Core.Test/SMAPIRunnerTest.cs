using Microsoft.VisualStudio.TestTools.UnitTesting;
using SMAPI.Core;
using SMAPI.Core.Request;
using System;
using System.Net.Http;

namespace SMAPI.Core.Test
{
    [TestClass]
    public class SMAPIRunnerTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SMAPIRunnerTest_Request_Null()
        {
            var Runner = new SMAPIRunner();
            Runner.RunRequest(null);
        }

        [TestMethod]
        public void SMAPIRunnerTest_Get_Request()
        {
            var Request = new SMAPIBaseRequest();
            Request.RequestType = HttpMethod.Get;
            Request.Url = "https://www.google.de";

            var Runner = new SMAPIRunner();

            Console.WriteLine(Runner.RunRequest(Request).Result);
        }
    }
}