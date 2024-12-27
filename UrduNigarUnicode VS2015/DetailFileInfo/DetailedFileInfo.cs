// Decompiled with JetBrains decompiler
// Type: DetailFileInfo.DetailedFileInfo
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

namespace DetailFileInfo
{
  public class DetailedFileInfo
  {
    private string sValue = "";
    private int iID;

    public int ID
    {
      get
      {
        return this.iID;
      }
      set
      {
        this.iID = value;
      }
    }

    public string Value
    {
      get
      {
        return this.sValue;
      }
      set
      {
        this.sValue = value;
      }
    }

    public DetailedFileInfo(int ID, string Value)
    {
      this.iID = ID;
      this.sValue = Value;
    }
  }
}
