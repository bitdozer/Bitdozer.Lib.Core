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
public void UriEscapeDataStringTest509()
{
    string s;
    s = this.UriEscapeDataStringTest(".~");
    Assert.AreEqual<string>(".~", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void UriEscapeDataStringTest539()
{
    string s;
    s = this.UriEscapeDataStringTest("%");
    Assert.AreEqual<string>("%25", s);
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
//[Ignore]
//[PexDescription("the test state was: path bounds exceeded")]
public void UriEscapeDataStringTest596()
{
    string s;
    s = this.UriEscapeDataStringTest
            ("퀀퀀栀\0\0@]_]_~~~~~~~~~~~~~~~~~~~~~~~~~~~~~__~__~~~~~~--\0k\0\0\0\0\0\0");
    Assert.AreEqual<string>
        ("%ED%80%80%ED%80%80%E6%A0%80%00%00%40%5D_%5D_~~~~~~~~~~~~~~~~~~~~~~~~~~~~~__~__~~~~~~--%00k%00%00%00%00%00%00", s);
}

        [TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void UriEscapeDataStringTest861()
{
    string s;
    s = this.UriEscapeDataStringTest("퀀퀀栀\0\0]`_`_~__~__~______~~~~~_%%");
    Assert.AreEqual<string>
        ("%ED%80%80%ED%80%80%E6%A0%80%00%00%5D%60_%60_~__~__~______~~~~~_%25%25", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void UriEscapeDataStringTest233()
{
    string s;
    s = this.UriEscapeDataStringTest("�\0");
    Assert.AreEqual<string>("%EF%BF%BD%C2%80%00", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
[PexRaisedException(typeof(UriFormatException))]
public void UriEscapeDataStringTestThrowsUriFormatException332()
{
    string s;
    s = this.UriEscapeDataStringTest("�\0");
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
[PexRaisedException(typeof(UriFormatException))]
public void UriEscapeDataStringTestThrowsUriFormatException920()
{
    string s;
    s = this.UriEscapeDataStringTest("퀀蠀\0�");
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
//[Ignore]
//[PexDescription("the test state was: path bounds exceeded")]
public void UriEscapeDataStringTest65()
{
    string s;
    s = this.UriEscapeDataStringTest(
                                    "`砀%砀%砀0%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%"
                                    );
    Assert.AreEqual<string>("%60%E7%A0%80%25%E7%A0%80%25%E7%A0%800%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25%25", s);

        }

        [TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
//[PexRaisedException(typeof(UriFormatException))]
public void UriEscapeDataStringTestThrowsUriFormatException255()
{
    string s;
    s = this.UriEscapeDataStringTest("저�\0�");
    Assert.AreEqual<string>("%EC%A0%80%EF%BF%BD%00%EF%BF%BD", s);

}

        [TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
[PexRaisedException(typeof(UriFormatException))]
public void UriEscapeDataStringTestThrowsUriFormatException208()
{
    string s;
    s = this.UriEscapeDataStringTest("]砀%砀%砀0%%%%%%%%%%%%�\0");
    Assert.AreEqual<string>("%5D%E7%A0%80%25%E7%A0%80%25%E7%A0%800%25%25%25%25%25%25%25%25%25%25%C2%80%25%C2%80%25%EF%BF%BD%00", s);
}
    }
}
