// Decompiled with JetBrains decompiler
// Type: Utils.Uri.Psp.Program3.IniFileManager
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

using System;
using System.Collections;
using System.Globalization;
using System.IO;

namespace Utils.Uri.Psp.Program3
{
  public class IniFileManager
  {
    private string myIniFileName = "";
    private SortedList myFileLines = new SortedList();
    private SortedList mySectionKeysLines = new SortedList();
    private bool myFileReaded;
    private long MaxFileLines;
    private long InsertedKeys;

    public string IniFileName
    {
      get
      {
        return this.myIniFileName;
      }
      set
      {
        this.myFileReaded = false;
        this.myIniFileName = value;
      }
    }

    public IniFileManager(string iniFileName)
    {
      this.myIniFileName = iniFileName;
      this.myFileReaded = this.ReadIniFile();
    }

    public IniFileManager()
    {
      this.myFileReaded = false;
    }

    private string BuildSectionKeyToHKey(string section, string key)
    {
      return this.BuildSectionToHKey(section) + key.Trim();
    }

    private string BuildSectionToHKey(string section)
    {
      return "[" + section.Trim() + "]";
    }

    private string BuildLineToHKey(string lineCount, string extension)
    {
      return lineCount.PadLeft(10, "0".ToCharArray()[0]) + extension;
    }

    private bool ReadIniFile()
    {
      if (this.myFileReaded)
        return true;
      if (!File.Exists(this.myIniFileName))
        File.Create(this.myIniFileName).Close();
      long num = 0;
      this.myFileLines = new SortedList();
      this.mySectionKeysLines = new SortedList();
      string str1 = "[Default]";
      using (StreamReader streamReader = new StreamReader(this.myIniFileName))
      {
        try
        {
          while (streamReader.Peek() > -1)
          {
            string str2 = streamReader.ReadLine().Trim();
            ++num;
            if (this.GetIniLineType(str2) == 2)
            {
              str1 = str2;
              this.mySectionKeysLines.Add((object) str1, (object) this.BuildLineToHKey(num.ToString(), ".0"));
            }
            else if (this.GetIniLineType(str2) == 3)
              this.mySectionKeysLines.Add((object) (str1 + this.GetKeyFromLine(str2)), (object) this.BuildLineToHKey(num.ToString(), ".0"));
            this.myFileLines.Add((object) this.BuildLineToHKey(num.ToString(), ".0"), (object) str2);
          }
          this.MaxFileLines = num;
          this.myFileReaded = true;
        }
        catch (Exception ex)
        {
          throw new Exception("Error reading file: " + this.myIniFileName, ex);
        }
      }
      return this.myFileReaded;
    }

    private int GetIniLineType(string lineText)
    {
      lineText = lineText.Trim();
      return !(lineText == "") ? (!lineText.StartsWith(";") ? (!lineText.StartsWith("[") || !lineText.EndsWith("]") ? 3 : 2) : 1) : 0;
    }

    private string GetKeyFromLine(string line)
    {
      return line.Split("=".ToCharArray())[0];
    }

    private string GetValueFromLine(string line)
    {
      string[] strArray = line.Split("=".ToCharArray());
      if (strArray.Length > 1)
        return strArray[1];
      return "";
    }

    private bool ModifyKeyValue(string section, string key, string keyValue)
    {
      this.myFileLines[(object) this.mySectionKeysLines[(object) this.BuildSectionKeyToHKey(section, key)].ToString()] = (object) (key + "=" + keyValue);
      return true;
    }

    private bool InsertKeyValue(string section, string key, string keyValue)
    {
      ++this.InsertedKeys;
      ++this.MaxFileLines;
      string lineCount = this.mySectionKeysLines[(object) this.BuildSectionToHKey(section)].ToString();
      this.mySectionKeysLines.Add((object) this.BuildSectionKeyToHKey(section, key), (object) this.BuildLineToHKey(lineCount, this.InsertedKeys.ToString()));
      this.myFileLines.Add((object) this.BuildLineToHKey(lineCount, this.InsertedKeys.ToString()), (object) (key + "=" + keyValue));
      return true;
    }

    private bool InsertSection(string section)
    {
      ++this.MaxFileLines;
      this.mySectionKeysLines.Add((object) this.BuildSectionToHKey(section), (object) (this.MaxFileLines.ToString() + ".0"));
      this.myFileLines.Add((object) this.BuildLineToHKey(this.MaxFileLines.ToString(), ".0"), (object) this.BuildSectionToHKey(section));
      return true;
    }

    public bool WriteValue(string section, string key, string keyValue)
    {
      if (!this.ReadIniFile())
        return false;
      section = section.Trim();
      key = key.Trim();
      bool flag;
      if (this.ExistsSectionKey(section, key))
        flag = this.ModifyKeyValue(section, key, keyValue);
      else if (this.ExistsSection(section))
      {
        flag = this.InsertKeyValue(section, key, keyValue);
      }
      else
      {
        flag = this.InsertSection(section);
        if (flag)
          flag = this.InsertKeyValue(section, key, keyValue);
      }
      return flag;
    }

    public bool WriteValue(string section, string key, int keyValue)
    {
      if (!this.ReadIniFile())
        return false;
      return this.WriteValue(section, key, keyValue.ToString());
    }

    public string ReadValue(string section, string key, string defaultValue)
    {
      string str;
      try
      {
        if (!this.ReadIniFile())
          return defaultValue;
        str = this.ExistsSectionKey(section, key) ? this.GetValueFromLine(this.myFileLines[(object) this.mySectionKeysLines[(object) this.BuildSectionKeyToHKey(section, key)].ToString()].ToString()) : defaultValue;
      }
      catch (Exception ex)
      {
        throw new Exception("Error reading file: " + this.myIniFileName + ";section=" + section + ";Key=" + key, ex);
      }
      return str;
    }

    public int ReadValue(string section, string key, int defaultValue)
    {
      int num1 = defaultValue;
      int num2;
      try
      {
        if (!this.ReadIniFile())
          return num1;
        num2 = this.ExistsSectionKey(section, key) ? int.Parse(this.ReadValue(section, key, defaultValue.ToString()), NumberStyles.Integer) : defaultValue;
      }
      catch (Exception ex)
      {
        throw new Exception("Error reading value in file: " + this.myIniFileName + ";section=" + section + ";Key=" + key, ex);
      }
      return num2;
    }

    public bool ExistsSectionKey(string section, string key)
    {
      if (!this.ReadIniFile())
        return false;
      return this.mySectionKeysLines.Contains((object) this.BuildSectionKeyToHKey(section, key));
    }

    public bool EraseSectionKey(string section, string key)
    {
      try
      {
        if (!this.ReadIniFile())
          return false;
        if (!this.ExistsSectionKey(section, key))
          return true;
        this.myFileLines.Remove((object) this.mySectionKeysLines[(object) this.BuildSectionKeyToHKey(section, key)].ToString());
        this.mySectionKeysLines.Remove((object) this.BuildSectionKeyToHKey(section, key));
        return true;
      }
      catch (Exception ex)
      {
        throw new Exception("Error deleting key in file: " + this.myIniFileName + ";section=" + section + ";Key=" + key, ex);
      }
    }

    public bool ExistsSection(string section)
    {
      try
      {
        if (!this.ReadIniFile())
          return false;
        return this.mySectionKeysLines.Contains((object) this.BuildSectionToHKey(section.Trim()));
      }
      catch (Exception ex)
      {
        throw new Exception("Error searching section in file: " + this.myIniFileName + ";section=" + section, ex);
      }
    }

    public bool EraseSection(string section)
    {
      try
      {
        if (!this.ReadIniFile())
          return false;
        if (!this.ExistsSection(section))
          return true;
        int index = this.myFileLines.IndexOfValue((object) this.BuildSectionToHKey(section));
        this.mySectionKeysLines.Remove((object) this.BuildSectionToHKey(section));
        this.myFileLines.RemoveAt(index);
        while (index < this.myFileLines.Count && this.GetIniLineType(this.myFileLines.GetByIndex(index).ToString()) != 2)
        {
          string str = this.myFileLines.GetByIndex(index).ToString();
          if (this.GetIniLineType(str) == 3)
            this.EraseSectionKey(section, this.GetKeyFromLine(str));
          else
            this.myFileLines.RemoveAt(index);
        }
        return true;
      }
      catch (Exception ex)
      {
        throw new Exception("Error deleting section in file: " + this.myIniFileName + ";section=" + section, ex);
      }
    }

    public bool FlushToDisk()
    {
      try
      {
        using (StreamWriter streamWriter = new StreamWriter(this.myIniFileName))
        {
          for (int index = 0; index < this.myFileLines.Count; ++index)
            streamWriter.WriteLine(this.myFileLines.GetByIndex(index));
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Error saving file: " + this.myIniFileName, ex);
      }
      return true;
    }

    private enum iniLineType
    {
      empty,
      comment,
      section,
      keyValue,
    }
  }
}
