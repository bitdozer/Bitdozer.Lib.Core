using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="StringExtensionTest.UriEscapeDataStringTest.g.cs">Copyright ©  2018</copyright>
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
public void UriEscapeDataStringTest781()
{
    string s;
    s = this.UriEscapeDataStringTest((string)null);
    Assert.AreEqual<string>((string)null, s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
[PexRaisedException(typeof(UriFormatException))]
public void UriEscapeDataStringTestThrowsUriFormatException101()
{
    string s;
    s = this.UriEscapeDataStringTest("�");
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void UriEscapeDataStringTest87()
{
    string s;
    s = this.UriEscapeDataStringTest("�");
    Assert.AreEqual<string>("%EF%BF%BD%C2%80", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void UriEscapeDataStringTest149()
{
    string s;
    s = this.UriEscapeDataStringTest("%~");
    Assert.AreEqual<string>("%25~", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void UriEscapeDataStringTest334()
{
    string s;
    s = this.UriEscapeDataStringTest("�");
    Assert.AreEqual<string>("%EF%BF%BD", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void UriEscapeDataStringTest650()
{
    string s;
    s = this.UriEscapeDataStringTest("`%%");
    Assert.AreEqual<string>("%60%C2%80%25%25", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void UriEscapeDataStringTest467()
{
    string s;
    s = this.UriEscapeDataStringTest("@�\0");
    Assert.AreEqual<string>("%40%C2%80%EF%BF%BD%00", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
[PexRaisedException(typeof(UriFormatException))]
public void UriEscapeDataStringTestThrowsUriFormatException416()
{
    string s;
    s = this.UriEscapeDataStringTest("`�\0�\0");
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void UriEscapeDataStringTest792()
{
    string s;
    s = this.UriEscapeDataStringTest("x�\0");
    Assert.AreEqual<string>("x%EF%BF%BD%EE%80%80%00", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
[PexRaisedException(typeof(UriFormatException))]
public void UriEscapeDataStringTestThrowsUriFormatException221()
{
    string s;
    s = this.UriEscapeDataStringTest("P��");
}
    }
}
