using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="StringExtensionTest.ToTitleTest.g.cs">Copyright ©  2018</copyright>
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
public void ToTitleTest236()
{
    string s;
    s = this.ToTitleTest((string)null, false);
    Assert.AreEqual<string>("", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ToTitleTest740()
{
    string s;
    s = this.ToTitleTest("h", false);
    Assert.AreEqual<string>("H", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ToTitleTest973()
{
    string s;
    s = this.ToTitleTest("a", false);
    Assert.AreEqual<string>("a", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ToTitleTest110()
{
    string s;
    s = this.ToTitleTest(" \0", true);
    Assert.AreEqual<string>(" \0", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ToTitleTest17()
{
    string s;
    s = this.ToTitleTest("\0   ", false);
    Assert.AreEqual<string>("\0   ", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ToTitleTest97()
{
    string s;
    s = this.ToTitleTest("  \b ", false);
    Assert.AreEqual<string>("  \b ", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ToTitleTest422()
{
    string s;
    s = this.ToTitleTest("\0  \0  ", false);
    Assert.AreEqual<string>("\0  \0  ", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ToTitleTest554()
{
    string s;
    s = this.ToTitleTest("H  H  ", false);
    Assert.AreEqual<string>("H  H  ", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void ToTitleTest320()
{
    string s;
    s = this.ToTitleTest("\0\0  ", false);
    Assert.AreEqual<string>("\0\0  ", s);
}
    }
}
