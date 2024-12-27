// Decompiled with JetBrains decompiler
// Type: Utils.Uri.Psp.Program3.DirectIniFile
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

namespace Utils.Uri.Psp.Program3
{
  public class DirectIniFile
  {
    public static bool WriteProfileValue(string iniFileName, string section, string key, string keyValue)
    {
      IniFileManager iniFileManager = new IniFileManager(iniFileName);
      bool flag = iniFileManager.WriteValue(section, key, keyValue);
      if (flag)
        flag = iniFileManager.FlushToDisk();
      return flag;
    }

    public static bool WriteProfileValue(string iniFileName, string section, string key, int keyValue)
    {
      IniFileManager iniFileManager = new IniFileManager(iniFileName);
      bool flag = iniFileManager.WriteValue(section, key, keyValue);
      if (flag)
        flag = iniFileManager.FlushToDisk();
      return flag;
    }

    public static string ReadProfileValue(string iniFileName, string section, string key, string defaultValue)
    {
      return new IniFileManager(iniFileName).ReadValue(section, key, defaultValue);
    }

    public static int ReadProfileValue(string iniFileName, string section, string key, int defaultValue)
    {
      return new IniFileManager(iniFileName).ReadValue(section, key, defaultValue);
    }
  }
}
