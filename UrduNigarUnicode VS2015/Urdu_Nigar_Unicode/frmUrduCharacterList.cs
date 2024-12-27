// Decompiled with JetBrains decompiler
// Type: Urdu_Nigar_Unicode.frmUrduCharacterList
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Urdu_Nigar_Unicode
{
  public class frmUrduCharacterList : Form
  {
    private IContainer components;
    private PictureBox pictureBox1;

    public frmUrduCharacterList()
    {
      this.InitializeComponent();
    }

    private void UrduCharacterList_Load(object sender, EventArgs e)
    {
    }

    private void frmUrduCharacterList_Load(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmUrduCharacterList));
      this.pictureBox1 = new PictureBox();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.pictureBox1.BackgroundImageLayout = ImageLayout.Center;
      this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
      this.pictureBox1.Location = new Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(200, 2611);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoScroll = true;
      this.ClientSize = new Size(235, 442);
      this.Controls.Add((Control) this.pictureBox1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmUrduCharacterList";
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "UrduCharacterList";
      this.TopMost = true;
      this.Load += new EventHandler(this.frmUrduCharacterList_Load);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
