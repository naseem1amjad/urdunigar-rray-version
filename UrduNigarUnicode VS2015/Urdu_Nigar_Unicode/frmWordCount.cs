// Decompiled with JetBrains decompiler
// Type: Urdu_Nigar_Unicode.frmWordCount
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Urdu_Nigar_Unicode
{
  public class frmWordCount : Form
  {
    public static bool formOpened;
    private Form1 f;
    private IContainer components;
    private Button button1;
    private Button button2;
    private Label label5;
    private ComboBox cbocountwhere;
    private ListView lst;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader5;

    public frmWordCount()
    {
      this.InitializeComponent();
    }

    public void MySub(Form1 frm)
    {
      this.f = frm;
    }

    public static int GetWords(string s)
    {
      return s.Split(new char[3]
      {
        ' ',
        '\r',
        '\n'
      }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public static int GetCharsNoSpaces(string s)
    {
      string[] strArray = s.Split(new char[3]
      {
        ' ',
        '\r',
        '\n'
      }, StringSplitOptions.RemoveEmptyEntries);
      int num = 0;
      foreach (string str in strArray)
        num += str.Length;
      return num;
    }

    public static int GetCharsWithSpaces(string s)
    {
      string[] strArray = s.Split(new char[2]
      {
        '\n',
        '\r'
      }, StringSplitOptions.RemoveEmptyEntries);
      int num = 0;
      foreach (string str in strArray)
        num += str.Length;
      return num;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (!this.f.tabControl1.Visible)
      {
        if (this.cbocountwhere.SelectedIndex == 0 || this.cbocountwhere.SelectedIndex == 1)
        {
          int num = (int) MessageBox.Show("There are currently no active documents.", "Error");
        }
        else
          this.LoadStuff();
      }
      else
        this.LoadStuff();
    }

    private void LoadStuff()
    {
      if (this.cbocountwhere.SelectedIndex == 0)
      {
        this.lst.Items.Clear();
        int num = 0;
        foreach (string str in this.f.txtbox[this.f.tabControl1.SelectedTab.ImageIndex].Lines)
          ++num;
        ListViewItem listViewItem = this.lst.Items.Add(this.f.tabControl1.SelectedTab.Text.Replace("*", ""));
        listViewItem.SubItems.Add(frmWordCount.GetWords(this.f.txtbox[this.f.tabControl1.SelectedTab.ImageIndex].Text).ToString());
        listViewItem.SubItems.Add(frmWordCount.GetCharsNoSpaces(this.f.txtbox[this.f.tabControl1.SelectedTab.ImageIndex].Text).ToString());
        listViewItem.SubItems.Add(frmWordCount.GetCharsWithSpaces(this.f.txtbox[this.f.tabControl1.SelectedTab.ImageIndex].Text).ToString());
        listViewItem.SubItems.Add(num.ToString());
      }
      else
      {
        if (this.cbocountwhere.SelectedIndex != 1)
          return;
        this.lst.Items.Clear();
        for (int index = 0; index < this.f.tabControl1.TabPages.Count; ++index)
        {
          int num = 0;
          foreach (string str in this.f.txtbox[this.f.tabControl1.TabPages[index].ImageIndex].Lines)
            ++num;
          ListViewItem listViewItem = this.lst.Items.Add(this.f.tabControl1.TabPages[index].Text.Replace("*", ""));
          listViewItem.SubItems.Add(frmWordCount.GetWords(this.f.txtbox[this.f.tabControl1.TabPages[index].ImageIndex].Text).ToString());
          listViewItem.SubItems.Add(frmWordCount.GetCharsNoSpaces(this.f.txtbox[this.f.tabControl1.TabPages[index].ImageIndex].Text).ToString());
          listViewItem.SubItems.Add(frmWordCount.GetCharsWithSpaces(this.f.txtbox[this.f.tabControl1.TabPages[index].ImageIndex].Text).ToString());
          listViewItem.SubItems.Add(num.ToString());
        }
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        for (int index = 0; index < this.lst.Items.Count; ++index)
        {
          num1 += Convert.ToInt32(this.lst.Items[index].SubItems[1].Text);
          num2 += Convert.ToInt32(this.lst.Items[index].SubItems[2].Text);
          num3 += Convert.ToInt32(this.lst.Items[index].SubItems[3].Text);
          num4 += Convert.ToInt32(this.lst.Items[index].SubItems[4].Text);
        }
        this.lst.Items.Add("");
        ListViewItem listViewItem1 = this.lst.Items.Add("Total");
        listViewItem1.SubItems.Add(num1.ToString());
        listViewItem1.SubItems.Add(num2.ToString());
        listViewItem1.SubItems.Add(num3.ToString());
        listViewItem1.SubItems.Add(num4.ToString());
      }
    }

    private void frmWordCount_Load(object sender, EventArgs e)
    {
      frmWordCount.formOpened = true;
      this.cbocountwhere.SelectedIndex = 0;
    }

    private void frmWordCount_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmWordCount.formOpened = false;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void cbocountwhere_SelectedIndexChanged(object sender, EventArgs e)
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
      this.button1 = new Button();
      this.button2 = new Button();
      this.label5 = new Label();
      this.cbocountwhere = new ComboBox();
      this.lst = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.columnHeader5 = new ColumnHeader();
      this.SuspendLayout();
      this.button1.FlatStyle = FlatStyle.System;
      this.button1.Location = new Point(392, 248);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Start";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.DialogResult = DialogResult.Cancel;
      this.button2.FlatStyle = FlatStyle.System;
      this.button2.Location = new Point(312, 248);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "Close";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.label5.AutoSize = true;
      this.label5.FlatStyle = FlatStyle.System;
      this.label5.Location = new Point(8, 8);
      this.label5.Name = "label5";
      this.label5.Size = new Size(75, 13);
      this.label5.TabIndex = 3;
      this.label5.Text = "Count Where:";
      this.cbocountwhere.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbocountwhere.FormattingEnabled = true;
      this.cbocountwhere.Items.AddRange(new object[2]
      {
        (object) "Current File",
        (object) "All Opened Files"
      });
      this.cbocountwhere.Location = new Point(88, 7);
      this.cbocountwhere.Name = "cbocountwhere";
      this.cbocountwhere.Size = new Size(280, 21);
      this.cbocountwhere.TabIndex = 4;
      this.cbocountwhere.SelectedIndexChanged += new EventHandler(this.cbocountwhere_SelectedIndexChanged);
      this.lst.Columns.AddRange(new ColumnHeader[5]
      {
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader3,
        this.columnHeader4,
        this.columnHeader5
      });
      this.lst.GridLines = true;
      this.lst.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.lst.Location = new Point(8, 32);
      this.lst.MultiSelect = false;
      this.lst.Name = "lst";
      this.lst.Size = new Size(456, 208);
      this.lst.TabIndex = 5;
      this.lst.UseCompatibleStateImageBehavior = false;
      this.lst.View = View.Details;
      this.columnHeader1.Text = "File";
      this.columnHeader1.Width = 100;
      this.columnHeader2.Text = "Words";
      this.columnHeader3.Text = "Chars (no spaces)";
      this.columnHeader3.Width = 105;
      this.columnHeader4.Text = "Chars (with spaces)";
      this.columnHeader4.Width = 110;
      this.columnHeader5.Text = "Lines";
      this.AcceptButton = (IButtonControl) this.button1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.button2;
      this.ClientSize = new Size(473, 278);
      this.Controls.Add((Control) this.lst);
      this.Controls.Add((Control) this.cbocountwhere);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmWordCount";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Word Count";
      this.FormClosing += new FormClosingEventHandler(this.frmWordCount_FormClosing);
      this.Load += new EventHandler(this.frmWordCount_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
