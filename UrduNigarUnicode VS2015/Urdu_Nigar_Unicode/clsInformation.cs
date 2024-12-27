// Decompiled with JetBrains decompiler
// Type: Urdu_Nigar_Unicode.clsInformation
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System;

namespace Urdu_Nigar_Unicode
{
  internal class clsInformation
  {
    public string GetFrameworkShortVersion()
    {
      return Environment.Version.ToString().Remove(3);
    }

    public string GetOSFullName()
    {
      return new ComputerInfo().OSFullName;
    }

    public static string FormatBytes(double dblBytes)
    {
      try
      {
        if (dblBytes == 1073741824.0)
          return Strings.FormatNumber((object) (dblBytes / 1073741824.0), 2, TriState.False, TriState.False, TriState.False) + " GB";
        if (1048576.0 <= dblBytes && dblBytes <= 1073741823.0)
          return Strings.FormatNumber((object) (dblBytes / 1048576.0), 2, TriState.False, TriState.False, TriState.False) + " MB";
        if (1024.0 <= dblBytes && dblBytes <= 1048575.0)
          return Strings.FormatNumber((object) (dblBytes / 1024.0), 0, TriState.False, TriState.False, TriState.False) + " KB";
        if (0.0 <= dblBytes && dblBytes <= 1023.0)
          return Strings.FormatNumber((object) dblBytes, 0, TriState.False, TriState.False, TriState.False) + " bytes";
        return "";
      }
      catch
      {
        return "";
      }
    }
  }
}
