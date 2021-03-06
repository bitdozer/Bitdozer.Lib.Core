using System.Text;
// <copyright file="StringExtensionTest.cs">Copyright ©  2018</copyright>
using System;
using System.Collections;
using System.Collections.Generic;
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
        /// <summary>Test stub for BlankIfNull(String)</summary>
        [PexMethod]
        public string BlankIfNullTest(string str)
        {
            string result = StringExtension.BlankIfNull(str);
            return result;
            // TODO: add assertions to method StringExtensionTest.BlankIfNullTest(String)
        }

        /// <summary>Test stub for BetweenFirst(String, String, String)</summary>
        [PexMethod]
        public string BetweenFirstTest(
            string s,
            string StartText,
            string EndText
        )
        {
            string result = StringExtension.BetweenFirst(s, StartText, EndText);
            return result;
            // TODO: add assertions to method StringExtensionTest.BetweenFirstTest(String, String, String)
        }

        /// <summary>Test stub for ContainsCount(String, Char)</summary>
        [PexMethod]
        public long ContainsCountTest(string s, char FindChar)
        {
            long result = StringExtension.ContainsCount(s, FindChar);
            return result;
            // TODO: add assertions to method StringExtensionTest.ContainsCountTest(String, Char)
        }

        /// <summary>Test stub for ExpandCamel(String)</summary>
        [PexMethod]
        public string ExpandCamelTest(string s)
        {
            string result = StringExtension.ExpandCamel(s);
            return result;
            // TODO: add assertions to method StringExtensionTest.ExpandCamelTest(String)
        }

        /// <summary>Test stub for IndexOfAnyOther(String, Char[])</summary>
        [PexMethod]
        public int IndexOfAnyOtherTest(string s, char[] Find)
        {
            int result = StringExtension.IndexOfAnyOther(s, Find);
            return result;
            // TODO: add assertions to method StringExtensionTest.IndexOfAnyOtherTest(String, Char[])
        }

        /// <summary>Test stub for IsBlankOrNull(String, Boolean)</summary>
        [PexMethod]
        public bool IsBlankOrNullTest(string s, bool TreatWhiteSpaceAsBlank)
        {
            bool result = StringExtension.IsBlankOrNull(s, TreatWhiteSpaceAsBlank);
            return result;
            // TODO: add assertions to method StringExtensionTest.IsBlankOrNullTest(String, Boolean)
        }

        /// <summary>Test stub for IsBlankOrNull(String)</summary>
        [PexMethod]
        public bool IsBlankOrNullTest01(string s)
        {
            bool result = StringExtension.IsBlankOrNull(s);
            return result;
            // TODO: add assertions to method StringExtensionTest.IsBlankOrNullTest01(String)
        }

        /// <summary>Test stub for IsNumeric(String)</summary>
        [PexMethod]
        public bool IsNumericTest(string s)
        {
            bool result = StringExtension.IsNumeric(s);
            return result;
            // TODO: add assertions to method StringExtensionTest.IsNumericTest(String)
        }

        /// <summary>Test stub for Left(String, Int32)</summary>
        [PexMethod]
        public string LeftTest(string s, int len)
        {
            string result = StringExtension.Left(s, len);
            return result;
            // TODO: add assertions to method StringExtensionTest.LeftTest(String, Int32)
        }

        /// <summary>Test stub for LeftOf(String, String)</summary>
        [PexMethod]
        public string LeftOfTest(string s, string search)
        {
            string result = StringExtension.LeftOf(s, search);
            return result;
            // TODO: add assertions to method StringExtensionTest.LeftOfTest(String, String)
        }

        /// <summary>Test stub for LeftOf(String, String, Boolean)</summary>
        [PexMethod]
        public string LeftOfTest01(
            string s,
            string search,
            bool ReturnWholeStringIfNotFound
        )
        {
            string result = StringExtension.LeftOf(s, search, ReturnWholeStringIfNotFound);
            return result;
            // TODO: add assertions to method StringExtensionTest.LeftOfTest01(String, String, Boolean)
        }

        /// <summary>Test stub for LeftOf(String, Char)</summary>
        [PexMethod]
        public string LeftOfTest02(string s, char c)
        {
            string result = StringExtension.LeftOf(s, c);
            return result;
            // TODO: add assertions to method StringExtensionTest.LeftOfTest02(String, Char)
        }

        /// <summary>Test stub for LeftOfLast(String, String, Boolean)</summary>
        [PexMethod]
        public string LeftOfLastTest(
            string s,
            string search,
            bool returnWholeStringIfNotFound
        )
        {
            string result = StringExtension.LeftOfLast(s, search, returnWholeStringIfNotFound);
            return result;
            // TODO: add assertions to method StringExtensionTest.LeftOfLastTest(String, String, Boolean)
        }

        /// <summary>Test stub for LimitLength(String, Int32, Int32, String)</summary>
        [PexMethod]
        public string LimitLengthTest(
            string s,
            int length,
            int shortenBy,
            string append
        )
        {
            string result = StringExtension.LimitLength(s, length, shortenBy, append);
            return result;
            // TODO: add assertions to method StringExtensionTest.LimitLengthTest(String, Int32, Int32, String)
        }

        /// <summary>Test stub for LimitLength(String, Int32, Int32)</summary>
        [PexMethod]
        public string LimitLengthTest01(
            string s,
            int length,
            int shortenBy
        )
        {
            string result = StringExtension.LimitLength(s, length, shortenBy);
            return result;
            // TODO: add assertions to method StringExtensionTest.LimitLengthTest01(String, Int32, Int32)
        }

        /// <summary>Test stub for LimitLength(String, Int32)</summary>
        [PexMethod]
        public string LimitLengthTest02(string s, int length)
        {
            string result = StringExtension.LimitLength(s, length);
            return result;
            // TODO: add assertions to method StringExtensionTest.LimitLengthTest02(String, Int32)
        }

        /// <summary>Test stub for NormalizeLineEndings(String, String)</summary>
        [PexMethod]
        public string NormalizeLineEndingsTest(string s, string LineEnding)
        {
            string result = StringExtension.NormalizeLineEndings(s, LineEnding);
            return result;
            // TODO: add assertions to method StringExtensionTest.NormalizeLineEndingsTest(String, String)
        }

        /// <summary>Test stub for NullIfBlank(String, Boolean)</summary>
        [PexMethod]
        public string NullIfBlankTest(string s, bool TreatWhiteSpaceAsBlank)
        {
            string result = StringExtension.NullIfBlank(s, TreatWhiteSpaceAsBlank);
            return result;
            // TODO: add assertions to method StringExtensionTest.NullIfBlankTest(String, Boolean)
        }

        /// <summary>Test stub for NullIfBlank(String)</summary>
        [PexMethod]
        public string NullIfBlankTest01(string s)
        {
            string result = StringExtension.NullIfBlank(s);
            return result;
            // TODO: add assertions to method StringExtensionTest.NullIfBlankTest01(String)
        }

        /// <summary>Test stub for OrDefault(String, String)</summary>
        [PexMethod]
        public string OrDefaultTest(string str, string DefaultValue)
        {
            string result = StringExtension.OrDefault(str, DefaultValue);
            return result;
            // TODO: add assertions to method StringExtensionTest.OrDefaultTest(String, String)
        }

        /// <summary>Test stub for Pluralize(String, Boolean)</summary>
        [PexMethod]
        public string PluralizeTest(string s, bool pluralize)
        {
            string result = StringExtension.Pluralize(s, pluralize);
            return result;
            // TODO: add assertions to method StringExtensionTest.PluralizeTest(String, Boolean)
        }

        /// <summary>Test stub for Pluralize(String)</summary>
        [PexMethod]
        public string PluralizeTest01(string s)
        {
            string result = StringExtension.Pluralize(s);
            return result;
            // TODO: add assertions to method StringExtensionTest.PluralizeTest01(String)
        }

        /// <summary>Test stub for Replace(String, String, String, StringComparison)</summary>
        [PexMethod]
        public string ReplaceTest(
            string s,
            string search,
            string replace,
            StringComparison comparer
        )
        {
            string result = StringExtension.Replace(s, search, replace, comparer);
            return result;
            // TODO: add assertions to method StringExtensionTest.ReplaceTest(String, String, String, StringComparison)
        }

        /// <summary>Test stub for Right(String, Int32)</summary>
        [PexMethod]
        public string RightTest(string s, int len)
        {
            string result = StringExtension.Right(s, len);
            return result;
            // TODO: add assertions to method StringExtensionTest.RightTest(String, Int32)
        }

        /// <summary>Test stub for RightOf(String, String, Boolean)</summary>
        [PexMethod]
        public string RightOfTest(
            string s,
            string search,
            bool ReturnWholeStringIfNotFound
        )
        {
            string result = StringExtension.RightOf(s, search, ReturnWholeStringIfNotFound);
            return result;
            // TODO: add assertions to method StringExtensionTest.RightOfTest(String, String, Boolean)
        }

        /// <summary>Test stub for RightOf(String, String)</summary>
        [PexMethod]
        public string RightOfTest01(string s, string search)
        {
            string result = StringExtension.RightOf(s, search);
            return result;
            // TODO: add assertions to method StringExtensionTest.RightOfTest01(String, String)
        }

        /// <summary>Test stub for RightOf(String, Char)</summary>
        [PexMethod]
        public string RightOfTest02(string s, char c)
        {
            string result = StringExtension.RightOf(s, c);
            return result;
            // TODO: add assertions to method StringExtensionTest.RightOfTest02(String, Char)
        }

        /// <summary>Test stub for RightOfFirst(String, String)</summary>
        [PexMethod]
        public string RightOfFirstTest(string s, string search)
        {
            string result = StringExtension.RightOfFirst(s, search);
            return result;
            // TODO: add assertions to method StringExtensionTest.RightOfFirstTest(String, String)
        }

        /// <summary>Test stub for RightOfFirst(String, String, StringComparison)</summary>
        [PexMethod]
        public string RightOfFirstTest01(
            string s,
            string search,
            StringComparison comparer
        )
        {
            string result = StringExtension.RightOfFirst(s, search, comparer);
            return result;
            // TODO: add assertions to method StringExtensionTest.RightOfFirstTest01(String, String, StringComparison)
        }

        /// <summary>Test stub for SafeDouble(String)</summary>
        [PexMethod]
        public double SafeDoubleTest(string s)
        {
            double result = StringExtension.SafeDouble(s);
            return result;
            // TODO: add assertions to method StringExtensionTest.SafeDoubleTest(String)
        }

        /// <summary>Test stub for SafeGet(String[], Int32)</summary>
        [PexMethod]
        public string SafeGetTest(string[] l, int index)
        {
            string result = StringExtension.SafeGet(l, index);
            return result;
            // TODO: add assertions to method StringExtensionTest.SafeGetTest(String[], Int32)
        }

        /// <summary>Test stub for SafeGet(String[], Int32, String)</summary>
        [PexMethod]
        public string SafeGetTest01(
            string[] l,
            int index,
            string DefaultValue
        )
        {
            string result = StringExtension.SafeGet(l, index, DefaultValue);
            return result;
            // TODO: add assertions to method StringExtensionTest.SafeGetTest01(String[], Int32, String)
        }

        /// <summary>Test stub for SafeInt(String)</summary>
        [PexMethod]
        public int SafeIntTest(string s)
        {
            int result = StringExtension.SafeInt(s);
            return result;
            // TODO: add assertions to method StringExtensionTest.SafeIntTest(String)
        }

        /// <summary>Test stub for SafeLong(String)</summary>
        [PexMethod]
        public long SafeLongTest(string s)
        {
            long result = StringExtension.SafeLong(s);
            return result;
            // TODO: add assertions to method StringExtensionTest.SafeLongTest(String)
        }

        /// <summary>Test stub for SplitKeepSplitters(String, Char[])</summary>
        [PexMethod]
        public string[] SplitKeepSplittersTest(string s, char[] splitters)
        {
            string[] result = StringExtension.SplitKeepSplitters(s, splitters);
            return result;
            // TODO: add assertions to method StringExtensionTest.SplitKeepSplittersTest(String, Char[])
        }

        /// <summary>Test stub for SplitTrim(String, Char[])</summary>
        [PexMethod]
        public string[] SplitTrimTest(string s, char[] splitters)
        {
            string[] result = StringExtension.SplitTrim(s, splitters);
            return result;
            // TODO: add assertions to method StringExtensionTest.SplitTrimTest(String, Char[])
        }

        /// <summary>Test stub for SplitTrim(String, Boolean, Boolean, Char[])</summary>
        [PexMethod]
        public string[] SplitTrimTest01(
            string s,
            bool AllowEmptyItems,
            bool AllowDuplicates,
            char[] splitters
        )
        {
            string[] result = StringExtension.SplitTrim(s, AllowEmptyItems, AllowDuplicates, splitters);
            return result;
            // TODO: add assertions to method StringExtensionTest.SplitTrimTest01(String, Boolean, Boolean, Char[])
        }

        /// <summary>Test stub for StripChars(String, Char[])</summary>
        [PexMethod]
        public string StripCharsTest(string s, char[] chars)
        {
            string result = StringExtension.StripChars(s, chars);
            return result;
            // TODO: add assertions to method StringExtensionTest.StripCharsTest(String, Char[])
        }

        /// <summary>Test stub for StripHtmlTags(String)</summary>
        [PexMethod]
        public string StripHtmlTagsTest(string s)
        {
            string result = StringExtension.StripHtmlTags(s);
            return result;
            // TODO: add assertions to method StringExtensionTest.StripHtmlTagsTest(String)
        }

        /// <summary>Test stub for StripNonAlphaNumeric(String)</summary>
        [PexMethod]
        public string StripNonAlphaNumericTest(string s)
        {
            string result = StringExtension.StripNonAlphaNumeric(s);
            return result;
            // TODO: add assertions to method StringExtensionTest.StripNonAlphaNumericTest(String)
        }

        /// <summary>Test stub for ToCsvString(String[], Boolean)</summary>
        [PexMethod]
        public string ToCsvStringTest(IList<string> productArray, bool alwaysQuote)
        {
            string result = StringExtension.ToCsvString(productArray, alwaysQuote);
            return result;
            // TODO: add assertions to method StringExtensionTest.ToCsvStringTest(String[], Boolean)
        }

        /// <summary>Test stub for ToSentence(String)</summary>
        [PexMethod]
        public string ToSentenceTest(string s)
        {
            string result = StringExtension.ToSentence(s);
            return result;
            // TODO: add assertions to method StringExtensionTest.ToSentenceTest(String)
        }

        /// <summary>Test stub for ToString(String[], String)</summary>
        [PexMethod]
        public string ToStringTest(string[] l, string separator)
        {
            string result = StringExtension.ToString(l, separator);
            return result;
            // TODO: add assertions to method StringExtensionTest.ToStringTest(String[], String)
        }

        /// <summary>Test stub for ToTitle(String, Boolean)</summary>
        [PexMethod]
        public string ToTitleTest(string s, bool ForceLowerCase)
        {
            string result = StringExtension.ToTitle(s, ForceLowerCase);
            return result;
            // TODO: add assertions to method StringExtensionTest.ToTitleTest(String, Boolean)
        }

        /// <summary>Test stub for ToTitle(String)</summary>
        [PexMethod]
        public string ToTitleTest01(string s)
        {
            string result = StringExtension.ToTitle(s);
            return result;
            // TODO: add assertions to method StringExtensionTest.ToTitleTest01(String)
        }

        /// <summary>Test stub for UriEscapeDataString(String)</summary>
        [PexMethod]
        public string UriEscapeDataStringTest(string str)
        {
            string result = StringExtension.UriEscapeDataString(str);
            return result;
            // TODO: add assertions to method StringExtensionTest.UriEscapeDataStringTest(String)
        }

        /// <summary>Test stub for SafeAppendQuerystringParameter(String, String, String)</summary>
        [PexMethod]
        public string SafeAppendQuerystringParameterTest(
            string url,
            string param,
            string value
        )
        {
            string result = StringExtension.SafeAppendQuerystringParameter(url, param, value);
            return result;
            // TODO: add assertions to method StringExtensionTest.SafeAppendQuerystringParameterTest(String, String, String)
        }

        [PexMethod]
        public string SafeAppend(
            char separator,
            string root,
            string[] items
        )
        {
            string result = StringExtension.SafeAppend(separator, root, items);
            return result;
            // TODO: add assertions to method StringExtensionTest.SafeAppend(Char, String, String[])
        }

        [PexMethod]
        public string SafeAppendFilePath(string path, string[] next)
        {
            string result = StringExtension.SafeAppendFilePath(path, next);
            return result;
            // TODO: add assertions to method StringExtensionTest.SafeAppendFilePath(String, String[])
        }

        /// <summary>Test stub for SafeAppendUrlPath(String, String[])</summary>
        [PexMethod]
        public string SafeAppendUrlPathTest(string path, string[] next)
        {
            string result = StringExtension.SafeAppendUrlPath(path, next);
            return result;
            // TODO: add assertions to method StringExtensionTest.SafeAppendUrlPathTest(String, String[])
        }

        /// <summary>Test stub for SafeAppendQuerystring(String, String)</summary>
        [PexMethod]
        public string SafeAppendQuerystringTest(string url, string qString)
        {
            string result = StringExtension.SafeAppendQuerystring(url, qString);
            return result;
            // TODO: add assertions to method StringExtensionTest.SafeAppendQuerystringTest(String, String)
        }

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

        /// <summary>Test stub for LeftOf(String, String, StringComparison)</summary>
        [PexMethod]
        public string LeftOfTest(
            string s,
            string search,
            StringComparison comparison
        )
        {
            string result = StringExtension.LeftOf(s, search, comparison);
            return result;
            // TODO: add assertions to method StringExtensionTest.LeftOfTest(String, String, StringComparison)
        }

        /// <summary>Test stub for LeftOf(String, String, Boolean, StringComparison)</summary>
        [PexMethod]
        public string LeftOfTest(
            string s,
            string search,
            bool returnWholeStringIfNotFound,
            StringComparison comparison
        )
        {
            string result = StringExtension.LeftOf(s, search, returnWholeStringIfNotFound, comparison);
            return result;
            // TODO: add assertions to method StringExtensionTest.LeftOfTest(String, String, Boolean, StringComparison)
        }


        /// <summary>Test stub for Contains(String, String, StringComparison)</summary>
        [PexMethod]
        public bool ContainsTest(
            string source,
            string stringToFind,
            StringComparison comparison
        )
        {
            bool result = StringExtension.Contains(source, stringToFind, comparison);
            return result;
            // TODO: add assertions to method StringExtensionTest.ContainsTest(String, String, StringComparison)
        }

        /// <summary>Test stub for AppendFormatLine(StringBuilder, String, Object[])</summary>
        [PexMethod]
        public StringBuilder AppendFormatLineTest(
            StringBuilder sb,
            string format,
            object[] args
        )
        {
            StringBuilder result = StringExtension.AppendFormatLine(sb, format, args);
            return result;
            // TODO: add assertions to method StringExtensionTest.AppendFormatLineTest(StringBuilder, String, Object[])
        }
    }
}
