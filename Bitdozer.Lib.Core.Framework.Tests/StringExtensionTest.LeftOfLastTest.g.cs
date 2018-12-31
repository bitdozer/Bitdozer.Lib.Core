using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="StringExtensionTest.LeftOfLastTest.g.cs">Copyright ©  2018</copyright>
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
public void LeftOfLastTest504()
{
    string s;
    s = this.LeftOfLastTest((string)null, (string)null, false);
    Assert.AreEqual<string>("", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LeftOfLastTest66()
{
    string s;
    s = this.LeftOfLastTest("\0", (string)null, false);
    Assert.AreEqual<string>("", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LeftOfLastTest701()
{
    string s;
    s = this.LeftOfLastTest("\0", (string)null, true);
    Assert.AreEqual<string>("\0", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LeftOfLastTest436()
{
    string s;
    s = this.LeftOfLastTest("\0\0", "\0\0\0", false);
    Assert.AreEqual<string>("", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LeftOfLastTest552()
{
    string s;
    s = this.LeftOfLastTest("\0", "\0", false);
    Assert.AreEqual<string>("", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LeftOfLastTest499()
{
    string s;
    s = this.LeftOfLastTest("\0\0", "\0", false);
    Assert.AreEqual<string>("\0", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LeftOfLastTest176()
{
    string s;
    s = this.LeftOfLastTest("\0", "\0\0\0", false);
    Assert.AreEqual<string>("", s);
}
    }
}
