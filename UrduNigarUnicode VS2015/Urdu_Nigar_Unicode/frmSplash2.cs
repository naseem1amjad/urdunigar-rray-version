// Decompiled with JetBrains decompiler
// Type: Urdu_Nigar_Unicode.frmSplash2
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Urdu_Nigar_Unicode.Properties;

namespace Urdu_Nigar_Unicode
{
  public class frmSplash2 : Form
  {
    private IContainer components;
    private PictureBox pictureBox1;
    private Label lblName;
    private Label lblVersion;

    public frmSplash2()
    {
      this.InitializeComponent();
    }

    private void frmSplash2_Load(object sender, EventArgs e)
    {
      this.lblVersion.Text = Settings.Default.VersionNumber + " " + Settings.Default.isAlphaOrBeta;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSplash2));
      this.pictureBox1 = new PictureBox();
      this.lblName = new Label();
      this.lblVersion = new Label();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
      this.pictureBox1.Location = new Point(1, 3);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(398, 186);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.lblName.AutoSize = true;
      this.lblName.BackColor = Color.Transparent;
      this.lblName.Font = new Font("Microsoft Sans Serif", 16.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblName.Location = new Point(125, 118);
      this.lblName.Name = "lblName";
      this.lblName.Size = new Size(263, 32);
      this.lblName.TabIndex = 1;
      this.lblName.Text = "Urdu Nigar Rray version";
      this.lblVersion.AutoSize = true;
      this.lblVersion.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblVersion.ForeColor = Color.FromArgb(0, 64, 64);
      this.lblVersion.Location = new Point(195, 163);
      this.lblVersion.Name = "lblVersion";
      this.lblVersion.Size = new Size(142, 20);
      this.lblVersion.TabIndex = 2;
      this.lblVersion.Text = "Version 2.0 (beta)";
      this.AutoScaleMode = AutoScaleMode.Inherit;
      this.AutoSize = true;
      this.ClientSize = new Size(400, 192);
      this.ControlBox = false;
      this.Controls.Add((Control) this.lblVersion);
      this.Controls.Add((Control) this.lblName);
      this.Controls.Add((Control) this.pictureBox1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.MaximizeBox = false;
      this.Name = "frmSplash2";
      this.Opacity = 0.95;
      this.ShowInTaskbar = false;
      this.SizeGripStyle = SizeGripStyle.Hide;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "frmSplash2";
      this.Load += new EventHandler(this.frmSplash2_Load);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
