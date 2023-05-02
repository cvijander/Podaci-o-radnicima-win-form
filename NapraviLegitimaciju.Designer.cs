namespace Podaci_o_radnicima__.Net_
{
    partial class NapraviLegitimaciju
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
            this.lboxRadnici = new System.Windows.Forms.ListBox();
            this.rtboxInfo = new System.Windows.Forms.RichTextBox();
            this.btnPredjinaLegitimaciju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboxRadnici
            // 
            this.lboxRadnici.FormattingEnabled = true;
            this.lboxRadnici.Location = new System.Drawing.Point(13, 22);
            this.lboxRadnici.Name = "lboxRadnici";
            this.lboxRadnici.Size = new System.Drawing.Size(259, 628);
            this.lboxRadnici.TabIndex = 0;
            this.lboxRadnici.SelectedIndexChanged += new System.EventHandler(this.lboxRadnici_SelectedIndexChanged);
            // 
            // rtboxInfo
            // 
            this.rtboxInfo.Location = new System.Drawing.Point(311, 22);
            this.rtboxInfo.Name = "rtboxInfo";
            this.rtboxInfo.Size = new System.Drawing.Size(375, 215);
            this.rtboxInfo.TabIndex = 1;
            this.rtboxInfo.Text = "";
            // 
            // btnPredjinaLegitimaciju
            // 
            this.btnPredjinaLegitimaciju.Location = new System.Drawing.Point(311, 590);
            this.btnPredjinaLegitimaciju.Name = "btnPredjinaLegitimaciju";
            this.btnPredjinaLegitimaciju.Size = new System.Drawing.Size(375, 60);
            this.btnPredjinaLegitimaciju.TabIndex = 2;
            this.btnPredjinaLegitimaciju.Text = "Predji na legitimaciju";
            this.btnPredjinaLegitimaciju.UseVisualStyleBackColor = true;
            this.btnPredjinaLegitimaciju.Click += new System.EventHandler(this.btnPredjinaLegitimaciju_Click);
            // 
            // NapraviLegitimaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 705);
            this.Controls.Add(this.btnPredjinaLegitimaciju);
            this.Controls.Add(this.rtboxInfo);
            this.Controls.Add(this.lboxRadnici);
            this.Name = "NapraviLegitimaciju";
            this.Text = "Napravi legitimaciju";
            this.Load += new System.EventHandler(this.NapraviLegitimaciju_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboxRadnici;
        private System.Windows.Forms.RichTextBox rtboxInfo;
        private System.Windows.Forms.Button btnPredjinaLegitimaciju;
    }
}