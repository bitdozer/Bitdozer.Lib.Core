using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bitdozer.Lib.Core;

namespace Bitdozer.Lib.Core.Tests
{
    [TestClass]
    public class StringExtensionManualTests
    {
        [TestMethod]
        public void BetweenFirstTest()
        {
            string s;
            s = "hello".BetweenFirst("hello", "goodbye", StringComparison.OrdinalIgnoreCase);
            Assert.AreEqual<string>("", s);
            s = "hello".BetweenFirst("hello", "hello", StringComparison.OrdinalIgnoreCase);
            Assert.AreEqual<string>("", s);
            s = "hellohello".BetweenFirst("hello", "hello", StringComparison.OrdinalIgnoreCase);
            Assert.AreEqual<string>("", s);
            s = "helloahello".BetweenFirst("hello", "hello", StringComparison.OrdinalIgnoreCase);
            Assert.AreEqual<string>("a", s);
            s = "hellogoodbye".BetweenFirst("hello", "goodbye", StringComparison.OrdinalIgnoreCase);
            Assert.AreEqual<string>("", s);
            s = "hellogoodbyebye".BetweenFirst("hello", "goodbye", StringComparison.OrdinalIgnoreCase);
            Assert.AreEqual<string>("", s);
        }

        [TestMethod]
        public void SafeAppendQuerystringTest()
        {
            string s;
            s = "google.com".SafeAppendQuerystring("test=test&test2=test2");
            Assert.AreEqual<string>("google.com?test=test&test2=test2", s);
            s = "google.com".SafeAppendQuerystring("?test=test&test2=test2");
            Assert.AreEqual<string>("google.com?test=test&test2=test2", s);
            s = "google.com?test=test".SafeAppendQuerystring("test2=test2");
            Assert.AreEqual<string>("google.com?test=test&test2=test2", s);
            s = "google.com?test=test".SafeAppendQuerystring("&test2=test2");
            Assert.AreEqual<string>("google.com?test=test&test2=test2", s);
        }

    }
}
