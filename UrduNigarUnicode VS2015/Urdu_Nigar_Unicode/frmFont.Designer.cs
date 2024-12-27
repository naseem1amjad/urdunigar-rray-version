namespace Urdu_Nigar_Unicode
{
    partial class frmFont
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUrdu = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUrdu
            // 
            this.lblUrdu.AutoSize = true;
            this.lblUrdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrdu.Location = new System.Drawing.Point(12, 9);
            this.lblUrdu.Name = "lblUrdu";
            this.lblUrdu.Size = new System.Drawing.Size(45, 16);
            this.lblUrdu.TabIndex = 0;
            this.lblUrdu.Text = "label1";
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglish.Location = new System.Drawing.Point(12, 62);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(45, 16);
            this.lblEnglish.TabIndex = 1;
            this.lblEnglish.Text = "label1";
            // 
            // frmFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(745, 101);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.lblUrdu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFont";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmFont";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFont_FormClosing);
        
            this.Load += new System.EventHandler(this.frmFont_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrdu;
        private System.Windows.Forms.Label lblEnglish;
    }
}