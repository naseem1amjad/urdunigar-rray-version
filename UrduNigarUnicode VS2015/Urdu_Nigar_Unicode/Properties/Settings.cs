// Decompiled with JetBrains decompiler
// Type: Urdu_Nigar_Unicode.Properties.Settings
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Urdu_Nigar_Unicode.Properties
{
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
  [CompilerGenerated]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        return Settings.defaultInstance;
      }
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("3.2.0.1")]
    public string VersionNumber
    {
      get
      {
        return (string) this["VersionNumber"];
      }
    }

        [ApplicationScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("(Alpha)")]
        public string isAlphaOrBeta
        {
            get
            {
                return (string)this["isAlphaOrBeta"];
            }
        }

        [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("(Beta)")]
    public string isBeta
    {
      get
      {
        return (string) this["isBeta"];
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("http://www.ajsoftpk.com/redirect4urdunigar/index.html")]
    [ApplicationScopedSetting]
    public string Url_1_For_Address_Of_UploadAddress
    {
      get
      {
        return (string) this["Url_1_For_Address_Of_UploadAddress"];
      }
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("http://naseem.amjad.googlepages.com/redirect4urdunigar.txt")]
    public string Url_2_For_Address_Of_UploadAddress
    {
      get
      {
        return (string) this["Url_2_For_Address_Of_UploadAddress"];
      }
    }
  }
}
