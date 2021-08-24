using Microsoft.VisualStudio.TestTools.UnitTesting;
using SMAPI.Core;
using System;

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
    }
}