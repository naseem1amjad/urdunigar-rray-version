// Decompiled with JetBrains decompiler
// Type: Urdu_Nigar_Unicode.frmArguments
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Urdu_Nigar_Unicode
{
  public class frmArguments : Form
  {
    private IContainer components;
    private Button button1;
    private Button button2;
    private Label label1;
    private Label label2;
    public TextBox txtarguments;
    public TextBox txtcommandline;
    private frmOptions f;

    public frmArguments()
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
      this.button1 = new Button();
      this.button2 = new Button();
      this.txtarguments = new TextBox();
      this.txtcommandline = new TextBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.SuspendLayout();
      this.button1.FlatStyle = FlatStyle.System;
      this.button1.Location = new Point(184, 64);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "OK";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.DialogResult = DialogResult.Cancel;
      this.button2.FlatStyle = FlatStyle.System;
      this.button2.Location = new Point(264, 64);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "Cancel";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.txtarguments.Location = new Point(88, 8);
      this.txtarguments.Name = "txtarguments";
      this.txtarguments.Size = new Size(248, 21);
      this.txtarguments.TabIndex = 2;
      this.txtcommandline.Location = new Point(88, 32);
      this.txtcommandline.Name = "txtcommandline";
      this.txtcommandline.ReadOnly = true;
      this.txtcommandline.Size = new Size(248, 21);
      this.txtcommandline.TabIndex = 3;
      this.label1.AutoSize = true;
      this.label1.FlatStyle = FlatStyle.System;
      this.label1.Location = new Point(8, 8);
      this.label1.Name = "label1";
      this.label1.Size = new Size(63, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Arguments:";
      this.label2.AutoSize = true;
      this.label2.FlatStyle = FlatStyle.System;
      this.label2.Location = new Point(8, 32);
      this.label2.Name = "label2";
      this.label2.Size = new Size(80, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Command Line:";
      this.AcceptButton = (IButtonControl) this.button1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.button2;
      this.ClientSize = new Size(346, 95);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.txtcommandline);
      this.Controls.Add((Control) this.txtarguments);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmArguments";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public void MySub(frmOptions frm)
    {
      this.f = frm;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
