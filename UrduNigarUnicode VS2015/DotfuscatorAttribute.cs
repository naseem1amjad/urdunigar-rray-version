// Decompiled with JetBrains decompiler
// Type: DotfuscatorAttribute
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

using System;

[AttributeUsage(AttributeTargets.Assembly)]
public sealed class DotfuscatorAttribute : Attribute
{
  private string a;

  public string A
  {
    get
    {
      return this.a;
    }
  }

  //public DotfuscatorAttribute(string a)
  //{
  //  DotfuscatorAttribute dotfuscatorAttribute = this;
  //  // ISSUE: explicit constructor call
  //  dotfuscatorAttribute.\u002Ector();
  //  string str = a;
  //  dotfuscatorAttribute.a = str;
  //}

  public string a()
  {
    return this.a;
  }
}
