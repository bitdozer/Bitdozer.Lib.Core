using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="StringExtensionTest.NullIfBlankTest.g.cs">Copyright ©  2018</copyright>
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
public void NullIfBlankTest821()
{
    string s;
    s = this.NullIfBlankTest((string)null, false);
    Assert.AreEqual<string>((string)null, s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void NullIfBlankTest587()
{
    string s;
    s = this.NullIfBlankTest("\0", false);
    Assert.AreEqual<string>("\0", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void NullIfBlankTest497()
{
    string s;
    s = this.NullIfBlankTest("\0", true);
    Assert.AreEqual<string>("\0", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void NullIfBlankTest569()
{
    string s;
    s = this.NullIfBlankTest("\0﻿", true);
    Assert.AreEqual<string>("\0﻿", s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void NullIfBlankTest7101()
{
    string s;
    s = this.NullIfBlankTest(@" 　", true);
    Assert.AreEqual<string>((string)null, s);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void NullIfBlankTest62401()
{
    string s;
    s = this.NullIfBlankTest("﻿\0﻿﻿", true);
    Assert.AreEqual<string>("﻿\0﻿﻿", s);
}
    }
}
