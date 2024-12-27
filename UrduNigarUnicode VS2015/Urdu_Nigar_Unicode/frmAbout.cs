// Decompiled with JetBrains decompiler
// Type: Urdu_Nigar_Unicode.frmAbout
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Urdu_Nigar_Unicode.Properties;

namespace Urdu_Nigar_Unicode
{
  internal class frmAbout : Form
  {
    private IContainer components;
    private Label lbltitle;
    private Button okButton;
    private PictureBox pictureBox1;
    private Button button1;
    private TextBox textBox1;
    private PictureBox logoPictureBox;
    private GroupBox groupBox1;
    private PictureBox pictureBox2;
    private Label labelVersion;
    private Label lblDeveloper;
    private LinkLabel linkLabel1;
    private Label lblEmail;
    private Label lblWeb;
    private LinkLabel linkLabel2;
    private Label label1;

    public frmAbout()
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAbout));
      this.lbltitle = new Label();
      this.okButton = new Button();
      this.pictureBox1 = new PictureBox();
      this.button1 = new Button();
      this.textBox1 = new TextBox();
      this.logoPictureBox = new PictureBox();
      this.groupBox1 = new GroupBox();
      this.pictureBox2 = new PictureBox();
      this.labelVersion = new Label();
      this.lblDeveloper = new Label();
      this.linkLabel1 = new LinkLabel();
      this.lblEmail = new Label();
      this.lblWeb = new Label();
      this.linkLabel2 = new LinkLabel();
      this.label1 = new Label();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      ((ISupportInitialize) this.logoPictureBox).BeginInit();
      ((ISupportInitialize) this.pictureBox2).BeginInit();
      this.SuspendLayout();
      this.lbltitle.AutoSize = true;
      this.lbltitle.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.lbltitle.FlatStyle = FlatStyle.System;
      this.lbltitle.Font = new Font("Tahoma", 20f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lbltitle.Location = new Point(20, 19);
      this.lbltitle.Margin = new Padding(6, 0, 3, 0);
      this.lbltitle.MaximumSize = new Size(0, 50);
      this.lbltitle.Name = "lbltitle";
      this.lbltitle.Size = new Size(259, 41);
      this.lbltitle.TabIndex = 19;
      this.lbltitle.Text = "Product Name";
      this.lbltitle.TextAlign = ContentAlignment.MiddleLeft;
      this.lbltitle.Click += new EventHandler(this.lbltitle_Click);
      this.okButton.DialogResult = DialogResult.Cancel;
      this.okButton.FlatStyle = FlatStyle.System;
      this.okButton.Location = new Point(485, 343);
      this.okButton.Name = "okButton";
      this.okButton.Size = new Size(118, 31);
      this.okButton.TabIndex = 24;
      this.okButton.Text = "OK";
      this.okButton.Click += new EventHandler(this.okButton_Click);
      this.pictureBox1.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.pictureBox1.BorderStyle = BorderStyle.Fixed3D;
      this.pictureBox1.Location = new Point(8, 8);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(595, 70);
      this.pictureBox1.TabIndex = 28;
      this.pictureBox1.TabStop = false;
      this.button1.FlatStyle = FlatStyle.System;
      this.button1.Location = new Point(346, 343);
      this.button1.Name = "button1";
      this.button1.Size = new Size(89, 31);
      this.button1.TabIndex = 33;
      this.button1.Text = "System Info";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.textBox1.Location = new Point(8, 270);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.ScrollBars = ScrollBars.Vertical;
      this.textBox1.Size = new Size(294, 75);
      this.textBox1.TabIndex = 37;
      this.textBox1.Text = "Warning: You may distribute the software freely without changing anything. All the files should be in original form.";
//      this.logoPictureBox.Image = (Image) componentResourceManager.GetObject("logoPictureBox.Image");
      this.logoPictureBox.Location = new Point(310, 93);
      this.logoPictureBox.Name = "logoPictureBox";
      this.logoPictureBox.Size = new Size(293, 146);
      this.logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
      this.logoPictureBox.TabIndex = 38;
      this.logoPictureBox.TabStop = false;
      this.groupBox1.Location = new Point(6, 248);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(597, 10);
      this.groupBox1.TabIndex = 39;
      this.groupBox1.TabStop = false;
      this.groupBox1.Enter += new EventHandler(this.groupBox1_Enter);
//      this.pictureBox2.Image = (Image) componentResourceManager.GetObject("pictureBox2.Image");
      this.pictureBox2.Location = new Point(6, 93);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new Size(296, 146);
      this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pictureBox2.TabIndex = 40;
      this.pictureBox2.TabStop = false;
      this.labelVersion.AutoSize = true;
      this.labelVersion.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.labelVersion.FlatStyle = FlatStyle.System;
      this.labelVersion.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.labelVersion.Location = new Point(383, 32);
      this.labelVersion.Margin = new Padding(6, 0, 3, 0);
      this.labelVersion.MaximumSize = new Size(0, 30);
      this.labelVersion.MinimumSize = new Size(0, 20);
      this.labelVersion.Name = "labelVersion";
      this.labelVersion.Size = new Size(131, 24);
      this.labelVersion.TabIndex = 0;
      this.labelVersion.Text = "Version: 3.2";
      this.labelVersion.TextAlign = ContentAlignment.MiddleLeft;
      this.lblDeveloper.AutoSize = true;
      this.lblDeveloper.Font = new Font("Tahoma", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDeveloper.Location = new Point(342, 268);
      this.lblDeveloper.Name = "lblDeveloper";
      this.lblDeveloper.Size = new Size(260, 21);
      this.lblDeveloper.TabIndex = 41;
      this.lblDeveloper.Text = "Developed by Naseem Amjad";
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Cursor = Cursors.Hand;
      this.linkLabel1.Location = new Point(384, 294);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new Size(173, 17);
      this.linkLabel1.TabIndex = 42;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "naseem@technologist.com";
      this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      this.lblEmail.AutoSize = true;
      this.lblEmail.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblEmail.Location = new Point(343, 294);
      this.lblEmail.Name = "lblEmail";
      this.lblEmail.Size = new Size(48, 17);
      this.lblEmail.TabIndex = 43;
      this.lblEmail.Text = "Email: ";
      this.lblEmail.Click += new EventHandler(this.label2_Click);
      this.lblWeb.AutoSize = true;
      this.lblWeb.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblWeb.Location = new Point(343, 314);
      this.lblWeb.Name = "lblWeb";
      this.lblWeb.Size = new Size(119, 17);
      this.lblWeb.TabIndex = 44;
      this.lblWeb.Text = "Search Keywords:";
      this.linkLabel2.AutoSize = true;
      this.linkLabel2.Cursor = Cursors.Hand;
      this.linkLabel2.Location = new Point(459, 314);
      this.linkLabel2.Name = "linkLabel2";
      this.linkLabel2.Size = new Size(111, 17);
      this.linkLabel2.TabIndex = 45;
      this.linkLabel2.TabStop = true;
      this.linkLabel2.Text = "\"Naseem Amjad\"";
      this.linkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(3, 357);
      this.label1.Name = "label1";
      this.label1.Size = new Size(150, 17);
      this.label1.TabIndex = 46;
      this.label1.Text = "©2017 AJSoft Pakistan";
      this.AcceptButton = (IButtonControl) this.okButton;
      this.AutoScaleDimensions = new SizeF(8f, 17f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.okButton;
      this.ClientSize = new Size(610, 382);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.linkLabel2);
      this.Controls.Add((Control) this.lblWeb);
      this.Controls.Add((Control) this.linkLabel1);
      this.Controls.Add((Control) this.lblDeveloper);
      this.Controls.Add((Control) this.labelVersion);
      this.Controls.Add((Control) this.pictureBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.logoPictureBox);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.lbltitle);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.okButton);
      this.Controls.Add((Control) this.lblEmail);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmAbout";
      this.Padding = new Padding(5);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Load += new EventHandler(this.frmAbout_Load);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      ((ISupportInitialize) this.logoPictureBox).EndInit();
      ((ISupportInitialize) this.pictureBox2).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void okButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void frmAbout_Load(object sender, EventArgs e)
    {
      this.Text = "About " + Form1.strTitle;
      this.lbltitle.Text = Form1.strTitle;
      this.labelVersion.Text = Settings.Default.VersionNumber + " " + Settings.Default.isAlphaOrBeta;
      this.button1.Visible = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        Process.Start("msinfo32.exe");
      }
      catch
      {
      }
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
    }

    private void lbltitle_Click(object sender, EventArgs e)
    {
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("mailto:" + this.linkLabel1.Text + "?subject=from UrduNigarRrayVersion" + Settings.Default.VersionNumber + " " + Settings.Default.isAlphaOrBeta + " :");
    }

    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("http://www.google.com.pk/search?hl=en&q=naseem+amjad&btnI=745");
    }
  }
}
