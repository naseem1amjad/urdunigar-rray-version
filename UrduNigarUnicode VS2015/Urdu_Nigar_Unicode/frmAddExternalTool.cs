// Decompiled with JetBrains decompiler
// Type: Urdu_Nigar_Unicode.frmAddExternalTool
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Utils.Uri.Psp.Program3;

namespace Urdu_Nigar_Unicode
{
  public class frmAddExternalTool : Form
  {
    private IContainer components;
    private Button button1;
    private Label label1;
    private Label label2;
    private Button button2;
    private Button button3;
    public TextBox txttitle;
    public TextBox txtcommand;
    private Label label3;
    public TextBox txtarguments;
    private GroupBox groupBox1;
    public CheckBox ckpromptforarguments;
    private frmOptions f;

    public frmAddExternalTool()
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
      this.txttitle = new TextBox();
      this.txtcommand = new TextBox();
      this.button1 = new Button();
      this.label1 = new Label();
      this.label2 = new Label();
      this.button2 = new Button();
      this.button3 = new Button();
      this.txtarguments = new TextBox();
      this.label3 = new Label();
      this.groupBox1 = new GroupBox();
      this.ckpromptforarguments = new CheckBox();
      this.SuspendLayout();
      this.txttitle.Location = new Point(72, 8);
      this.txttitle.Name = "txttitle";
      this.txttitle.Size = new Size(232, 21);
      this.txttitle.TabIndex = 0;
      this.txttitle.TextChanged += new EventHandler(this.txttitle_TextChanged);
      this.txtcommand.Location = new Point(72, 32);
      this.txtcommand.Name = "txtcommand";
      this.txtcommand.Size = new Size(232, 21);
      this.txtcommand.TabIndex = 1;
      this.txtcommand.TextChanged += new EventHandler(this.txtcommand_TextChanged);
      this.button1.FlatStyle = FlatStyle.System;
      this.button1.Location = new Point(312, 32);
      this.button1.Name = "button1";
      this.button1.Size = new Size(27, 21);
      this.button1.TabIndex = 2;
      this.button1.Text = "...";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.label1.AutoSize = true;
      this.label1.FlatStyle = FlatStyle.System;
      this.label1.Location = new Point(8, 8);
      this.label1.Name = "label1";
      this.label1.Size = new Size(31, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Title:";
      this.label2.AutoSize = true;
      this.label2.FlatStyle = FlatStyle.System;
      this.label2.Location = new Point(8, 32);
      this.label2.Name = "label2";
      this.label2.Size = new Size(58, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Command:";
      this.button2.Enabled = false;
      this.button2.FlatStyle = FlatStyle.System;
      this.button2.Location = new Point(184, 126);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 5;
      this.button2.Text = "OK";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button3.DialogResult = DialogResult.Cancel;
      this.button3.FlatStyle = FlatStyle.System;
      this.button3.Location = new Point(264, 126);
      this.button3.Name = "button3";
      this.button3.Size = new Size(75, 23);
      this.button3.TabIndex = 6;
      this.button3.Text = "Cancel";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.txtarguments.Location = new Point(72, 56);
      this.txtarguments.Name = "txtarguments";
      this.txtarguments.Size = new Size(232, 21);
      this.txtarguments.TabIndex = 2;
      this.label3.AutoSize = true;
      this.label3.FlatStyle = FlatStyle.System;
      this.label3.Location = new Point(8, 56);
      this.label3.Name = "label3";
      this.label3.Size = new Size(63, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Arguments:";
      this.groupBox1.Location = new Point(8, 112);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(330, 8);
      this.groupBox1.TabIndex = 9;
      this.groupBox1.TabStop = false;
      this.ckpromptforarguments.AutoSize = true;
      this.ckpromptforarguments.FlatStyle = FlatStyle.System;
      this.ckpromptforarguments.Location = new Point(72, 88);
      this.ckpromptforarguments.Name = "ckpromptforarguments";
      this.ckpromptforarguments.Size = new Size(137, 18);
      this.ckpromptforarguments.TabIndex = 10;
      this.ckpromptforarguments.Text = "Prompt for arguments";
      this.ckpromptforarguments.UseVisualStyleBackColor = true;
      this.AcceptButton = (IButtonControl) this.button2;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.button3;
      this.ClientSize = new Size(345, 156);
      this.Controls.Add((Control) this.ckpromptforarguments);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.txtarguments);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.txtcommand);
      this.Controls.Add((Control) this.txttitle);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmAddExternalTool";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Add External Tool";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public void MySub(frmOptions frm)
    {
      this.f = frm;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Programs (*.exe)|*.exe|All Files (*.*)|*.*";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.txtcommand.Text = openFileDialog.FileName;
    }

    private void txttitle_TextChanged(object sender, EventArgs e)
    {
      this.button2.Enabled = this.txttitle.Text.Trim().Length > 0 && File.Exists(this.txtcommand.Text);
    }

    private void txtcommand_TextChanged(object sender, EventArgs e)
    {
      this.button2.Enabled = this.txttitle.Text.Trim().Length > 0 && File.Exists(this.txtcommand.Text);
    }

    private bool ToolExists(string str)
    {
      foreach (ListViewItem listViewItem in this.f.lstexternaltools.Items)
      {
        if (listViewItem.SubItems[0].Text.ToLower() == str.ToLower())
          return true;
      }
      return false;
    }

    private bool ToolExists2(string newname)
    {
      foreach (ListViewItem listViewItem in this.f.lstexternaltools.Items)
      {
        if (!(newname.ToLower() != this.f.lstexternaltools.FocusedItem.Text.ToString()))
          return false;
        if (newname.ToLower() == listViewItem.Text.ToLower() && listViewItem.Text.ToLower() != this.f.lstexternaltools.FocusedItem.Text.ToLower())
          return true;
      }
      return false;
    }

    private void SaveTools()
    {
      string keyValue = (string) null;
      for (int index = 0; index < this.f.lstexternaltools.Items.Count; ++index)
        keyValue = keyValue + this.f.lstexternaltools.Items[index].Text + "==" + this.f.lstexternaltools.Items[index].Tag.ToString() + "<>";
      DirectIniFile.WriteProfileValue(Form1.strINI, "Tools", "External Tools", keyValue);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (this.Text == "Add External Tool")
      {
        if (!this.ToolExists(this.txttitle.Text))
        {
          this.f.lstexternaltools.Items.Add(this.txttitle.Text).Tag = (object) (this.txtcommand.Text + ";" + this.txtarguments.Text + ";" + this.ckpromptforarguments.Checked.ToString());
          this.f.btnApply.Enabled = true;
          this.Close();
        }
        else
        {
          int num1 = (int) MessageBox.Show("An external tool with this name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
      else if (this.ToolExists2(this.txttitle.Text))
      {
        int num2 = (int) MessageBox.Show("An external tool with this name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        this.f.lstexternaltools.FocusedItem.Text = this.txttitle.Text;
        this.f.lstexternaltools.FocusedItem.Tag = (object) (this.txtcommand.Text + ";" + this.txtarguments.Text + ";" + this.ckpromptforarguments.Checked.ToString());
        this.f.btnApply.Enabled = true;
        this.Close();
      }
    }
  }
}
