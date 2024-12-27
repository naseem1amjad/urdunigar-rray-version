// Decompiled with JetBrains decompiler
// Type: Urdu_Nigar_Unicode.frmProperties
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

using DetailFileInfo;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Urdu_Nigar_Unicode
{
  public class frmProperties : Form
  {
    private IContainer components;
    private Button button2;
    internal TabPage TabPage1;
    private CheckBox ckReadonly;
    private Label label8;
    private GroupBox groupBox2;
    internal GroupBox GroupBox1;
    private Label Label6;
    private Label Label5;
    private Label Label4;
    private Label lblsize;
    private Label Label3;
    private TextBox txtlocation;
    private Label Label2;
    private Label lbltypeoffile;
    private Label Label1;
    private Label lblfile;
    private TabControl TabControl1;
    private CheckBox ckHidden;
    private Label lblaccessed;
    private Label lblmodified;
    private Label lblcreated;
    private CheckBox ckSystem;
    private CheckBox ckArchive;
    private ListView lst;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private Label label7;
    private GroupBox groupBox3;
    private Form1 f;

    public frmProperties()
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
      this.button2 = new Button();
      this.TabPage1 = new TabPage();
      this.lst = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.label7 = new Label();
      this.groupBox3 = new GroupBox();
      this.ckSystem = new CheckBox();
      this.ckArchive = new CheckBox();
      this.ckHidden = new CheckBox();
      this.ckReadonly = new CheckBox();
      this.label8 = new Label();
      this.groupBox2 = new GroupBox();
      this.GroupBox1 = new GroupBox();
      this.lblaccessed = new Label();
      this.lblmodified = new Label();
      this.lblcreated = new Label();
      this.Label6 = new Label();
      this.Label5 = new Label();
      this.Label4 = new Label();
      this.lblsize = new Label();
      this.Label3 = new Label();
      this.txtlocation = new TextBox();
      this.Label2 = new Label();
      this.lbltypeoffile = new Label();
      this.Label1 = new Label();
      this.lblfile = new Label();
      this.TabControl1 = new TabControl();
      this.TabPage1.SuspendLayout();
      this.TabControl1.SuspendLayout();
      this.SuspendLayout();
      this.button2.FlatStyle = FlatStyle.System;
      this.button2.Location = new Point(291, 427);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 4;
      this.button2.Text = "OK";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.TabPage1.Controls.Add((Control) this.lst);
      this.TabPage1.Controls.Add((Control) this.label7);
      this.TabPage1.Controls.Add((Control) this.groupBox3);
      this.TabPage1.Controls.Add((Control) this.ckSystem);
      this.TabPage1.Controls.Add((Control) this.ckArchive);
      this.TabPage1.Controls.Add((Control) this.ckHidden);
      this.TabPage1.Controls.Add((Control) this.ckReadonly);
      this.TabPage1.Controls.Add((Control) this.label8);
      this.TabPage1.Controls.Add((Control) this.groupBox2);
      this.TabPage1.Controls.Add((Control) this.GroupBox1);
      this.TabPage1.Controls.Add((Control) this.lblaccessed);
      this.TabPage1.Controls.Add((Control) this.lblmodified);
      this.TabPage1.Controls.Add((Control) this.lblcreated);
      this.TabPage1.Controls.Add((Control) this.Label6);
      this.TabPage1.Controls.Add((Control) this.Label5);
      this.TabPage1.Controls.Add((Control) this.Label4);
      this.TabPage1.Controls.Add((Control) this.lblsize);
      this.TabPage1.Controls.Add((Control) this.Label3);
      this.TabPage1.Controls.Add((Control) this.txtlocation);
      this.TabPage1.Controls.Add((Control) this.Label2);
      this.TabPage1.Controls.Add((Control) this.lbltypeoffile);
      this.TabPage1.Controls.Add((Control) this.Label1);
      this.TabPage1.Controls.Add((Control) this.lblfile);
      this.TabPage1.Location = new Point(4, 22);
      this.TabPage1.Name = "TabPage1";
      this.TabPage1.Padding = new Padding(3);
      this.TabPage1.Size = new Size(352, 390);
      this.TabPage1.TabIndex = 0;
      this.TabPage1.Text = "General";
      this.TabPage1.UseVisualStyleBackColor = true;
      this.lst.Columns.AddRange(new ColumnHeader[4]
      {
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader3,
        this.columnHeader4
      });
      this.lst.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.lst.Location = new Point(8, 320);
      this.lst.MultiSelect = false;
      this.lst.Name = "lst";
      this.lst.Size = new Size(336, 57);
      this.lst.TabIndex = 23;
      this.lst.UseCompatibleStateImageBehavior = false;
      this.lst.View = View.Details;
      this.columnHeader1.Text = "Words";
      this.columnHeader1.Width = 46;
      this.columnHeader2.Text = "Chars (no spaces)";
      this.columnHeader2.Width = 111;
      this.columnHeader3.Text = "Chars (with spaces)";
      this.columnHeader3.Width = 113;
      this.columnHeader4.Text = "Lines";
      this.columnHeader4.Width = 59;
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label7.Location = new Point(8, 304);
      this.label7.Name = "label7";
      this.label7.Size = new Size(105, 13);
      this.label7.TabIndex = 22;
      this.label7.Text = "Document Statistics:";
      this.groupBox3.Location = new Point(8, 288);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(336, 8);
      this.groupBox3.TabIndex = 21;
      this.groupBox3.TabStop = false;
      this.ckSystem.AutoSize = true;
      this.ckSystem.Enabled = false;
      this.ckSystem.FlatStyle = FlatStyle.System;
      this.ckSystem.Location = new Point(168, 264);
      this.ckSystem.Name = "ckSystem";
      this.ckSystem.Size = new Size(67, 18);
      this.ckSystem.TabIndex = 20;
      this.ckSystem.Text = "System";
      this.ckSystem.UseVisualStyleBackColor = true;
      this.ckArchive.AutoSize = true;
      this.ckArchive.Enabled = false;
      this.ckArchive.FlatStyle = FlatStyle.System;
      this.ckArchive.Location = new Point(83, 264);
      this.ckArchive.Name = "ckArchive";
      this.ckArchive.Size = new Size(68, 18);
      this.ckArchive.TabIndex = 19;
      this.ckArchive.Text = "Archive";
      this.ckArchive.UseVisualStyleBackColor = true;
      this.ckHidden.AutoSize = true;
      this.ckHidden.Enabled = false;
      this.ckHidden.FlatStyle = FlatStyle.System;
      this.ckHidden.Location = new Point(168, 240);
      this.ckHidden.Name = "ckHidden";
      this.ckHidden.Size = new Size(65, 18);
      this.ckHidden.TabIndex = 18;
      this.ckHidden.Text = "Hidden";
      this.ckHidden.UseVisualStyleBackColor = true;
      this.ckReadonly.AutoSize = true;
      this.ckReadonly.Enabled = false;
      this.ckReadonly.FlatStyle = FlatStyle.System;
      this.ckReadonly.Location = new Point(83, 240);
      this.ckReadonly.Name = "ckReadonly";
      this.ckReadonly.Size = new Size(81, 18);
      this.ckReadonly.TabIndex = 17;
      this.ckReadonly.Text = "Read-only";
      this.ckReadonly.UseVisualStyleBackColor = true;
      this.label8.AutoSize = true;
      this.label8.BackColor = Color.Transparent;
      this.label8.Location = new Point(8, 240);
      this.label8.Name = "label8";
      this.label8.Size = new Size(59, 13);
      this.label8.TabIndex = 16;
      this.label8.Text = "Attributes:";
      this.label8.TextAlign = ContentAlignment.MiddleLeft;
      this.groupBox2.Location = new Point(8, 216);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(336, 8);
      this.groupBox2.TabIndex = 15;
      this.groupBox2.TabStop = false;
      this.GroupBox1.Location = new Point(8, 120);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(336, 8);
      this.GroupBox1.TabIndex = 14;
      this.GroupBox1.TabStop = false;
      this.lblaccessed.BackColor = Color.Transparent;
      this.lblaccessed.Location = new Point(80, 192);
      this.lblaccessed.Name = "lblaccessed";
      this.lblaccessed.Size = new Size(248, 13);
      this.lblaccessed.TabIndex = 12;
      this.lblaccessed.TextAlign = ContentAlignment.MiddleLeft;
      this.lblmodified.BackColor = Color.Transparent;
      this.lblmodified.Location = new Point(80, 168);
      this.lblmodified.Name = "lblmodified";
      this.lblmodified.Size = new Size(248, 13);
      this.lblmodified.TabIndex = 11;
      this.lblmodified.TextAlign = ContentAlignment.MiddleLeft;
      this.lblcreated.BackColor = Color.Transparent;
      this.lblcreated.Location = new Point(80, 144);
      this.lblcreated.Name = "lblcreated";
      this.lblcreated.Size = new Size(248, 13);
      this.lblcreated.TabIndex = 10;
      this.lblcreated.TextAlign = ContentAlignment.MiddleLeft;
      this.Label6.AutoSize = true;
      this.Label6.BackColor = Color.Transparent;
      this.Label6.Location = new Point(8, 192);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(56, 13);
      this.Label6.TabIndex = 9;
      this.Label6.Text = "Accessed:";
      this.Label6.TextAlign = ContentAlignment.MiddleLeft;
      this.Label5.AutoSize = true;
      this.Label5.BackColor = Color.Transparent;
      this.Label5.Location = new Point(8, 168);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(51, 13);
      this.Label5.TabIndex = 8;
      this.Label5.Text = "Modified:";
      this.Label5.TextAlign = ContentAlignment.MiddleLeft;
      this.Label4.AutoSize = true;
      this.Label4.BackColor = Color.Transparent;
      this.Label4.Location = new Point(8, 144);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(50, 13);
      this.Label4.TabIndex = 7;
      this.Label4.Text = "Created:";
      this.Label4.TextAlign = ContentAlignment.MiddleLeft;
      this.lblsize.BackColor = Color.Transparent;
      this.lblsize.Location = new Point(80, 96);
      this.lblsize.Name = "lblsize";
      this.lblsize.Size = new Size(240, 13);
      this.lblsize.TabIndex = 6;
      this.lblsize.TextAlign = ContentAlignment.MiddleLeft;
      this.Label3.AutoSize = true;
      this.Label3.BackColor = Color.Transparent;
      this.Label3.Location = new Point(8, 96);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(30, 13);
      this.Label3.TabIndex = 5;
      this.Label3.Text = "Size:";
      this.Label3.TextAlign = ContentAlignment.MiddleLeft;
      this.txtlocation.BackColor = SystemColors.Window;
      this.txtlocation.BorderStyle = BorderStyle.None;
      this.txtlocation.Location = new Point(83, 72);
      this.txtlocation.Name = "txtlocation";
      this.txtlocation.ReadOnly = true;
      this.txtlocation.Size = new Size(256, 14);
      this.txtlocation.TabIndex = 4;
      this.Label2.AutoSize = true;
      this.Label2.BackColor = Color.Transparent;
      this.Label2.Location = new Point(8, 72);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(51, 13);
      this.Label2.TabIndex = 3;
      this.Label2.Text = "Location:";
      this.Label2.TextAlign = ContentAlignment.MiddleLeft;
      this.lbltypeoffile.BackColor = Color.Transparent;
      this.lbltypeoffile.Location = new Point(80, 48);
      this.lbltypeoffile.Name = "lbltypeoffile";
      this.lbltypeoffile.Size = new Size(248, 13);
      this.lbltypeoffile.TabIndex = 2;
      this.lbltypeoffile.TextAlign = ContentAlignment.MiddleLeft;
      this.Label1.AutoSize = true;
      this.Label1.BackColor = Color.Transparent;
      this.Label1.Location = new Point(8, 48);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(65, 13);
      this.Label1.TabIndex = 1;
      this.Label1.Text = "Type of file:";
      this.Label1.TextAlign = ContentAlignment.MiddleLeft;
      this.lblfile.AutoSize = true;
      this.lblfile.BackColor = Color.Transparent;
      this.lblfile.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblfile.Location = new Point(8, 8);
      this.lblfile.Name = "lblfile";
      this.lblfile.Size = new Size(28, 16);
      this.lblfile.TabIndex = 0;
      this.lblfile.Text = "File";
      this.lblfile.TextAlign = ContentAlignment.MiddleLeft;
      this.TabControl1.Controls.Add((Control) this.TabPage1);
      this.TabControl1.Location = new Point(6, 6);
      this.TabControl1.Name = "TabControl1";
      this.TabControl1.SelectedIndex = 0;
      this.TabControl1.Size = new Size(360, 416);
      this.TabControl1.TabIndex = 2;
      this.AcceptButton = (IButtonControl) this.button2;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.button2;
      this.ClientSize = new Size(371, 457);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.TabControl1);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmProperties";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Properties";
      this.Load += new EventHandler(this.frmProperties_Load);
      this.TabPage1.ResumeLayout(false);
      this.TabPage1.PerformLayout();
      this.TabControl1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public void MySub(Form1 frm)
    {
      this.f = frm;
    }

    public void SetProperties(string str)
    {
      if (File.Exists(str))
      {
        CFileInfo cfileInfo = new CFileInfo(str);
        this.lblfile.Text = Path.GetFileNameWithoutExtension(str);
        this.lbltypeoffile.Text = cfileInfo.FileType;
        this.lblsize.Text = string.Concat(new object[4]
        {
          (object) clsInformation.FormatBytes((double) cfileInfo.FileSize),
          (object) " (",
          (object) cfileInfo.FileSize,
          (object) " bytes)"
        });
        this.txtlocation.Text = cfileInfo.FilePath;
        this.lblcreated.Text = cfileInfo.FileCreationDate.ToLongDateString() + ", " + cfileInfo.FileCreationDate.ToLongTimeString();
        this.lblmodified.Text = cfileInfo.FileModificationDate.ToLongDateString() + ", " + cfileInfo.FileModificationDate.ToLongTimeString();
        this.lblaccessed.Text = cfileInfo.FileAccessedDate.ToLongDateString() + ", " + cfileInfo.FileAccessedDate.ToLongTimeString();
        this.ckReadonly.Checked = frmProperties.IsReadOnly(str);
        this.ckHidden.Checked = frmProperties.IsHidden(str);
        this.ckArchive.Checked = this.IsArchive(str);
        this.ckSystem.Checked = this.IsSystem(str);
      }
      else
        this.lblfile.Text = "None";
      this.Text = Path.GetFileNameWithoutExtension(str) + " Properties";
      this.lblfile.Text = Path.GetFileNameWithoutExtension(str);
      int num = 0;
      foreach (string str1 in this.f.txtbox[this.f.tabControl1.SelectedTab.ImageIndex].Lines)
        ++num;
      ListViewItem listViewItem = this.lst.Items.Add(frmWordCount.GetWords(this.f.txtbox[this.f.tabControl1.SelectedTab.ImageIndex].Text).ToString());
      listViewItem.SubItems.Add(frmWordCount.GetCharsNoSpaces(this.f.txtbox[this.f.tabControl1.SelectedTab.ImageIndex].Text).ToString());
      listViewItem.SubItems.Add(frmWordCount.GetCharsWithSpaces(this.f.txtbox[this.f.tabControl1.SelectedTab.ImageIndex].Text).ToString());
      listViewItem.SubItems.Add(num.ToString());
    }

    public static bool IsReadOnly(string File)
    {
            //return (File.GetAttributes(File) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly;
            return false;
    }

    public static bool IsHidden(string File)
    {
            //return (File.GetAttributes(File) & FileAttributes.Hidden) == FileAttributes.Hidden;
            return false;
        }

    private bool IsArchive(string File)
    {
            //return (File.GetAttributes(File) & FileAttributes.Archive) == FileAttributes.Archive;
            return false;
        }

    private bool IsSystem(string File)
    {
            //return (File.GetAttributes(File) & FileAttributes.System) == FileAttributes.System;
            return false;
        }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void frmProperties_Load(object sender, EventArgs e)
    {
    }
  }
}
