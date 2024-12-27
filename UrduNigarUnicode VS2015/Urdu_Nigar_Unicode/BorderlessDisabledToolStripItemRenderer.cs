// Decompiled with JetBrains decompiler
// Type: Urdu_Nigar_Unicode.BorderlessDisabledToolStripItemRenderer
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

using System.Windows.Forms;

namespace Urdu_Nigar_Unicode
{
  internal class BorderlessDisabledToolStripItemRenderer : ToolStripProfessionalRenderer
  {
    protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
    {
      if (!e.Item.Enabled)
        return;
      base.OnRenderMenuItemBackground(e);
    }
  }
}
