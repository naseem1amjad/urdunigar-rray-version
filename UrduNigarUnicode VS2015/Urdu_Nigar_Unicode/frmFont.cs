using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Urdu_Nigar_Unicode
{
    
    public partial class frmFont : Form
    {
        private double mChildFormOpacity;

        public frmFont()
        {
            InitializeComponent();
        }

        private void frmFont_Load(object sender, EventArgs e)
        {
            lblUrdu.Text = "ایک ٹیلے پر واقع مزار خواجہ فرید الدین گنج شکر کے احاطہ صحن میں ذراسی ژالہ باری چاندی کے ڈھیروں کی مثل بڑے غضب کا نظارہ دیتی ہے";

            lblEnglish.Text = "Quick Brown Fox Jumped Over the Lazy Dog";
        }

        public void setFontOfLabels(string fntFamily)
        {
            this.Text = fntFamily;

            lblEnglish.Font = new Font(fntFamily, lblEnglish.Font.Size);
            lblUrdu.Font=new Font(fntFamily,lblUrdu.Font.Size);
        }

        public double ChildFormOpacity
        {
            get { return mChildFormOpacity; }
            set
            {
                Opacity = value;
                mChildFormOpacity = Opacity;
            }
        }

        private void frmFont_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
