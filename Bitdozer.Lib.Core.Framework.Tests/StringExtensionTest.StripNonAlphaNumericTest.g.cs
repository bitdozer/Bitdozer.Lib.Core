using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="StringExtensionTest.StripNonAlphaNumericTest.g.cs">Copyright ©  2018</copyright>
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
public void StripNonAlphaNumericTest640()
{
    string s;
    s = this.StripNonAlphaNumericTest((string)null);
    Assert.AreEqual<string>("", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void StripNonAlphaNumericTest34()
{
    string s;
    s = this.StripNonAlphaNumericTest("1\0");
    Assert.AreEqual<string>("1", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void StripNonAlphaNumericTest902()
{
    string s;
    s = this.StripNonAlphaNumericTest("11");
    Assert.AreEqual<string>("11", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void StripNonAlphaNumericTest941()
{
    string s;
    s = this.StripNonAlphaNumericTest("qQ耱\0\0\0");
    Assert.AreEqual<string>("qQ耱", s);
}
    }
}
