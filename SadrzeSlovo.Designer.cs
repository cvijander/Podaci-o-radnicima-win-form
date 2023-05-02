namespace Podaci_o_radnicima__.Net_
{
    partial class SadrzeSlovo
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
            this.label1 = new System.Windows.Forms.Label();
            this.tboxSlova = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gboxImePrezime = new System.Windows.Forms.GroupBox();
            this.rbnPrezime = new System.Windows.Forms.RadioButton();
            this.rbnIme = new System.Windows.Forms.RadioButton();
            this.gboxPrvoSrednjeZadnje = new System.Windows.Forms.GroupBox();
            this.rbnZadnjeSlovo = new System.Windows.Forms.RadioButton();
            this.rbnSrednjeSlovo = new System.Windows.Forms.RadioButton();
            this.rbnPrvo = new System.Windows.Forms.RadioButton();
            this.btnPronadji = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gboxImePrezime.SuspendLayout();
            this.gboxPrvoSrednjeZadnje.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite slovo ili slova koja zelite da pronadjemo";
            // 
            // tboxSlova
            // 
            this.tboxSlova.Location = new System.Drawing.Point(299, 62);
            this.tboxSlova.Name = "tboxSlova";
            this.tboxSlova.Size = new System.Drawing.Size(120, 20);
            this.tboxSlova.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(534, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(582, 630);
            this.dataGridView1.TabIndex = 2;
            // 
            // gboxImePrezime
            // 
            this.gboxImePrezime.Controls.Add(this.rbnPrezime);
            this.gboxImePrezime.Controls.Add(this.rbnIme);
            this.gboxImePrezime.Location = new System.Drawing.Point(41, 127);
            this.gboxImePrezime.Name = "gboxImePrezime";
            this.gboxImePrezime.Size = new System.Drawing.Size(378, 94);
            this.gboxImePrezime.TabIndex = 3;
            this.gboxImePrezime.TabStop = false;
            this.gboxImePrezime.Text = "Ime , prezime ili oba";
            // 
            // rbnPrezime
            // 
            this.rbnPrezime.AutoSize = true;
            this.rbnPrezime.Location = new System.Drawing.Point(154, 43);
            this.rbnPrezime.Name = "rbnPrezime";
            this.rbnPrezime.Size = new System.Drawing.Size(61, 17);
            this.rbnPrezime.TabIndex = 1;
            this.rbnPrezime.TabStop = true;
            this.rbnPrezime.Text = "prezime";
            this.rbnPrezime.UseVisualStyleBackColor = true;
            this.rbnPrezime.CheckedChanged += new System.EventHandler(this.rbnPrezime_CheckedChanged);
            // 
            // rbnIme
            // 
            this.rbnIme.AutoSize = true;
            this.rbnIme.Location = new System.Drawing.Point(21, 43);
            this.rbnIme.Name = "rbnIme";
            this.rbnIme.Size = new System.Drawing.Size(41, 17);
            this.rbnIme.TabIndex = 0;
            this.rbnIme.TabStop = true;
            this.rbnIme.Text = "ime";
            this.rbnIme.UseVisualStyleBackColor = true;
            this.rbnIme.CheckedChanged += new System.EventHandler(this.rbnIme_CheckedChanged);
            // 
            // gboxPrvoSrednjeZadnje
            // 
            this.gboxPrvoSrednjeZadnje.Controls.Add(this.rbnZadnjeSlovo);
            this.gboxPrvoSrednjeZadnje.Controls.Add(this.rbnSrednjeSlovo);
            this.gboxPrvoSrednjeZadnje.Controls.Add(this.rbnPrvo);
            this.gboxPrvoSrednjeZadnje.Location = new System.Drawing.Point(41, 256);
            this.gboxPrvoSrednjeZadnje.Name = "gboxPrvoSrednjeZadnje";
            this.gboxPrvoSrednjeZadnje.Size = new System.Drawing.Size(378, 98);
            this.gboxPrvoSrednjeZadnje.TabIndex = 4;
            this.gboxPrvoSrednjeZadnje.TabStop = false;
            this.gboxPrvoSrednjeZadnje.Text = "Raspored ";
            // 
            // rbnZadnjeSlovo
            // 
            this.rbnZadnjeSlovo.AutoSize = true;
            this.rbnZadnjeSlovo.Location = new System.Drawing.Point(270, 45);
            this.rbnZadnjeSlovo.Name = "rbnZadnjeSlovo";
            this.rbnZadnjeSlovo.Size = new System.Drawing.Size(86, 17);
            this.rbnZadnjeSlovo.TabIndex = 2;
            this.rbnZadnjeSlovo.TabStop = true;
            this.rbnZadnjeSlovo.Text = "Zadnje slovo";
            this.rbnZadnjeSlovo.UseVisualStyleBackColor = true;
            this.rbnZadnjeSlovo.CheckedChanged += new System.EventHandler(this.rbnZadnjeSlovo_CheckedChanged);
            // 
            // rbnSrednjeSlovo
            // 
            this.rbnSrednjeSlovo.AutoSize = true;
            this.rbnSrednjeSlovo.Location = new System.Drawing.Point(114, 45);
            this.rbnSrednjeSlovo.Name = "rbnSrednjeSlovo";
            this.rbnSrednjeSlovo.Size = new System.Drawing.Size(89, 17);
            this.rbnSrednjeSlovo.TabIndex = 1;
            this.rbnSrednjeSlovo.TabStop = true;
            this.rbnSrednjeSlovo.Text = "Srednje slovo";
            this.rbnSrednjeSlovo.UseVisualStyleBackColor = true;
            this.rbnSrednjeSlovo.CheckedChanged += new System.EventHandler(this.rbnSrednjeSlovo_CheckedChanged);
            // 
            // rbnPrvo
            // 
            this.rbnPrvo.AutoSize = true;
            this.rbnPrvo.Location = new System.Drawing.Point(21, 45);
            this.rbnPrvo.Name = "rbnPrvo";
            this.rbnPrvo.Size = new System.Drawing.Size(75, 17);
            this.rbnPrvo.TabIndex = 0;
            this.rbnPrvo.TabStop = true;
            this.rbnPrvo.Text = "Prvo slovo";
            this.rbnPrvo.UseVisualStyleBackColor = true;
            this.rbnPrvo.CheckedChanged += new System.EventHandler(this.rbnPrvo_CheckedChanged);
            // 
            // btnPronadji
            // 
            this.btnPronadji.Location = new System.Drawing.Point(41, 391);
            this.btnPronadji.Name = "btnPronadji";
            this.btnPronadji.Size = new System.Drawing.Size(378, 36);
            this.btnPronadji.TabIndex = 5;
            this.btnPronadji.Text = "Pronadji";
            this.btnPronadji.UseVisualStyleBackColor = true;
            this.btnPronadji.Click += new System.EventHandler(this.btnPronadji_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 620);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ukupno radnika ";
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(341, 620);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(100, 20);
            this.txtUkupno.TabIndex = 7;
            // 
            // SadrzeSlovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 693);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPronadji);
            this.Controls.Add(this.gboxPrvoSrednjeZadnje);
            this.Controls.Add(this.gboxImePrezime);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tboxSlova);
            this.Controls.Add(this.label1);
            this.Name = "SadrzeSlovo";
            this.Text = "SadrzeSlovo";
            this.Load += new System.EventHandler(this.SadrzeSlovo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gboxImePrezime.ResumeLayout(false);
            this.gboxImePrezime.PerformLayout();
            this.gboxPrvoSrednjeZadnje.ResumeLayout(false);
            this.gboxPrvoSrednjeZadnje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxSlova;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gboxImePrezime;
        private System.Windows.Forms.RadioButton rbnPrezime;
        private System.Windows.Forms.RadioButton rbnIme;
        private System.Windows.Forms.GroupBox gboxPrvoSrednjeZadnje;
        private System.Windows.Forms.RadioButton rbnZadnjeSlovo;
        private System.Windows.Forms.RadioButton rbnSrednjeSlovo;
        private System.Windows.Forms.RadioButton rbnPrvo;
        private System.Windows.Forms.Button btnPronadji;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUkupno;
    }
}