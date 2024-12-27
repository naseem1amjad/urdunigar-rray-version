// Decompiled with JetBrains decompiler
// Type: Urdu_Nigar_Unicode.frmReplace
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Urdu_Nigar_Unicode
{
  public class frmReplace : Form
  {
    public static bool formOpened;
    private Form1 f;
    private IContainer components;
    private GroupBox groupBox1;
    private RadioButton rdoDown;
    private RadioButton rdoUp;
    private Label Label1;
    private Button Button2;
    private TextBox txt;
    private Button Button1;
    private Button button3;
    private TextBox txt2;
    private Label label2;
    private Button button4;

    public frmReplace()
    {
      this.InitializeComponent();
    }

    public void MySub(Form1 frm)
    {
      this.f = frm;
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void txt_TextChanged(object sender, EventArgs e)
    {
      this.Button1.Enabled = this.txt.Text.Length > 0;
      this.button3.Enabled = this.txt.Text.Length > 0;
      this.button4.Enabled = this.txt.Text.Length > 0;
    }

    private string ReplaceString(string StrSource, string StrFind, string StrReplace)
    {
      int length = StrSource.IndexOf(StrFind);
      string str = "";
      for (; length != -1; length = StrSource.IndexOf(StrFind))
      {
        str = str + StrSource.Substring(0, length) + StrReplace;
        StrSource = StrSource.Substring(length + StrFind.Length);
      }
      if (StrSource.Length > 0)
        str += StrSource;
      return str;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      this.f.IsDirectionDownward2 = this.rdoDown.Checked;
      this.f.ReplaceText = this.txt.Text;
      this.f.FindReplace((object) null, (EventArgs) null);
      if (this.f.txtbox[this.f.tabControl1.SelectedTab.ImageIndex].SelectionLength <= 0)
        return;
      this.f.txtbox[this.f.tabControl1.SelectedTab.ImageIndex].SelectedText = this.txt2.Text;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.f.txtbox[this.f.tabControl1.SelectedTab.ImageIndex].Text = this.ReplaceString(this.f.txtbox[this.f.tabControl1.SelectedTab.ImageIndex].Text, this.txt.Text, this.txt2.Text);
    }

    private void frmReplace_Load(object sender, EventArgs e)
    {
      frmReplace.formOpened = true;
    }

    private void frmReplace_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmReplace.formOpened = false;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.f.IsDirectionDownward = this.rdoDown.Checked;
      this.f.FindText = this.txt.Text;
      this.f.Find((object) null, (EventArgs) null);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.groupBox1 = new GroupBox();
      this.rdoDown = new RadioButton();
      this.rdoUp = new RadioButton();
      this.Label1 = new Label();
      this.Button2 = new Button();
      this.txt = new TextBox();
      this.Button1 = new Button();
      this.button3 = new Button();
      this.txt2 = new TextBox();
      this.label2 = new Label();
      this.button4 = new Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.rdoDown);
      this.groupBox1.Controls.Add((Control) this.rdoUp);
      this.groupBox1.FlatStyle = FlatStyle.System;
      this.groupBox1.Location = new Point(200, 64);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(104, 56);
      this.groupBox1.TabIndex = 29;
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
      this.Label1.AutoSize = true;
      this.Label1.FlatStyle = FlatStyle.System;
      this.Label1.Location = new Point(7, 9);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(58, 13);
      this.Label1.TabIndex = 27;
      this.Label1.Text = "Find what:";
      this.Label1.TextAlign = ContentAlignment.MiddleLeft;
      this.Button2.DialogResult = DialogResult.Cancel;
      this.Button2.FlatStyle = FlatStyle.System;
      this.Button2.Location = new Point(312, 104);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(75, 23);
      this.Button2.TabIndex = 26;
      this.Button2.Text = "Cancel";
      this.Button2.UseVisualStyleBackColor = true;
      this.Button2.Click += new EventHandler(this.Button2_Click);
      this.txt.Location = new Point(80, 8);
      this.txt.Name = "txt";
      this.txt.Size = new Size(223, 21);
      this.txt.TabIndex = 24;
      this.txt.TextChanged += new EventHandler(this.txt_TextChanged);
      this.Button1.Enabled = false;
      this.Button1.FlatStyle = FlatStyle.System;
      this.Button1.Location = new Point(312, 40);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(75, 23);
      this.Button1.TabIndex = 25;
      this.Button1.Text = "Replace";
      this.Button1.UseVisualStyleBackColor = true;
      this.Button1.Click += new EventHandler(this.Button1_Click);
      this.button3.Enabled = false;
      this.button3.FlatStyle = FlatStyle.System;
      this.button3.Location = new Point(312, 72);
      this.button3.Name = "button3";
      this.button3.Size = new Size(75, 23);
      this.button3.TabIndex = 30;
      this.button3.Text = "Replace All";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.txt2.Location = new Point(80, 40);
      this.txt2.Name = "txt2";
      this.txt2.Size = new Size(224, 21);
      this.txt2.TabIndex = 31;
      this.label2.AutoSize = true;
      this.label2.FlatStyle = FlatStyle.System;
      this.label2.Location = new Point(7, 40);
      this.label2.Name = "label2";
      this.label2.Size = new Size(72, 13);
      this.label2.TabIndex = 32;
      this.label2.Text = "Replace with:";
      this.button4.Enabled = false;
      this.button4.FlatStyle = FlatStyle.System;
      this.button4.Location = new Point(312, 8);
      this.button4.Name = "button4";
      this.button4.Size = new Size(75, 23);
      this.button4.TabIndex = 33;
      this.button4.Text = "Find Next";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.AcceptButton = (IButtonControl) this.button4;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.Button2;
      this.ClientSize = new Size(394, 135);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.txt2);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.txt);
      this.Controls.Add((Control) this.Button1);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmReplace";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Replace";
      this.FormClosing += new FormClosingEventHandler(this.frmReplace_FormClosing);
      this.Load += new EventHandler(this.frmReplace_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
