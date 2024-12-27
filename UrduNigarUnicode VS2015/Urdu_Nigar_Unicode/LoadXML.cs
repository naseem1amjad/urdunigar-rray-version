// Decompiled with JetBrains decompiler
// Type: Urdu_Nigar_Unicode.LoadXML
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
//using System.Xml;

namespace Urdu_Nigar_Unicode
{
  public class LoadXML
  {
    private Assembly a;

    public LoadXML()
    {
      this.a = Assembly.GetExecutingAssembly();
    }

    public DataTable LoadDictionary()
    {
      DataSet dataSet = new DataSet();
      dataSet.Tables.Clear();
      Stream manifestResourceStream = this.a.GetManifestResourceStream("UrduNigarUnicode.Res.UrduDict.xml");
      if (manifestResourceStream == null)
      {
        int num1 = (int) MessageBox.Show("Unable to Load Dictionary");
      }
      int num2 = (int) dataSet.ReadXml(manifestResourceStream, XmlReadMode.ReadSchema);
      return dataSet.Tables[0];
    }
  }
}
