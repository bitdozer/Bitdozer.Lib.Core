using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="StringExtensionTest.SafeAppendQuerystringParameterTest.g.cs">Copyright ©  2018</copyright>
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
public void SafeAppendQuerystringParameterTest72()
{
    string s;
    s = this.SafeAppendQuerystringParameterTest
            ((string)null, (string)null, (string)null);
    Assert.AreEqual<string>("", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void SafeAppendQuerystringParameterTest609()
{
    string s;
    s = this.SafeAppendQuerystringParameterTest((string)null, "\0", (string)null);
    Assert.AreEqual<string>("?\0=", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void SafeAppendQuerystringParameterTest430()
{
    string s;
    s = this.SafeAppendQuerystringParameterTest("\0", "\0", (string)null);
    Assert.AreEqual<string>("\0?\0=", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void SafeAppendQuerystringParameterTest608()
{
    string s;
    s = this.SafeAppendQuerystringParameterTest("?", "?", (string)null);
    Assert.AreEqual<string>("??=", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void SafeAppendQuerystringParameterTest518()
{
    string s;
    s = this.SafeAppendQuerystringParameterTest("", "\0", (string)null);
    Assert.AreEqual<string>("?\0=", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void SafeAppendQuerystringParameterTest419()
{
    string s;
    s = this.SafeAppendQuerystringParameterTest((string)null, "%", "%");
    Assert.AreEqual<string>("?%=%25", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void SafeAppendQuerystringParameterTest57()
{
    string s;
    s = this.SafeAppendQuerystringParameterTest("\0\0", "\0", (string)null);
    Assert.AreEqual<string>("\0\0?\0=", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
[PexRaisedException(typeof(UriFormatException))]
public void SafeAppendQuerystringParameterTestThrowsUriFormatException523()
{
    string s;
    s = this.SafeAppendQuerystringParameterTest((string)null, "�", "�");
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void SafeAppendQuerystringParameterTest177()
{
    string s;
    s = this.SafeAppendQuerystringParameterTest((string)null, "", "\0\0\0");
    Assert.AreEqual<string>("?=%C2%80%C2%80%C2%80%C2%80%00%00%00", s);
}


[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void SafeAppendQuerystringParameterTest721()
{
    string s;
    s = this.SafeAppendQuerystringParameterTest("?\0", "?", "");
    Assert.AreEqual<string>("?\0&?=", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void SafeAppendQuerystringParameterTest995()
{
    string s;
    s = this.SafeAppendQuerystringParameterTest
            ((string)null, "~~", "　퀀퀀 　퀀퀀퀀퀀栀`_~%%%%%%%%%%%");
    Assert.AreEqual<string>
        ("?~~=%E3%80%80%C2%80%C2%80%C2%80%C2%80%C2%80%ED%80%80%ED%80%80%E2%80%80%E3%80%80%ED%80%80%ED%80%80%ED%80%80%ED%80%80%E6%A0%80%60%C2%80_%C2%80~%25%25%25%25%25%25%25%25%25%25%25", 
         s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void SafeAppendQuerystringParameterTest348()
{
    string s;
    s = this.SafeAppendQuerystringParameterTest
            ((string)null, "뀀", "뀀�Ā\0");
    Assert.AreEqual<string>
        ("?뀀=%EB%80%80%EF%BF%BD%C2%80%C2%80%C2%80%C2%80%C4%80%C2%80%C2%80%C2%80%C2%80%C2%80%C2%80%C2%80%C2%80%00", 
         s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void SafeAppend192()
{
    string s;
    s = this.SafeAppend(' ', (string)null, (string[])null);
    Assert.AreEqual<string>("", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void SafeAppend248()
{
    string s;
    string[] ss = new string[1];
    s = this.SafeAppend(' ', "", ss);
    Assert.AreEqual<string>(" ", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void SafeAppend190()
{
    string s;
    string[] ss = new string[2];
    ss[0] = "A@";
    ss[1] = "A@";
    s = this.SafeAppend('A', (string)null, ss);
    Assert.AreEqual<string>("A@A@", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void SafeAppend554()
{
    string s;
    string[] ss = new string[2];
    ss[1] = "! ";
    s = this.SafeAppend(' ', "! ", ss);
    Assert.AreEqual<string>("! ! ", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void SafeAppend124()
{
    string s;
    string[] ss = new string[2];
    ss[0] = "";
    ss[1] = "";
    s = this.SafeAppend(' ', "", ss);
    Assert.AreEqual<string>(" ", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void SafeAppend399()
{
    string s;
    string[] ss = new string[3];
    s = this.SafeAppend(' ', (string)null, ss);
    Assert.AreEqual<string>(" ", s);
}
    }
}
