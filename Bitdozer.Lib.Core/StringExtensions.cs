using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bitdozer.Lib.Core
{
    public static partial class StringExtension
    {
        /// <summary>
        /// Applies Uri.EscapeDataString to the string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string UriEscapeDataString(this String str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            return Uri.EscapeDataString(str);
        }
        /// <summary>
        /// Returns same value as string ?? ""
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string BlankIfNull(this String str)
        {
            return str ?? "";
        }
        /// <summary>
        /// Returns the DefaultValue if the string is null or zero-length
        /// </summary>
        /// <param name="str"></param>
        /// <param name="DefaultValue"></param>
        /// <returns></returns>
        public static string OrDefault(this String str, string DefaultValue)
        {
            if (string.IsNullOrEmpty(str))
                return DefaultValue;
            else
                return str;
        }
        /// <summary>
        /// Shortens the string to length, and if shortening further shortens and appends an indicator
        /// </summary>
        /// <param name="s"></param>
        /// <param name="length">The length to test against-string.Length &lt; length will not be altered</param>
        /// <param name="shortenBy">If string exceeds length, shorten to length-shortenBy</param>
        /// <param name="append">If string exceeds length, append this string, e.g. "..."</param>
        /// <returns></returns>
        public static string LimitLength(this String s, int length, int shortenBy = 3, string append = "...")
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (length < 1 || length - shortenBy < 1)
            {
                return "";
            }
            if (length - shortenBy > s.Length)
            {
                return s;
            }
            if (s.Length > length && s.Length > shortenBy)
                return s.Substring(0, length - shortenBy) + append;
            else
                return s;
        }
        /// <summary>
        /// Returns the left len characters of a string
        /// </summary>
        /// <param name="s"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public static string Left(this string s, int len)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (len < 1 || s.Length == 0)
                return "";
            else if (s.Length <= len)
                return s;
            else
                return s.Substring(0, len);
        }

        /// <summary>
        /// Returns the string left of the first occurence of search.  If search is not found, empty string is returned.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="search">The string to search for</param>
        /// <param name="comparison">The comparision type to perform.  Default: Ordinal</param>
        /// <returns></returns>
        public static string LeftOf(this string s, string search, StringComparison comparison = StringComparison.Ordinal)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (search == null)
                return s;
            if (s.IndexOf(search, comparison) < 0)
                return "";
            else
                return s.Substring(0, s.IndexOf(search, comparison));
        }

        /// <summary>
        /// Returns the string left of the first occurence of search with explicit control over not found handling
        /// </summary>
        /// <param name="s"></param>
        /// <param name="search"></param>
        /// <param name="returnWholeStringIfNotFound"></param>
        /// <param name="comparison">The comparision type to perform.  Default: Ordinal</param>
        /// <returns></returns>
        public static string LeftOf(this string s, string search, bool returnWholeStringIfNotFound, StringComparison comparison = StringComparison.Ordinal)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (search == null)
                return s;
            if (!(s.IndexOf(search, comparison) > -1 || returnWholeStringIfNotFound))
                return "";
            else
                return s.Substring(0, (s + search).IndexOf(search, comparison));
        }
        /// <summary>
        /// Returns the string left of the last occurence of search with explicit control over not found handling
        /// </summary>
        /// <param name="s"></param>
        /// <param name="search"></param>
        /// <param name="returnWholeStringIfNotFound"></param>
        /// <param name="comparison">The comparision type to perform.  Default: Ordinal</param>
        /// <returns></returns>
        public static string LeftOfLast(this string s, string search, bool returnWholeStringIfNotFound = false, StringComparison comparison = StringComparison.Ordinal)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (string.IsNullOrEmpty(search) || s.IndexOf(search, comparison) < 0)
                return returnWholeStringIfNotFound ? s : "";
            return s.Substring(0, s.LastIndexOf(search, comparison));
        }
        /// <summary>
        /// Returns the string right of the last occurence of search with explicit control over not found handling
        /// </summary>
        /// <param name="s"></param>
        /// <param name="search"></param>
        /// <param name="returnWholeStringIfNotFound"></param>
        /// <param name="comparison">The comparision type to perform.  Default: Ordinal</param>
        /// <returns></returns>
        public static string RightOf(this string s, string search, bool returnWholeStringIfNotFound, StringComparison comparison = StringComparison.Ordinal)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (string.IsNullOrEmpty(search))
                return s;
            if (!(s.IndexOf(search, comparison) > -1 || returnWholeStringIfNotFound))
                return "";
            else
            {
                string t = search + s;
                return t.Substring(t.LastIndexOf(search, comparison) + search.Length);
            }
        }
        /// <summary>
        /// Returns the string right of the last occurence of search
        /// </summary>
        /// <param name="s"></param>
        /// <param name="search"></param>
        /// <param name="comparison"></param>
        /// <returns></returns>
        public static string RightOf(this string s, string search, StringComparison comparison = StringComparison.Ordinal)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (string.IsNullOrEmpty(search))
                return s;
            if (s.IndexOf(search, comparison) < 0)
                return "";
            else
                return s.Substring(s.LastIndexOf(search, comparison) + search.Length);
        }
        /// <summary>
        /// Returns the string right of the first occurence of search with explicit control over not found handling
        /// </summary>
        /// <param name="s"></param>
        /// <param name="search"></param>
        /// <param name="comparison">The comparision type to perform.  Default: Ordinal</param>
        /// <returns></returns>
        public static string RightOfFirst(this string s, string search, StringComparison comparison = StringComparison.Ordinal)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (string.IsNullOrEmpty(search))
                return s;
            if (s.IndexOf(search, comparison) < 0)
                return "";
            else
                return s.Substring(s.IndexOf(search, comparison) + search.Length);
        }
        /// <summary>
        /// Replace with control over culture and case handling.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="search">String to find</param>
        /// <param name="replace">Replacement string</param>
        /// <param name="comparison">StringComparison enumerable type</param>
        /// <returns></returns>
        public static string Replace(this string s, string search, string replace, StringComparison comparison)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(search) || (s.IndexOf(search, comparison) < 0))
                return s;
            else
            {
                string s2 = s;
                int index = 0;
                while (index < s2.Length && s2.IndexOf(search, index, comparison) >= 0)
                {
                    int foundat = s2.IndexOf(search, index, comparison);
                    s2 = s2.Left(foundat) + (replace ?? "") + s2.Substring(foundat + search.Length);
                    index = foundat + (replace?.Length ?? 0);
                }
                return s2;
            }
        }
        /// <summary>
        /// Returns the string left of the first occurence of a char with explicit control over not found handling
        /// </summary>
        /// <param name="s"></param>
        /// <param name="c">Character to search for</param>
        /// <param name="returnWholeStringIfNotFound"></param>
        /// <param name="comparison"></param>
        /// <returns></returns>
        public static string LeftOf(this string s, char c, bool returnWholeStringIfNotFound = false, StringComparison comparison = StringComparison.Ordinal)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            return LeftOf(s, c.ToString(), returnWholeStringIfNotFound, comparison);
        }
        /// <summary>
        /// Returns the string right of the last occurence of a char with explicit control over not found handling
        /// </summary>
        /// <param name="s"></param>
        /// <param name="c">Character to search for</param>
        /// <param name="returnWholeStringIfNotFound"></param>
        /// <param name="comparison"></param>
        public static string RightOf(this string s, char c, bool returnWholeStringIfNotFound = false, StringComparison comparison = StringComparison.Ordinal)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            return RightOf(s, c.ToString(), returnWholeStringIfNotFound, comparison);
        }
        /// <summary>
        /// Returns the right len characters of a string
        /// </summary>
        /// <param name="s"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public static string Right(this string s, int len)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (len < 1 || s.Length == 0)
                return "";
            else if (s.Length <= len)
                return s;
            else
                return s.Substring(s.Length - len);
        }
        /// <summary>
        /// Attempts to pluralize a string using standard rules if pluralize is true
        /// </summary>
        /// <param name="s"></param>
        /// <param name="pluralize">Test to determine if pluralizing</param>
        /// <returns></returns>
        public static string Pluralize(this string s, bool pluralize)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (pluralize && !s.EndsWith("."))
            {
                if (s.EndsWith("y") && !("|ay|ey|oy|iy|uy|").Contains("|" + s.Right(2) + "|"))
                {
                    return s.Left(s.Length - 1) + "ies";
                }
                else if (s.EndsWith("s"))
                {
                    return s + "es";
                }
                else
                    return s + "s";
            }
            else
                return s;
        }
        /// <summary>
        /// Attempts to pluralize a string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Pluralize(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            return Pluralize(s, true);
        }
        /// <summary>
        /// Returns true if string is null or empty, or made up entirely of whitespace if specified
        /// </summary>
        /// <param name="s"></param>
        /// <param name="treatWhiteSpaceAsBlank"></param>
        /// <returns></returns>
        public static bool IsBlankOrNull(this string s, bool treatWhiteSpaceAsBlank)
        {
            return (string.IsNullOrEmpty(s) || (treatWhiteSpaceAsBlank && s.Trim().Length == 0));
        }
        /// <summary>
        /// Inline version of string.IsNullOrEmpty
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsBlankOrNull(this string s)
        {
            return string.IsNullOrEmpty(s);
        }
        /// <summary>
        /// Converts a string to null if it is null, empty, or made entirely of whitespace (if specified)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="TreatWhiteSpaceAsBlank"></param>
        /// <returns></returns>
        public static string NullIfBlank(this string s, bool TreatWhiteSpaceAsBlank)
        {
            if (string.IsNullOrEmpty(s) || (TreatWhiteSpaceAsBlank && s.Trim().Length == 0))
                return null;
            else
                return s;
        }
        /// <summary>
        /// Returns null if string.IsNullOrEmpty
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string NullIfBlank(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return null;
            else
                return s;
        }
        /// <summary>
        /// Removes any characters that do not match char.IsLetterOrDigit
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string StripNonAlphaNumeric(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            StringBuilder sb = new StringBuilder();
            foreach (var t in s)
                if (char.IsLetterOrDigit(t))
                    sb.Append(t);

            return sb.ToString();
        }
        /// <summary>
        /// Removes any characters from the string that exist in chars
        /// </summary>
        /// <param name="s"></param>
        /// <param name="chars"></param>
        /// <returns></returns>
        public static string StripChars(this string s, params char[] chars)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (chars == null || chars.Length == 0)
                return s;
            StringBuilder sb = new StringBuilder();
            foreach (var t in s)
                if (!chars.Contains(t))
                    sb.Append(t);

            return sb.ToString();
        }
        /// <summary>
        /// Expands a string by adding a space before any upper-case letters
        /// </summary>
        /// <param name="s">Input string in CamelCase</param>
        /// <returns>Input string expanded with spaces.</returns>
        public static string ExpandCamel(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0 && s[i] >= 'A' && s[i] <= 'Z')
                    sb.Append(" ");
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
        /// <summary>
        /// Returns a case-sensitive cound of occurences of findChar in the string
        /// </summary>
        /// <param name="s"></param>
        /// <param name="findChar"></param>
        /// <returns></returns>
        public static long ContainsCount(this string s, char findChar)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            long count = 0;
            foreach (char c in s)
                if (c == findChar) count++;
            return count;
        }
        /// <summary>
        /// Capitalizes the first character of a string and lowe cases the rest.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToSentence(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            if (s.BlankIfNull().Length > 1)
            {
                return s.Left(1).ToUpper() + s.Substring(1).ToLower();
            }
            else
            {
                return s.BlankIfNull().ToUpper();
            }
        }
        /// <summary>
        /// Like Split, returns a string array, but includes each splitter as an element of the array (allows original to be reassembled from the list).
        /// </summary>
        /// <param name="s">Input string</param>
        /// <param name="splitters">List of char delimiters</param>
        /// <returns></returns>
        public static string[] SplitKeepSplitters(this string s, params char[] splitters)
        {
            //string[] outarray = null;
            if (string.IsNullOrEmpty(s) || splitters == null || splitters.Length == 0)
                return new[] { s };

            var outList = new List<string>();
            while (s.Length > 0)
            {
                if (splitters.Contains(s[0]))
                {
                    outList.Add(s[0].ToString());
                    s = s.Length > 1 ? s.Substring(1) : "";
                }
                else
                {
                    int i = 0;
                    while (i < s.Length && !splitters.Contains(s[i]))
                        i++;
                    if (s.Length > i + 1)
                    {
                        outList.Add(s.Left(i));
                        s = s.Substring(i);
                    }
                    else
                    {
                        outList.Add(s);
                        s = "";
                    }
                }
            }
            return outList.ToArray();
        }

        /// <summary>
        /// Splits a string list, trims the elements of whitespace and omits blank and duplicate items
        /// </summary>
        /// <param name="s"></param>
        /// <param name="splitters">char[] of splitters</param>
        /// <returns>string[]</returns>
        public static string[] SplitTrim(this string s, params char[] splitters)
        {
            if (s.IsBlankOrNull())
                return new string[0];
            if (splitters == null || splitters.Length == 0)
                return new[] { s };
            var atemp = s.Split(splitters);
            List<string> templist = new List<string>();
            foreach (var item in atemp)
            {
                s = item.Trim();
                if (s.Length > 0 && !templist.Contains(item))
                    templist.Add(s);
            }
            return templist.ToArray();
        }

        /// <summary>
        /// Splits a string list, trims the elements of whitespace and optionally retains blank and/or duplicate items
        /// </summary>
        /// <param name="s"></param>
        /// <param name="allowEmptyItems">If true, empty values are retained</param>
        /// <param name="allowDuplicates">If true, duplicate values are retained</param>
        /// <param name="splitters">char[] of splitters</param>
        /// <returns>string[]</returns>
        public static string[] SplitTrim(this string s, bool allowEmptyItems, bool allowDuplicates, params char[] splitters)
        {
            if (s.IsBlankOrNull())
                return new string[0];
            if (splitters == null || splitters.Length == 0)
                return new[] { s };
            var atemp = s.Split(splitters);

            List<string> templist = new List<string>();
            foreach (var item in atemp)
            {
                s = item.Trim();
                if ((s.Length > 0 || allowEmptyItems) && (allowDuplicates || !templist.Contains(item)))
                    templist.Add(s);
            }
            return templist.ToArray();
        }
        /// <summary>
        /// Attempts to convert a string to title case leaving common connector words as lower case
        /// </summary>
        /// <param name="s"></param>
        /// <param name="forceLowerCase">If false only alters case on first letter, if true forcess rest of word to lower case</param>
        /// <returns></returns>
        public static string ToTitle(this string s, bool forceLowerCase = true)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;
            StringBuilder sb = new StringBuilder();
            string[] words = s.SplitKeepSplitters(' ', '-', '/', '(', '+', '=', '\'', '"', '{', '[', '<', '>', ',', '\n', '\r', '\t', '&');
            string[] ignore = { "of", "on", "the", "a", "an", "the", "to", "but", "or", "and", "nor", "in", "for", "with", "as", "by", "at", "from" };
            foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    if (!ignore.Contains(word.ToLower()))
                        sb.Append(word[0].ToString().ToUpper() + (forceLowerCase ? word.Substring(1).ToLower() : word.Substring(1)));
                    else
                        sb.Append(word.ToLower());
                }
            }
            return sb.ToString();
        }

        // adapted from: http://blog.binaryocean.com/2008/02/24/TextBoxMaxLengthFromLINQMetaData.aspx
        /// <summary>
        /// Returns text between first StartText and EndText in s, ignoring case
        /// </summary>
        /// <param name="s">String being searched</param>
        /// <param name="startText">Start delimiter</param>
        /// <param name="endText">End delimiter</param>
        /// <param name="comparison">Comparison to use, default to ignore case</param>
        /// <returns></returns>
        public static string BetweenFirst(this string s, string startText, string endText, StringComparison comparison = StringComparison.OrdinalIgnoreCase)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(startText) || string.IsNullOrEmpty(endText) ||
                s.IndexOf(startText, comparison) < 0)
                return string.Empty;
            int start = s.IndexOf(startText, comparison) + startText.Length;
            int end = s.IndexOf(endText, start, comparison);
            if (end < 1)
                return string.Empty;
            return s.Substring(start, end - start);
        }
        /// <summary>
        /// Returns the result of double.TryParse on the string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsNumeric(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;
            return double.TryParse(s, out _);
        }
        /// <summary>
        /// Converts a string array to a string with the given separator
        /// </summary>
        /// <param name="l"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static string ToString(this string[] l, string separator)
        {
            string s = "";
            if (l != null && l.Length > 0)
            {
                for (int i = 0; i < l.Length; i++)
                    s += ((i > 0) ? separator : "") + l[i];
            }
            return s;
        }
        /// <summary>
        /// Returns a CSV of the array.  Values are quoted if any value contains a comma or quote, or if alwaysQuote=true
        /// </summary>
        /// <param name="productArray">Array of string. nulls are converted to the empty string</param>
        /// <param name="alwaysQuote">Always use quotes, even if no value requires it</param>
        /// <returns></returns>
        public static string ToCsvString(this string[] productArray, bool alwaysQuote = false)
        {
            if (productArray == null)
                return null;
            if (productArray.Length == 0)
                return "";
            string s = "";
            bool quoted = alwaysQuote || productArray.Any(p => p != null && (p.Contains(",") || p.Contains("\"")));
            for (var i = 0; i < productArray.Length; i++)
            {
                var s1 = productArray[i] ?? "";
                if (quoted)
                    s1 = s1.Replace("\"", "\"\"");
                s += ((i > 0) ? "," : "") + (quoted ? "\"" : "") + s1 +
                     (quoted ? "\"" : "");
            }
            return s;
        }
        /// <summary>
        /// Returns a value from the array or default value if index outside the bounds
        /// </summary>
        /// <param name="l"></param>
        /// <param name="index"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static string SafeGet(this string[] l, int index, string defaultValue = "")
        {
            if (l != null && index >= 0 && l.Length > index)
                return l[index];
            else
                return defaultValue;
        }
        /// <summary>
        /// Returns position of first character in string not in the array.  Returns -1 if not found.
        /// </summary>
        /// <param name="s">String to search</param>
        /// <param name="Find">Char array of ignore characters</param>
        /// <returns></returns>
        public static int IndexOfAnyOther(this string s, char[] Find)
        {
            if (string.IsNullOrEmpty(s) || Find == null || Find.Length == 0)
                return -1;
            var position = 0;
            while (position < s.Length && Find.Contains(s[position]))
                position++;
            if (position >= s.Length)
                return -1;
            else
                return position;
        }
        public static string StripHtmlTags(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;
            StringBuilder sb = new StringBuilder();
            bool inside = false;

            foreach (var @let in s)
            {
                if (@let == '<')
                {
                    inside = true;
                    continue;
                }
                if (@let == '>')
                {
                    inside = false;
                    continue;
                }
                if (!inside)
                {
                    sb.Append(@let);
                }
            }
            return sb.ToString();
        }
        public static string NormalizeLineEndings(this string s, string LineEnding)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;
            s = s.Replace("\r\n", "\n");
            s = s.Replace("\r", "");
            s = s.Replace("\n", LineEnding);
            return s;
        }
        /// <summary>
        /// Returns the result of int.TryParse or 0 if that fails
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int SafeInt(this string s)
        {
            if (s != null && int.TryParse(s, out var i))
                return i;
            return 0;
        }
        /// <summary>
        /// Returns the result of long.TryParse or 0 if that fails
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static long SafeLong(this string s)
        {
            if (s != null && long.TryParse(s, out var i))
                return i;
            return 0;
        }
        /// <summary>
        /// Returns the result of double.TryParse or 0.0 if that fails.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static double SafeDouble(this string s)
        {
            if (s != null && double.TryParse(s, out var i))
                return i;
            return 0.0;
        }
        /// <summary>
        /// Attempts to append a querystring parameter and value by looking for existing ? and & in the url.  Does not take into account # anchors
        /// </summary>
        /// <param name="url"></param>
        /// <param name="param"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SafeAppendQuerystringParameter(this string url, string param, string value)
        {
            string preChar = "";
            string paramString = "";
            if (!string.IsNullOrEmpty(param))
            {
                if (!((url ?? "").EndsWith("?") || (url ?? "").EndsWith("&")))
                {
                    preChar = (url ?? "").Contains("?") ? "&" : "?";
                }
                paramString = param + "=" + value.UriEscapeDataString();
            }
            return (url ?? "") + preChar + paramString;
        }
        public static string SafeAppendQuerystring(this string url, string qString)
        {
            string prechar = "";
            if (string.IsNullOrEmpty(qString))
                return url ?? "";
            if (qString.StartsWith("?") || qString.StartsWith("&"))
                qString = qString.Substring(1);
            if (!string.IsNullOrEmpty(qString))
            {
                if (!((url ?? "").EndsWith("?") || (url ?? "").EndsWith("&")))
                {
                    prechar = (url ?? "").Contains("?") ? "&" : "?";
                }
            }
            return (url ?? "") + prechar + (qString ?? "");
        }
        public static string SafeAppendFilePath(string path, params string[] next)
        {
            return SafeAppend('\\', path, next);
        }
        public static string SafeAppendUrlPath(string path, params string[] next)
        {
            return SafeAppend('/', path, next);
        }
        public static string SafeAppend(char separator, string root, params string[] items)
        {
            string tempPath = root ?? "";
            if (items == null || items.Length < 1)
                return tempPath;
            foreach (var item in items)
                tempPath = (tempPath.TrimEnd(separator) + separator + (item ?? "").TrimStart(separator));
            return tempPath;
        }
        /// <summary>
        /// Performs a Contains test with control over the StringComparison used
        /// </summary>
        /// <param name="source"></param>
        /// <param name="stringToFind"></param>
        /// <param name="comparison"></param>
        /// <returns></returns>
        public static bool Contains(this string source, string stringToFind, StringComparison comparison)
        {
            return source != null && stringToFind != null && source.IndexOf(stringToFind, comparison) > -1;
        }
        /// <summary>
        /// Same as StringBuilder.AppendFormat + StringBuilder.AppendLine
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="format">A composite format string</param>
        /// <param name="args">An array of objects to format</param>
        /// <returns>A reference to this instance with format and the default line terminator appended. Each format item in format is replaced by the string representation of the corresponding object argument.</returns>
        public static StringBuilder AppendFormatLine(this StringBuilder sb, string format, params object[] args)
        {
            if (!string.IsNullOrEmpty(format) && args != null)
                sb?.AppendFormat(format, args);
            sb?.AppendLine();
            return sb;
        }
    }

}
