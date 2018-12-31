using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="StringExtensionTest.StripHtmlTagsTest.g.cs">Copyright ©  2018</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace Bitdozer.Lib.Core.Tests
{
    public partial class StringExtensionTest
    {

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void StripHtmlTagsTest640()
{
    string s;
    s = this.StripHtmlTagsTest((string)null);
    Assert.AreEqual<string>("", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void StripHtmlTagsTest257()
{
    string s;
    s = this.StripHtmlTagsTest("\0");
    Assert.AreEqual<string>("\0", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void StripHtmlTagsTest329()
{
    string s;
    s = this.StripHtmlTagsTest("\0\0");
    Assert.AreEqual<string>("\0\0", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void StripHtmlTagsTest168()
{
    string s;
    s = this.StripHtmlTagsTest("<\0");
    Assert.AreEqual<string>("", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void StripHtmlTagsTest24()
{
    string s;
    s = this.StripHtmlTagsTest("<<>>");
    Assert.AreEqual<string>("", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void StripHtmlTagsTest827()
{
    string s;
    s = this.StripHtmlTagsTest("<<\0<\0");
    Assert.AreEqual<string>("", s);
}
    }
}
