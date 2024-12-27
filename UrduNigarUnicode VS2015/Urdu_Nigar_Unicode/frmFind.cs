// Decompiled with JetBrains decompiler
// Type: Urdu_Nigar_Unicode.frmFind
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Urdu_Nigar_Unicode
{
  public class frmFind : Form
  {
    private IContainer components;
    private Label Label1;
    private Button Button2;
    private Button Button1;
    private GroupBox groupBox1;
    private RadioButton rdoDown;
    private RadioButton rdoUp;
    private TextBox txt;
    public static bool formOpened;
    private Form1 f;

    public frmFind()
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
      this.Label1 = new Label();
      this.Button2 = new Button();
      this.Button1 = new Button();
      this.groupBox1 = new GroupBox();
      this.rdoDown = new RadioButton();
      this.rdoUp = new RadioButton();
      this.txt = new TextBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      this.Label1.FlatStyle = FlatStyle.System;
      this.Label1.Location = new Point(7, 9);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(58, 13);
      this.Label1.TabIndex = 21;
      this.Label1.Text = "Find what:";
      this.Label1.TextAlign = ContentAlignment.MiddleLeft;
      this.Button2.DialogResult = DialogResult.Cancel;
      this.Button2.FlatStyle = FlatStyle.System;
      this.Button2.Location = new Point(312, 40);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(75, 23);
      this.Button2.TabIndex = 20;
      this.Button2.Text = "Cancel";
      this.Button2.UseVisualStyleBackColor = true;
      this.Button2.Click += new EventHandler(this.Button2_Click);
      this.Button1.Enabled = false;
      this.Button1.FlatStyle = FlatStyle.System;
      this.Button1.Location = new Point(312, 8);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(75, 23);
      this.Button1.TabIndex = 19;
      this.Button1.Text = "Find Next";
      this.Button1.UseVisualStyleBackColor = true;
      this.Button1.Click += new EventHandler(this.Button1_Click);
      this.groupBox1.Controls.Add((Control) this.rdoDown);
      this.groupBox1.Controls.Add((Control) this.rdoUp);
      this.groupBox1.FlatStyle = FlatStyle.System;
      this.groupBox1.Location = new Point(200, 32);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(104, 56);
      this.groupBox1.TabIndex = 23;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Direction";
      this.rdoDown.Checked = true;
      this.rdoDown.FlatStyle = FlatStyle.System;
      this.rdoDown.Location = new Point(48, 24);
      this.rdoDown.Name = "rdoDown";
      this.rdoDown.Size = new Size(48, 18);
      this.rdoDown.TabIndex = 1;
      this.rdoDown.TabStop = true;
      this.rdoDown.Text = "Down";
      this.rdoDown.UseVisualStyleBackColor = true;
      this.rdoUp.AutoSize = true;
      this.rdoUp.FlatStyle = FlatStyle.System;
      this.rdoUp.Location = new Point(8, 24);
      this.rdoUp.Name = "rdoUp";
      this.rdoUp.Size = new Size(44, 18);
      this.rdoUp.TabIndex = 0;
      this.rdoUp.Text = "Up";
      this.rdoUp.UseVisualStyleBackColor = true;
      this.txt.Location = new Point(72, 8);
      this.txt.Name = "txt";
      this.txt.Size = new Size(232, 21);
      this.txt.TabIndex = 24;
      this.txt.TextChanged += new EventHandler(this.txt_TextChanged);
      this.AcceptButton = (IButtonControl) this.Button1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.Button2;
      this.ClientSize = new Size(394, 98);
      this.Controls.Add((Control) this.txt);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.Button1);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmFind";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Find";
      this.FormClosing += new FormClosingEventHandler(this.frmFind_FormClosing);
      this.Load += new EventHandler(this.frmFind_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public void MySub(Form1 frm)
    {
      this.f = frm;
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      this.f.IsDirectionDownward = this.rdoDown.Checked;
      this.f.FindText = this.txt.Text;
      this.f.Find((object) null, (EventArgs) null);
    }

    private void txt_TextChanged(object sender, EventArgs e)
    {
      this.Button1.Enabled = this.txt.Text.Length > 0;
    }

    private void frmFind_Load(object sender, EventArgs e)
    {
      frmFind.formOpened = true;
      this.txt.Focus();
      this.txt.Select();
    }

    private void frmFind_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmFind.formOpened = false;
    }
  }
}
