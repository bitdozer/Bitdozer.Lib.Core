// <copyright file="StringExtensionTest.cs">Copyright ©  2018</copyright>
using System;
using Bitdozer.Lib.Core;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bitdozer.Lib.Core.Tests
{
    /// <summary>This class contains parameterized unit tests for StringExtension</summary>
    [PexClass(typeof(StringExtension))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class StringExtensionTest
    {
        /// <summary>Test stub for BetweenFirst(String, String, String, StringComparison)</summary>
        [PexMethod]
        public string BetweenFirstTest(
            string s,
            string startText,
            string endText,
            StringComparison comparison
        )
        {
            string result = StringExtension.BetweenFirst(s, startText, endText, comparison);
            return result;
            // TODO: add assertions to method StringExtensionTest.BetweenFirstTest(String, String, String, StringComparison)
        }
    }
}
