namespace Podaci_o_radnicima__.Net_
{
    partial class ImeiPrezime
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.btnPronadji = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(584, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(488, 629);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite ime: ";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(160, 184);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(204, 20);
            this.txtIme.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unesite prezime: ";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(160, 240);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(204, 20);
            this.txtPrezime.TabIndex = 4;
            // 
            // btnPronadji
            // 
            this.btnPronadji.Location = new System.Drawing.Point(30, 297);
            this.btnPronadji.Name = "btnPronadji";
            this.btnPronadji.Size = new System.Drawing.Size(410, 103);
            this.btnPronadji.TabIndex = 5;
            this.btnPronadji.Text = "Pronadji";
            this.btnPronadji.UseVisualStyleBackColor = true;
            this.btnPronadji.Click += new System.EventHandler(this.btnPronadji_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 610);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ukupno korisnika";
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(422, 603);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(100, 20);
            this.txtUkupno.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(412, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Unesite  ime ili prezime ili oba  u predvidjenim mestima i pritiskom na  dugmetu " +
    "pronadji ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(476, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = " dobicemo spisak svih korisnika sa tim imenom , prezimenom ili kombinacijom kao i" +
    " broj koliko ih ima ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(415, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "* mozemo uneti malim slovima ili kako god a sistem ce napraviti sa prvim velikim " +
    "slovom";
            // 
            // ImeiPrezime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 670);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPronadji);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ImeiPrezime";
            this.Text = "Ime i prezime";
            this.Load += new System.EventHandler(this.ImeiPrezime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Button btnPronadji;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}