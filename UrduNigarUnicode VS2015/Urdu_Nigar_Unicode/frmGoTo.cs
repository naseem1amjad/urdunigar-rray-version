// Decompiled with JetBrains decompiler
// Type: Urdu_Nigar_Unicode.frmGoTo
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Urdu_Nigar_Unicode
{
  public class frmGoTo : Form
  {
    private IContainer components;
    private Label Label1;
    private Button Button2;
    private Button Button1;
    private TextBox txt;
    private Form1 f;
    public static bool formOpened;

    public frmGoTo()
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
      this.txt = new TextBox();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      this.Label1.FlatStyle = FlatStyle.System;
      this.Label1.Location = new Point(8, 8);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(69, 13);
      this.Label1.TabIndex = 8;
      this.Label1.Text = "Line number:";
      this.Label1.TextAlign = ContentAlignment.MiddleLeft;
      this.Button2.DialogResult = DialogResult.Cancel;
      this.Button2.FlatStyle = FlatStyle.System;
      this.Button2.Location = new Point(166, 56);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(75, 23);
      this.Button2.TabIndex = 7;
      this.Button2.Text = "Cancel";
      this.Button2.UseVisualStyleBackColor = true;
      this.Button2.Click += new EventHandler(this.Button2_Click);
      this.Button1.Enabled = false;
      this.Button1.FlatStyle = FlatStyle.System;
      this.Button1.Location = new Point(86, 56);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(75, 23);
      this.Button1.TabIndex = 6;
      this.Button1.Text = "OK";
      this.Button1.UseVisualStyleBackColor = true;
      this.Button1.Click += new EventHandler(this.Button1_Click);
      this.txt.Location = new Point(8, 24);
      this.txt.Name = "txt";
      this.txt.Size = new Size(232, 21);
      this.txt.TabIndex = 5;
      this.txt.TextChanged += new EventHandler(this.txt_TextChanged);
      this.AcceptButton = (IButtonControl) this.Button1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.Button2;
      this.ClientSize = new Size(249, 87);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.txt);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmGoTo";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Go To Line";
      this.FormClosing += new FormClosingEventHandler(this.frmGoTo_FormClosing);
      this.Load += new EventHandler(this.frmGoTo_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public void MySub(Form1 frm)
    {
      this.f = frm;
    }

    public static bool isNumeric(string str)
    {
      if (str.Trim() == "")
        return false;
      char[] chArray = str.ToCharArray();
      for (int index = 0; index < chArray.Length; ++index)
      {
        if ((int) chArray[index] > 57 || (int) chArray[index] < 48)
          return false;
      }
      return true;
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void txt_TextChanged(object sender, EventArgs e)
    {
      this.Button1.Enabled = frmGoTo.isNumeric(this.txt.Text);
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      Convert.ToInt32(this.txt.Text);
      int num1 = Convert.ToInt32(this.txt.Text);
      int num2 = 0;
      int num3 = 1;
      foreach (string str in this.f.txtbox[this.f.tabControl1.SelectedTab.ImageIndex].Lines)
      {
        if (num3 != num1)
        {
          num2 += str.Length;
          ++num3;
        }
        else
          break;
      }
      this.f.txtbox[this.f.tabControl1.SelectedTab.ImageIndex].SelectionStart = Convert.ToInt32(num2 + num1 - 1);
      this.f.txtbox[this.f.tabControl1.SelectedTab.ImageIndex].Focus();
      this.Close();
    }

    private void frmGoTo_Load(object sender, EventArgs e)
    {
      frmGoTo.formOpened = true;
    }

    private void frmGoTo_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmGoTo.formOpened = false;
    }
  }
}
