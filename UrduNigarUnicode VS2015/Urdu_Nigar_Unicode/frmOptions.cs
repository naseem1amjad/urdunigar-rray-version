// Decompiled with JetBrains decompiler
// Type: Urdu_Nigar_Unicode.frmOptions
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Utils.Uri.Psp.Program3;

namespace Urdu_Nigar_Unicode
{
  public class frmOptions : Form
  {
    private IContainer components;
    private Button btnOK;
    private Button btnCancel;
    public Button btnApply;
    private TabPage tabPage3;
    private GroupBox groupBox5;
    public ListView lstexternaltools;
    private ColumnHeader columnHeader1;
    private Button btnExternalToolModify;
    private Label label1;
    private Button btnDeleteExternalTool;
    private Button btnAddExternalTool;
    private TabPage tabPage2;
    private GroupBox groupBox3;
    private Label label7;
    private CheckBox ckclearundobufferwhensaving;
    private CheckBox ckautosave;
    private TextBox txtautosave;
    private TabPage tabPage1;
    private GroupBox groupBox1;
    private Label label3;
    private TextBox txtrecentfiles;
    private Button btnClearRecentFiles;
    private TabControl tabControl1;
    public Form1 f;

    public frmOptions()
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
      this.btnOK = new Button();
      this.btnCancel = new Button();
      this.btnApply = new Button();
      this.tabPage3 = new TabPage();
      this.groupBox5 = new GroupBox();
      this.lstexternaltools = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.btnExternalToolModify = new Button();
      this.label1 = new Label();
      this.btnDeleteExternalTool = new Button();
      this.btnAddExternalTool = new Button();
      this.tabPage2 = new TabPage();
      this.groupBox3 = new GroupBox();
      this.label7 = new Label();
      this.ckclearundobufferwhensaving = new CheckBox();
      this.ckautosave = new CheckBox();
      this.txtautosave = new TextBox();
      this.tabPage1 = new TabPage();
      this.groupBox1 = new GroupBox();
      this.label3 = new Label();
      this.txtrecentfiles = new TextBox();
      this.btnClearRecentFiles = new Button();
      this.tabControl1 = new TabControl();
      this.tabPage3.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.SuspendLayout();
      this.btnOK.FlatStyle = FlatStyle.System;
      this.btnOK.Location = new Point(150, 430);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new Size(75, 23);
      this.btnOK.TabIndex = 1;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new EventHandler(this.btnOK_Click);
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.FlatStyle = FlatStyle.System;
      this.btnCancel.Location = new Point(230, 430);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(75, 23);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.btnApply.FlatStyle = FlatStyle.System;
      this.btnApply.Location = new Point(310, 430);
      this.btnApply.Name = "btnApply";
      this.btnApply.Size = new Size(75, 23);
      this.btnApply.TabIndex = 3;
      this.btnApply.Text = "Apply";
      this.btnApply.UseVisualStyleBackColor = true;
      this.btnApply.Click += new EventHandler(this.btnApply_Click);
      this.tabPage3.Controls.Add((Control) this.groupBox5);
      this.tabPage3.Location = new Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new Padding(3);
      this.tabPage3.Size = new Size(368, 390);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "External Tools";
      this.tabPage3.UseVisualStyleBackColor = true;
      this.groupBox5.Controls.Add((Control) this.lstexternaltools);
      this.groupBox5.Controls.Add((Control) this.btnExternalToolModify);
      this.groupBox5.Controls.Add((Control) this.label1);
      this.groupBox5.Controls.Add((Control) this.btnDeleteExternalTool);
      this.groupBox5.Controls.Add((Control) this.btnAddExternalTool);
      this.groupBox5.Location = new Point(12, 10);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new Size(340, 166);
      this.groupBox5.TabIndex = 0;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "External Tools";
      this.lstexternaltools.Columns.AddRange(new ColumnHeader[1]
      {
        this.columnHeader1
      });
      this.lstexternaltools.HeaderStyle = ColumnHeaderStyle.None;
      this.lstexternaltools.Location = new Point(16, 40);
      this.lstexternaltools.Name = "lstexternaltools";
      this.lstexternaltools.Size = new Size(224, 112);
      this.lstexternaltools.TabIndex = 5;
      this.lstexternaltools.UseCompatibleStateImageBehavior = false;
      this.lstexternaltools.View = View.Details;
      this.lstexternaltools.DoubleClick += new EventHandler(this.lstexternaltools_DoubleClick);
      this.lstexternaltools.SelectedIndexChanged += new EventHandler(this.lstexternaltools_SelectedIndexChanged_1);
      this.columnHeader1.Width = 181;
      this.btnExternalToolModify.Enabled = false;
      this.btnExternalToolModify.FlatStyle = FlatStyle.System;
      this.btnExternalToolModify.Location = new Point(248, 72);
      this.btnExternalToolModify.Name = "btnExternalToolModify";
      this.btnExternalToolModify.Size = new Size(75, 23);
      this.btnExternalToolModify.TabIndex = 4;
      this.btnExternalToolModify.Text = "Modify";
      this.btnExternalToolModify.UseVisualStyleBackColor = true;
      this.btnExternalToolModify.Click += new EventHandler(this.btnExternalToolModify_Click);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(16, 24);
      this.label1.Name = "label1";
      this.label1.Size = new Size(82, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Menu contents:";
      this.btnDeleteExternalTool.Enabled = false;
      this.btnDeleteExternalTool.FlatStyle = FlatStyle.System;
      this.btnDeleteExternalTool.Location = new Point(248, 104);
      this.btnDeleteExternalTool.Name = "btnDeleteExternalTool";
      this.btnDeleteExternalTool.Size = new Size(75, 23);
      this.btnDeleteExternalTool.TabIndex = 1;
      this.btnDeleteExternalTool.Text = "Delete";
      this.btnDeleteExternalTool.UseVisualStyleBackColor = true;
      this.btnDeleteExternalTool.Click += new EventHandler(this.btnDeleteExternalTool_Click);
      this.btnAddExternalTool.Location = new Point(248, 40);
      this.btnAddExternalTool.Name = "btnAddExternalTool";
      this.btnAddExternalTool.Size = new Size(75, 23);
      this.btnAddExternalTool.TabIndex = 0;
      this.btnAddExternalTool.Text = "Add";
      this.btnAddExternalTool.UseVisualStyleBackColor = true;
      this.btnAddExternalTool.Click += new EventHandler(this.btnAddExternalTool_Click);
      this.tabPage2.Controls.Add((Control) this.groupBox3);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(368, 390);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Save";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.groupBox3.Controls.Add((Control) this.label7);
      this.groupBox3.Controls.Add((Control) this.ckclearundobufferwhensaving);
      this.groupBox3.Controls.Add((Control) this.ckautosave);
      this.groupBox3.Controls.Add((Control) this.txtautosave);
      this.groupBox3.Location = new Point(12, 10);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(340, 86);
      this.groupBox3.TabIndex = 1;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "General";
      this.label7.AutoSize = true;
      this.label7.Location = new Point(224, 27);
      this.label7.Name = "label7";
      this.label7.Size = new Size(44, 13);
      this.label7.TabIndex = 7;
      this.label7.Text = "minutes";
      this.label7.TextAlign = ContentAlignment.MiddleLeft;
      this.ckclearundobufferwhensaving.Location = new Point(16, 48);
      this.ckclearundobufferwhensaving.Name = "ckclearundobufferwhensaving";
      this.ckclearundobufferwhensaving.Size = new Size(180, 24);
      this.ckclearundobufferwhensaving.TabIndex = 4;
      this.ckclearundobufferwhensaving.Text = "Clear undo buffer when saving";
      this.ckclearundobufferwhensaving.UseVisualStyleBackColor = true;
      this.ckclearundobufferwhensaving.CheckedChanged += new EventHandler(this.ckclearundobufferwhensaving_CheckedChanged);
      this.ckautosave.Location = new Point(16, 24);
      this.ckautosave.Name = "ckautosave";
      this.ckautosave.Size = new Size(152, 18);
      this.ckautosave.TabIndex = 5;
      this.ckautosave.Text = "Automatically save every";
      this.ckautosave.UseVisualStyleBackColor = true;
      this.ckautosave.CheckedChanged += new EventHandler(this.ckautosave_CheckedChanged);
      this.txtautosave.Location = new Point(168, 24);
      this.txtautosave.Name = "txtautosave";
      this.txtautosave.Size = new Size(48, 21);
      this.txtautosave.TabIndex = 6;
      this.txtautosave.KeyPress += new KeyPressEventHandler(this.txtautosave_KeyPress);
      this.txtautosave.TextChanged += new EventHandler(this.txtautosave_TextChanged);
      this.tabPage1.Controls.Add((Control) this.groupBox1);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(368, 390);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "General";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.txtrecentfiles);
      this.groupBox1.Controls.Add((Control) this.btnClearRecentFiles);
      this.groupBox1.Location = new Point(12, 10);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(340, 72);
      this.groupBox1.TabIndex = 11;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Recent Files";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(16, 24);
      this.label3.Name = "label3";
      this.label3.Size = new Size(154, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Number of recent files to show";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.txtrecentfiles.Location = new Point(176, 22);
      this.txtrecentfiles.Name = "txtrecentfiles";
      this.txtrecentfiles.Size = new Size(48, 21);
      this.txtrecentfiles.TabIndex = 5;
      this.txtrecentfiles.KeyPress += new KeyPressEventHandler(this.txtrecentfiles_KeyPress);
      this.txtrecentfiles.TextChanged += new EventHandler(this.txtrecentfiles_TextChanged);
      this.btnClearRecentFiles.FlatStyle = FlatStyle.System;
      this.btnClearRecentFiles.Location = new Point(240, 22);
      this.btnClearRecentFiles.Name = "btnClearRecentFiles";
      this.btnClearRecentFiles.Size = new Size(75, 23);
      this.btnClearRecentFiles.TabIndex = 6;
      this.btnClearRecentFiles.Text = "Clear";
      this.btnClearRecentFiles.UseVisualStyleBackColor = true;
      this.btnClearRecentFiles.Click += new EventHandler(this.btnClearRecentFiles_Click);
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Controls.Add((Control) this.tabPage3);
      this.tabControl1.Location = new Point(8, 8);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(376, 416);
      this.tabControl1.TabIndex = 12;
      this.AcceptButton = (IButtonControl) this.btnOK;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(391, 461);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.btnApply);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnOK);
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmOptions";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Options";
      this.Load += new EventHandler(this.frmOptions_Load);
      this.tabPage3.ResumeLayout(false);
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.tabPage1.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public void MySub(Form1 frm)
    {
      this.f = frm;
    }

    private void LoadSettings()
    {
      this.txtrecentfiles.Text = DirectIniFile.ReadProfileValue(Form1.strINI, "Recent Files", "Items To Show", "10");
      this.btnClearRecentFiles.Enabled = DirectIniFile.ReadProfileValue(Form1.strINI, "Recent Files", "Items", "").Length > 0;
      this.ckclearundobufferwhensaving.Checked = Convert.ToBoolean(DirectIniFile.ReadProfileValue(Form1.strINI, "Editor", "Clear Undo", "False"));
      this.ckautosave.Checked = Convert.ToBoolean(DirectIniFile.ReadProfileValue(Form1.strINI, "Backup", "Enable Auto Save", "False"));
      this.txtautosave.Text = DirectIniFile.ReadProfileValue(Form1.strINI, "Backup", "Auto Save Interval", "5");
      this.txtautosave.Enabled = this.ckautosave.Checked;
      this.LoadExternalTools();
      this.btnApply.Enabled = false;
    }

    public static string[] Split(string searchString, string splitString)
    {
      string str = searchString;
      int num1 = 0;
      int index1 = 0;
      int startIndex = 0;
      int num2 = str.IndexOf(splitString, 0);
      int length;
      if (num2 == -1)
      {
        length = 1;
      }
      else
      {
        for (; num2 != -1 && num2 < str.Length; num2 = str.IndexOf(splitString, num2 + splitString.Length))
          ++num1;
        length = num1 + 1;
      }
      string[] strArray = new string[length];
      if (length == 1)
      {
        strArray[0] = str;
      }
      else
      {
        for (int index2 = str.IndexOf(splitString, 0); index2 != -1 && index2 < str.Length; index2 = str.IndexOf(splitString, startIndex))
        {
          strArray[index1] = str.Substring(startIndex, index2 - startIndex);
          startIndex = index2 + splitString.Length;
          ++index1;
          if (startIndex >= str.Length)
            break;
        }
        strArray[index1] = startIndex < str.Length ? str.Substring(startIndex, str.Length - startIndex) : "";
      }
      return strArray;
    }

    private void LoadExternalTools()
    {
      try
      {
        string searchString1 = DirectIniFile.ReadProfileValue(Form1.strINI, "Tools", "External Tools", "");
        if (!(searchString1 != ""))
          return;
        foreach (string searchString2 in frmOptions.Split(searchString1, "<>"))
        {
          string[] strArray = frmOptions.Split(searchString2, ";");
          if (strArray[0].Length > 0)
            this.lstexternaltools.Items.Add(strArray[0]).Tag = (object) (strArray[1] + ";" + strArray[2] + ";" + strArray[3]);
        }
      }
      catch
      {
      }
    }

    private void SaveExternalTools()
    {
      if (this.lstexternaltools.Items.Count == 0)
      {
        DirectIniFile.WriteProfileValue(Form1.strINI, "Tools", "External Tools", "");
      }
      else
      {
        string keyValue = (string) null;
        for (int index = 0; index < this.lstexternaltools.Items.Count; ++index)
          keyValue = keyValue + this.lstexternaltools.Items[index].Text + ";" + this.lstexternaltools.Items[index].Tag.ToString() + "<>";
        DirectIniFile.WriteProfileValue(Form1.strINI, "Tools", "External Tools", keyValue);
      }
    }

    private void SaveSettings()
    {
      DirectIniFile.WriteProfileValue(Form1.strINI, "Recent Files", "Items To Show", this.txtrecentfiles.Text);
      DirectIniFile.WriteProfileValue(Form1.strINI, "Editor", "Clear Undo", this.ckclearundobufferwhensaving.Checked.ToString());
      DirectIniFile.WriteProfileValue(Form1.strINI, "Backup", "Enable Auto Save", this.ckautosave.Checked.ToString());
      DirectIniFile.WriteProfileValue(Form1.strINI, "Backup", "Auto Save Interval", this.txtautosave.Text);
      if (this.ckautosave.Checked)
      {
        int num = Convert.ToInt32(this.txtautosave.Text) * 10000;
        if (this.f.autosave.Enabled)
        {
          if (this.f.autosave.Interval != num)
            this.f.autosave.Interval = num;
        }
        else
        {
          this.f.autosave.Interval = num;
          this.f.autosave.Enabled = true;
        }
        this.f.lblautosave.Text = "AutoSave: On";
      }
      else
      {
        if (this.f.autosave.Enabled)
          this.f.autosave.Enabled = false;
        this.f.lblautosave.Text = "";
      }
      this.SaveExternalTools();
    }

    private void ckautosave_CheckedChanged(object sender, EventArgs e)
    {
      this.txtautosave.Enabled = this.ckautosave.Checked;
      this.btnApply.Enabled = true;
    }

    private void frmOptions_Load(object sender, EventArgs e)
    {
      this.LoadSettings();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      int num1 = 0;
      string str = (string) null;
      if (!Form1.isNumeric(this.txtrecentfiles.Text))
      {
        ++num1;
        str += "Enter a numeric value for recent files item field.\n";
      }
      if (this.ckautosave.Checked && !Form1.isNumeric(this.txtautosave.Text))
      {
        ++num1;
        str += "Enter a numeric value for autosave interval.\n";
      }
      if (num1 > 0)
      {
        int num2 = (int) MessageBox.Show(string.Concat(new object[4]
        {
          (object) "Total of ",
          (object) num1,
          (object) " error(s) have occured.\nPlease fix them before proceeding:\n\n",
          (object) str
        }), "Error");
      }
      else
      {
        this.SaveSettings();
        this.Close();
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnClearRecentFiles_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Clear the recent files list?", Form1.strTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      DirectIniFile.WriteProfileValue(Form1.strINI, "Recent Files", "Items", "");
      this.btnClearRecentFiles.Enabled = false;
    }

    private void ckAlwaysopenfilesincurrenttab_CheckedChanged(object sender, EventArgs e)
    {
      this.btnApply.Enabled = true;
    }

    private void txtrecentfiles_TextChanged(object sender, EventArgs e)
    {
      this.btnApply.Enabled = true;
    }

    private void ckclearundobufferwhensaving_CheckedChanged(object sender, EventArgs e)
    {
      this.btnApply.Enabled = true;
    }

    private void txtautosave_TextChanged(object sender, EventArgs e)
    {
      this.btnApply.Enabled = true;
    }

    private void tabPage3_Click(object sender, EventArgs e)
    {
    }

    private void btnApply_Click(object sender, EventArgs e)
    {
      int num1 = 0;
      string str = (string) null;
      if (!Form1.isNumeric(this.txtrecentfiles.Text))
      {
        ++num1;
        str += "Enter a numeric value for recent files item field.\n";
      }
      if (this.ckautosave.Checked && !Form1.isNumeric(this.txtautosave.Text))
      {
        ++num1;
        str += "Enter a numeric value for autosave interval.\n";
      }
      if (num1 > 0)
      {
        int num2 = (int) MessageBox.Show(string.Concat(new object[4]
        {
          (object) "Total of ",
          (object) num1,
          (object) " error(s) have occured.\nPlease fix them before proceeding:\n\n",
          (object) str
        }), "Error");
      }
      else
      {
        this.SaveSettings();
        this.btnApply.Enabled = false;
      }
    }

    private void txtautosave_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsDigit(e.KeyChar) || (int) e.KeyChar == 8)
        return;
      e.Handled = true;
    }

    private void txtrecentfiles_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsDigit(e.KeyChar) || (int) e.KeyChar == 8)
        return;
      e.Handled = true;
    }

    private void ckwordwrap_CheckedChanged(object sender, EventArgs e)
    {
      this.btnApply.Enabled = true;
    }

    private void btnAddExternalTool_Click(object sender, EventArgs e)
    {
      frmAddExternalTool frmAddExternalTool = new frmAddExternalTool();
      frmAddExternalTool.MySub(this);
      int num = (int) frmAddExternalTool.ShowDialog();
    }

    private void lstexternaltools_SelectedIndexChanged_1(object sender, EventArgs e)
    {
      this.btnDeleteExternalTool.Enabled = this.lstexternaltools.SelectedItems.Count > 0;
      this.btnExternalToolModify.Enabled = this.lstexternaltools.SelectedItems.Count == 1;
    }

    private void btnExternalToolModify_Click(object sender, EventArgs e)
    {
      frmAddExternalTool frmAddExternalTool = new frmAddExternalTool();
      frmAddExternalTool.Text = "Edit External Tool";
      frmAddExternalTool.txttitle.Text = this.lstexternaltools.FocusedItem.Text;
      string[] strArray = frmOptions.Split(this.lstexternaltools.FocusedItem.Tag.ToString(), ";");
      frmAddExternalTool.txtcommand.Text = strArray[0];
      frmAddExternalTool.txtarguments.Text = strArray[1];
      frmAddExternalTool.ckpromptforarguments.Checked = Convert.ToBoolean(strArray[2]);
      frmAddExternalTool.MySub(this);
      int num = (int) frmAddExternalTool.ShowDialog();
    }

    private void btnDeleteExternalTool_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Remove the selected item(s)?", Form1.strTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      foreach (ListViewItem listViewItem in this.lstexternaltools.SelectedItems)
        listViewItem.Remove();
      this.btnApply.Enabled = true;
    }

    private void cboonstartup_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.btnApply.Enabled = true;
    }

    private void ckshowfullpathintitlebar_CheckedChanged(object sender, EventArgs e)
    {
      this.btnApply.Enabled = true;
    }

    private void lstexternaltools_DoubleClick(object sender, EventArgs e)
    {
      if (this.lstexternaltools.SelectedItems.Count != 1)
        return;
      this.btnExternalToolModify_Click((object) null, (EventArgs) null);
    }

    private void ckautomaticallyaddfiletype_CheckedChanged(object sender, EventArgs e)
    {
      this.btnApply.Enabled = true;
    }

    private void ckclearclipboardonexit_CheckedChanged(object sender, EventArgs e)
    {
      this.btnApply.Enabled = true;
    }

    private void ckshowstatusbar_CheckedChanged(object sender, EventArgs e)
    {
      this.btnApply.Enabled = true;
    }

    private void ckEnabledraganddropediting_CheckedChanged(object sender, EventArgs e)
    {
      this.btnApply.Enabled = true;
    }

    private void ckAlloweditingofreadonlyfiles_CheckedChanged(object sender, EventArgs e)
    {
      this.btnApply.Enabled = true;
    }

    private void groupBox4_Enter(object sender, EventArgs e)
    {
    }
  }
}
