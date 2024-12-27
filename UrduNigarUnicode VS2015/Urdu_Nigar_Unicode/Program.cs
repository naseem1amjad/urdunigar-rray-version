// Decompiled with JetBrains decompiler
// Type: Urdu_Nigar_Unicode.Program
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

using System;
using System.Windows.Forms;

namespace Urdu_Nigar_Unicode
{
  internal static class Program
  {
    private static Timer myTimer = new Timer();
    private static int counter = 0;
    private static bool glbIsTimeOver = false;

    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      frmSplash2 frmSplash2 = new frmSplash2();
      Program.myTimer.Tick += new EventHandler(Program.myTimer_Tick);
      Program.myTimer.Interval = 1000;
      Program.myTimer.Start();
      while (!Program.glbIsTimeOver)
      {
        frmSplash2.Show();
        Application.DoEvents();
        if (Program.glbIsTimeOver)
        {
          frmSplash2.Dispose();
          Application.Run((Form) new Form1());
          break;
        }
      }
    }

    private static void myTimer_Tick(object sender, EventArgs e)
    {
      Program.myTimer.Stop();
      if (Program.counter < 4)
      {
        Program.myTimer.Enabled = true;
        ++Program.counter;
      }
      if (Program.counter != 4)
        return;
      Program.glbIsTimeOver = true;
    }
  }
}
