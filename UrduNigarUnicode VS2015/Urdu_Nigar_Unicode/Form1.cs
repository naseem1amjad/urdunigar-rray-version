// Decompiled with JetBrains decompiler
// Type: Urdu_Nigar_Unicode.Form1
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Urdu_Nigar_Unicode.Properties;
using Utils.Uri.Psp.Program3;

namespace Urdu_Nigar_Unicode
{
    public class Form1 : Form
    {

        private frmFont myFrm;
        public static int glbMaxWrongWordsForUrduSpellCheck = 99990;
        public static int glbMaxNumberOfTabs = 15;
        public static string strTitle = "Urdu Nigar Rray version";
        public static string strINI = Application.StartupPath + "\\settings.ini";
        public static string strArgument = (string)null;
        public int[] glbCurrentWrongWordsForUrduSpellCheck = new int[Form1.glbMaxNumberOfTabs + 1];
        public string glbCurrentSelectedGandaText = "";
        public string glbUrduCustomIlfaazAll = "";
        public string glbUrduCustomIlfaazIsam = "";
        public string glbUrduCustomIlfaazFale = "";
        public string glbUrduCustomIlfaazNamaloom = "";
        public string strFilter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*";
        public string strFilter4Export = "Gif File (*.gif)|*.gif|Urdu Nigar Classic (*.unc)|*.unc";
        public string strReadOnlyMsg = "The file is read-only\n\nDo you still want to open it?";
        public PrintDocument docToPrint = new PrintDocument();
        public RichTextBox[] txtbox = new RichTextBox[101];

        public Form1.gandaWord[,] gandaWords =
            new Form1.gandaWord[Form1.glbMaxNumberOfTabs, Form1.glbMaxWrongWordsForUrduSpellCheck];

        public string FindText = "";
        public string ReplaceText = "";
        public bool IsDirectionDownward = true;
        public bool IsDirectionDownward2 = true;
        public static bool glbIsUrduWordLoaded;
        public static bool glbIsCustomListsLoadedAll;
        public static bool glbIsCustomListsLoadedIsam;
        public static bool glbIsCustomListsLoadedFale;
        public static bool glbIsCustomListsLoadedNamaloom;
        public static bool glbIsEnglishWordLoaded;
        public static bool glbIsDefaultLanguageSet;
        public string glbfamily_name;
        public float glbfont_size;
        public string glbfont_style;
        public string glbUrduIlfaaz;
        public string glbEnglishWords;
        private Supported_Language glbSelectedLanguage;
        public StringReader myReader;
        private DataTable dtDict;
        public bool timerison;
        private Point rightClickedPoint;
        private IContainer components;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem mnuUndo2;
        private ToolStripSeparator mnuSep;
        private ToolStripMenuItem mnuCut2;
        private ToolStripMenuItem mnuCopy2;
        private ToolStripMenuItem mnuPaste2;
        private ToolStripMenuItem mnuDelete2;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripMenuItem mnuSelectAll2;
        public System.Windows.Forms.Timer autosave;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem mnuCloseTab;
        private ToolStripMenuItem mnuCloseOtherTabs;
        private ToolStripSeparator toolStripSeparator23;
        private ToolStripMenuItem mnuSaveTab;
        private ToolStripSeparator toolStripSeparator24;
        private ToolStripMenuItem mnuSaveAllTabs;
        private ToolStripMenuItem mnuCopyFullPath;
        private ToolStripMenuItem mnuOpenContainingFolder;
        public ToolStripStatusLabel lblautosave;
        private ToolStripStatusLabel lblnumlock;
        private ToolStripStatusLabel lblins;
        private ToolStripStatusLabel lblcaps;
        public ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.Timer keystimer;
        private System.Windows.Forms.Timer fontsWindowtimer;
        private ToolStripStatusLabel lblline2;
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        public StatusStrip sb;
        private ToolStripStatusLabel lblnewfileicon;
        public ToolStripStatusLabel toolStripStatusLabel6;
        private ToolStripStatusLabel lblline;
        private ToolStripStatusLabel lblnum;
        private ToolStripStatusLabel lblins2;
        private ToolStripStatusLabel lblcaps2;
        private MenuStrip mnu;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem mnuOpen;
        private ToolStripMenuItem mnuClose;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnuSave;
        private ToolStripMenuItem mnuSaveAs;
        private ToolStripMenuItem mnuSaveAll;
        private ToolStripSeparator mnuSep2;
        private ToolStripMenuItem mnuPageSetup;
        private ToolStripMenuItem mnuPrint;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem mnuSend;
        private ToolStripSeparator toolStripSeparator21;
        public ToolStripMenuItem mnuRecentFiles;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem mnuProperties;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuEdit;
        private ToolStripMenuItem mnuUndo;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem mnuCut;
        private ToolStripMenuItem mnuCopy;
        private ToolStripMenuItem mnuPaste;
        private ToolStripMenuItem mnuDelete;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem mnuSelectAll;
        private ToolStripSeparator toolStripSeparator16;
        private ToolStripMenuItem mnuFind;
        private ToolStripMenuItem mnuFindNext;
        private ToolStripMenuItem mnuReplace;
        private ToolStripMenuItem mnuGoTo;
        private ToolStripMenuItem mnuView;
        public ToolStripMenuItem mnuStatusBar;
        private ToolStripMenuItem mnuFormat;
        public ToolStripMenuItem mnuWordWrap;
        private ToolStripMenuItem mnuFont;
        private ToolStripMenuItem mnuTools;
        private ToolStripMenuItem mnuExternalTools;
        private ToolStripSeparator toolStripSeparator26;
        private ToolStripMenuItem mnuWordCount;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuOptions;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuAbout;
        public TabControl tabControl1;
        private ToolStripMenuItem mnuTimeDate;
        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripMenuItem1;
        private ToolStripButton toolStripMenuItem2;
        private ToolStripButton toolStripMenuItem3;
        private ToolStripButton toolStripMenuItem4;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tbCut;
        private ToolStripButton tbCopy;
        private ToolStripButton tbPaste;
        private ToolStripButton tbDelete;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton tbUndo;
        private ToolStripMenuItem testingToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripComboBox toolStripComboBox2;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton tbSpellCheck;
        private ToolStripMenuItem urduCharacterListToolStripMenuItem;
        private ToolStripMenuItem urduPhoneticLayoutToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem5AddToDictionary;
        private ToolStripMenuItem mnuAdd2DictIsam;
        private ToolStripMenuItem mnuAdd2DictFail;
        private ToolStripMenuItem mnuAdd2DictNaMaloom;
        private ToolStripMenuItem spellCheckToolStripMenuItem;
        private ToolStripMenuItem reverseToolStripMenuItem;
        private ToolStripMenuItem transliterateToolStripMenuItem;
        private ToolStripMenuItem submitFilesToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripButton tbRefresh;
        public ToolStripMenuItem mnuAutoAlignment;
        private ToolStripButton tbAlignLeft;
        private ToolStripButton tbAlignRight;
        private ToolStripSeparator tbStripAlign;
        private ToolStripMenuItem mnuExport;
        private ToolStripMenuItem tipsToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem convertToImageToolStripMenuItem;
        private ToolStripMenuItem usageOfSpaceBarToolStripMenuItem;
        private ToolStripMenuItem UsageOfAlignmentOptionToolStripMenuItem;
        private ToolStripMenuItem howToPrintTextToolStripMenuItem;
        private ToolStripMenuItem howToSpellCheckToolStripMenuItem;
        
        public Form1()
        {
            this.InitializeComponent();
            this.mnu.Renderer = (ToolStripRenderer)new BorderlessDisabledToolStripItemRenderer();
            this.contextMenuStrip1.Renderer = (ToolStripRenderer)new BorderlessDisabledToolStripItemRenderer();
            this.contextMenuStrip3.Renderer = (ToolStripRenderer)new BorderlessDisabledToolStripItemRenderer();
            this.Height = Convert.ToInt32(DirectIniFile.ReadProfileValue(Form1.strINI, "Size", "Height", "580"));
            this.Width = Convert.ToInt32(DirectIniFile.ReadProfileValue(Form1.strINI, "Size", "Width", "780"));
            this.Location =
                new Point(Convert.ToInt32(DirectIniFile.ReadProfileValue(Form1.strINI, "Location", "X", "10")),
                    Convert.ToInt32(DirectIniFile.ReadProfileValue(Form1.strINI, "Location", "Y", "10")));
            
        }

        public void NewFile()
        {
            if (this.tabControl1.TabPages.Count != Form1.glbMaxNumberOfTabs)
            {
                TabPage tabPage = new TabPage("Untitled.txt");
                tabPage.Tag = (object)"Untitled";
                int index = this.tabControl1.TabPages.Count + 1;
                this.txtbox[index] = new RichTextBox();
                this.txtbox[index].AcceptsTab = true;
                this.txtbox[index].Multiline = true;
                this.txtbox[index].BorderStyle = BorderStyle.None;
                this.txtbox[index].ScrollBars = RichTextBoxScrollBars.Both;
                this.txtbox[index].WordWrap = false;
                this.txtbox[index].Dock = DockStyle.Fill;
                this.txtbox[index].ContextMenuStrip = this.contextMenuStrip1;
                this.txtbox[index].TextChanged += new EventHandler(this.txtbox_TextChanged);
                this.txtbox[index].Click += new EventHandler(this.txtbox_Click);
                this.txtbox[index].KeyUp += new KeyEventHandler(this.txtbox_KeyUp);
                this.txtbox[index].KeyPress += new KeyPressEventHandler(this.txtbox_KeyPress);
                this.txtbox[index].MouseDown += new MouseEventHandler(this.txtbox_MouseDown);
                this.txtbox[index].MouseMove += new MouseEventHandler(this.txtbox_MouseMove);
                this.txtbox[index].RightToLeft = RightToLeft.Yes;
                float emSize = Convert.ToSingle(DirectIniFile.ReadProfileValue(Form1.strINI, "Font", "Size", "14"));
                this.glbfont_size = emSize;
                string familyName = DirectIniFile.ReadProfileValue(Form1.strINI, "Font", "Name", "Arial");
                this.glbfamily_name = familyName;
                FontStyle style = FontStyle.Regular;
                string str = DirectIniFile.ReadProfileValue(Form1.strINI, "Font", "Style", "Regular");
                if (str == "Regular")
                    style = FontStyle.Regular;
                if (str == "Bold")
                    style = FontStyle.Bold;
                if (str == "Italic")
                    style = FontStyle.Italic;
                if (str == "Bold, Italic")
                    style = FontStyle.Bold | FontStyle.Italic;
                Font font = new Font(familyName, emSize, style);
                this.txtbox[index].Font = font;
                this.mnuWordWrap.Checked =
                    Convert.ToBoolean(DirectIniFile.ReadProfileValue(Form1.strINI, "Format", "Word Wrap", "False"));
                if (this.mnuWordWrap.Checked)
                {
                    this.txtbox[index].WordWrap = true;
                    this.txtbox[index].ScrollBars = RichTextBoxScrollBars.Vertical;
                }
                this.mnuAutoAlignment.Checked =
                    Convert.ToBoolean(DirectIniFile.ReadProfileValue(Form1.strINI, "Format", "Auto Alignment", "False"));
                if (this.mnuAutoAlignment.Checked)
                {
                    this.tbAlignLeft.Visible = false;
                    this.tbAlignRight.Visible = false;
                    this.tbStripAlign.Visible = false;
                }
                else
                {
                    this.tbAlignLeft.Visible = true;
                    this.tbAlignRight.Visible = true;
                    this.tbStripAlign.Visible = true;
                }
                tabPage.ImageIndex = index;
                tabPage.Controls.Add((Control)this.txtbox[index]);
                this.tabControl1.TabPages.Add(tabPage);
                this.tabControl1.SelectedTab = tabPage;
                this.txtbox[index].Focus();
                this.txtbox[index].Select();
                this.Text = "Untitled - " + Form1.strTitle;
            }
            else
            {
                int num =
                    (int)
                        MessageBox.Show("You have reached the limit on tabs.", Form1.strTitle, MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
            }
        }

        public void OpenFile(string FileName)
        {
            this.NewFile();
            StreamReader streamReader = new StreamReader(FileName);
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text = streamReader.ReadToEnd();
            streamReader.Close();
            if (this.IsReadOnly(FileName))
            {
                if ("False" ==
                    DirectIniFile.ReadProfileValue(Form1.strINI, "Files", "Allow Editing Of Read Only Files", "True"))
                    this.txtbox[this.tabControl1.SelectedTab.ImageIndex].ReadOnly = true;
                if ("True" ==
                    DirectIniFile.ReadProfileValue(Form1.strINI, "Files", "Show Full Path In Title Bar", "False"))
                    this.Text = FileName + " - " + Form1.strTitle + " (Read-Only)";
                else
                    this.Text = Path.GetFileNameWithoutExtension(FileName) + " - " + Form1.strTitle + " (Read-Only)";
            }
            else
            {
                this.txtbox[this.tabControl1.SelectedTab.ImageIndex].ReadOnly = false;
                if ("True" ==
                    DirectIniFile.ReadProfileValue(Form1.strINI, "Files", "Show Full Path In Title Bar", "False"))
                    this.Text = FileName + " - " + Form1.strTitle;
                else
                    this.Text = Path.GetFileNameWithoutExtension(FileName) + " - " + Form1.strTitle;
            }
            this.AddRecentFile(FileName);
            this.tabControl1.SelectedTab.Text = Path.GetFileName(FileName);
            this.tabControl1.SelectedTab.Tag = (object)FileName;
        }

        public void SaveFile(string FileName)
        {
            StreamWriter streamWriter = new StreamWriter(FileName);
            streamWriter.Write(this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text);
            streamWriter.Close();
            if ("True" == DirectIniFile.ReadProfileValue(Form1.strINI, "Files", "Show Full Path In Title Bar", "False"))
                this.Text = FileName + " - " + Form1.strTitle;
            else
                this.Text = Path.GetFileNameWithoutExtension(FileName) + " - " + Form1.strTitle;
            this.tabControl1.SelectedTab.Text = Path.GetFileName(FileName);
            this.tabControl1.SelectedTab.Tag = (object)FileName;
            if (!("True" == DirectIniFile.ReadProfileValue(Form1.strINI, "Editor", "Clear Undo", "False")))
                return;
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].ClearUndo();
        }

        public void SaveFile2(string FileName, string Text)
        {
            StreamWriter streamWriter = new StreamWriter(FileName);
            streamWriter.Write(Text);
            streamWriter.Close();
            if ("True" == DirectIniFile.ReadProfileValue(Form1.strINI, "Files", "Show Full Path In Title Bar", "False"))
                this.Text = FileName + " - " + Form1.strTitle;
            else
                this.Text = Path.GetFileNameWithoutExtension(FileName) + " - " + Form1.strTitle;
            this.tabControl1.SelectedTab.Text = Path.GetFileName(FileName);
            this.tabControl1.SelectedTab.Tag = (object)FileName;
            if (!("True" == DirectIniFile.ReadProfileValue(Form1.strINI, "Editor", "Clear Undo", "False")))
                return;
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].ClearUndo();
        }

        public bool IsReadOnly(string File)
        {
            return System.IO.File.Exists(File) &&
                   (System.IO.File.GetAttributes(File) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly;
        }

        public void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            int num1 = 0;
            float x = (float)e.MarginBounds.Left;
            float num2 = (float)e.MarginBounds.Top;
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            Font font = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Font;
            float num3 = (float)e.MarginBounds.Height / font.GetHeight(e.Graphics);
            string s;
            for (s = this.myReader.ReadLine(); (double)num1 < (double)num3 && s != null; s = this.myReader.ReadLine())
            {
                float y = num2 + (float)num1 * font.GetHeight(e.Graphics);
                e.Graphics.DrawString(s, font, (Brush)solidBrush, x, y, new StringFormat());
                ++num1;
            }
            e.HasMorePages = s != null;
            solidBrush.Dispose();
        }

        private float getCurrentY(int currentLine, float topMargin, float fontHeight)
        {
            return topMargin + (float)currentLine * fontHeight;
        }

        public static bool isNumeric(string str)
        {
            if (str.Trim() == "")
                return false;
            char[] chArray = str.ToCharArray();
            for (int index = 0; index < chArray.Length; ++index)
            {
                if ((int)chArray[index] > 57 || (int)chArray[index] < 48)
                    return false;
            }
            return true;
        }

        private void mnuWordCount_Click(object sender, EventArgs e)
        {
            //if (frmWordCount.formOpened)
            //  return;
            frmWordCount frmWordCount = new frmWordCount();
            frmWordCount.MySub(this);
            frmWordCount.Show((IWin32Window)this);
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Font;
            fontDialog.ShowEffects = false;
            if (fontDialog.ShowDialog() != DialogResult.OK)
                return;
            this.glbfamily_name = fontDialog.Font.Name;
            this.glbfont_size = fontDialog.Font.Size;
            this.glbfont_style = fontDialog.Font.Style.ToString();
            SetFontOfText(fontDialog.Font);
        }

        private void SetFontOfText(Font fnt)
        {

            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Font = fnt;
            DirectIniFile.WriteProfileValue(Form1.strINI, "Font", "Name", fnt.Name);
            DirectIniFile.WriteProfileValue(Form1.strINI, "Font", "Size", fnt.Size.ToString());
            DirectIniFile.WriteProfileValue(Form1.strINI, "Font", "Style", fnt.Style.ToString());
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = this.strFilter;
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            if (this.IsReadOnly(openFileDialog.FileName))
            {
                if (
                    MessageBox.Show(this.strReadOnlyMsg, Form1.strTitle, MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation) != DialogResult.Yes)
                    return;
                this.OpenFile(openFileDialog.FileName);
            }
            else
                this.OpenFile(openFileDialog.FileName);
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = this.strFilter;
            if (this.tabControl1.SelectedTab.Text.EndsWith(".rtf"))
                saveFileDialog.FilterIndex = 2;
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            if (this.IsReadOnly(saveFileDialog.FileName))
            {
                int num =
                    (int)
                        MessageBox.Show("The file is read-only. You cannot write to it.", Form1.strTitle,
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                this.SaveFile(saveFileDialog.FileName);
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab.Tag.ToString() != "Untitled")
            {
                if (this.IsReadOnly(this.tabControl1.SelectedTab.Tag.ToString()))
                {
                    int num1 =
                        (int)
                            MessageBox.Show(
                                "The file is read-only. You cannot write to it.\n\nTo save, use Save As in the File menu.",
                                Form1.strTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    this.SaveFile(this.tabControl1.SelectedTab.Tag.ToString());
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = this.strFilter;
                if (this.tabControl1.SelectedTab.Text.EndsWith(".rtf"))
                    saveFileDialog.FilterIndex = 2;
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                if (this.IsReadOnly(saveFileDialog.FileName))
                {
                    int num2 =
                        (int)
                            MessageBox.Show("The file is read-only. You cannot write to it.", Form1.strTitle,
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    this.SaveFile(saveFileDialog.FileName);
            }
        }

        private void mnuEdit_DropDownOpening(object sender, EventArgs e)
        {
            this.mnuUndo.Enabled = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].CanUndo;
            this.mnuCut.Enabled = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength > 0;
            this.mnuCopy.Enabled = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength > 0;
            this.mnuPaste.Enabled = Clipboard.ContainsText();
            this.mnuDelete.Enabled = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength > 0;
            if (this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength ==
                this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text.Length)
                this.mnuSelectAll.Enabled = false;
            else if (this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text.Length == 0)
                this.mnuSelectAll.Enabled = false;
            else
                this.mnuSelectAll.Enabled = true;
        }

        private void mnuUndo_Click(object sender, EventArgs e)
        {
            if (!this.txtbox[this.tabControl1.SelectedTab.ImageIndex].CanUndo)
                return;
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Undo();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuProperties_Click(object sender, EventArgs e)
        {
            frmProperties frmProperties = new frmProperties();
            frmProperties.MySub(this);
            frmProperties.SetProperties(this.tabControl1.SelectedTab.Tag.ToString());
            int num = (int)frmProperties.ShowDialog();
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            if (this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength <= 0)
                return;
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Cut();
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            if (this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength <= 0)
                return;
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Copy();
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            if (!Clipboard.ContainsText())
                return;
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Paste();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength <= 0)
                return;
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectedText = "";
        }

        private void mnuSelectAll_Click(object sender, EventArgs e)
        {
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Focus();
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectAll();
        }

        private void mnuFind_Click(object sender, EventArgs e)
        {
            //if (frmFind.formOpened)
            //  return;
            frmFind frmFind = new frmFind();
            frmFind.MySub(this);
            frmFind.Show((IWin32Window)this);
        }

        private void mnuReplace_Click(object sender, EventArgs e)
        {
            //if (frmReplace.formOpened)
            //  return;
            frmReplace frmReplace = new frmReplace();
            frmReplace.MySub(this);
            frmReplace.Show((IWin32Window)this);
        }

        private void mnuGoTo_Click(object sender, EventArgs e)
        {
            //if (frmGoTo.formOpened)
            //  return;
            frmGoTo frmGoTo = new frmGoTo();
            frmGoTo.MySub(this);
            frmGoTo.Show((IWin32Window)this);
        }

        private void mnuUppercase_Click(object sender, EventArgs e)
        {
            if (this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength == 0)
                this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text =
                    this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text.ToUpper();
            else
                this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectedText =
                    this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectedText.ToUpper();
        }

        private void mnuLowercase_Click(object sender, EventArgs e)
        {
            if (this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength == 0)
                this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text =
                    this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text.ToLower();
            else
                this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectedText =
                    this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectedText.ToLower();
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
                for (int index2 = str.IndexOf(splitString, 0);
                    index2 != -1 && index2 < str.Length;
                    index2 = str.IndexOf(splitString, startIndex))
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

        public void LoadRecentFiles()
        {
            this.mnuRecentFiles.DropDownItems.Clear();
            //try
            {
                string searchString = DirectIniFile.ReadProfileValue(Form1.strINI, "Recent Files", "Items", "");
                int num1 =
                    Convert.ToInt32(DirectIniFile.ReadProfileValue(Form1.strINI, "Recent Files", "Items To Show", "10"));
                if (searchString != null)
                {
                    int num2 = 1;
                    string[] strArray = Form1.Split(searchString, ",");
                    for (int index = 0; index < num1; ++index)
                    {
                        if ((index < strArray.Length) && strArray[index] != "")
                        {
                            ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
                            if (strArray[index].Length > 65)
                                toolStripMenuItem.Text = num2.ToString() + " " +
                                                         strArray[index].Replace("Documents and Settings", "...");
                            else
                                toolStripMenuItem.Text = num2.ToString() + " " + strArray[index];
                            toolStripMenuItem.Click += new EventHandler(this.OnRecentFileClick);
                            toolStripMenuItem.Tag = (object)strArray[index];
                            this.mnuRecentFiles.DropDownItems.Add((ToolStripItem)toolStripMenuItem);
                            ++num2;
                        }
                    }
                }
            }
            //catch
            //{
            //}
            this.mnuRecentFiles.Enabled = this.mnuRecentFiles.HasDropDownItems;
        }

        private void AddRecentFile(string str)
        {
            this.mnuRecentFiles.Enabled = true;
            if (this.mnuRecentFiles.DropDownItems.Count == 0)
            {
                ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(str.Replace("Documents and Settings", "..."));
                toolStripMenuItem.Click += new EventHandler(this.OnRecentFileClick);
                toolStripMenuItem.Tag = (object)str;
                this.mnuRecentFiles.DropDownItems.Add((ToolStripItem)toolStripMenuItem);
                this.SaveRecentFiles();
            }
            else
            {
                if (this.mnuRecentFiles.DropDownItems.Count ==
                    Convert.ToInt32(DirectIniFile.ReadProfileValue(Form1.strINI, "Recent Files", "Items To Show", "10")))
                    this.mnuRecentFiles.DropDownItems.RemoveAt(0);
                if (this.RecentFileExists(str))
                    return;
                ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(str.Replace("Documents and Settings", "..."));
                toolStripMenuItem.Click += new EventHandler(this.OnRecentFileClick);
                toolStripMenuItem.Tag = (object)str;
                this.mnuRecentFiles.DropDownItems.Add((ToolStripItem)toolStripMenuItem);
                this.SaveRecentFiles();
            }
        }

        private void SaveRecentFiles()
        {
            string keyValue = (string)null;
            foreach (
                ToolStripMenuItem toolStripMenuItem in (ArrangedElementCollection)this.mnuRecentFiles.DropDownItems)
                keyValue = keyValue + toolStripMenuItem.Tag + ",";
            DirectIniFile.WriteProfileValue(Form1.strINI, "Recent Files", "Items", keyValue);
        }

        private void DeleteMissingRecentFile(string t)
        {
            try
            {
                foreach (
                    ToolStripMenuItem toolStripMenuItem in (ArrangedElementCollection)this.mnuRecentFiles.DropDownItems
                    )
                {
                    if (toolStripMenuItem.Text == t && !System.IO.File.Exists(toolStripMenuItem.Tag.ToString()))
                        this.mnuRecentFiles.DropDownItems.Remove((ToolStripItem)toolStripMenuItem);
                }
            }
            catch
            {
            }
        }

        private bool RecentFileExists(string t)
        {
            try
            {
                foreach (ToolStripItem toolStripItem in (ArrangedElementCollection)this.mnuRecentFiles.DropDownItems)
                {
                    if (toolStripItem.Tag.ToString() == t)
                        return true;
                }
            }
            catch
            {
            }
            return false;
        }

        private void OnRecentFileClick(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
            if (System.IO.File.Exists(toolStripMenuItem.Tag.ToString()))
            {
                if (this.IsReadOnly(toolStripMenuItem.Tag.ToString()))
                {
                    if (
                        MessageBox.Show(this.strReadOnlyMsg, Form1.strTitle, MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation) != DialogResult.Yes)
                        return;
                    this.OpenFile(toolStripMenuItem.Tag.ToString());
                }
                else
                    this.OpenFile(toolStripMenuItem.Tag.ToString());
            }
            else
            {
                if (
                    MessageBox.Show(
                        "The file \"" + toolStripMenuItem.Text +
                        "\" does not exist.\n\nDo you wish to remove it from the recent files list?", Form1.strTitle,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                    return;
                this.DeleteMissingRecentFile(toolStripMenuItem.Text);
                this.SaveRecentFiles();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myFrm = new frmFont();

            this.mnuSend.Visible = false;
            this.toolStripSeparator21.Visible = false;
            this.mnuTools.Visible = true;
            this.mnuExternalTools.Visible = false;
            this.toolStripSeparator26.Visible = false;
            this.mnuWordCount.Visible = false;
            this.toolStripSeparator1.Visible = false;
            this.mnuOptions.Visible = false;
            this.mnuFind.Visible = false;
            this.mnuFindNext.Visible = false;
            this.mnuReplace.Visible = false;
            this.mnuGoTo.Visible = false;
            this.toolStripSeparator16.Visible = false;
            this.mnuTimeDate.Visible = false;
            this.mnuUndo.Visible = false;
            this.tbUndo.Visible = false;
            this.mnuUndo2.Visible = false;
            this.toolStripSeparator7.Visible = false;
            this.mnuSep.Visible = false;
            this.mnuPrint.Visible = false;
            this.mnuPageSetup.Visible = false;
            this.toolStripSeparator10.Visible = false;
            Form1.glbIsDefaultLanguageSet = false;
            this.toolStripComboBox1.SelectedIndex = 1;
            this.glbSelectedLanguage = Supported_Language.Urdu;
            Form1.glbIsDefaultLanguageSet = true;

            FontStyleForm_Load(sender, e);//Load Font List
            if (Form1.strArgument != null)
            {
                string[] strArray = Form1.strArgument.Split(',');
                for (int index = 0; index < strArray.Length; ++index)
                {
                    if (System.IO.File.Exists(strArray[index]))
                        this.OpenFile(strArray[index]);
                }
                if (this.tabControl1.TabPages.Count == 0)
                    this.NewFile();
            }
            else
                this.NewFile();
            this.mnuStatusBar.Checked =
                Convert.ToBoolean(DirectIniFile.ReadProfileValue(Form1.strINI, "View", "Status Bar", "True"));
            if (!this.mnuStatusBar.Checked)
                this.sb.Visible = false;
            if (!("True" == DirectIniFile.ReadProfileValue(Form1.strINI, "Backup", "Enable Auto Save", "False")))
                return;
            this.autosave.Interval =
                Convert.ToInt32(DirectIniFile.ReadProfileValue(Form1.strINI, "Backup", "Auto Save Interval", "5")) * 10000;
            this.autosave.Enabled = true;
            this.lblautosave.Text = "AutoSave: On";

            this.keystimer.Enabled = true;

            
        }


        private void tbNew_Click(object sender, EventArgs e)
        {
            this.NewFile();
        }

        private void mnuWordWrap_Click(object sender, EventArgs e)
        {
            if (this.mnuWordWrap.Checked)
            {
                this.mnuWordWrap.Checked = false;
                for (int index = 0; index < this.tabControl1.TabPages.Count; ++index)
                {
                    this.txtbox[this.tabControl1.TabPages[index].ImageIndex].WordWrap = false;
                    this.txtbox[this.tabControl1.TabPages[index].ImageIndex].ScrollBars = RichTextBoxScrollBars.Both;
                }
            }
            else
            {
                this.mnuWordWrap.Checked = true;
                for (int index = 0; index < this.tabControl1.TabPages.Count; ++index)
                {
                    this.txtbox[this.tabControl1.TabPages[index].ImageIndex].WordWrap = true;
                    this.txtbox[this.tabControl1.TabPages[index].ImageIndex].ScrollBars = RichTextBoxScrollBars.Vertical;
                }
            }
            DirectIniFile.WriteProfileValue(Form1.strINI, "Format", "Word Wrap", this.mnuWordWrap.Checked.ToString());
        }

        private void mnuPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = this.docToPrint;
            this.myReader = new StringReader(this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text);
            printDialog.AllowSomePages = true;
            if (printDialog.Document.PrinterSettings.PrinterName == "<no default printer>")
            {
                int num =
                    (int)
                        MessageBox.Show("There are currently no printers installed.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Hand);
            }
            else
            {
                if (printDialog.ShowDialog() != DialogResult.OK)
                    return;
                this.docToPrint.Print();
            }
        }

        private void mnuPageSetup_Click(object sender, EventArgs e)
        {
            PageSetupDialog pageSetupDialog = new PageSetupDialog();
            pageSetupDialog.Document = this.docToPrint;
            if (pageSetupDialog.Document.PrinterSettings.PrinterName == "<no default printer>")
            {
                int num1 =
                    (int)
                        MessageBox.Show("There are currently no printers installed.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Hand);
            }
            else
            {
                int num2 = (int)pageSetupDialog.ShowDialog();
            }
        }

        private void tbOpen_ButtonClick(object sender, EventArgs e)
        {
            this.mnuOpen_Click((object)this, new EventArgs());
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            int num = (int)new frmAbout().ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            int num1 = 0;
            int num2 = 0;
            foreach (TabPage tabPage in this.tabControl1.TabPages)
                ++num1;
            foreach (Control control in this.tabControl1.TabPages)
            {
                if (control.Text.EndsWith("*"))
                    ++num2;
            }
            if (num2 > 0)
            {
                for (int index = 0; index < this.tabControl1.TabPages.Count; ++index)
                {
                    if (this.tabControl1.TabPages[index].Text.EndsWith("*"))
                    {
                        if (this.tabControl1.TabPages[index].Tag.ToString() != "Untitled")
                        {
                            if (!this.IsReadOnly(this.tabControl1.TabPages[index].Tag.ToString()))
                            {
                                this.tabControl1.SelectedIndex = index;
                                switch (
                                    MessageBox.Show(
                                        "The text in the " + this.tabControl1.SelectedTab.Tag.ToString() +
                                        " file has changed.\n\nDo you wish to save the changes?", Form1.strTitle,
                                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
                                {
                                    case DialogResult.Yes:
                                        this.SaveFile(this.tabControl1.TabPages[index].Tag.ToString());
                                        if (num1 == this.tabControl1.TabPages.Count)
                                        {
                                            e.Cancel = false;
                                            continue;
                                        }
                                        continue;
                                    case DialogResult.No:
                                        if (num1 == this.tabControl1.TabPages.Count)
                                        {
                                            e.Cancel = false;
                                            continue;
                                        }
                                        continue;
                                    case DialogResult.Cancel:
                                        e.Cancel = true;
                                        continue;
                                    default:
                                        continue;
                                }
                            }
                            else if (num1 == this.tabControl1.TabPages.Count)
                                e.Cancel = false;
                        }
                        else
                        {
                            this.tabControl1.SelectedIndex = index;
                            switch (
                                MessageBox.Show(
                                    "The text in the " + this.tabControl1.SelectedTab.Tag.ToString() +
                                    " file has changed.\n\nDo you wish to save the changes?", Form1.strTitle,
                                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
                            {
                                case DialogResult.Yes:
                                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                                    saveFileDialog.Filter = this.strFilter;
                                    if (this.tabControl1.SelectedTab.Text.EndsWith(".rtf"))
                                        saveFileDialog.FilterIndex = 2;
                                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                    {
                                        this.SaveFile(saveFileDialog.FileName);
                                        if (num1 == this.tabControl1.TabPages.Count)
                                        {
                                            e.Cancel = false;
                                            continue;
                                        }
                                        continue;
                                    }
                                    continue;
                                case DialogResult.No:
                                    if (num1 == this.tabControl1.TabPages.Count)
                                    {
                                        e.Cancel = false;
                                        continue;
                                    }
                                    continue;
                                case DialogResult.Cancel:
                                    e.Cancel = true;
                                    continue;
                                default:
                                    continue;
                            }
                        }
                    }
                }
            }
            else
                e.Cancel = false;
        }

        private void txtbox_MouseMove(object sender, MouseEventArgs e)
        {
            this.tbCut.Enabled = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength > 0;
            this.tbCopy.Enabled = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength > 0;
            this.tbDelete.Enabled = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength > 0;
        }

        private void txtbox_MouseDown(object sender, MouseEventArgs e)
        {
            if ("True" ==
                DirectIniFile.ReadProfileValue(Form1.strINI, "Format", "Enable Drag And Drop Editing", "False") &&
                this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectedText.Length > 0)
            {
                int num =
                    (int)
                        this.txtbox[this.tabControl1.SelectedTab.ImageIndex].DoDragDrop(
                            (object)this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectedText,
                            DragDropEffects.Copy);
            }
            if (e.Button != MouseButtons.Right)
                return;
            if (
                this.isGandaWord(
                    this.txtbox[this.tabControl1.SelectedTab.ImageIndex].GetCharIndexFromPosition(new Point(e.X, e.Y))))
                this.toolStripMenuItem5AddToDictionary.Visible = true;
            else
                this.toolStripMenuItem5AddToDictionary.Visible = false;
            this.mnuUndo2.Enabled = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].CanUndo;
            this.mnuCut2.Enabled = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength > 0;
            this.mnuCopy2.Enabled = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength > 0;
            this.mnuPaste2.Enabled = Clipboard.ContainsText();
            this.mnuDelete2.Enabled = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength > 0;
            if (this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength ==
                this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text.Length)
                this.mnuSelectAll2.Enabled = false;
            else if (this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text.Length == 0)
                this.mnuSelectAll2.Enabled = false;
            else
                this.mnuSelectAll2.Enabled = true;
        }

        private void mnuStatusBar_Click(object sender, EventArgs e)
        {
            if (this.mnuStatusBar.Checked)
            {
                this.mnuStatusBar.Checked = false;
                this.sb.Visible = false;
            }
            else
            {
                this.sb.Visible = true;
                this.mnuStatusBar.Checked = true;
            }
            DirectIniFile.WriteProfileValue(Form1.strINI, "View", "Status Bar", this.mnuStatusBar.Checked.ToString());
        }

        private void txtbox_TextChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab.Text.IndexOf("*") != -1)
                return;
            this.tabControl1.SelectedTab.Text += "*";
        }

        private void txtbox_Click(object sender, EventArgs e)
        {
        }

        private void txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.glbSelectedLanguage != Supported_Language.Urdu)
                return;
            char ch = this.setUrduPhoneticUnicodes(e.KeyChar);
            e.KeyChar = ch;
        }

        private void txtbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
                return;
            this.manualDelete();
        }

        public void FindReplace(object sender, EventArgs e)
        {
            int num1 = -1;
            if (this.IsDirectionDownward2)
                num1 = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength != 0
                    ? this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text.IndexOf(this.ReplaceText,
                        this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionStart +
                        this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength)
                    : this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text.IndexOf(this.ReplaceText,
                        this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionStart);
            else if (this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionStart > 0)
                num1 = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text.LastIndexOf(this.ReplaceText,
                    this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionStart - 1);
            if (num1 != -1)
            {
                this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionStart = num1;
                this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength = this.ReplaceText.Length;
                this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Focus();
            }
            else
            {
                int num2 =
                    (int)
                        MessageBox.Show("Cannot find \"" + this.ReplaceText + "\"", Form1.strTitle, MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
            }
        }

        public void Find(object sender, EventArgs e)
        {
            int num1 = -1;
            if (this.IsDirectionDownward)
                num1 = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength != 0
                    ? this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text.IndexOf(this.FindText,
                        this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionStart +
                        this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength)
                    : this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text.IndexOf(this.FindText,
                        this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionStart);
            else if (this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionStart > 0)
                num1 = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text.LastIndexOf(this.FindText,
                    this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionStart - 1);
            if (num1 != -1)
            {
                this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionStart = num1;
                this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength = this.FindText.Length;
                this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Focus();
            }
            else
            {
                int num2 =
                    (int)
                        MessageBox.Show("Cannot find \"" + this.FindText + "\"", Form1.strTitle, MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
            }
        }

        private void mnuFindNext_Click(object sender, EventArgs e)
        {
            if (this.FindText.Length == 0)
            {
                //if (frmFind.formOpened)
                //  return;
                frmFind frmFind = new frmFind();
                frmFind.MySub(this);
                frmFind.Show((IWin32Window)this);
            }
            else
                this.Find((object)null, (EventArgs)null);
        }

        private void mnuFile_DropDownOpening(object sender, EventArgs e)
        {
            this.mnuClose.Enabled = this.tabControl1.TabPages.Count > 1;
            this.LoadRecentFiles();
        }

        private void changeLanguage()
        {
            switch (this.toolStripComboBox1.SelectedIndex)
            {
                case 0:
                    this.glbSelectedLanguage = Supported_Language.English;
                    if (!this.mnuAutoAlignment.Checked)
                        break;
                    this.txtbox[this.tabControl1.SelectedTab.ImageIndex].RightToLeft = RightToLeft.No;
                    break;
                case 1:
                    this.glbSelectedLanguage = Supported_Language.Urdu;
                    if (!this.mnuAutoAlignment.Checked)
                        break;
                    this.txtbox[this.tabControl1.SelectedTab.ImageIndex].RightToLeft = RightToLeft.Yes;
                    break;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.changeLanguage();
            if (!this.tabControl1.Visible)
                return;
            if (this.IsReadOnly(this.tabControl1.SelectedTab.Tag.ToString()))
            {
                if ("True" ==
                    DirectIniFile.ReadProfileValue(Form1.strINI, "Files", "Show Full Path In Title Bar", "False"))
                    this.Text = this.tabControl1.SelectedTab.Tag.ToString() + " - " + Form1.strTitle + " (Read-Only)";
                else
                    this.Text = Path.GetFileNameWithoutExtension(this.tabControl1.SelectedTab.Tag.ToString()) + " - " +
                                Form1.strTitle + " (Read-Only)";
            }
            else if ("True" ==
                     DirectIniFile.ReadProfileValue(Form1.strINI, "Files", "Show Full Path In Title Bar", "False"))
                this.Text = this.tabControl1.SelectedTab.Tag.ToString() + " - " + Form1.strTitle;
            else
                this.Text = Path.GetFileNameWithoutExtension(this.tabControl1.SelectedTab.Tag.ToString()) + " - " +
                            Form1.strTitle;
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Select();
        }

        public void CloseTab()
        {
            if (this.tabControl1.TabPages.Count <= 1)
                return;
            this.tabControl1.TabPages.Remove(this.tabControl1.SelectedTab);
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            if (!this.tabControl1.SelectedTab.Text.EndsWith("*"))
            {
                this.CloseTab();
            }
            else
            {
                switch (
                    MessageBox.Show(
                        "The text in the " + this.tabControl1.SelectedTab.Tag.ToString() +
                        " file has changed.\n\nDo you wish to save the changes?", Form1.strTitle,
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
                {
                    case DialogResult.Yes:
                        if (this.tabControl1.SelectedTab.Tag.ToString() != "Untitled")
                        {
                            if (this.IsReadOnly(this.tabControl1.SelectedTab.Tag.ToString()))
                            {
                                int num =
                                    (int)
                                        MessageBox.Show("The file is read-only. You cannot write to it.", Form1.strTitle,
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            }
                            this.SaveFile(this.tabControl1.SelectedTab.Tag.ToString());
                            this.CloseTab();
                            break;
                        }
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = this.strFilter;
                        if (this.tabControl1.SelectedTab.Text.EndsWith(".rtf"))
                            saveFileDialog.FilterIndex = 2;
                        if (saveFileDialog.ShowDialog() != DialogResult.OK)
                            break;
                        if (this.IsReadOnly(saveFileDialog.FileName))
                        {
                            int num =
                                (int)
                                    MessageBox.Show("The file is read-only. You cannot write to it.", Form1.strTitle,
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        }
                        this.SaveFile(saveFileDialog.FileName);
                        this.CloseTab();
                        break;
                    case DialogResult.No:
                        this.CloseTab();
                        break;
                }
            }
        }

        private void mnuSaveAll_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < this.tabControl1.TabPages.Count; ++index)
            {
                if (this.tabControl1.TabPages[index].Tag.ToString() != "Untitled")
                {
                    if (!this.IsReadOnly(this.tabControl1.TabPages[index].Tag.ToString()))
                    {
                        this.tabControl1.SelectedIndex = index;
                        this.SaveFile(this.tabControl1.TabPages[index].Tag.ToString());
                    }
                }
                else
                {
                    this.tabControl1.SelectedIndex = index;
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = this.strFilter;
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        this.SaveFile(saveFileDialog.FileName);
                }
            }
        }

        private void OnTabClick(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = ((ToolStripItem)sender).ImageIndex - 1;
        }

        private void mnuInsertFileAsText_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = this.strFilter;
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            StreamReader streamReader = new StreamReader(openFileDialog.FileName);
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength = 0;
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionStart =
                this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionStart;
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectedText += streamReader.ReadToEnd();
            streamReader.Close();
        }

        private void mnuOptions_Click(object sender, EventArgs e)
        {
            frmOptions frmOptions = new frmOptions();
            frmOptions.MySub(this);
            int num = (int)frmOptions.ShowDialog();
        }

        private void autosave_Tick(object sender, EventArgs e)
        {
            if (!("True" == DirectIniFile.ReadProfileValue(Form1.strINI, "Backup", "Enable Auto Save", "False")) ||
                !this.tabControl1.Visible || this.timerison)
                return;
            this.timerison = true;
            for (int index = 0; index < this.tabControl1.TabPages.Count; ++index)
            {
                if (this.tabControl1.TabPages[index].Tag.ToString() != "Web" &&
                    this.tabControl1.TabPages[index].Text.IndexOf("*") != -1)
                {
                    if (this.tabControl1.TabPages[index].Tag.ToString() == "Untitled")
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = this.strFilter;
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            this.SaveFile2(saveFileDialog.FileName,
                                this.txtbox[this.tabControl1.TabPages[index].ImageIndex].Text);
                    }
                    else if (!this.IsReadOnly(this.tabControl1.TabPages[index].Tag.ToString()))
                        this.SaveFile2(this.tabControl1.TabPages[index].Tag.ToString(),
                            this.txtbox[this.tabControl1.TabPages[index].ImageIndex].Text);
                }
            }
            this.timerison = false;
        }

        private void mnuSend_Click(object sender, EventArgs e)
        {
            string fileName = string.Format("mailto:{0}?subject={1}&body={2}", (object)"", (object)" ",
                (object)this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text.Replace("\n", "%0D%0A"));
            try
            {
                Process.Start(fileName);
            }
            catch
            {
            }
        }

        private void mnuDeleteFile_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(this.tabControl1.SelectedTab.Tag.ToString()) ||
                MessageBox.Show(
                    "Are you sure you want to permanently delete this file?\n\n \"" +
                    this.tabControl1.SelectedTab.Tag.ToString() + "\"", Form1.strTitle, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;
            System.IO.File.Delete(this.tabControl1.SelectedTab.Tag.ToString());
            if (this.tabControl1.TabPages.Count == 1)
            {
                this.tabControl1.SelectedTab.Text = "Untitled1.txt";
                this.tabControl1.SelectedTab.Tag = (object)"Untitled";
                this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Tag = (object)"Untitled";
                this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text = "";
                this.Text = "Untitled - " + Form1.strTitle;
            }
            else
                this.tabControl1.TabPages.Remove(this.tabControl1.SelectedTab);
        }

        private void mnuCloseTab_Click(object sender, EventArgs e)
        {
            this.rightClickedPoint.Offset(-this.toolStripContainer1.ContentPanel.Left,
                -this.toolStripContainer1.ContentPanel.Top);
            for (int index = 0; index < this.tabControl1.TabPages.Count; ++index)
            {
                if (this.tabControl1.GetTabRect(index).Contains(this.rightClickedPoint))
                {
                    if (this.tabControl1.TabPages[index].Text.IndexOf("*") == -1)
                    {
                        if (this.tabControl1.TabPages.Count > 1)
                        {
                            this.tabControl1.TabPages.RemoveAt(index);
                            break;
                        }
                        this.CloseTab();
                        break;
                    }
                    switch (
                        MessageBox.Show(
                            "The text in the " + this.tabControl1.SelectedTab.Tag.ToString() +
                            " file has changed.\n\nDo you wish to save the changes?", Form1.strTitle,
                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
                    {
                        case DialogResult.Cancel:
                            return;
                        case DialogResult.Yes:
                            if (this.tabControl1.TabPages[index].Tag.ToString() != "Untitled")
                            {
                                if (this.IsReadOnly(this.tabControl1.TabPages[index].Tag.ToString()))
                                {
                                    int num =
                                        (int)
                                            MessageBox.Show(
                                                "The file is read-only. You cannot write to it.\n\nTo save, use Save As in the File menu.",
                                                Form1.strTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return;
                                }
                                this.SaveFile(this.tabControl1.TabPages[index].Tag.ToString());
                                if (this.tabControl1.TabPages.Count > 1)
                                {
                                    this.tabControl1.TabPages.RemoveAt(index);
                                    return;
                                }
                                this.CloseTab();
                                return;
                            }
                            SaveFileDialog saveFileDialog = new SaveFileDialog();
                            saveFileDialog.Filter = this.strFilter;
                            if (this.tabControl1.SelectedTab.Text.EndsWith(".rtf"))
                                saveFileDialog.FilterIndex = 2;
                            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                                return;
                            if (this.IsReadOnly(saveFileDialog.FileName))
                            {
                                int num =
                                    (int)
                                        MessageBox.Show(
                                            "The file is read-only. You cannot write to it.\n\nTo save, use Save As in the File menu.",
                                            Form1.strTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            this.SaveFile(saveFileDialog.FileName);
                            if (this.tabControl1.TabPages.Count > 1)
                            {
                                this.tabControl1.TabPages.RemoveAt(index);
                                return;
                            }
                            this.CloseTab();
                            return;
                        case DialogResult.No:
                            if (this.tabControl1.TabPages.Count > 1)
                            {
                                this.tabControl1.TabPages.RemoveAt(index);
                                return;
                            }
                            this.CloseTab();
                            return;
                        default:
                            return;
                    }
                }
            }
        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {
            this.rightClickedPoint = this.PointToClient(Control.MousePosition);
            this.mnuCloseTab.Enabled = this.tabControl1.TabPages.Count > 1;
            this.mnuCloseOtherTabs.Enabled = this.tabControl1.TabPages.Count > 1;
            this.rightClickedPoint.Offset(-this.toolStripContainer1.ContentPanel.Left,
                -this.toolStripContainer1.ContentPanel.Top);
            for (int index = 0; index < this.tabControl1.TabPages.Count; ++index)
            {
                if (this.tabControl1.GetTabRect(index).Contains(this.rightClickedPoint))
                {
                    this.tabControl1.SelectedTab = this.tabControl1.TabPages[index];
                    this.mnuCopyFullPath.Enabled = this.tabControl1.TabPages[index].Tag.ToString() != "Untitled";
                    this.mnuOpenContainingFolder.Enabled = this.tabControl1.TabPages[index].Tag.ToString() != "Untitled";
                }
            }
        }

        private void mnuCloseOtherTabs_Click(object sender, EventArgs e)
        {
            this.rightClickedPoint.Offset(-this.toolStripContainer1.ContentPanel.Left,
                -this.toolStripContainer1.ContentPanel.Top);
            for (int index1 = 0; index1 < this.tabControl1.TabPages.Count; ++index1)
            {
                if (this.tabControl1.GetTabRect(index1).Contains(this.rightClickedPoint))
                {
                    int index2 = index1 + 1;
                    int count = this.tabControl1.TabPages.Count;
                    for (int index3 = index2; index3 < count; ++index3)
                    {
                        if (this.tabControl1.TabPages[index2].Text.IndexOf("*") == -1)
                        {
                            if (this.tabControl1.TabPages.Count > 1)
                                this.tabControl1.TabPages.RemoveAt(index2);
                            else
                                this.CloseTab();
                        }
                        else
                        {
                            switch (
                                MessageBox.Show(
                                    "The text in the " + this.tabControl1.SelectedTab.Tag.ToString() +
                                    " file has changed.\n\nDo you wish to save the changes?", Form1.strTitle,
                                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
                            {
                                case DialogResult.Yes:
                                    if (this.tabControl1.TabPages[index2].Tag.ToString() != "Untitled")
                                    {
                                        if (this.IsReadOnly(this.tabControl1.TabPages[index2].Tag.ToString()))
                                        {
                                            int num =
                                                (int)
                                                    MessageBox.Show(
                                                        "The file is read-only. You cannot write to it.\n\nTo save, use Save As in the File menu.",
                                                        Form1.strTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            continue;
                                        }
                                        this.SaveFile2(this.tabControl1.TabPages[index2].Tag.ToString(),
                                            this.tabControl1.TabPages[index2].Text);
                                        if (this.tabControl1.TabPages.Count > 1)
                                        {
                                            this.tabControl1.TabPages.RemoveAt(index2);
                                            continue;
                                        }
                                        this.CloseTab();
                                        continue;
                                    }
                                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                                    saveFileDialog.Filter = this.strFilter;
                                    if (this.tabControl1.SelectedTab.Text.EndsWith(".rtf"))
                                        saveFileDialog.FilterIndex = 2;
                                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                    {
                                        if (this.IsReadOnly(saveFileDialog.FileName))
                                        {
                                            int num =
                                                (int)
                                                    MessageBox.Show(
                                                        "The file is read-only. You cannot write to it.\n\nTo save, use Save As in the File menu.",
                                                        Form1.strTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            continue;
                                        }
                                        this.SaveFile2(saveFileDialog.FileName, this.tabControl1.TabPages[index2].Text);
                                        if (this.tabControl1.TabPages.Count > 1)
                                        {
                                            this.tabControl1.TabPages.RemoveAt(index2);
                                            continue;
                                        }
                                        this.CloseTab();
                                        continue;
                                    }
                                    continue;
                                case DialogResult.No:
                                    if (this.tabControl1.TabPages.Count > 1)
                                    {
                                        this.tabControl1.TabPages.RemoveAt(index2);
                                        continue;
                                    }
                                    this.CloseTab();
                                    continue;
                                default:
                                    continue;
                            }
                        }
                    }
                    for (int index3 = 0; index3 < index1; ++index3)
                    {
                        if (this.tabControl1.TabPages[0].Text.IndexOf("*") == -1)
                        {
                            if (this.tabControl1.TabPages.Count > 1)
                                this.tabControl1.TabPages.RemoveAt(0);
                            else
                                this.CloseTab();
                        }
                        else
                        {
                            switch (
                                MessageBox.Show(
                                    "The text in the " + this.tabControl1.SelectedTab.Tag.ToString() +
                                    " file has changed.\n\nDo you wish to save the changes?", Form1.strTitle,
                                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
                            {
                                case DialogResult.Yes:
                                    if (this.tabControl1.TabPages[0].Tag.ToString() != "Untitled")
                                    {
                                        if (this.IsReadOnly(this.tabControl1.TabPages[0].Tag.ToString()))
                                        {
                                            int num =
                                                (int)
                                                    MessageBox.Show(
                                                        "The file is read-only. You cannot write to it.\n\nTo save, use Save As in the File menu.",
                                                        Form1.strTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            continue;
                                        }
                                        this.SaveFile2(this.tabControl1.TabPages[index2].Tag.ToString(),
                                            this.tabControl1.TabPages[index2].Text);
                                        if (this.tabControl1.TabPages.Count > 1)
                                        {
                                            this.tabControl1.TabPages.RemoveAt(0);
                                            continue;
                                        }
                                        this.CloseTab();
                                        continue;
                                    }
                                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                                    saveFileDialog.Filter = this.strFilter;
                                    if (this.tabControl1.SelectedTab.Text.EndsWith(".rtf"))
                                        saveFileDialog.FilterIndex = 2;
                                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                    {
                                        if (this.IsReadOnly(saveFileDialog.FileName))
                                        {
                                            int num =
                                                (int)
                                                    MessageBox.Show(
                                                        "The file is read-only. You cannot write to it.\n\nTo save, use Save As in the File menu.",
                                                        Form1.strTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            continue;
                                        }
                                        this.SaveFile2(saveFileDialog.FileName, this.tabControl1.TabPages[index2].Text);
                                        if (this.tabControl1.TabPages.Count > 1)
                                        {
                                            this.tabControl1.TabPages.RemoveAt(0);
                                            continue;
                                        }
                                        this.CloseTab();
                                        continue;
                                    }
                                    continue;
                                case DialogResult.No:
                                    if (this.tabControl1.TabPages.Count > 1)
                                    {
                                        this.tabControl1.TabPages.RemoveAt(0);
                                        continue;
                                    }
                                    this.CloseTab();
                                    continue;
                                default:
                                    continue;
                            }
                        }
                    }
                    break;
                }
            }
        }

        private void mnuSaveTab_Click(object sender, EventArgs e)
        {
            this.rightClickedPoint.Offset(-this.toolStripContainer1.ContentPanel.Left,
                -this.toolStripContainer1.ContentPanel.Top);
            for (int index = 0; index < this.tabControl1.TabPages.Count; ++index)
            {
                if (this.tabControl1.GetTabRect(index).Contains(this.rightClickedPoint))
                {
                    if (this.tabControl1.TabPages[index].Tag.ToString() == "Untitled")
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = this.strFilter;
                        if (this.tabControl1.SelectedTab.Text.EndsWith(".rtf"))
                            saveFileDialog.FilterIndex = 2;
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            this.SaveFile2(saveFileDialog.FileName,
                                this.txtbox[this.tabControl1.TabPages[index].ImageIndex].Text);
                    }
                    else if (this.IsReadOnly(this.tabControl1.TabPages[index].Tag.ToString()))
                    {
                        int num =
                            (int)
                                MessageBox.Show(
                                    "The file is read-only. You cannot write to it.\n\nTo save, use Save As in the File menu.",
                                    Form1.strTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        this.SaveFile2(this.tabControl1.TabPages[index].Tag.ToString(),
                            this.txtbox[this.tabControl1.TabPages[index].ImageIndex].Text);
                }
            }
        }

        private void mnuSaveAllTabs_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < this.tabControl1.TabPages.Count; ++index)
            {
                if (this.tabControl1.TabPages[index].Text.IndexOf("*") != -1)
                {
                    if (this.tabControl1.TabPages[index].Tag.ToString() != "Untitled")
                    {
                        if (!this.IsReadOnly(this.tabControl1.TabPages[index].Tag.ToString()))
                            this.SaveFile2(this.tabControl1.TabPages[index].Tag.ToString(),
                                this.txtbox[this.tabControl1.TabPages[index].ImageIndex].Text);
                    }
                    else
                    {
                        this.tabControl1.SelectedIndex = index;
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = this.strFilter;
                        if (this.tabControl1.SelectedTab.Text.EndsWith(".rtf"))
                            saveFileDialog.FilterIndex = 2;
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            this.SaveFile2(saveFileDialog.FileName,
                                this.txtbox[this.tabControl1.TabPages[index].ImageIndex].Text);
                    }
                }
                else
                {
                    this.tabControl1.SelectedIndex = index;
                    if (this.tabControl1.SelectedTab.Tag.ToString() == "Untitled")
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = this.strFilter;
                        if (this.tabControl1.SelectedTab.Text.EndsWith(".rtf"))
                            saveFileDialog.FilterIndex = 2;
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            this.SaveFile2(saveFileDialog.FileName,
                                this.txtbox[this.tabControl1.TabPages[index].ImageIndex].Text);
                    }
                }
            }
        }

        private void contextMenuStrip3_Opened(object sender, EventArgs e)
        {
            this.rightClickedPoint = this.PointToClient(Control.MousePosition);
        }

        private void mnuCopyFullPath_Click(object sender, EventArgs e)
        {
            this.rightClickedPoint.Offset(-this.toolStripContainer1.ContentPanel.Left,
                -this.toolStripContainer1.ContentPanel.Top);
            for (int index = 0; index < this.tabControl1.TabPages.Count; ++index)
            {
                if (this.tabControl1.GetTabRect(index).Contains(this.rightClickedPoint))
                    Clipboard.SetText(Path.GetDirectoryName(this.tabControl1.TabPages[index].Tag.ToString()));
            }
        }

        private void mnuOpenContainingFolder_Click(object sender, EventArgs e)
        {
            this.rightClickedPoint.Offset(-this.toolStripContainer1.ContentPanel.Left,
                -this.toolStripContainer1.ContentPanel.Top);
            for (int index = 0; index < this.tabControl1.TabPages.Count; ++index)
            {
                if (this.tabControl1.GetTabRect(index).Contains(this.rightClickedPoint))
                {
                    try
                    {
                        if (Directory.Exists(Path.GetDirectoryName(this.tabControl1.TabPages[index].Tag.ToString())))
                            Process.Start(Path.GetDirectoryName(this.tabControl1.TabPages[index].Tag.ToString()));
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void OnExternalToolClick(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
            try
            {
                string[] strArray = Form1.Split(toolStripMenuItem.Tag.ToString(), ";");
                if (strArray[2] == "True")
                {
                    frmArguments frmArguments = new frmArguments();
                    frmArguments.Text = Path.GetFileNameWithoutExtension(strArray[0]);
                    frmArguments.txtcommandline.Text = strArray[0];
                    if (strArray[1].Length > 0)
                        frmArguments.txtarguments.Text = strArray[1];
                    frmArguments.txtarguments.Focus();
                    frmArguments.txtarguments.Select();
                    if (frmArguments.ShowDialog() != DialogResult.OK)
                        return;
                    new Process()
                    {
                        StartInfo =
                        {
                            FileName = strArray[0],
                            Arguments = frmArguments.txtarguments.Text
                        }
                    }.Start();
                }
                else
                {
                    Process process = new Process();
                    if (strArray[0].Length > 0)
                        process.StartInfo.FileName = strArray[0];
                    if (strArray[1].Length > 0)
                        process.StartInfo.Arguments = strArray[1];
                    process.Start();
                }
            }
            catch
            {
            }
        }

        private void EditToolsListClick(object sender, EventArgs e)
        {
            frmOptions frmOptions = new frmOptions();
            frmOptions.MySub(this);
            int num = (int)frmOptions.ShowDialog();
        }

        private void LoadExternalTools()
        {
            try
            {
                if (this.mnuExternalTools.HasDropDownItems)
                    this.mnuExternalTools.DropDownItems.Clear();
                string searchString1 = DirectIniFile.ReadProfileValue(Form1.strINI, "Tools", "External Tools", "");
                if (searchString1 != "")
                {
                    foreach (string searchString2 in Form1.Split(searchString1, "<>"))
                    {
                        string[] strArray = Form1.Split(searchString2, ";");
                        if (strArray[0].Length > 0)
                        {
                            ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(strArray[0]);
                            toolStripMenuItem.Tag = (object)(strArray[1] + ";" + strArray[2] + ";" + strArray[3]);
                            toolStripMenuItem.Click += new EventHandler(this.OnExternalToolClick);
                            this.mnuExternalTools.DropDownItems.Add((ToolStripItem)toolStripMenuItem);
                        }
                    }
                }
                else
                {
                    ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem("None");
                    toolStripMenuItem.Enabled = false;
                    this.mnuExternalTools.DropDownItems.Add((ToolStripItem)toolStripMenuItem);
                }
            }
            catch
            {
            }
        }

        private void mnuTools_DropDownOpening(object sender, EventArgs e)
        {
            this.LoadExternalTools();
        }

        private void mnuFormat_DropDownOpening(object sender, EventArgs e)
        {
            this.mnuFont.Enabled = this.tabControl1.Visible;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized && this.WindowState != FormWindowState.Minimized)
            {
                DirectIniFile.WriteProfileValue(Form1.strINI, "Location", "X", this.Location.X.ToString());
                DirectIniFile.WriteProfileValue(Form1.strINI, "Location", "Y", this.Location.Y.ToString());
                DirectIniFile.WriteProfileValue(Form1.strINI, "Size", "Height", this.Height.ToString());
                DirectIniFile.WriteProfileValue(Form1.strINI, "Size", "Width", this.Width.ToString());
            }
            if (!("True" == DirectIniFile.ReadProfileValue(Form1.strINI, "Files", "Clear Clipboard On Exit", "False")))
                return;
            Clipboard.Clear();
        }

        private void mnuCloseAllTabs_Click(object sender, EventArgs e)
        {
            foreach (TabPage tabPage in this.tabControl1.TabPages)
            {
                if (tabPage.Text.IndexOf("*") == -1)
                {
                    if (this.tabControl1.TabPages.Count > 1)
                        this.tabControl1.TabPages.Remove(tabPage);
                    else
                        this.CloseTab();
                }
                else
                {
                    switch (
                        MessageBox.Show("Save changes to " + tabPage.Text.Replace("*", "") + "?", "Save Changes",
                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
                    {
                        case DialogResult.Yes:
                            if (tabPage.Tag.ToString() != "Untitled")
                            {
                                if (this.IsReadOnly(tabPage.Tag.ToString()))
                                {
                                    int num =
                                        (int)
                                            MessageBox.Show(
                                                "The file is read-only. You cannot write to it.\n\nTo save, use Save As in the File menu.",
                                                Form1.strTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    continue;
                                }
                                this.SaveFile2(tabPage.Tag.ToString(), this.txtbox[tabPage.ImageIndex].Text);
                                if (this.tabControl1.TabPages.Count > 1)
                                {
                                    this.tabControl1.TabPages.Remove(tabPage);
                                    continue;
                                }
                                this.CloseTab();
                                continue;
                            }
                            SaveFileDialog saveFileDialog = new SaveFileDialog();
                            saveFileDialog.Filter = this.strFilter;
                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                if (this.IsReadOnly(saveFileDialog.FileName))
                                {
                                    int num =
                                        (int)
                                            MessageBox.Show(
                                                "The file is read-only. You cannot write to it.\n\nTo save, use Save As in the File menu.",
                                                Form1.strTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    continue;
                                }
                                this.SaveFile2(saveFileDialog.FileName, this.txtbox[tabPage.ImageIndex].Text);
                                if (this.tabControl1.TabPages.Count > 1)
                                {
                                    this.tabControl1.TabPages.Remove(tabPage);
                                    continue;
                                }
                                this.CloseTab();
                                continue;
                            }
                            continue;
                        case DialogResult.No:
                            if (this.tabControl1.TabPages.Count > 1)
                            {
                                this.tabControl1.TabPages.Remove(tabPage);
                                continue;
                            }
                            this.CloseTab();
                            continue;
                        default:
                            continue;
                    }
                }
            }
        }

        [DllImport("user32")]
        private static extern int GetKeyState(long nVirtKey);

        public bool CapsLockOn()
        {
            int keyState = Form1.GetKeyState((long)Convert.ToInt32((object)Keys.Capital));
            return keyState == 1 | keyState == -127;
        }

        public bool InsLockOn()
        {
            int keyState = Form1.GetKeyState((long)Convert.ToInt32((object)Keys.Insert));
            return keyState == 1 | keyState == -127;
        }

        public bool NumLockOn()
        {
            int keyState = Form1.GetKeyState((long)Convert.ToInt32((object)Keys.NumLock));
            return keyState == 1 | keyState == -127;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblins2.Enabled = this.InsLockOn();
            this.lblcaps2.Enabled = this.CapsLockOn();
            this.lblnum.Enabled = this.NumLockOn();
            this.tbUndo.Enabled = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].CanUndo;
            this.tbPaste.Enabled = Clipboard.ContainsText();
            this.tbCut.Enabled = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength > 0;
            this.tbCopy.Enabled = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength > 0;
            this.tbDelete.Enabled = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength > 0;
        }

        private void mnuTimeDate_Click(object sender, EventArgs e)
        {
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength = 0;
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionStart =
                this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionStart;
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectedText = DateTime.Today.ToShortTimeString() + " " +
                                                                                DateTime.Today.ToShortDateString();
        }

        private void testingToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        public void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Form1.glbIsDefaultLanguageSet)
                return;
            this.changeLanguage();
        }

        private void SpellCheckUsingUrduDictionary()
        {
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectAll();
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionColor = Color.Black;
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionFont = new Font(this.glbfamily_name,
                this.glbfont_size);
            string text = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text;
            Font font1 = new Font(this.glbfamily_name, this.glbfont_size, FontStyle.Bold);
            Font font2 = new Font(this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Font.Name,
                this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Font.Size, FontStyle.Regular);
            string[] strArray = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text.Split('\'', ',', '.', '(', ')',
                '{', '}', '[', ']', '"', ' ', '\n', '\\', '/', char.MinValue, char.MinValue, char.MinValue,
                char.MinValue, char.MinValue, char.MinValue, '،', '؍', '؎', '؏', 'ؕ', '؛', '؞', '؟', char.MinValue,
                '\x0640', '٪', '٫', '٬', '٭', char.MinValue, '۔', char.MinValue, char.MinValue, char.MinValue,
                char.MinValue, char.MinValue, char.MinValue, char.MinValue, char.MinValue, char.MinValue, char.MinValue,
                char.MinValue, char.MinValue, char.MinValue, char.MinValue);
            int index = 0;
            int start1 = 0;
            foreach (string str in strArray)
            {
                if (str.Length > 1 && !this.glbUrduCustomIlfaazIsam.Contains(str) &&
                    (!this.glbUrduCustomIlfaazFale.Contains(str) && !this.glbUrduCustomIlfaazNamaloom.Contains(str)) &&
                    (!this.glbUrduIlfaaz.Contains(str) && !this.isEnglishCharacters(str) && !this.isUrduNumbers(str)))
                {
                    int num = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Find(str, start1,
                        RichTextBoxFinds.WholeWord);
                    if (-1 != num)
                    {
                        ++index;
                        this.glbCurrentWrongWordsForUrduSpellCheck[this.tabControl1.SelectedTab.ImageIndex] = index;
                        int start2 = num;
                        int length = str.Length;
                        this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Select(start2, length);
                        this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionColor = Color.Red;
                        this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionFont = font1;
                        this.gandaWords[this.tabControl1.SelectedTab.ImageIndex, index] = new Form1.gandaWord();
                        this.gandaWords[this.tabControl1.SelectedTab.ImageIndex, index].meraStart = start2;
                        this.gandaWords[this.tabControl1.SelectedTab.ImageIndex, index].meraLength = length;
                        this.gandaWords[this.tabControl1.SelectedTab.ImageIndex, index].meraEnd = start2 + length;
                        this.gandaWords[this.tabControl1.SelectedTab.ImageIndex, index].meraWord = str;
                        start1 = start2 + length;
                    }
                }
            }
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Select(0, 0);
        }

        private void LoadUrduDictionaryTXT()
        {
            if (Form1.glbIsUrduWordLoaded)
                return;
            Cursor.Current = Cursors.WaitCursor;
            string path =
                (Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\ilfaaz.dat").Replace(
                    "file:\\", "");
            if (System.IO.File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                this.glbUrduIlfaaz = streamReader.ReadToEnd();
                Cursor.Current = Cursors.Default;
                Form1.glbIsUrduWordLoaded = true;
                streamReader.Close();
            }
            else
            {
                int num = (int)MessageBox.Show("Dictionary File Not Found");
                Application.Exit();
            }
        }

        private void LoadEnglishDictionaryTXT()
        {
            if (Form1.glbIsEnglishWordLoaded)
                return;
            Cursor.Current = Cursors.WaitCursor;
            this.glbEnglishWords =
                new StreamReader(
                    (Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\words.dat").Replace(
                        "file:\\", "")).ReadToEnd();
            Cursor.Current = Cursors.Default;
            Form1.glbIsEnglishWordLoaded = true;
        }

        private bool isEnglishCharacters(string wrd)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int index = 0; index < wrd.Length; ++index)
            {
                if (((int)wrd[index] < 48 || (int)wrd[index] > 57) &&
                    ((int)wrd[index] < 65 || (int)wrd[index] > 122))
                    return false;
            }
            return true;
        }

        private bool isUrduNumbers(string wrd)
        {
            foreach (char ch in new char[10]
            {
                '۰',
                '۱',
                '۲',
                '۳',
                '۴',
                '۵',
                '۶',
                '۷',
                '۸',
                '۹'
            })
            {
                string str = ch.ToString();
                if (wrd.Contains(str))
                    return true;
            }
            return false;
        }

        private void tbSpellCheck_Click(object sender, EventArgs e)
        {
            this.LoadUrduDictionaryTXT();
            this.LoadEnglishDictionaryTXT();
            this.LoadCustomListsAll();
            this.SpellCheckUsingUrduDictionary();
        }

        private void urduCharacterListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUrduCharacterList().Show();
        }

        private void urduPhoneticLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUrduPhoneticLayout().Show();
        }

        private bool isGandaWord(int lclGetSelection)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = this.glbCurrentWrongWordsForUrduSpellCheck[this.tabControl1.SelectedTab.ImageIndex];
            for (int index = 1; index <= num3; ++index)
            {
                int imageIndex = this.tabControl1.SelectedTab.ImageIndex;
                try
                {
                    num1 = this.gandaWords[imageIndex, index].meraStart;
                    num2 = this.gandaWords[imageIndex, index].meraEnd;
                }
                catch
                {
                }
                if (lclGetSelection >= num1 && lclGetSelection <= num2)
                {
                    this.glbCurrentSelectedGandaText =
                        this.gandaWords[this.tabControl1.SelectedTab.ImageIndex, index].meraWord;
                    return true;
                }
            }
            return false;
        }

        private void mnuAdd2DictIsam_Click(object sender, EventArgs e)
        {
            this.AdditionToCustomList(CustomListType.Isam);
        }

        private void mnuAdd2DictFail_Click(object sender, EventArgs e)
        {
            this.AdditionToCustomList(CustomListType.Fale);
        }

        private void mnuAdd2DictNaMaloom_Click(object sender, EventArgs e)
        {
            this.AdditionToCustomList(CustomListType.NaMaloom);
        }

        private void manualDelete()
        {
            if (this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionLength > 0)
                return;
            int selectionStart = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionStart;
            if (selectionStart < 0)
                return;
            if (this.glbSelectedLanguage == Supported_Language.Urdu)
                this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Select(selectionStart, 1);
            else
                this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Select(selectionStart, 1);
        }

        private void LoadCustomListsAll()
        {
            string cPath = "";
            if (!Form1.glbIsCustomListsLoadedIsam)
            {
                Cursor.Current = Cursors.WaitCursor;
                if (this.getPathOfIsamFile(ref cPath))
                {
                    StreamReader streamReader = new StreamReader(cPath);
                    this.glbUrduCustomIlfaazIsam = streamReader.ReadToEnd();
                    Cursor.Current = Cursors.Default;
                    Form1.glbIsCustomListsLoadedIsam = true;
                    streamReader.Close();
                }
                else
                    System.IO.File.Create(cPath).Close();
            }
            if (!Form1.glbIsCustomListsLoadedFale)
            {
                Cursor.Current = Cursors.WaitCursor;
                if (this.getPathOfFaleFile(ref cPath))
                {
                    StreamReader streamReader = new StreamReader(cPath);
                    this.glbUrduCustomIlfaazFale = streamReader.ReadToEnd();
                    Cursor.Current = Cursors.Default;
                    Form1.glbIsCustomListsLoadedFale = true;
                    streamReader.Close();
                }
                else
                    System.IO.File.Create(cPath).Close();
            }
            if (Form1.glbIsCustomListsLoadedNamaloom)
                return;
            Cursor.Current = Cursors.WaitCursor;
            if (this.getPathOfNamaloomFile(ref cPath))
            {
                StreamReader streamReader = new StreamReader(cPath);
                this.glbUrduCustomIlfaazNamaloom = streamReader.ReadToEnd();
                Cursor.Current = Cursors.Default;
                Form1.glbIsCustomListsLoadedNamaloom = true;
                streamReader.Close();
            }
            else
                System.IO.File.Create(cPath).Close();
        }

        private bool AdditionToCustomList(CustomListType selection)
        {
            string str = "";
            if (selection == CustomListType.Isam)
                str = "Noun (اسم)";
            else if (selection == CustomListType.Fale)
                str = "Verb (فعل)";
            else if (selection == CustomListType.NaMaloom)
                str = "Unknown( نامعلوم )";
            if (
                MessageBox.Show("Add \" " + this.glbCurrentSelectedGandaText + " \" as " + str + " to dictionary ?",
                    "Addition to dictionary - لغت میں اندراج", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) !=
                DialogResult.Yes)
                return false;
            if (selection == CustomListType.Isam)
            {
                this.glbUrduCustomIlfaazIsam = this.glbUrduCustomIlfaazIsam + "\r\n" + this.glbCurrentSelectedGandaText;
                StreamWriter streamWriter = new StreamWriter("isam.txt", false, Encoding.Unicode);
                streamWriter.Write(this.glbUrduCustomIlfaazIsam);
                streamWriter.Close();
            }
            else if (selection == CustomListType.Fale)
            {
                this.glbUrduCustomIlfaazFale = this.glbUrduCustomIlfaazFale + "\r\n" + this.glbCurrentSelectedGandaText;
                StreamWriter streamWriter = new StreamWriter("fale.txt", false, Encoding.Unicode);
                streamWriter.Write(this.glbUrduCustomIlfaazFale);
                streamWriter.Close();
            }
            else if (selection == CustomListType.NaMaloom)
            {
                this.glbUrduCustomIlfaazNamaloom = this.glbUrduCustomIlfaazNamaloom + "\r\n" +
                                                   this.glbCurrentSelectedGandaText;
                StreamWriter streamWriter = new StreamWriter("namaloom.txt", false, Encoding.Unicode);
                streamWriter.Write(this.glbUrduCustomIlfaazNamaloom);
                streamWriter.Close();
            }
            this.tbSpellCheck_Click((object)null, (EventArgs)null);
            return true;
        }

        private void spellCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tbSpellCheck_Click((object)null, (EventArgs)null);
        }

        private void reverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text=ReverseText(this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text);
        }

        private void transliterateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text = TransliterateText(this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text);
        }

        private bool getWebAddress4FileSubmission(ref string strReturnedWebAddress)
        {
            string addressOfUploadAddress1 = Settings.Default.Url_1_For_Address_Of_UploadAddress;
            string addressOfUploadAddress2 = Settings.Default.Url_2_For_Address_Of_UploadAddress;
            if (Form1.FetchURL(addressOfUploadAddress1, "dummyname.txt", ref strReturnedWebAddress) ||
                Form1.FetchURL(addressOfUploadAddress2, "dummyname.txt", ref strReturnedWebAddress))
                return true;
            int num =
                (int)
                    MessageBox.Show("Unable to connect to server", "Error Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
            return false;
        }

        private void submitFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strReturnedWebAddress = "";
            if (!this.getWebAddress4FileSubmission(ref strReturnedWebAddress))
                return;
            string strReturnedHTML = "";
            if (Form1.FetchURL(strReturnedWebAddress, "dummyfile.txt", ref strReturnedHTML))
            {
                string cPath1 = "";
                if (this.getPathOfIsamFile(ref cPath1))
                    this.UploadFile(strReturnedWebAddress, cPath1);
                string cPath2 = "";
                if (this.getPathOfFaleFile(ref cPath2))
                    this.UploadFile(strReturnedWebAddress, cPath2);
                string cPath3 = "";
                if (this.getPathOfNamaloomFile(ref cPath3))
                    this.UploadFile(strReturnedWebAddress, cPath3);
                int num = (int)MessageBox.Show("Files uploading completed", "Thank You");
            }
            else
            {
                int num1 =
                    (int)
                        MessageBox.Show("Unable to connect to server for uploading files", "Unable to upload",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private static bool FetchURL(string url, string fileToSave, ref string strReturnedHTML)
        {
            Cursor.Current = Cursors.WaitCursor;
            bool flag = true;
            try
            {
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Proxy = WebRequest.DefaultWebProxy;
                webRequest.Proxy.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
                if (httpWebResponse.StatusCode == HttpStatusCode.OK)
                {
                    using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                    {
                        strReturnedHTML = streamReader.ReadToEnd();
                        streamReader.Close();
                    }
                }
                else
                    flag = false;
            }
            catch (Exception ex)
            {
                flag = false;
            }
            Cursor.Current = Cursors.Default;
            return flag;
        }

        private bool UploadFile(string url4Upload, string filePath)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("Content-Type", "text/plain");
                byte[] bytes = webClient.UploadFile(url4Upload, "POST", filePath);
                Encoding.UTF8.GetString(bytes, 0, bytes.Length);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {
        }

        private bool getPathOfIsamFile(ref string cPath)
        {
            cPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
            cPath = cPath + "\\isam.txt";
            cPath = cPath.Replace("file:\\", "");
            return System.IO.File.Exists(cPath);
        }

        private bool getPathOfFaleFile(ref string cPath)
        {
            cPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
            cPath = cPath + "\\fale.txt";
            cPath = cPath.Replace("file:\\", "");
            return System.IO.File.Exists(cPath);
        }

        private bool getPathOfNamaloomFile(ref string cPath)
        {
            cPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
            cPath = cPath + "\\namaloom.txt";
            cPath = cPath.Replace("file:\\", "");
            return System.IO.File.Exists(cPath);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectAll();
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionColor = Color.Black;
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].SelectionFont = new Font(this.glbfamily_name,
                this.glbfont_size);
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Select(0, 0);
        }

        private void tbRefresh_Click(object sender, EventArgs e)
        {
            this.refreshToolStripMenuItem_Click((object)null, (EventArgs)null);
        }

        private void mnuAutoAlignment_Click(object sender, EventArgs e)
        {
            if (!this.mnuAutoAlignment.Checked)
            {
                this.tbAlignLeft.Visible = false;
                this.tbAlignRight.Visible = false;
                this.tbStripAlign.Visible = false;
                this.mnuAutoAlignment.Checked = true;
            }
            else
            {
                this.tbAlignLeft.Visible = true;
                this.tbAlignRight.Visible = true;
                this.tbStripAlign.Visible = true;
                this.mnuAutoAlignment.Checked = false;
            }
            DirectIniFile.WriteProfileValue(Form1.strINI, "Format", "Auto Alignment",
                this.mnuAutoAlignment.Checked.ToString());
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
        }

        private void tbAlignLeft_Click(object sender, EventArgs e)
        {
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].RightToLeft = RightToLeft.No;
        }

        private void tbAlignRight_Click(object sender, EventArgs e)
        {
            this.txtbox[this.tabControl1.SelectedTab.ImageIndex].RightToLeft = RightToLeft.Yes;
        }


        private void tasveerBanao(string fPath)
        {
            Color black = Color.Black;
            Color white = Color.White;
            string familyName = this.glbfamily_name;
            int num1 = (int)this.glbfont_size;
            string text = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text;
            int height1 = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Height;
            int width1 = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Width;
            Size proposedSize = new Size();
            proposedSize.Width = width1;
            proposedSize.Height = height1;
            int height2 = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].GetPreferredSize(proposedSize).Height;
            int width2 = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].GetPreferredSize(proposedSize).Width;
            int height3 = height2;
            int width3 = width2;
            int x = -5;
            int y = 5;
            int num2 = -10;
            int num3 = 0;
            try
            {
                Bitmap bitmap = new Bitmap(width3, height3);
                Graphics graphics = Graphics.FromImage((Image)bitmap);
                Font font = new Font(familyName, (float)num1, FontStyle.Regular);
                SolidBrush solidBrush1 = new SolidBrush(black);
                SolidBrush solidBrush2 = new SolidBrush(white);
                Rectangle rectangle = new Rectangle(x, y, width3 + num2, height3 + num3);
                graphics.FillRectangle((Brush)solidBrush2, 0, 0, width3, height3);
                StringFormat format = (StringFormat)StringFormat.GenericTypographic.Clone();
                format.Alignment = StringAlignment.Far;
                format.LineAlignment = StringAlignment.Near;
                graphics.DrawString(text, font, (Brush)solidBrush1, (RectangleF)rectangle, format);
                bitmap.Save(fPath, ImageFormat.Gif);
            }
            catch (Exception ex)
            {
                int num4 = (int)MessageBox.Show(ex.Message);
            }
        }

        private void mnuExport_Click(object sender, EventArgs e)
        {
            //this.UrduNigarClassicExport("FileName");//delme
            //return;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = this.strFilter4Export;
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            if (this.IsReadOnly(saveFileDialog.FileName))
            {
                int num =
                    (int)
                        MessageBox.Show("The file is read-only. You cannot write to it.", Form1.strTitle,
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (saveFileDialog.FilterIndex == 2)
            {
                this.UrduNigarClassicExport(saveFileDialog.FileName);

            }
            else
            {
                this.tasveerBanao(saveFileDialog.FileName);
            }
        }

        public void UrduNigarClassicExport(string FileName)
        {

            string UnicodeText = this.txtbox[this.tabControl1.SelectedTab.ImageIndex].Text;
            string PhoneticText = ConvertUrduNigarUnicode2PhoneticText(UnicodeText);
            string UrduNigarClassicText = ConvertPhoneticText2UrduNigarClassicText(PhoneticText);

            //string forDebug = PhoneticText + "==============\n\r" + UrduNigarClassicText;

            StreamWriter streamWriter = new StreamWriter(FileName);


            string uncText = UrduNigarClassicText;
            try
            {
                //streamWriter.Write(uncText, true, Encoding.GetEncoding("Windows-1252"));
                streamWriter.Write(uncText);
            }
            catch (Exception e)
            {
                Debug.WriteLine(UrduNigarClassicText);
                MessageBox.Show("Unable to export to Urdu Nigar Classic format");
                MessageBox.Show(e.ToString());
            }
            streamWriter.Close();

        }

        private char previousChar;
        private char previousPreviousChar;

        private string ConvertPhoneticText2UrduNigarClassicText(string PhoneticText)
        {
            string p = "";
            char c;

            InitCharMap();

            byte[] arrayChar = new byte[PhoneticText.Length];

            for (int i = 0; i < PhoneticText.Length; i++)
            {

                p = PhoneticText.Substring(i, 1);
                c = p[0];
                if (c <= 255)
                {
                    if (i == 0)
                    {
                        //1st char will always be full
                        arrayChar[0] = g_cmChar[c].char1;
                    }
                    else
                    {
                        if (g_cmChar[previousChar].iType == 2 || g_cmChar[previousChar].iType == 5)
                        {
                            //if previous letter is end wala or space etc. then current char will be full

                            arrayChar[i] = g_cmChar[c].char1;
                        }
                        else
                        {
                            //previous is start character
                            //current is end character
                            if (g_cmChar[c].iType == 5)
                            {
                            }
                            else
                            {
                                if ((g_cmChar[previousPreviousChar].iType == 3 && g_cmChar[previousChar].iType == 3))
                                {
                                    arrayChar[i - 1] = g_cmChar[previousChar].char3;
                                }
                                else
                                {
                                    arrayChar[i - 1] = g_cmChar[previousChar].char2;
                                }
                            }
                            arrayChar[i] = g_cmChar[c].char4;
                        }
                    }

                    previousPreviousChar = previousChar;
                    previousChar = c;
                }

            }

            var str = Encoding.GetEncoding("Windows-1252").GetString(arrayChar);

            str = StringReverseAndNormalize(str);


            string newStr = str.Replace("B»", "Ü"); //for LamAlif
            string finalStr = newStr.Replace("B¼", "Ý"); //attached LamAlif


            return finalStr;

        }

        private string StringReverseAndNormalize(string instr)
        {

            string revstr = "";
            string fstr = "";

            for (int i = instr.Length - 1; i >= 0; i--)
            {
                fstr = instr.Substring(i, 1);
                if (fstr != "\0")
                {
                    revstr = revstr + fstr;
                }

            }

            return revstr;
        }


        public string ConvertUrduNigarUnicode2PhoneticText(string UrduUnicodeText)
        {

            string phoneticText = "";
            string s = "";
            string p = "";

            for (int i = 0; i < UrduUnicodeText.Length; i++)
            {

                s = UrduUnicodeText.Substring(i, 1);
                p = setUrduUnicode2Phonetic(s);

                phoneticText = phoneticText + p;

            }
            return phoneticText;

        }

        private bool showTipFile(string tPath)
        {
            string str =
                (Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\tips\\" + tPath).Replace
                    ("file:\\", "");
            if (System.IO.File.Exists(str))
            {
                Process.Start(str);
                return true;
            }
            int num = (int)MessageBox.Show("Help file not found");
            return false;
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.showTipFile("Usage_Of_CTRL+S.htm");
        }

        private void convertToImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.showTipFile("How_to_export_text_to_image.htm");
        }

        private void usageOfSpaceBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.showTipFile("Usage_Of_SpaceBar.htm");
        }

        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.showTipFile("Usage_Of_Alignment_Option.htm");
        }

        private void howToPrintTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.showTipFile("How_to_print_Text_of_UrduNigarUnicode.htm");
        }

        private void howToSpellCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.showTipFile("Usage_Of_SpellCheck.htm");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = (IContainer)new Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.toolStripMenuItem5AddToDictionary = new ToolStripMenuItem();
            this.mnuAdd2DictIsam = new ToolStripMenuItem();
            this.mnuAdd2DictFail = new ToolStripMenuItem();
            this.mnuAdd2DictNaMaloom = new ToolStripMenuItem();
            this.mnuUndo2 = new ToolStripMenuItem();
            this.mnuSep = new ToolStripSeparator();
            this.mnuCut2 = new ToolStripMenuItem();
            this.mnuCopy2 = new ToolStripMenuItem();
            this.mnuPaste2 = new ToolStripMenuItem();
            this.mnuDelete2 = new ToolStripMenuItem();
            this.toolStripSeparator14 = new ToolStripSeparator();
            this.mnuSelectAll2 = new ToolStripMenuItem();
            this.contextMenuStrip3 = new ContextMenuStrip(this.components);
            this.mnuCloseTab = new ToolStripMenuItem();
            this.mnuCloseOtherTabs = new ToolStripMenuItem();
            this.toolStripSeparator23 = new ToolStripSeparator();
            this.mnuSaveTab = new ToolStripMenuItem();
            this.mnuSaveAllTabs = new ToolStripMenuItem();
            this.toolStripSeparator24 = new ToolStripSeparator();
            this.mnuCopyFullPath = new ToolStripMenuItem();
            this.mnuOpenContainingFolder = new ToolStripMenuItem();
            this.autosave = new System.Windows.Forms.Timer(this.components);
            this.keystimer = new System.Windows.Forms.Timer(this.components);
            this.fontsWindowtimer = new System.Windows.Forms.Timer(this.components);
            this.lblautosave = new ToolStripStatusLabel();
            this.lblnumlock = new ToolStripStatusLabel();
            this.lblins = new ToolStripStatusLabel();
            this.lblcaps = new ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new ToolStripStatusLabel();
            this.lblline2 = new ToolStripStatusLabel();
            this.BottomToolStripPanel = new ToolStripPanel();
            this.TopToolStripPanel = new ToolStripPanel();
            this.RightToolStripPanel = new ToolStripPanel();
            this.LeftToolStripPanel = new ToolStripPanel();
            this.ContentPanel = new ToolStripContentPanel();
            this.sb = new StatusStrip();
            this.lblnewfileicon = new ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new ToolStripStatusLabel();
            this.lblline = new ToolStripStatusLabel();
            this.lblnum = new ToolStripStatusLabel();
            this.lblins2 = new ToolStripStatusLabel();
            this.lblcaps2 = new ToolStripStatusLabel();
            this.mnu = new MenuStrip();
            this.mnuFile = new ToolStripMenuItem();
            this.mnuNew = new ToolStripMenuItem();
            this.mnuOpen = new ToolStripMenuItem();
            this.mnuClose = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.mnuSave = new ToolStripMenuItem();
            this.mnuSaveAs = new ToolStripMenuItem();
            this.mnuSaveAll = new ToolStripMenuItem();
            this.mnuExport = new ToolStripMenuItem();
            this.mnuSep2 = new ToolStripSeparator();
            this.mnuPageSetup = new ToolStripMenuItem();
            this.mnuPrint = new ToolStripMenuItem();
            this.toolStripSeparator10 = new ToolStripSeparator();
            this.mnuSend = new ToolStripMenuItem();
            this.toolStripSeparator21 = new ToolStripSeparator();
            this.mnuRecentFiles = new ToolStripMenuItem();
            this.toolStripSeparator9 = new ToolStripSeparator();
            this.mnuProperties = new ToolStripMenuItem();
            this.mnuExit = new ToolStripMenuItem();
            this.mnuEdit = new ToolStripMenuItem();
            this.mnuUndo = new ToolStripMenuItem();
            this.toolStripSeparator5 = new ToolStripSeparator();
            this.mnuCut = new ToolStripMenuItem();
            this.mnuCopy = new ToolStripMenuItem();
            this.mnuPaste = new ToolStripMenuItem();
            this.mnuDelete = new ToolStripMenuItem();
            this.toolStripSeparator4 = new ToolStripSeparator();
            this.mnuFind = new ToolStripMenuItem();
            this.mnuFindNext = new ToolStripMenuItem();
            this.mnuReplace = new ToolStripMenuItem();
            this.mnuGoTo = new ToolStripMenuItem();
            this.toolStripSeparator16 = new ToolStripSeparator();
            this.mnuSelectAll = new ToolStripMenuItem();
            this.mnuTimeDate = new ToolStripMenuItem();
            this.mnuView = new ToolStripMenuItem();
            this.mnuStatusBar = new ToolStripMenuItem();
            this.refreshToolStripMenuItem = new ToolStripMenuItem();
            this.mnuFormat = new ToolStripMenuItem();
            this.mnuWordWrap = new ToolStripMenuItem();
            this.mnuAutoAlignment = new ToolStripMenuItem();
            this.mnuFont = new ToolStripMenuItem();
            this.mnuTools = new ToolStripMenuItem();
            this.mnuExternalTools = new ToolStripMenuItem();
            this.toolStripSeparator26 = new ToolStripSeparator();
            this.mnuWordCount = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.mnuOptions = new ToolStripMenuItem();
            this.spellCheckToolStripMenuItem = new ToolStripMenuItem();
            this.reverseToolStripMenuItem = new ToolStripMenuItem();
            this.transliterateToolStripMenuItem = new ToolStripMenuItem();
            this.mnuHelp = new ToolStripMenuItem();
            this.testingToolStripMenuItem = new ToolStripMenuItem();
            this.urduCharacterListToolStripMenuItem = new ToolStripMenuItem();
            this.urduPhoneticLayoutToolStripMenuItem = new ToolStripMenuItem();
            this.submitFilesToolStripMenuItem = new ToolStripMenuItem();
            this.mnuAbout = new ToolStripMenuItem();
            this.tipsToolStripMenuItem = new ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new ToolStripMenuItem();
            this.convertToImageToolStripMenuItem = new ToolStripMenuItem();
            this.tabControl1 = new TabControl();
            this.toolStripContainer1 = new ToolStripContainer();
            this.toolStrip1 = new ToolStrip();
            this.toolStripMenuItem1 = new ToolStripButton();
            this.toolStripMenuItem2 = new ToolStripButton();
            this.toolStripMenuItem3 = new ToolStripButton();
            this.toolStripMenuItem4 = new ToolStripButton();
            this.toolStripSeparator6 = new ToolStripSeparator();
            this.tbCut = new ToolStripButton();
            this.tbCopy = new ToolStripButton();
            this.tbPaste = new ToolStripButton();
            this.tbDelete = new ToolStripButton();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this.tbUndo = new ToolStripButton();
            this.toolStripSeparator7 = new ToolStripSeparator();
            this.tbAlignLeft = new ToolStripButton();
            this.tbAlignRight = new ToolStripButton();
            this.tbStripAlign = new ToolStripSeparator();
            this.tbSpellCheck = new ToolStripButton();
            this.tbRefresh = new ToolStripButton();
            this.toolStripComboBox1 = new ToolStripComboBox();
            this.toolStripComboBox2 = new ToolStripComboBox();
            this.usageOfSpaceBarToolStripMenuItem = new ToolStripMenuItem();
            this.UsageOfAlignmentOptionToolStripMenuItem = new ToolStripMenuItem();
            this.howToPrintTextToolStripMenuItem = new ToolStripMenuItem();
            this.howToSpellCheckToolStripMenuItem = new ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.sb.SuspendLayout();
            this.mnu.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[9]
            {
                (ToolStripItem) this.toolStripMenuItem5AddToDictionary,
                (ToolStripItem) this.mnuUndo2,
                (ToolStripItem) this.mnuSep,
                (ToolStripItem) this.mnuCut2,
                (ToolStripItem) this.mnuCopy2,
                (ToolStripItem) this.mnuPaste2,
                (ToolStripItem) this.mnuDelete2,
                (ToolStripItem) this.toolStripSeparator14,
                (ToolStripItem) this.mnuSelectAll2
            });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(210, 198);
            this.toolStripMenuItem5AddToDictionary.DropDownItems.AddRange(new ToolStripItem[3]
            {
                (ToolStripItem) this.mnuAdd2DictIsam,
                (ToolStripItem) this.mnuAdd2DictFail,
                (ToolStripItem) this.mnuAdd2DictNaMaloom
            });
            this.toolStripMenuItem5AddToDictionary.Name = "toolStripMenuItem5AddToDictionary";
            this.toolStripMenuItem5AddToDictionary.Size = new Size(209, 26);
            this.toolStripMenuItem5AddToDictionary.Text = "Add to Dictionary";
            this.mnuAdd2DictIsam.Name = "mnuAdd2DictIsam";
            this.mnuAdd2DictIsam.Size = new Size(229, 26);
            this.mnuAdd2DictIsam.Text = "Noun - اسم";
            this.mnuAdd2DictIsam.Click += new EventHandler(this.mnuAdd2DictIsam_Click);
            this.mnuAdd2DictFail.Name = "mnuAdd2DictFail";
            this.mnuAdd2DictFail.Size = new Size(229, 26);
            this.mnuAdd2DictFail.Text = "Verb - فعل";
            this.mnuAdd2DictFail.Click += new EventHandler(this.mnuAdd2DictFail_Click);
            this.mnuAdd2DictNaMaloom.Name = "mnuAdd2DictNaMaloom";
            this.mnuAdd2DictNaMaloom.Size = new Size(229, 26);
            this.mnuAdd2DictNaMaloom.Text = "(Unknown - نامعلوم)";
            this.mnuAdd2DictNaMaloom.Click += new EventHandler(this.mnuAdd2DictNaMaloom_Click);
            this.mnuUndo2.Image = (Image)componentResourceManager.GetObject("mnuUndo2.Image");
            this.mnuUndo2.ImageTransparentColor = Color.Magenta;
            this.mnuUndo2.Name = "mnuUndo2";
            this.mnuUndo2.Size = new Size(209, 26);
            this.mnuUndo2.Text = "Undo";
            this.mnuUndo2.Click += new EventHandler(this.mnuUndo_Click);
            this.mnuSep.Name = "mnuSep";
            this.mnuSep.Size = new Size(206, 6);
            this.mnuCut2.Image = (Image)componentResourceManager.GetObject("mnuCut2.Image");
            this.mnuCut2.ImageTransparentColor = Color.Magenta;
            this.mnuCut2.Name = "mnuCut2";
            this.mnuCut2.Size = new Size(209, 26);
            this.mnuCut2.Text = "Cut";
            this.mnuCut2.Click += new EventHandler(this.mnuCut_Click);
            this.mnuCopy2.Image = (Image)componentResourceManager.GetObject("mnuCopy2.Image");
            this.mnuCopy2.ImageTransparentColor = Color.Magenta;
            this.mnuCopy2.Name = "mnuCopy2";
            this.mnuCopy2.Size = new Size(209, 26);
            this.mnuCopy2.Text = "Copy";
            this.mnuCopy2.Click += new EventHandler(this.mnuCopy_Click);
            this.mnuPaste2.Image = (Image)componentResourceManager.GetObject("mnuPaste2.Image");
            this.mnuPaste2.ImageTransparentColor = Color.Magenta;
            this.mnuPaste2.Name = "mnuPaste2";
            this.mnuPaste2.Size = new Size(209, 26);
            this.mnuPaste2.Text = "Paste";
            this.mnuPaste2.Click += new EventHandler(this.mnuPaste_Click);
            this.mnuDelete2.Image = (Image)componentResourceManager.GetObject("mnuDelete2.Image");
            this.mnuDelete2.ImageTransparentColor = Color.Magenta;
            this.mnuDelete2.Name = "mnuDelete2";
            this.mnuDelete2.Size = new Size(209, 26);
            this.mnuDelete2.Text = "Delete";
            this.mnuDelete2.Click += new EventHandler(this.mnuDelete_Click);
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new Size(206, 6);
            this.mnuSelectAll2.Name = "mnuSelectAll2";
            this.mnuSelectAll2.Size = new Size(209, 26);
            this.mnuSelectAll2.Text = "Select All";
            this.mnuSelectAll2.Click += new EventHandler(this.mnuSelectAll_Click);
            this.contextMenuStrip3.Items.AddRange(new ToolStripItem[8]
            {
                (ToolStripItem) this.mnuCloseTab,
                (ToolStripItem) this.mnuCloseOtherTabs,
                (ToolStripItem) this.toolStripSeparator23,
                (ToolStripItem) this.mnuSaveTab,
                (ToolStripItem) this.mnuSaveAllTabs,
                (ToolStripItem) this.toolStripSeparator24,
                (ToolStripItem) this.mnuCopyFullPath,
                (ToolStripItem) this.mnuOpenContainingFolder
            });
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new Size(254, 172);
            this.contextMenuStrip3.Opened += new EventHandler(this.contextMenuStrip3_Opened);
            this.contextMenuStrip3.Opening += new CancelEventHandler(this.contextMenuStrip3_Opening);
            this.mnuCloseTab.Name = "mnuCloseTab";
            this.mnuCloseTab.Size = new Size(253, 26);
            this.mnuCloseTab.Text = "Close";
            this.mnuCloseTab.Click += new EventHandler(this.mnuCloseTab_Click);
            this.mnuCloseOtherTabs.Name = "mnuCloseOtherTabs";
            this.mnuCloseOtherTabs.Size = new Size(253, 26);
            this.mnuCloseOtherTabs.Text = "Close Other Tabs";
            this.mnuCloseOtherTabs.Click += new EventHandler(this.mnuCloseOtherTabs_Click);
            this.toolStripSeparator23.Name = "toolStripSeparator23";
            this.toolStripSeparator23.Size = new Size(250, 6);
            this.mnuSaveTab.Image = (Image)componentResourceManager.GetObject("mnuSaveTab.Image");
            this.mnuSaveTab.ImageTransparentColor = Color.Magenta;
            this.mnuSaveTab.Name = "mnuSaveTab";
            this.mnuSaveTab.Size = new Size(253, 26);
            this.mnuSaveTab.Text = "Save";
            this.mnuSaveTab.Click += new EventHandler(this.mnuSaveTab_Click);
            this.mnuSaveAllTabs.Image = (Image)componentResourceManager.GetObject("mnuSaveAllTabs.Image");
            this.mnuSaveAllTabs.ImageTransparentColor = Color.Magenta;
            this.mnuSaveAllTabs.Name = "mnuSaveAllTabs";
            this.mnuSaveAllTabs.Size = new Size(253, 26);
            this.mnuSaveAllTabs.Text = "Save All";
            this.mnuSaveAllTabs.Click += new EventHandler(this.mnuSaveAllTabs_Click);
            this.toolStripSeparator24.Name = "toolStripSeparator24";
            this.toolStripSeparator24.Size = new Size(250, 6);
            this.mnuCopyFullPath.Name = "mnuCopyFullPath";
            this.mnuCopyFullPath.Size = new Size(253, 26);
            this.mnuCopyFullPath.Text = "Copy Full Path";
            this.mnuCopyFullPath.Click += new EventHandler(this.mnuCopyFullPath_Click);
            this.mnuOpenContainingFolder.Name = "mnuOpenContainingFolder";
            this.mnuOpenContainingFolder.Size = new Size(253, 26);
            this.mnuOpenContainingFolder.Text = "Open Containing Folder";
            this.mnuOpenContainingFolder.Click += new EventHandler(this.mnuOpenContainingFolder_Click);
            this.autosave.Tick += new EventHandler(this.autosave_Tick);
            this.keystimer.Enabled = false;
            this.keystimer.Tick += new EventHandler(this.timer1_Tick);
            this.fontsWindowtimer.Tick += new EventHandler(this.timer2_Tick);
            this.lblautosave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.lblautosave.Name = "lblautosave";
            this.lblautosave.Size = new Size(572, 17);
            this.lblautosave.Spring = true;
            this.lblautosave.TextAlign = ContentAlignment.MiddleLeft;
            this.lblnumlock.Name = "lblnumlock";
            this.lblnumlock.Size = new Size(32, 17);
            this.lblnumlock.Text = "NUM ";
            this.lblins.Name = "lblins";
            this.lblins.Size = new Size(27, 17);
            this.lblins.Text = "INS ";
            this.lblcaps.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.lblcaps.Name = "lblcaps";
            this.lblcaps.Size = new Size(36, 17);
            this.lblcaps.Text = "CAPS ";
            this.lblcaps.TextAlign = ContentAlignment.MiddleRight;
            this.toolStripStatusLabel1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new Size(572, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new Size(32, 17);
            this.toolStripStatusLabel2.Text = "NUM ";
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new Size(27, 17);
            this.toolStripStatusLabel3.Text = "INS ";
            this.toolStripStatusLabel4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new Size(36, 17);
            this.toolStripStatusLabel4.Text = "CAPS ";
            this.toolStripStatusLabel4.TextAlign = ContentAlignment.MiddleRight;
            this.toolStripStatusLabel5.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new Size(0, 17);
            this.toolStripStatusLabel5.TextAlign = ContentAlignment.MiddleRight;
            this.lblline2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.lblline2.Name = "lblline2";
            this.lblline2.Size = new Size(10, 17);
            this.lblline2.Text = " ";
            this.BottomToolStripPanel.Location = new Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new Size(0, 0);
            this.TopToolStripPanel.Location = new Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = Orientation.Horizontal;
            this.TopToolStripPanel.RenderMode = ToolStripRenderMode.Professional;
            this.TopToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new Size(0, 0);
            this.RightToolStripPanel.Location = new Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new Size(0, 0);
            this.LeftToolStripPanel.Location = new Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new Size(0, 0);
            this.ContentPanel.BackColor = SystemColors.Control;
            this.ContentPanel.Size = new Size(697, 474);
            this.sb.Dock = DockStyle.None;
            this.sb.GripStyle = ToolStripGripStyle.Visible;
            this.sb.Items.AddRange(new ToolStripItem[6]
            {
                (ToolStripItem) this.lblnewfileicon,
                (ToolStripItem) this.toolStripStatusLabel6,
                (ToolStripItem) this.lblline,
                (ToolStripItem) this.lblnum,
                (ToolStripItem) this.lblins2,
                (ToolStripItem) this.lblcaps2
            });
            this.sb.Location = new Point(0, 0);
            this.sb.Name = "sb";
            this.sb.Size = new Size(695, 26);
            this.sb.TabIndex = 3;
            this.lblnewfileicon.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.lblnewfileicon.Name = "lblnewfileicon";
            this.lblnewfileicon.Size = new Size(0, 21);
            this.toolStripStatusLabel6.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new Size(530, 21);
            this.toolStripStatusLabel6.Spring = true;
            this.toolStripStatusLabel6.TextAlign = ContentAlignment.MiddleLeft;
            this.lblline.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.lblline.Name = "lblline";
            this.lblline.Size = new Size(0, 21);
            this.lblline.TextAlign = ContentAlignment.MiddleRight;
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new Size(50, 21);
            this.lblnum.Text = "NUM ";
            this.lblins2.Name = "lblins2";
            this.lblins2.Size = new Size(41, 21);
            this.lblins2.Text = "INS ";
            this.lblcaps2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.lblcaps2.Name = "lblcaps2";
            this.lblcaps2.Size = new Size(59, 21);
            this.lblcaps2.Text = "CAPS  ";
            this.lblcaps2.TextAlign = ContentAlignment.MiddleRight;
            this.mnu.Dock = DockStyle.None;
            this.mnu.Items.AddRange(new ToolStripItem[6]
            {
                (ToolStripItem) this.mnuFile,
                (ToolStripItem) this.mnuEdit,
                (ToolStripItem) this.mnuView,
                (ToolStripItem) this.mnuFormat,
                (ToolStripItem) this.mnuTools,
                (ToolStripItem) this.mnuHelp
            });
            this.mnu.Location = new Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.RenderMode = ToolStripRenderMode.Professional;
            this.mnu.Size = new Size(695, 29);
            this.mnu.TabIndex = 1;
            this.mnuFile.DropDownItems.AddRange(new ToolStripItem[18]
            {
                (ToolStripItem) this.mnuNew,
                (ToolStripItem) this.mnuOpen,
                (ToolStripItem) this.mnuClose,
                (ToolStripItem) this.toolStripSeparator2,
                (ToolStripItem) this.mnuSave,
                (ToolStripItem) this.mnuSaveAs,
                (ToolStripItem) this.mnuSaveAll,
                (ToolStripItem) this.mnuExport,
                (ToolStripItem) this.mnuSep2,
                (ToolStripItem) this.mnuPageSetup,
                (ToolStripItem) this.mnuPrint,
                (ToolStripItem) this.toolStripSeparator10,
                (ToolStripItem) this.mnuSend,
                (ToolStripItem) this.toolStripSeparator21,
                (ToolStripItem) this.mnuRecentFiles,
                (ToolStripItem) this.toolStripSeparator9,
                (ToolStripItem) this.mnuProperties,
                (ToolStripItem) this.mnuExit
            });
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new Size(48, 25);
            this.mnuFile.Text = "File";
            this.mnuFile.DropDownOpening += new EventHandler(this.mnuFile_DropDownOpening);
            this.mnuNew.Image = (Image)componentResourceManager.GetObject("mnuNew.Image");
            this.mnuNew.ImageTransparentColor = Color.Magenta;
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.ShortcutKeys = Keys.N | Keys.Control;
            this.mnuNew.Size = new Size(194, 26);
            this.mnuNew.Text = "New...";
            this.mnuNew.Click += new EventHandler(this.tbNew_Click);
            this.mnuOpen.Image = (Image)componentResourceManager.GetObject("mnuOpen.Image");
            this.mnuOpen.ImageTransparentColor = Color.Magenta;
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.ShortcutKeys = Keys.O | Keys.Control;
            this.mnuOpen.Size = new Size(194, 26);
            this.mnuOpen.Text = "Open...";
            this.mnuOpen.Click += new EventHandler(this.mnuOpen_Click);
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new Size(194, 26);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new EventHandler(this.mnuClose_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(191, 6);
            this.mnuSave.Image = (Image)componentResourceManager.GetObject("mnuSave.Image");
            this.mnuSave.ImageTransparentColor = Color.Magenta;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = Keys.S | Keys.Control;
            this.mnuSave.Size = new Size(194, 26);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new EventHandler(this.mnuSave_Click);
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.Size = new Size(194, 26);
            this.mnuSaveAs.Text = "Save As...";
            this.mnuSaveAs.Click += new EventHandler(this.mnuSaveAs_Click);
            this.mnuSaveAll.Image = (Image)componentResourceManager.GetObject("mnuSaveAll.Image");
            this.mnuSaveAll.ImageTransparentColor = Color.Magenta;
            this.mnuSaveAll.Name = "mnuSaveAll";
            this.mnuSaveAll.Size = new Size(194, 26);
            this.mnuSaveAll.Text = "Save All";
            this.mnuSaveAll.Click += new EventHandler(this.mnuSaveAll_Click);
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.Size = new Size(194, 26);
            this.mnuExport.Text = "Export...";
            this.mnuExport.Click += new EventHandler(this.mnuExport_Click);
            this.mnuSep2.Name = "mnuSep2";
            this.mnuSep2.Size = new Size(191, 6);
            this.mnuPageSetup.Image = (Image)componentResourceManager.GetObject("mnuPageSetup.Image");
            this.mnuPageSetup.ImageTransparentColor = Color.Magenta;
            this.mnuPageSetup.Name = "mnuPageSetup";
            this.mnuPageSetup.Size = new Size(194, 26);
            this.mnuPageSetup.Text = "Page Setup...";
            this.mnuPageSetup.Click += new EventHandler(this.mnuPageSetup_Click);
            this.mnuPrint.Image = (Image)componentResourceManager.GetObject("mnuPrint.Image");
            this.mnuPrint.ImageTransparentColor = Color.Magenta;
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.ShortcutKeys = Keys.P | Keys.Control;
            this.mnuPrint.Size = new Size(194, 26);
            this.mnuPrint.Text = "Print...";
            this.mnuPrint.Click += new EventHandler(this.mnuPrint_Click);
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new Size(191, 6);
            this.mnuSend.Image = (Image)componentResourceManager.GetObject("mnuSend.Image");
            this.mnuSend.ImageTransparentColor = Color.Magenta;
            this.mnuSend.Name = "mnuSend";
            this.mnuSend.Size = new Size(194, 26);
            this.mnuSend.Text = "Send";
            this.mnuSend.Click += new EventHandler(this.mnuSend_Click);
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new Size(191, 6);
            this.mnuRecentFiles.Name = "mnuRecentFiles";
            this.mnuRecentFiles.Size = new Size(194, 26);
            this.mnuRecentFiles.Text = "Recent Files";
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new Size(191, 6);
            this.mnuProperties.Image = (Image)componentResourceManager.GetObject("mnuProperties.Image");
            this.mnuProperties.ImageTransparentColor = Color.Magenta;
            this.mnuProperties.Name = "mnuProperties";
            this.mnuProperties.Size = new Size(194, 26);
            this.mnuProperties.Text = "Properties";
            this.mnuProperties.Click += new EventHandler(this.mnuProperties_Click);
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new Size(194, 26);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new EventHandler(this.mnuExit_Click);
            this.mnuEdit.DropDownItems.AddRange(new ToolStripItem[14]
            {
                (ToolStripItem) this.mnuUndo,
                (ToolStripItem) this.toolStripSeparator5,
                (ToolStripItem) this.mnuCut,
                (ToolStripItem) this.mnuCopy,
                (ToolStripItem) this.mnuPaste,
                (ToolStripItem) this.mnuDelete,
                (ToolStripItem) this.toolStripSeparator4,
                (ToolStripItem) this.mnuFind,
                (ToolStripItem) this.mnuFindNext,
                (ToolStripItem) this.mnuReplace,
                (ToolStripItem) this.mnuGoTo,
                (ToolStripItem) this.toolStripSeparator16,
                (ToolStripItem) this.mnuSelectAll,
                (ToolStripItem) this.mnuTimeDate
            });
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new Size(51, 25);
            this.mnuEdit.Text = "Edit";
            this.mnuEdit.DropDownOpening += new EventHandler(this.mnuEdit_DropDownOpening);
            this.mnuUndo.Image = (Image)componentResourceManager.GetObject("mnuUndo.Image");
            this.mnuUndo.ImageTransparentColor = Color.Magenta;
            this.mnuUndo.Name = "mnuUndo";
            this.mnuUndo.ShortcutKeys = Keys.Z | Keys.Control;
            this.mnuUndo.Size = new Size(213, 26);
            this.mnuUndo.Text = "Undo";
            this.mnuUndo.Click += new EventHandler(this.mnuUndo_Click);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new Size(210, 6);
            this.mnuCut.Image = (Image)componentResourceManager.GetObject("mnuCut.Image");
            this.mnuCut.ImageTransparentColor = Color.Magenta;
            this.mnuCut.Name = "mnuCut";
            this.mnuCut.ShortcutKeys = Keys.X | Keys.Control;
            this.mnuCut.Size = new Size(213, 26);
            this.mnuCut.Text = "Cut";
            this.mnuCut.Click += new EventHandler(this.mnuCut_Click);
            this.mnuCopy.Image = (Image)componentResourceManager.GetObject("mnuCopy.Image");
            this.mnuCopy.ImageTransparentColor = Color.Magenta;
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.ShortcutKeys = Keys.C | Keys.Control;
            this.mnuCopy.Size = new Size(213, 26);
            this.mnuCopy.Text = "Copy";
            this.mnuCopy.Click += new EventHandler(this.mnuCopy_Click);
            this.mnuPaste.Image = (Image)componentResourceManager.GetObject("mnuPaste.Image");
            this.mnuPaste.ImageTransparentColor = Color.Magenta;
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.ShortcutKeys = Keys.V | Keys.Control;
            this.mnuPaste.Size = new Size(213, 26);
            this.mnuPaste.Text = "Paste";
            this.mnuPaste.Click += new EventHandler(this.mnuPaste_Click);
            this.mnuDelete.Image = (Image)componentResourceManager.GetObject("mnuDelete.Image");
            this.mnuDelete.ImageTransparentColor = Color.Magenta;
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.ShortcutKeys = Keys.Delete;
            this.mnuDelete.Size = new Size(213, 26);
            this.mnuDelete.Text = "Delete";
            this.mnuDelete.Click += new EventHandler(this.mnuDelete_Click);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new Size(210, 6);
            this.mnuFind.Image = (Image)componentResourceManager.GetObject("mnuFind.Image");
            this.mnuFind.ImageTransparentColor = Color.Magenta;
            this.mnuFind.Name = "mnuFind";
            this.mnuFind.ShortcutKeys = Keys.F | Keys.Control;
            this.mnuFind.Size = new Size(213, 26);
            this.mnuFind.Text = "Find...";
            this.mnuFind.Click += new EventHandler(this.mnuFind_Click);
            this.mnuFindNext.Image = (Image)componentResourceManager.GetObject("mnuFindNext.Image");
            this.mnuFindNext.ImageTransparentColor = Color.Magenta;
            this.mnuFindNext.Name = "mnuFindNext";
            this.mnuFindNext.ShortcutKeys = Keys.F3;
            this.mnuFindNext.Size = new Size(213, 26);
            this.mnuFindNext.Text = "Find Next";
            this.mnuFindNext.Click += new EventHandler(this.mnuFindNext_Click);
            this.mnuReplace.Name = "mnuReplace";
            this.mnuReplace.ShortcutKeys = Keys.H | Keys.Control;
            this.mnuReplace.Size = new Size(213, 26);
            this.mnuReplace.Text = "Replace...";
            this.mnuReplace.Click += new EventHandler(this.mnuReplace_Click);
            this.mnuGoTo.Image = (Image)componentResourceManager.GetObject("mnuGoTo.Image");
            this.mnuGoTo.ImageTransparentColor = Color.Magenta;
            this.mnuGoTo.Name = "mnuGoTo";
            this.mnuGoTo.ShortcutKeys = Keys.G | Keys.Control;
            this.mnuGoTo.Size = new Size(213, 26);
            this.mnuGoTo.Text = "Go To...";
            this.mnuGoTo.Click += new EventHandler(this.mnuGoTo_Click);
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new Size(210, 6);
            this.mnuSelectAll.Name = "mnuSelectAll";
            this.mnuSelectAll.ShortcutKeys = Keys.A | Keys.Control;
            this.mnuSelectAll.Size = new Size(213, 26);
            this.mnuSelectAll.Text = "Select All";
            this.mnuSelectAll.Click += new EventHandler(this.mnuSelectAll_Click);
            this.mnuTimeDate.Name = "mnuTimeDate";
            this.mnuTimeDate.ShortcutKeys = Keys.F5;
            this.mnuTimeDate.Size = new Size(213, 26);
            this.mnuTimeDate.Text = "Time/Date";
            this.mnuTimeDate.Click += new EventHandler(this.mnuTimeDate_Click);
            this.mnuView.DropDownItems.AddRange(new ToolStripItem[2]
            {
                (ToolStripItem) this.mnuStatusBar,
                (ToolStripItem) this.refreshToolStripMenuItem
            });
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new Size(58, 25);
            this.mnuView.Text = "View";
            this.mnuStatusBar.Name = "mnuStatusBar";
            this.mnuStatusBar.Size = new Size(157, 26);
            this.mnuStatusBar.Text = "Status Bar";
            this.mnuStatusBar.Click += new EventHandler(this.mnuStatusBar_Click);
            this.refreshToolStripMenuItem.Image =
                (Image)componentResourceManager.GetObject("refreshToolStripMenuItem.Image");
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new Size(157, 26);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new EventHandler(this.refreshToolStripMenuItem_Click);
            this.mnuFormat.DropDownItems.AddRange(new ToolStripItem[3]
            {
                (ToolStripItem) this.mnuWordWrap,
                (ToolStripItem) this.mnuAutoAlignment,
                (ToolStripItem) this.mnuFont
            });
            this.mnuFormat.Name = "mnuFormat";
            this.mnuFormat.Size = new Size(75, 25);
            this.mnuFormat.Text = "Format";
            this.mnuFormat.DropDownOpening += new EventHandler(this.mnuFormat_DropDownOpening);
            this.mnuWordWrap.Name = "mnuWordWrap";
            this.mnuWordWrap.Size = new Size(195, 26);
            this.mnuWordWrap.Text = "Word Wrap";
            this.mnuWordWrap.Click += new EventHandler(this.mnuWordWrap_Click);
            this.mnuAutoAlignment.Name = "mnuAutoAlignment";
            this.mnuAutoAlignment.Size = new Size(195, 26);
            this.mnuAutoAlignment.Text = "Auto Alignment";
            this.mnuAutoAlignment.Click += new EventHandler(this.mnuAutoAlignment_Click);
            this.mnuFont.Image = (Image)componentResourceManager.GetObject("mnuFont.Image");
            this.mnuFont.ImageTransparentColor = Color.Magenta;
            this.mnuFont.Name = "mnuFont";
            this.mnuFont.Size = new Size(195, 26);
            this.mnuFont.Text = "Font...";
            this.mnuFont.Click += new EventHandler(this.mnuFont_Click);
            this.mnuTools.DropDownItems.AddRange(new ToolStripItem[8]
            {
                (ToolStripItem) this.mnuExternalTools,
                (ToolStripItem) this.toolStripSeparator26,
                (ToolStripItem) this.mnuWordCount,
                (ToolStripItem) this.toolStripSeparator1,
                (ToolStripItem) this.mnuOptions,
                (ToolStripItem) this.spellCheckToolStripMenuItem,
                (ToolStripItem) this.reverseToolStripMenuItem,
                (ToolStripItem) this.transliterateToolStripMenuItem
            });
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new Size(62, 25);
            this.mnuTools.Text = "Tools";
            this.mnuTools.DropDownOpening += new EventHandler(this.mnuTools_DropDownOpening);
            this.mnuExternalTools.Name = "mnuExternalTools";
            this.mnuExternalTools.Size = new Size(186, 26);
            this.mnuExternalTools.Text = "External Tools";
            this.toolStripSeparator26.Name = "toolStripSeparator26";
            this.toolStripSeparator26.Size = new Size(183, 6);
            this.mnuWordCount.Name = "mnuWordCount";
            this.mnuWordCount.Size = new Size(186, 26);
            this.mnuWordCount.Text = "Word Count...";
            this.mnuWordCount.Click += new EventHandler(this.mnuWordCount_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(183, 6);
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new Size(186, 26);
            this.mnuOptions.Text = "Options...";
            this.mnuOptions.Click += new EventHandler(this.mnuOptions_Click);
            this.spellCheckToolStripMenuItem.Image =
                (Image)componentResourceManager.GetObject("spellCheckToolStripMenuItem.Image");
            this.spellCheckToolStripMenuItem.Name = "spellCheckToolStripMenuItem";
            this.spellCheckToolStripMenuItem.Size = new Size(186, 26);
            this.spellCheckToolStripMenuItem.Text = "Spell Check";
            this.spellCheckToolStripMenuItem.Click += new EventHandler(this.spellCheckToolStripMenuItem_Click);
            this.reverseToolStripMenuItem.Name = "reverseToolStripMenuItem";
            this.reverseToolStripMenuItem.Size = new Size(186, 26);
            this.reverseToolStripMenuItem.Text = "Reverse Text";
            this.reverseToolStripMenuItem.Click += new EventHandler(this.reverseToolStripMenuItem_Click);
            this.transliterateToolStripMenuItem.Name = "transliterateToolStripMenuItem";
            this.transliterateToolStripMenuItem.Size = new Size(186, 26);
            this.transliterateToolStripMenuItem.Text = "Transliterate Text";
            this.transliterateToolStripMenuItem.Click += new EventHandler(this.transliterateToolStripMenuItem_Click);
            this.mnuHelp.DropDownItems.AddRange(new ToolStripItem[4]
            {
                (ToolStripItem) this.tipsToolStripMenuItem,
                (ToolStripItem) this.testingToolStripMenuItem,
                (ToolStripItem) this.submitFilesToolStripMenuItem,
                (ToolStripItem) this.mnuAbout
            });
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new Size(55, 25);
            this.mnuHelp.Text = "Help";
            this.testingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
            {
                (ToolStripItem) this.urduCharacterListToolStripMenuItem,
                (ToolStripItem) this.urduPhoneticLayoutToolStripMenuItem
            });
            this.testingToolStripMenuItem.Name = "testingToolStripMenuItem";
            this.testingToolStripMenuItem.Size = new Size(203, 26);
            this.testingToolStripMenuItem.Text = "Keyboard Layout";
            this.testingToolStripMenuItem.Click += new EventHandler(this.testingToolStripMenuItem_Click);
            this.urduCharacterListToolStripMenuItem.Name = "urduCharacterListToolStripMenuItem";
            this.urduCharacterListToolStripMenuItem.Size = new Size(237, 26);
            this.urduCharacterListToolStripMenuItem.Text = "Urdu Character List";
            this.urduCharacterListToolStripMenuItem.Click +=
                new EventHandler(this.urduCharacterListToolStripMenuItem_Click);
            this.urduPhoneticLayoutToolStripMenuItem.Name = "urduPhoneticLayoutToolStripMenuItem";
            this.urduPhoneticLayoutToolStripMenuItem.Size = new Size(237, 26);
            this.urduPhoneticLayoutToolStripMenuItem.Text = "Urdu Phonetic Layout";
            this.urduPhoneticLayoutToolStripMenuItem.Click +=
                new EventHandler(this.urduPhoneticLayoutToolStripMenuItem_Click);
            this.submitFilesToolStripMenuItem.Name = "submitFilesToolStripMenuItem";
            this.submitFilesToolStripMenuItem.Size = new Size(203, 26);
            this.submitFilesToolStripMenuItem.Text = "Submit Files...";
            this.submitFilesToolStripMenuItem.Click += new EventHandler(this.submitFilesToolStripMenuItem_Click);
            this.mnuAbout.ImageTransparentColor = Color.Transparent;
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new Size(203, 26);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new EventHandler(this.mnuAbout_Click);
            this.tipsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[6]
            {
                (ToolStripItem) this.saveFileToolStripMenuItem,
                (ToolStripItem) this.usageOfSpaceBarToolStripMenuItem,
                (ToolStripItem) this.UsageOfAlignmentOptionToolStripMenuItem,
                (ToolStripItem) this.howToPrintTextToolStripMenuItem,
                (ToolStripItem) this.convertToImageToolStripMenuItem,
                (ToolStripItem) this.howToSpellCheckToolStripMenuItem
            });
            this.tipsToolStripMenuItem.Name = "tipsToolStripMenuItem";
            this.tipsToolStripMenuItem.Size = new Size(203, 26);
            this.tipsToolStripMenuItem.Text = "Tips";
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new Size(279, 26);
            this.saveFileToolStripMenuItem.Text = "Save File (CTRL + S)";
            this.saveFileToolStripMenuItem.Click += new EventHandler(this.saveFileToolStripMenuItem_Click);
            this.convertToImageToolStripMenuItem.Name = "convertToImageToolStripMenuItem";
            this.convertToImageToolStripMenuItem.Size = new Size(279, 26);
            this.convertToImageToolStripMenuItem.Text = "How to Convert to Image";
            this.convertToImageToolStripMenuItem.Click += new EventHandler(this.convertToImageToolStripMenuItem_Click);
            this.tabControl1.ContextMenuStrip = this.contextMenuStrip3;
            this.tabControl1.Dock = DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new Size(695, 499);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new EventHandler(this.tabControl1_SelectedIndexChanged);
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add((Control)this.sb);
            this.toolStripContainer1.ContentPanel.Controls.Add((Control)this.tabControl1);
            this.toolStripContainer1.ContentPanel.Size = new Size(695, 499);
            this.toolStripContainer1.Dock = DockStyle.Fill;
            this.toolStripContainer1.Location = new Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new Size(695, 583);
            this.toolStripContainer1.TabIndex = 5;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanel.Controls.Add((Control)this.mnu);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add((Control)this.toolStrip1);
            this.toolStripContainer1.TopToolStripPanel.Click +=
                new EventHandler(this.toolStripContainer1_TopToolStripPanel_Click);
            this.toolStrip1.Dock = DockStyle.None;
            this.toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new ToolStripItem[19]
            {
                (ToolStripItem) this.toolStripMenuItem1,
                (ToolStripItem) this.toolStripMenuItem2,
                (ToolStripItem) this.toolStripMenuItem3,
                (ToolStripItem) this.toolStripMenuItem4,
                (ToolStripItem) this.toolStripSeparator6,
                (ToolStripItem) this.tbCut,
                (ToolStripItem) this.tbCopy,
                (ToolStripItem) this.tbPaste,
                (ToolStripItem) this.tbDelete,
                (ToolStripItem) this.toolStripSeparator3,
                (ToolStripItem) this.tbUndo,
                (ToolStripItem) this.toolStripSeparator7,
                (ToolStripItem) this.tbAlignLeft,
                (ToolStripItem) this.tbAlignRight,
                (ToolStripItem) this.tbStripAlign,
                (ToolStripItem) this.tbSpellCheck,
                (ToolStripItem) this.tbRefresh,
                (ToolStripItem) this.toolStripComboBox1,
                (ToolStripItem) this.toolStripComboBox2
            });
            this.toolStrip1.Location = new Point(3, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new Size(449, 29);
            this.toolStrip1.TabIndex = 2;
            this.toolStripMenuItem1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem1.Image = (Image)componentResourceManager.GetObject("toolStripMenuItem1.Image");
            this.toolStripMenuItem1.ImageTransparentColor = Color.Magenta;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new Size(23, 26);
            this.toolStripMenuItem1.Text = "New";
            this.toolStripMenuItem1.Click += new EventHandler(this.tbNew_Click);
            this.toolStripMenuItem2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem2.Image = (Image)componentResourceManager.GetObject("toolStripMenuItem2.Image");
            this.toolStripMenuItem2.ImageTransparentColor = Color.Magenta;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new Size(23, 26);
            this.toolStripMenuItem2.Text = "Open";
            this.toolStripMenuItem2.Click += new EventHandler(this.mnuOpen_Click);
            this.toolStripMenuItem3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem3.Image = (Image)componentResourceManager.GetObject("toolStripMenuItem3.Image");
            this.toolStripMenuItem3.ImageTransparentColor = Color.Magenta;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new Size(23, 26);
            this.toolStripMenuItem3.Text = "Save";
            this.toolStripMenuItem3.Click += new EventHandler(this.mnuSave_Click);
            this.toolStripMenuItem4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem4.Image = (Image)componentResourceManager.GetObject("toolStripMenuItem4.Image");
            this.toolStripMenuItem4.ImageTransparentColor = Color.Magenta;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new Size(23, 26);
            this.toolStripMenuItem4.Text = "Save All";
            this.toolStripMenuItem4.Click += new EventHandler(this.mnuSaveAll_Click);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new Size(6, 29);
            this.tbCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tbCut.Image = (Image)componentResourceManager.GetObject("tbCut.Image");
            this.tbCut.ImageTransparentColor = Color.Magenta;
            this.tbCut.Name = "tbCut";
            this.tbCut.Size = new Size(23, 26);
            this.tbCut.Text = "Cut";
            this.tbCut.Click += new EventHandler(this.mnuCut_Click);
            this.tbCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tbCopy.Image = (Image)componentResourceManager.GetObject("tbCopy.Image");
            this.tbCopy.ImageTransparentColor = Color.Magenta;
            this.tbCopy.Name = "tbCopy";
            this.tbCopy.Size = new Size(23, 26);
            this.tbCopy.Text = "Copy";
            this.tbCopy.Click += new EventHandler(this.mnuCopy_Click);
            this.tbPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tbPaste.Image = (Image)componentResourceManager.GetObject("tbPaste.Image");
            this.tbPaste.ImageTransparentColor = Color.Magenta;
            this.tbPaste.Name = "tbPaste";
            this.tbPaste.Size = new Size(23, 26);
            this.tbPaste.Text = "Paste";
            this.tbPaste.Click += new EventHandler(this.mnuPaste_Click);
            this.tbDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tbDelete.Image = (Image)componentResourceManager.GetObject("tbDelete.Image");
            this.tbDelete.ImageTransparentColor = Color.Magenta;
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new Size(23, 26);
            this.tbDelete.Text = "Delete";
            this.tbDelete.Click += new EventHandler(this.mnuDelete_Click);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new Size(6, 29);
            this.tbUndo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tbUndo.Image = (Image)componentResourceManager.GetObject("tbUndo.Image");
            this.tbUndo.ImageTransparentColor = Color.Magenta;
            this.tbUndo.Name = "tbUndo";
            this.tbUndo.Size = new Size(23, 26);
            this.tbUndo.Text = "Undo";
            this.tbUndo.Click += new EventHandler(this.mnuUndo_Click);
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new Size(6, 29);
            this.tbAlignLeft.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tbAlignLeft.Image = (Image)componentResourceManager.GetObject("tbAlignLeft.Image");
            this.tbAlignLeft.ImageTransparentColor = Color.Magenta;
            this.tbAlignLeft.Name = "tbAlignLeft";
            this.tbAlignLeft.Size = new Size(23, 26);
            this.tbAlignLeft.Text = "toolStripButton2";
            this.tbAlignLeft.ToolTipText = "Align Left";
            this.tbAlignLeft.Click += new EventHandler(this.tbAlignLeft_Click);
            this.tbAlignRight.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tbAlignRight.Image = (Image)componentResourceManager.GetObject("tbAlignRight.Image");
            this.tbAlignRight.ImageTransparentColor = Color.Magenta;
            this.tbAlignRight.Name = "tbAlignRight";
            this.tbAlignRight.Size = new Size(23, 26);
            this.tbAlignRight.Text = "toolStripButton1";
            this.tbAlignRight.ToolTipText = "Align Right";
            this.tbAlignRight.Click += new EventHandler(this.tbAlignRight_Click);
            this.tbStripAlign.Name = "tbStripAlign";
            this.tbStripAlign.Size = new Size(6, 29);
            this.tbSpellCheck.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tbSpellCheck.Image = (Image)componentResourceManager.GetObject("tbSpellCheck.Image");
            this.tbSpellCheck.ImageTransparentColor = Color.Magenta;
            this.tbSpellCheck.Name = "tbSpellCheck";
            this.tbSpellCheck.Size = new Size(23, 26);
            this.tbSpellCheck.Text = "Spell Check";
            this.tbSpellCheck.Click += new EventHandler(this.tbSpellCheck_Click);
            this.tbRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tbRefresh.Image = (Image)componentResourceManager.GetObject("tbRefresh.Image");
            this.tbRefresh.ImageTransparentColor = Color.Magenta;
            this.tbRefresh.Name = "tbRefresh";
            this.tbRefresh.Size = new Size(23, 26);
            this.tbRefresh.Text = "toolStripButton1";
            this.tbRefresh.ToolTipText = "Refresh";
            this.tbRefresh.Click += new EventHandler(this.tbRefresh_Click);
            this.toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.FlatStyle = FlatStyle.Standard;
            this.toolStripComboBox1.Items.AddRange(new object[2]
            {
                (object) "English",
                (object) "Urdu"
            });
            this.toolStripComboBox1.MaxDropDownItems = 3;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new Size(50, 29);
            this.toolStripComboBox1.ToolTipText = "Select a Language";
            this.toolStripComboBox1.SelectedIndexChanged +=
                new EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            this.toolStripComboBox1.Click += new EventHandler(this.toolStripComboBox1_Click);

            this.toolStripComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.toolStripComboBox2.FlatStyle = FlatStyle.Standard;
            //this.toolStripComboBox2.Items.AddRange(new object[1]
            //{
            //    (object) "Urdu Font List"
            //});
            this.toolStripComboBox2.MaxDropDownItems = 2;
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new Size(200, 29);
            this.toolStripComboBox2.ToolTipText = "Select an Urdu Font";
            this.toolStripComboBox2.SelectedIndexChanged +=
                new EventHandler(this.toolStripComboBox2_SelectedIndexChanged);
           // this.toolStripComboBox2.Click += new EventHandler(this.toolStripComboBox2_Click);
           
            this.usageOfSpaceBarToolStripMenuItem.Name = "usageOfSpaceBarToolStripMenuItem";
            this.usageOfSpaceBarToolStripMenuItem.Size = new Size(279, 26);
            this.usageOfSpaceBarToolStripMenuItem.Text = "Usage of Space Bar";
            this.usageOfSpaceBarToolStripMenuItem.Click += new EventHandler(this.usageOfSpaceBarToolStripMenuItem_Click);
            this.UsageOfAlignmentOptionToolStripMenuItem.Name = "UsageOfAlignmentOptionToolStripMenuItem";
            this.UsageOfAlignmentOptionToolStripMenuItem.Size = new Size(279, 26);
            this.UsageOfAlignmentOptionToolStripMenuItem.Text = "Usage of Alignment Option";
            this.UsageOfAlignmentOptionToolStripMenuItem.Click += new EventHandler(this.uToolStripMenuItem_Click);
            this.howToPrintTextToolStripMenuItem.Name = "howToPrintTextToolStripMenuItem";
            this.howToPrintTextToolStripMenuItem.Size = new Size(279, 26);
            this.howToPrintTextToolStripMenuItem.Text = "How to Print Text";
            this.howToPrintTextToolStripMenuItem.Click += new EventHandler(this.howToPrintTextToolStripMenuItem_Click);
            this.howToSpellCheckToolStripMenuItem.Name = "howToSpellCheckToolStripMenuItem";
            this.howToSpellCheckToolStripMenuItem.Size = new Size(279, 26);
            this.howToSpellCheckToolStripMenuItem.Text = "How to Spell Check";
            this.howToSpellCheckToolStripMenuItem.Click += new EventHandler(this.howToSpellCheckToolStripMenuItem_Click);
            this.AutoScaleDimensions = new SizeF(8f, 17f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(695, 583);
            this.Controls.Add((Control)this.toolStripContainer1);
            this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MainMenuStrip = this.mnu;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.Manual;
            this.Load += new EventHandler(this.Form1_Load);
            this.FormClosed += new FormClosedEventHandler(this.Form1_FormClosed);
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.sb.ResumeLayout(false);
            this.sb.PerformLayout();
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        
        }

        public class gandaWord
        {
            public int meraStart;
            public int meraEnd;
            public int meraLength;
            public string meraWord;
        }


        private char setUrduPhoneticUnicodes(char temp)
        {
            switch (temp)
            {
                case '\r':
                    return '\n';
                case ' ':
                    return ' ';
                case '!':
                    return '!';
                case '"':
                    return '”';
                case '\'':
                    return '’';
                case '(':
                    return '(';
                case ')':
                    return ')';
                case ',':
                    return '؛';
                case '.':
                    return '۔';
                case '0':
                    return '۰';
                case '1':
                    return '۱';
                case '2':
                    return '۲';
                case '3':
                    return '۳';
                case '4':
                    return '۴';
                case '5':
                    return '۵';
                case '6':
                    return '۶';
                case '7':
                    return '۷';
                case '8':
                    return '۸';
                case '9':
                    return '۹';
                case ':':
                    return ':';
                case '?':
                    return '؟';
                case 'A':
                    return 'آ';
                case 'C':
                    return 'ث';
                case 'D':
                    return 'ڈ';
                case 'G':
                    return 'غ';
                case 'H':
                    return 'ح';
                case 'J':
                    return 'ض';
                case 'K':
                    return 'خ';
                case 'N':
                    return 'ں';
                case 'R':
                    return 'ڑ';
                case 'S':
                    return 'ص';
                case 'T':
                    return 'ٹ';
                case 'V':
                    return 'ظ';
                case 'X':
                    return 'ژ';
                case 'Z':
                    return 'ذ';
                case 'a':
                    return 'ا';
                case 'b':
                    return 'ب';
                case 'c':
                    return 'چ';
                case 'd':
                    return 'د';
                case 'e':
                    return 'ع';
                case 'f':
                    return 'ف';
                case 'g':
                    return 'گ';
                case 'h':
                    return 'ھ';
                case 'i':
                    return 'ی';
                case 'j':
                    return 'ج';
                case 'k':
                    return 'ک';
                case 'l':
                    return 'ل';
                case 'm':
                    return 'م';
                case 'n':
                    return 'ن';
                case 'o':
                    return 'ہ';
                case 'p':
                    return 'پ';
                case 'q':
                    return 'ق';
                case 'r':
                    return 'ر';
                case 's':
                    return 'س';
                case 't':
                    return 'ت';
                case 'u':
                    return 'ء';
                case 'v':
                    return 'ط';
                case 'w':
                    return 'و';
                case 'x':
                    return 'ش';
                case 'y':
                    return 'ے';
                case 'z':
                    return 'ز';
                case '$': //check
                    return 'ئ';
                default:
                    return temp; //backspace ko ~ tang karta hay
            }
        }

        private string setUrduUnicode2Phonetic(string temp)
        {
            switch (temp)
            {

                case "\n":
                    return "\r";

                case " ":
                    return " ";

                case "!":
                    return "!";

                case "”":
                    return "\"";

                case "’":
                    return "\'";

                case ")":
                    return ")";

                case "(":
                    return "(";

                case "؛":
                    return ",";

                case "۔":
                    return ".";

                case "۰":
                    return "0";

                case "۱":
                    return "1";

                case "۲":
                    return "2";

                case "۳":
                    return "3";

                case "۴":
                    return "4";

                case "۵":
                    return "5";

                case "۶":
                    return "6";

                case "۷":
                    return "7";

                case "۸":
                    return "8";

                case "۹":
                    return "9";

                case ";":
                    return ";";

                case "؟":
                    return "?";

                case "آ":
                    return "A";

                case "ث":
                    return "C";

                case "ڈ":
                    return "D";

                case "غ":
                    return "G";

                case "ح":
                    return "H";

                case "ض":
                    return "J";

                case "خ":
                    return "K";

                case "ں":
                    return "N";

                case "ڑ":
                    return "R";

                case "ص":
                    return "S";

                case "ٹ":
                    return "T";

                case "ظ":
                    return "V";

                case "ژ":
                    return "X";

                case "ذ":
                    return "Z";

                case "ا":
                    return "a";

                case "ب":
                    return "b";

                case "چ":
                    return "c";

                case "د":
                    return "d";

                case "ع":
                    return "e";

                case "ف":
                    return "f";

                case "گ":
                    return "g";

                case "ھ":
                    return "h";

                case "ی":
                    return "i";

                case "ج":
                    return "j";

                case "ک":
                    return "k";

                case "ل":
                    return "l";

                case "م":
                    return "m";

                case "ن":
                    return "n";

                case "ہ":
                    return "o";

                case "پ":
                    return "p";

                case "ق":
                    return "q";

                case "ر":
                    return "r";

                case "س":
                    return "s";

                case "ت":
                    return "t";

                case "ء":
                    return "u";

                case "ط":
                    return "v";

                case "و":
                    return "w";

                case "ش":
                    return "x";

                case "ے":
                    return "y";

                case "ز":
                    return "z";

                case "ئ":
                    return "$";
                default:
                    return temp;
            }
        }


        struct cmChar
        {
            public int iType;
            public byte char1;
            public byte char2;
            public byte char3;
            public byte char4;
            public byte char5;
        };

        //AlKatib1 Urdu font map
        enum AlKatib1_Map
        {
            TwoLaam_Hay_ful = 34,
            Alif_ful = 65,
            Alif_end = 66,
            AlifMad_ful = 69,
            AlifMad_end = 70,
            Bay_sta = 73,
            Bay_mid = 74,
            Bay_end = 75,
            Bay_ful = 76,
            Tay_sta = 77,
            Tay_mid = 78,
            Tay_end = 79,
            Tay_ful = 80,
            Say_sta = 81,
            Say_mid = 82,
            Say_end = 83,
            Say_ful = 84,
            Jeem_sta = 85,
            Jeem_mid = 86,
            Jeem_end = 87,
            Jeem_ful = 88,
            HayHuqqa_sta = 89,
            HayHuqqa_mid = 90,
            HayHuqqa_end = 92,
            HayHuqqa_ful = 96,
            Khay_sta = 97,
            Khay_mid = 98,
            Khay_end = 99,
            Khay_ful = 100,
            Daal_ful = 101,
            Daal_end = 102,
            Zaal_ful = 103,
            Zaal_end = 104,
            Ray_ful = 105,
            Ray_end = 106,
            Zay_ful = 107,
            Zay_end = 108,
            Seen_sta = 109,
            Seen_mid = 110,
            Seen_end = 111,
            Seen_ful = 112,
            Sheen_sta = 113,
            Sheen_mid = 114,
            Sheen_end = 115,
            Sheen_ful = 116,
            Suad_sta = 117,
            Suad_mid = 118,
            Suad_end = 119,
            Suad_ful = 120,
            Duad_sta = 121,
            Duad_mid = 122,
            Duad_end = 124,
            Duad_ful = 126,
            Twain_sta = 162,
            Twain_mid = 241,
            Twain_end = 161,
            Twain_ful = 127,
            Pay_sta = 130,
            Pay_mid = 131,
            Pay_end = 132,
            Pay_ful = 133,
            Chay_sta = 134,
            Chay_mid = 135,
            Chay_end = 136,
            Chay_ful = 137,
            ZayZaala_ful = 138,
            ZayZaala_end = 139,
            Gaaf_sta = 140,
            Gaaf_mid = 140, //141
            Gaaf_end = 123, //143????
            Gaaf_ful = 123,
            TTay_sta = 144,
            TTay_mid = 145,
            TTay_end = 146,
            TTay_ful = 147,
            DDaal_ful = 148,
            DDaal_end = 149,
            RDay_ful = 152,
            RDay_end = 153,
            Zwain_sta = 166,
            Zwain_mid = 165,
            Zwain_end = 164,
            Zwain_ful = 163,
            Eain_sta = 167,
            Eain_mid = 168,
            Eain_end = 169,
            Eain_ful = 170,
            Ghain_sta = 171,
            Ghain_mid = 172,
            Ghain_end = 173,
            Ghain_ful = 174,
            Fay_sta = 175,
            Fay_mid = 176,
            Fay_end = 177,
            Fay_ful = 178,
            KKaaf_sta = 179,
            KKaaf_mid = 180,
            KKaaf_end = 181,
            KKaaf_ful = 182,
            Kaaf_sta = 183,
            Kaaf_mid = 184,
            Kaaf_end = 185,
            Kaaf_ful = 186,
            Laam_sta = 187,
            Laam_mid = 188,
            Laam_end = 189,
            Laam_ful = 190,
            Meem_sta = 191,
            Meem_mid = 192,
            Meem_end = 193,
            Meem_ful = 194,
            Noon_sta = 195,
            Noon_mid = 196,
            Noon_end = 197,
            Noon_ful = 198,
            HayHeaded_sta = 199, //........
            HayHeaded_mid = 200,
            HayHeaded_end = 201,
            HayHeaded_ful = 202, //........
            Wow_ful = 203,
            Wow_end = 204,
            YaySmall_sta = 205,
            YaySmall_mid = 206,
            YaySmall_end = 211,
            YaySmall_ful = 212,
            Noon_Ghunna_sta = 228,
            Noon_Ghunna_mid = 229,
            Noon_Ghunna_end = 230,
            Noon_Ghunna_ful = 231,
            HayTwoHeaded_sta = 232,
            HayTwoHeaded_mid = 233,
            HayTwoHeaded_end = 234,
            HayTwoHeaded_ful = 235,
            Hay_sta = 236,
            Hay_mid = 237,
            Hay_end = 238,
            Hay_ful = 202,
            YayBig_sta = 205,
            YayBig_mid = 206,
            YayBig_end = 154,
            YayBig_ful = 155,
            Hamza_sta = 214,
            Hamza_mid = 215,
            Hamza_end = 239,
            Hamza_ful = 213,
            LaamAlif_ful = 220,
            LaamAlif_end = 221,
            WowHamza_ful = 218,
            WowHamza_end = 219,
            HamzaOnly_ful = 213,
            Pash_mix = 243,
            Zuber_mix = 242,
            Zeer_mix = 248,
            Special_Space = 32,
            Special_Asterisk = 42,
            Special_Plus = 43,
            Special_Comma = 44,
            Special_Dash = 45,
            Special_Dot = 46,
            Special_Slash = 47,
            Special_SignOfExclamation = 33,
            Special_Percentage = 37,
            Special_LeftBracket = 40,
            Special_RightBracket = 41,
            Special_Colon = 58,
            Special_SemiColon = 59,
            Special_InvertedCommaLeft = 60,
            Special_InvertedCommaRight = 62,
            Special_Equal = 61,
            Special_QuestionMark = 63,
            Special_DotMota = 64
        }

        // fill whole phonetic(Urdu) character map with zeros later modify required values 
        private cmChar[] g_cmChar = new cmChar[255];

        // Fill Urdu Character Map
        private cmChar[] InitCharMap()
        {

            //--------------
            // map phonetic keyboard against Urdu character 
            //--------------

            g_cmChar['I'].iType = 1;
            g_cmChar['I'].char1 = (byte)AlKatib1_Map.TwoLaam_Hay_ful;


            g_cmChar['a'].iType = 2;
            g_cmChar['a'].char1 = (byte)AlKatib1_Map.Alif_ful;
            g_cmChar['a'].char4 = (byte)AlKatib1_Map.Alif_end;

            g_cmChar['A'].iType = 2;
            g_cmChar['A'].char1 = (byte)AlKatib1_Map.AlifMad_ful;
            g_cmChar['A'].char4 = (byte)AlKatib1_Map.AlifMad_end;

            g_cmChar['b'].iType = 3;
            g_cmChar['b'].char1 = (byte)AlKatib1_Map.Bay_ful;
            g_cmChar['b'].char2 = (byte)AlKatib1_Map.Bay_sta;
            g_cmChar['b'].char3 = (byte)AlKatib1_Map.Bay_mid;
            g_cmChar['b'].char4 = (byte)AlKatib1_Map.Bay_end;

            g_cmChar['t'].iType = 3;
            g_cmChar['t'].char1 = (byte)AlKatib1_Map.Tay_ful;
            g_cmChar['t'].char2 = (byte)AlKatib1_Map.Tay_sta;
            g_cmChar['t'].char3 = (byte)AlKatib1_Map.Tay_mid;
            g_cmChar['t'].char4 = (byte)AlKatib1_Map.Tay_end;

            g_cmChar['C'].iType = 3;
            g_cmChar['C'].char1 = (byte)AlKatib1_Map.Say_ful;
            g_cmChar['C'].char2 = (byte)AlKatib1_Map.Say_sta;
            g_cmChar['C'].char3 = (byte)AlKatib1_Map.Say_mid;
            g_cmChar['C'].char4 = (byte)AlKatib1_Map.Say_end;

            g_cmChar['j'].iType = 3;
            g_cmChar['j'].char1 = (byte)AlKatib1_Map.Jeem_ful;
            g_cmChar['j'].char2 = (byte)AlKatib1_Map.Jeem_sta;
            g_cmChar['j'].char3 = (byte)AlKatib1_Map.Jeem_mid;
            g_cmChar['j'].char4 = (byte)AlKatib1_Map.Jeem_end;

            g_cmChar['H'].iType = 3;
            g_cmChar['H'].char1 = (byte)AlKatib1_Map.HayHuqqa_ful;
            g_cmChar['H'].char2 = (byte)AlKatib1_Map.HayHuqqa_sta;
            g_cmChar['H'].char3 = (byte)AlKatib1_Map.HayHuqqa_mid;
            g_cmChar['H'].char4 = (byte)AlKatib1_Map.HayHuqqa_end;


            g_cmChar['K'].iType = 3;
            g_cmChar['K'].char1 = (byte)AlKatib1_Map.Khay_ful;
            g_cmChar['K'].char2 = (byte)AlKatib1_Map.Khay_sta;
            g_cmChar['K'].char3 = (byte)AlKatib1_Map.Khay_mid;
            g_cmChar['K'].char4 = (byte)AlKatib1_Map.Khay_end;

            g_cmChar['d'].iType = 2;
            g_cmChar['d'].char1 = (byte)AlKatib1_Map.Daal_ful;
            g_cmChar['d'].char4 = (byte)AlKatib1_Map.Daal_end;

            g_cmChar['Z'].iType = 2;
            g_cmChar['Z'].char1 = (byte)AlKatib1_Map.Zaal_ful;
            g_cmChar['Z'].char4 = (byte)AlKatib1_Map.Zaal_end;

            g_cmChar['r'].iType = 2;
            g_cmChar['r'].char1 = (byte)AlKatib1_Map.Ray_ful;
            g_cmChar['r'].char4 = (byte)AlKatib1_Map.Ray_end;

            g_cmChar['z'].iType = 2;
            g_cmChar['z'].char1 = (byte)AlKatib1_Map.Zay_ful;
            g_cmChar['z'].char4 = (byte)AlKatib1_Map.Zay_end;

            g_cmChar['s'].iType = 3;
            g_cmChar['s'].char1 = (byte)AlKatib1_Map.Seen_ful;
            g_cmChar['s'].char2 = (byte)AlKatib1_Map.Seen_sta;
            g_cmChar['s'].char3 = (byte)AlKatib1_Map.Seen_mid;
            g_cmChar['s'].char4 = (byte)AlKatib1_Map.Seen_end;

            g_cmChar['x'].iType = 3;
            g_cmChar['x'].char1 = (byte)AlKatib1_Map.Sheen_ful;
            g_cmChar['x'].char2 = (byte)AlKatib1_Map.Sheen_sta;
            g_cmChar['x'].char3 = (byte)AlKatib1_Map.Sheen_mid;
            g_cmChar['x'].char4 = (byte)AlKatib1_Map.Sheen_end;

            g_cmChar['S'].iType = 3;
            g_cmChar['S'].char1 = (byte)AlKatib1_Map.Suad_ful;
            g_cmChar['S'].char2 = (byte)AlKatib1_Map.Suad_sta;
            g_cmChar['S'].char3 = (byte)AlKatib1_Map.Suad_mid;
            g_cmChar['S'].char4 = (byte)AlKatib1_Map.Suad_end;

            g_cmChar['J'].iType = 3;
            g_cmChar['J'].char1 = (byte)AlKatib1_Map.Duad_ful;
            g_cmChar['J'].char2 = (byte)AlKatib1_Map.Duad_sta;
            g_cmChar['J'].char3 = (byte)AlKatib1_Map.Duad_mid;
            g_cmChar['J'].char4 = (byte)AlKatib1_Map.Duad_end;

            g_cmChar['v'].iType = 3;
            g_cmChar['v'].char1 = (byte)AlKatib1_Map.Twain_ful;
            g_cmChar['v'].char2 = (byte)AlKatib1_Map.Twain_sta;
            g_cmChar['v'].char3 = (byte)AlKatib1_Map.Twain_mid;
            g_cmChar['v'].char4 = (byte)AlKatib1_Map.Twain_end;

            g_cmChar['p'].iType = 3;
            g_cmChar['p'].char1 = (byte)AlKatib1_Map.Pay_ful;
            g_cmChar['p'].char2 = (byte)AlKatib1_Map.Pay_sta;
            g_cmChar['p'].char3 = (byte)AlKatib1_Map.Pay_mid;
            g_cmChar['p'].char4 = (byte)AlKatib1_Map.Pay_end;

            g_cmChar['c'].iType = 3;
            g_cmChar['c'].char1 = (byte)AlKatib1_Map.Chay_ful;
            g_cmChar['c'].char2 = (byte)AlKatib1_Map.Chay_sta;
            g_cmChar['c'].char3 = (byte)AlKatib1_Map.Chay_mid;
            g_cmChar['c'].char4 = (byte)AlKatib1_Map.Chay_end;

            g_cmChar['X'].iType = 2;
            g_cmChar['X'].char1 = (byte)AlKatib1_Map.ZayZaala_ful;
            g_cmChar['X'].char4 = (byte)AlKatib1_Map.ZayZaala_end;

            g_cmChar['g'].iType = 3;
            g_cmChar['g'].char1 = (byte)AlKatib1_Map.Gaaf_ful;
            g_cmChar['g'].char2 = (byte)AlKatib1_Map.Gaaf_sta;
            g_cmChar['g'].char3 = (byte)AlKatib1_Map.Gaaf_mid;
            g_cmChar['g'].char4 = (byte)AlKatib1_Map.Gaaf_end;

            g_cmChar['T'].iType = 3;
            g_cmChar['T'].char1 = (byte)AlKatib1_Map.TTay_ful;
            g_cmChar['T'].char2 = (byte)AlKatib1_Map.TTay_sta;
            g_cmChar['T'].char3 = (byte)AlKatib1_Map.TTay_mid;
            g_cmChar['T'].char4 = (byte)AlKatib1_Map.TTay_end;

            g_cmChar['D'].iType = 2;
            g_cmChar['D'].char1 = (byte)AlKatib1_Map.DDaal_ful;
            g_cmChar['D'].char4 = (byte)AlKatib1_Map.DDaal_end;

            g_cmChar['R'].iType = 2;
            g_cmChar['R'].char1 = (byte)AlKatib1_Map.RDay_ful;
            g_cmChar['R'].char4 = (byte)AlKatib1_Map.RDay_end;

            g_cmChar['V'].iType = 3;
            g_cmChar['V'].char1 = (byte)AlKatib1_Map.Zwain_ful;
            g_cmChar['V'].char2 = (byte)AlKatib1_Map.Zwain_sta;
            g_cmChar['V'].char3 = (byte)AlKatib1_Map.Zwain_mid;
            g_cmChar['V'].char4 = (byte)AlKatib1_Map.Zwain_end;

            g_cmChar['e'].iType = 3;
            g_cmChar['e'].char1 = (byte)AlKatib1_Map.Eain_ful;
            g_cmChar['e'].char2 = (byte)AlKatib1_Map.Eain_sta;
            g_cmChar['e'].char3 = (byte)AlKatib1_Map.Eain_mid;
            g_cmChar['e'].char4 = (byte)AlKatib1_Map.Eain_end;

            g_cmChar['G'].iType = 3;
            g_cmChar['G'].char1 = (byte)AlKatib1_Map.Ghain_ful;
            g_cmChar['G'].char2 = (byte)AlKatib1_Map.Ghain_sta;
            g_cmChar['G'].char3 = (byte)AlKatib1_Map.Ghain_mid;
            g_cmChar['G'].char4 = (byte)AlKatib1_Map.Ghain_end;

            g_cmChar['f'].iType = 3;
            g_cmChar['f'].char1 = (byte)AlKatib1_Map.Fay_ful;
            g_cmChar['f'].char2 = (byte)AlKatib1_Map.Fay_sta;
            g_cmChar['f'].char3 = (byte)AlKatib1_Map.Fay_mid;
            g_cmChar['f'].char4 = (byte)AlKatib1_Map.Fay_end;

            g_cmChar['q'].iType = 3;
            g_cmChar['q'].char1 = (byte)AlKatib1_Map.KKaaf_ful;
            g_cmChar['q'].char2 = (byte)AlKatib1_Map.KKaaf_sta;
            g_cmChar['q'].char3 = (byte)AlKatib1_Map.KKaaf_mid;
            g_cmChar['q'].char4 = (byte)AlKatib1_Map.KKaaf_end;

            g_cmChar['k'].iType = 3;
            g_cmChar['k'].char1 = (byte)AlKatib1_Map.Kaaf_ful;
            g_cmChar['k'].char2 = (byte)AlKatib1_Map.Kaaf_sta;
            g_cmChar['k'].char3 = (byte)AlKatib1_Map.Kaaf_mid;
            g_cmChar['k'].char4 = (byte)AlKatib1_Map.Kaaf_end;

            g_cmChar['l'].iType = 3;
            g_cmChar['l'].char1 = (byte)AlKatib1_Map.Laam_ful;
            g_cmChar['l'].char2 = (byte)AlKatib1_Map.Laam_sta;
            g_cmChar['l'].char3 = (byte)AlKatib1_Map.Laam_mid;
            g_cmChar['l'].char4 = (byte)AlKatib1_Map.Laam_end;

            g_cmChar['m'].iType = 3;
            g_cmChar['m'].char1 = (byte)AlKatib1_Map.Meem_ful;
            g_cmChar['m'].char2 = (byte)AlKatib1_Map.Meem_sta;
            g_cmChar['m'].char3 = (byte)AlKatib1_Map.Meem_mid;
            g_cmChar['m'].char4 = (byte)AlKatib1_Map.Meem_end;

            g_cmChar['n'].iType = 3;
            g_cmChar['n'].char1 = (byte)AlKatib1_Map.Noon_ful;
            g_cmChar['n'].char2 = (byte)AlKatib1_Map.Noon_sta;
            g_cmChar['n'].char3 = (byte)AlKatib1_Map.Noon_mid;
            g_cmChar['n'].char4 = (byte)AlKatib1_Map.Noon_end;

            g_cmChar['h'].iType = 3;
            g_cmChar['h'].char1 = (byte)AlKatib1_Map.HayTwoHeaded_ful;
            g_cmChar['h'].char2 = (byte)AlKatib1_Map.HayTwoHeaded_sta;
            g_cmChar['h'].char3 = (byte)AlKatib1_Map.HayTwoHeaded_mid;
            g_cmChar['h'].char4 = (byte)AlKatib1_Map.HayTwoHeaded_end;

            g_cmChar['w'].iType = 2;
            g_cmChar['w'].char1 = (byte)AlKatib1_Map.Wow_ful;
            g_cmChar['w'].char4 = (byte)AlKatib1_Map.Wow_end;

            g_cmChar['i'].iType = 3;
            g_cmChar['i'].char1 = (byte)AlKatib1_Map.YaySmall_ful;
            g_cmChar['i'].char2 = (byte)AlKatib1_Map.YaySmall_sta;
            g_cmChar['i'].char3 = (byte)AlKatib1_Map.YaySmall_mid;
            g_cmChar['i'].char4 = (byte)AlKatib1_Map.YaySmall_end;

            g_cmChar['N'].iType = 3;
            g_cmChar['N'].char1 = (byte)AlKatib1_Map.Noon_Ghunna_ful;
            g_cmChar['N'].char2 = (byte)AlKatib1_Map.Noon_Ghunna_sta;
            g_cmChar['N'].char3 = (byte)AlKatib1_Map.Noon_Ghunna_mid;
            g_cmChar['N'].char4 = (byte)AlKatib1_Map.Noon_Ghunna_end;

            g_cmChar['o'].iType = 3;
            g_cmChar['o'].char1 = (byte)AlKatib1_Map.Hay_ful;
            g_cmChar['o'].char2 = (byte)AlKatib1_Map.Hay_sta;
            g_cmChar['o'].char3 = (byte)AlKatib1_Map.Hay_mid;
            g_cmChar['o'].char4 = (byte)AlKatib1_Map.Hay_end;

            g_cmChar['y'].iType = 3;
            g_cmChar['y'].char1 = (byte)AlKatib1_Map.YayBig_ful;
            g_cmChar['y'].char2 = (byte)AlKatib1_Map.YayBig_sta;
            g_cmChar['y'].char3 = (byte)AlKatib1_Map.YayBig_mid;
            g_cmChar['y'].char4 = (byte)AlKatib1_Map.YayBig_end;

            g_cmChar['u'].iType = 3;
            g_cmChar['u'].char1 = (byte)AlKatib1_Map.Hamza_ful;
            g_cmChar['u'].char2 = (byte)AlKatib1_Map.Hamza_sta;
            g_cmChar['u'].char3 = (byte)AlKatib1_Map.Hamza_mid;
            g_cmChar['u'].char4 = (byte)AlKatib1_Map.Hamza_end;

            g_cmChar['L'].iType = 2;
            g_cmChar['L'].char1 = (byte)AlKatib1_Map.LaamAlif_ful;
            g_cmChar['L'].char4 = (byte)AlKatib1_Map.LaamAlif_end;

            g_cmChar['W'].iType = 2;
            g_cmChar['W'].char1 = (byte)AlKatib1_Map.WowHamza_ful;
            g_cmChar['W'].char4 = (byte)AlKatib1_Map.WowHamza_end;

            g_cmChar['P'].iType = 4;
            g_cmChar['P'].char5 = (byte)AlKatib1_Map.Pash_mix;

            g_cmChar['O'].iType = 4;
            g_cmChar['O'].char5 = (byte)AlKatib1_Map.Zuber_mix;

            g_cmChar['M'].iType = 4;
            g_cmChar['M'].char5 = (byte)AlKatib1_Map.Zeer_mix;

            g_cmChar[32].iType = 5;
            g_cmChar[32].char1 = (byte)AlKatib1_Map.Special_Space;
            g_cmChar[32].char4 = (byte)AlKatib1_Map.Special_Space;

            g_cmChar['*'].iType = 5;
            g_cmChar['*'].char1 = (byte)AlKatib1_Map.Special_Asterisk;
            g_cmChar['*'].char4 = (byte)AlKatib1_Map.Special_Asterisk;

            g_cmChar['+'].iType = 5;
            g_cmChar['+'].char1 = (byte)AlKatib1_Map.Special_Plus;
            g_cmChar['+'].char4 = (byte)AlKatib1_Map.Special_Plus;

            g_cmChar[','].iType = 5;
            g_cmChar[','].char1 = (byte)AlKatib1_Map.Special_Comma;
            g_cmChar[','].char4 = (byte)AlKatib1_Map.Special_Comma;

            g_cmChar['-'].iType = 5;
            g_cmChar['-'].char1 = (byte)AlKatib1_Map.Special_Dash;
            g_cmChar['-'].char4 = (byte)AlKatib1_Map.Special_Dash;


            g_cmChar['.'].iType = 5;
            g_cmChar['.'].char1 = (byte)AlKatib1_Map.Special_Dot;
            g_cmChar['.'].char4 = (byte)AlKatib1_Map.Special_Dot;

            g_cmChar['/'].iType = 5;
            g_cmChar['/'].char1 = (byte)AlKatib1_Map.Special_Slash;
            g_cmChar['/'].char4 = (byte)AlKatib1_Map.Special_Slash;


            g_cmChar['!'].iType = 5;
            g_cmChar['!'].char1 = (byte)AlKatib1_Map.Special_SignOfExclamation;
            g_cmChar['!'].char4 = (byte)AlKatib1_Map.Special_SignOfExclamation;


            g_cmChar['%'].iType = 5;
            g_cmChar['%'].char1 = (byte)AlKatib1_Map.Special_Percentage;
            g_cmChar['%'].char4 = (byte)AlKatib1_Map.Special_Percentage;


            g_cmChar['('].iType = 5;
            g_cmChar['('].char1 = (byte)AlKatib1_Map.Special_LeftBracket;
            g_cmChar['('].char4 = (byte)AlKatib1_Map.Special_LeftBracket;


            g_cmChar[')'].iType = 5;
            g_cmChar[')'].char1 = (byte)AlKatib1_Map.Special_RightBracket;
            g_cmChar[')'].char4 = (byte)AlKatib1_Map.Special_RightBracket;

            g_cmChar[':'].iType = 5;
            g_cmChar[':'].char1 = (byte)AlKatib1_Map.Special_Colon;
            g_cmChar[':'].char4 = (byte)AlKatib1_Map.Special_Colon;

            g_cmChar[';'].iType = 5;
            g_cmChar[';'].char1 = (byte)AlKatib1_Map.Special_SemiColon;
            g_cmChar[';'].char4 = (byte)AlKatib1_Map.Special_SemiColon;

            g_cmChar['='].iType = 5;
            g_cmChar['='].char1 = (byte)AlKatib1_Map.Special_Equal;
            g_cmChar['='].char4 = (byte)AlKatib1_Map.Special_Equal;

            g_cmChar['?'].iType = 5;
            g_cmChar['?'].char1 = (byte)AlKatib1_Map.Special_QuestionMark;
            g_cmChar['?'].char4 = (byte)AlKatib1_Map.Special_QuestionMark;

            g_cmChar['-'].iType = 5;
            g_cmChar['-'].char1 = (byte)AlKatib1_Map.Special_DotMota;
            g_cmChar['-'].char4 = (byte)AlKatib1_Map.Special_DotMota;

            g_cmChar['<'].iType = 5;
            g_cmChar['<'].char1 = (byte)AlKatib1_Map.Special_InvertedCommaLeft;
            g_cmChar['<'].char4 = (byte)AlKatib1_Map.Special_InvertedCommaLeft;

            g_cmChar['>'].iType = 5;
            g_cmChar['>'].char1 = (byte)AlKatib1_Map.Special_InvertedCommaRight;
            g_cmChar['>'].char4 = (byte)AlKatib1_Map.Special_InvertedCommaRight;

            return g_cmChar;
        }


        private Boolean _ignore = false;
        private string textFileName = "fontsList.txt";
        private string[] lineOfContents;

        private void FontStyleForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(textFileName))
            {
                lineOfContents = File.ReadAllLines(textFileName);
            }
            else
            {
                MessageBox.Show("file " + textFileName + " does not exist");
                return;
            }


            FontFamily[] fontFamilies = FontFamily.Families;
            var count = 1;
            foreach (var line in lineOfContents)
            {
                if (ValidateFont(line.Trim(), fontFamilies, count))
                {
                    toolStripComboBox2.Items.Add(line.Trim());
                }
                count++;
            }
        }

        //nsm
      

        private void ShowFontWindow(string selectedFont)
        {

            
            myFrm.setFontOfLabels(selectedFont);
            myFrm.Show();
            
            myFrm.Left = Left + ((this.Width / 2) - (myFrm.Width / 2));
            myFrm.Top = Top + ((Height / 2) - (myFrm.Height / 2));

            myFrm.TopMost = true;
           

           // fontsWindowtimer.Interval = 500; ;
            //myFrm.ChildFormOpacity = 1;
           // fontsWindowtimer.Start();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            myFrm.ChildFormOpacity -= .10;
            if (myFrm.ChildFormOpacity <= 0)
            {
                fontsWindowtimer.Stop();
                myFrm.Hide();
            }

        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string theFont = toolStripComboBox2.Text;
            Font objFont= new Font(theFont, glbfont_size);
            
            if (theFont  != "")
            {
               SetFontOfText(objFont);
            }
        }

        private Boolean ValidateFont(string font, FontFamily[] fontFamilies, int line_number)
        {
            foreach (FontFamily fontFamily in fontFamilies)
            {
                if (fontFamily.IsStyleAvailable(FontStyle.Regular))
                {

                    if (String.Equals(fontFamily.Name, font, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }


            if (!_ignore)
            {
                string message = "'" + font + "' is not a valid font style. \nPlease make change in " +
                                 Directory.GetCurrentDirectory() + "\\" + textFileName + "\nOn line " +
                                 line_number.ToString() + " \n Press OK for another attempt and Cancel to proceed as is";
                const string caption = "Something went wrong";
                var result = MessageBox.Show(message, caption,
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Exclamation);

                // If the no button was pressed ...
                if (result == DialogResult.Cancel)
                {
                    _ignore = true;

                }
            }
            return false;
        }

        public static string ReverseText(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private string setUrduUnicode2Roman(string temp)
        {
            switch (temp)
            {

                case "\u0627":
                    return "A";

                case "\u0675":
                    return "A";

                case "\u0673":
                    return "A";

                case "\u0630":
                    return "A";

                case "\u0622":
                    return "AA";

                case "\u0628":
                    return "B";

                case "\u067E":
                    return "P";

                case "\u062A":
                    return "T";

                case "\u0637":
                    return "T";

                case "\u0679":
                    return "T";

                case "\u062C":
                    return "J";

                case "\u0633":
                    return "S";

                case "\u062B":
                    return "S";

                case "\u0635":
                    return "S";

                case "\u0686":
                    return "CH";

                case "\u062D":
                    return "H";

                case "\u0647":
                    return "H";

                case "\u0629":
                    return "H";

                case "\u06DF":
                    return "H";

                case "\u062E":
                    return "KH";

                case "\u062F":
                    return "D";

                case "\u0688":
                    return "D";

               // case "\u0630":
                 //   return "Z";

                case "\u0632":
                    return "Z";

                case "\u0636":
                    return "Z";

                case "\u0638":
                    return "Z";

                case "\u068E":
                    return "Z";

                case "\u0631":
                    return "R";

                case "\u0691":
                    return "R";

                case "\u0634":
                    return "SH";

                case "\u063A":
                    return "GH";

                case "\u0641":
                    return "F";

                case "\u06A9":
                    return "K";

                case "\u0642":
                    return "K";

                case "\u06AF":
                    return "G";

                case "\u0644":
                    return "L";

                case "\u0645":
                    return "M";

                case "\u0646":
                    return "N";

                case "\u06BA":
                    return "N";

                case "\u0648":
                    return "O";

                case "\u0649":
                    return "Y";

                case "\u0626":
                    return "Y";

                case "\u06CC":
                    return "Y";

                case "\u06D2":
                    return "E";

                case "\u06C1":
                    return "H";

                case "\u064A":
                    return "E";

                case "\u06C2":
                    return "AH";

                case "\u06BE":
                    return "H";

                case "\u0639":
                    return "A";

                case "\u0643":
                    return "K";

                case "\u0621":
                    return "A";

                case "\u0624":
                    return "O";

                case "؟":
                    return "?";

                case "۱":
                    return "1";

                case "۲":
                    return "2";

                case "۳":
                    return "3";

                case "۴":
                    return "4";

                case "۵":
                    return "5";

                case "۶":
                    return "6";

                case "۷":
                    return "7";

                case "۸":
                    return "8";

                case "۹":
                    return "9";

                case "۰":
                    return "0";

            }
            return temp;
        }

        
            string TransliterateText(string s)
            {
                string result="";
                for (int i = 0; i < s.Length; i++)
                {
                    result=result+setUrduUnicode2Roman(s[i].ToString());

                }
                return result;
            }
    }
}
