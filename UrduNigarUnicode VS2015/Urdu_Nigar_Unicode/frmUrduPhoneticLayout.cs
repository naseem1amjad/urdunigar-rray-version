// Decompiled with JetBrains decompiler
// Type: Urdu_Nigar_Unicode.frmUrduPhoneticLayout
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Urdu_Nigar_Unicode
{
  public class frmUrduPhoneticLayout : Form
  {
    private IContainer components;
    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
    private PictureBox pictureBox3;
    private LinkLabel linkLabel1;
    private LinkLabel linkLabel2;
    private LinkLabel linkLabel3;

    public frmUrduPhoneticLayout()
    {
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmUrduPhoneticLayout));
      this.pictureBox1 = new PictureBox();
      this.pictureBox2 = new PictureBox();
      this.pictureBox3 = new PictureBox();
      this.linkLabel1 = new LinkLabel();
      this.linkLabel2 = new LinkLabel();
      this.linkLabel3 = new LinkLabel();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      ((ISupportInitialize) this.pictureBox2).BeginInit();
      ((ISupportInitialize) this.pictureBox3).BeginInit();
      this.SuspendLayout();
      this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
      this.pictureBox1.Location = new Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(545, 187);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.pictureBox2.Image = (Image) componentResourceManager.GetObject("pictureBox2.Image");
      this.pictureBox2.Location = new Point(12, 12);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new Size(545, 187);
      this.pictureBox2.TabIndex = 1;
      this.pictureBox2.TabStop = false;
      this.pictureBox3.Image = (Image) componentResourceManager.GetObject("pictureBox3.Image");
      this.pictureBox3.Location = new Point(12, 12);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new Size(545, 187);
      this.pictureBox3.TabIndex = 2;
      this.pictureBox3.TabStop = false;
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Cursor = Cursors.Hand;
      this.linkLabel1.Location = new Point(99, 212);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new Size(53, 17);
      this.linkLabel1.TabIndex = 3;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "Normal";
      this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      this.linkLabel2.AutoSize = true;
      this.linkLabel2.Location = new Point(183, 212);
      this.linkLabel2.Name = "linkLabel2";
      this.linkLabel2.Size = new Size(97, 17);
      this.linkLabel2.TabIndex = 4;
      this.linkLabel2.TabStop = true;
      this.linkLabel2.Text = "Caps Lock On";
      this.linkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
      this.linkLabel3.AutoSize = true;
      this.linkLabel3.Location = new Point(308, 212);
      this.linkLabel3.Name = "linkLabel3";
      this.linkLabel3.Size = new Size(120, 17);
      this.linkLabel3.TabIndex = 5;
      this.linkLabel3.TabStop = true;
      this.linkLabel3.Text = "Shift Key Pressed";
      this.linkLabel3.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
      this.AutoScaleMode = AutoScaleMode.Inherit;
      this.ClientSize = new Size(565, 242);
      this.Controls.Add((Control) this.linkLabel3);
      this.Controls.Add((Control) this.linkLabel2);
      this.Controls.Add((Control) this.linkLabel1);
      this.Controls.Add((Control) this.pictureBox3);
      this.Controls.Add((Control) this.pictureBox2);
      this.Controls.Add((Control) this.pictureBox1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmUrduPhoneticLayout";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "frmUrduPhoneticLayout";
      this.Load += new EventHandler(this.frmUrduPhoneticLayout_Load);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      ((ISupportInitialize) this.pictureBox2).EndInit();
      ((ISupportInitialize) this.pictureBox3).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void frmUrduPhoneticLayout_Load(object sender, EventArgs e)
    {
      this.pictureBox1.Visible = true;
      this.pictureBox2.Visible = false;
      this.pictureBox3.Visible = false;
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.pictureBox1.Visible = true;
      this.pictureBox2.Visible = false;
      this.pictureBox3.Visible = false;
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.pictureBox1.Visible = false;
      this.pictureBox2.Visible = true;
      this.pictureBox3.Visible = false;
    }

    private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.pictureBox1.Visible = false;
      this.pictureBox2.Visible = false;
      this.pictureBox3.Visible = true;
    }
  }
}
