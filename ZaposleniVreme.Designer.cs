namespace Podaci_o_radnicima__.Net_
{
    partial class ZaposleniVreme
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
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.btnGodina = new System.Windows.Forms.Button();
            this.gBoxGodine = new System.Windows.Forms.GroupBox();
            this.rbn2Godine = new System.Windows.Forms.RadioButton();
            this.rbn5Godina = new System.Windows.Forms.RadioButton();
            this.rbn10Godina = new System.Windows.Forms.RadioButton();
            this.rbn15Godina = new System.Windows.Forms.RadioButton();
            this.rbn20Godina = new System.Windows.Forms.RadioButton();
            this.gBoxVrednost = new System.Windows.Forms.GroupBox();
            this.rbnVece = new System.Windows.Forms.RadioButton();
            this.rbnManje = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gBoxGodine.SuspendLayout();
            this.gBoxVrednost.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(444, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(657, 633);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zaposleni koji su pre godinu dana";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(34, 73);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(345, 33);
            this.btnPrikazi.TabIndex = 2;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 657);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ukupan broj korisnika";
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(315, 650);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(100, 20);
            this.txtUkupno.TabIndex = 4;
            // 
            // btnGodina
            // 
            this.btnGodina.Location = new System.Drawing.Point(23, 549);
            this.btnGodina.Name = "btnGodina";
            this.btnGodina.Size = new System.Drawing.Size(345, 33);
            this.btnGodina.TabIndex = 6;
            this.btnGodina.Text = "Prikazi";
            this.btnGodina.UseVisualStyleBackColor = true;
            this.btnGodina.Click += new System.EventHandler(this.btnGodina_Click);
            // 
            // gBoxGodine
            // 
            this.gBoxGodine.Controls.Add(this.rbn20Godina);
            this.gBoxGodine.Controls.Add(this.rbn15Godina);
            this.gBoxGodine.Controls.Add(this.rbn10Godina);
            this.gBoxGodine.Controls.Add(this.rbn5Godina);
            this.gBoxGodine.Controls.Add(this.rbn2Godine);
            this.gBoxGodine.Location = new System.Drawing.Point(34, 208);
            this.gBoxGodine.Name = "gBoxGodine";
            this.gBoxGodine.Size = new System.Drawing.Size(345, 226);
            this.gBoxGodine.TabIndex = 7;
            this.gBoxGodine.TabStop = false;
            this.gBoxGodine.Text = "Godine";
            // 
            // rbn2Godine
            // 
            this.rbn2Godine.AutoSize = true;
            this.rbn2Godine.Location = new System.Drawing.Point(7, 29);
            this.rbn2Godine.Name = "rbn2Godine";
            this.rbn2Godine.Size = new System.Drawing.Size(84, 17);
            this.rbn2Godine.TabIndex = 0;
            this.rbn2Godine.TabStop = true;
            this.rbn2Godine.Text = "pre 2 godine";
            this.rbn2Godine.UseVisualStyleBackColor = true;
            this.rbn2Godine.CheckedChanged += new System.EventHandler(this.rbn2Godine_CheckedChanged);
            // 
            // rbn5Godina
            // 
            this.rbn5Godina.AutoSize = true;
            this.rbn5Godina.Location = new System.Drawing.Point(7, 69);
            this.rbn5Godina.Name = "rbn5Godina";
            this.rbn5Godina.Size = new System.Drawing.Size(87, 17);
            this.rbn5Godina.TabIndex = 1;
            this.rbn5Godina.TabStop = true;
            this.rbn5Godina.Text = "pre  5 godina";
            this.rbn5Godina.UseVisualStyleBackColor = true;
            this.rbn5Godina.CheckedChanged += new System.EventHandler(this.rbn5Godina_CheckedChanged);
            // 
            // rbn10Godina
            // 
            this.rbn10Godina.AutoSize = true;
            this.rbn10Godina.Location = new System.Drawing.Point(7, 105);
            this.rbn10Godina.Name = "rbn10Godina";
            this.rbn10Godina.Size = new System.Drawing.Size(90, 17);
            this.rbn10Godina.TabIndex = 2;
            this.rbn10Godina.TabStop = true;
            this.rbn10Godina.Text = "pre 10 godina";
            this.rbn10Godina.UseVisualStyleBackColor = true;
            this.rbn10Godina.CheckedChanged += new System.EventHandler(this.rbn10Godina_CheckedChanged);
            // 
            // rbn15Godina
            // 
            this.rbn15Godina.AutoSize = true;
            this.rbn15Godina.Location = new System.Drawing.Point(6, 137);
            this.rbn15Godina.Name = "rbn15Godina";
            this.rbn15Godina.Size = new System.Drawing.Size(90, 17);
            this.rbn15Godina.TabIndex = 3;
            this.rbn15Godina.TabStop = true;
            this.rbn15Godina.Text = "pre 15 godina";
            this.rbn15Godina.UseVisualStyleBackColor = true;
            this.rbn15Godina.CheckedChanged += new System.EventHandler(this.rbn15Godina_CheckedChanged);
            // 
            // rbn20Godina
            // 
            this.rbn20Godina.AutoSize = true;
            this.rbn20Godina.Location = new System.Drawing.Point(6, 171);
            this.rbn20Godina.Name = "rbn20Godina";
            this.rbn20Godina.Size = new System.Drawing.Size(90, 17);
            this.rbn20Godina.TabIndex = 4;
            this.rbn20Godina.TabStop = true;
            this.rbn20Godina.Text = "pre 20 godina";
            this.rbn20Godina.UseVisualStyleBackColor = true;
            this.rbn20Godina.CheckedChanged += new System.EventHandler(this.rbn20Godina_CheckedChanged);
            // 
            // gBoxVrednost
            // 
            this.gBoxVrednost.Controls.Add(this.rbnManje);
            this.gBoxVrednost.Controls.Add(this.rbnVece);
            this.gBoxVrednost.Location = new System.Drawing.Point(34, 125);
            this.gBoxVrednost.Name = "gBoxVrednost";
            this.gBoxVrednost.Size = new System.Drawing.Size(345, 67);
            this.gBoxVrednost.TabIndex = 8;
            this.gBoxVrednost.TabStop = false;
            this.gBoxVrednost.Text = "Vrednost";
            // 
            // rbnVece
            // 
            this.rbnVece.AutoSize = true;
            this.rbnVece.Location = new System.Drawing.Point(12, 31);
            this.rbnVece.Name = "rbnVece";
            this.rbnVece.Size = new System.Drawing.Size(64, 17);
            this.rbnVece.TabIndex = 0;
            this.rbnVece.TabStop = true;
            this.rbnVece.Text = "> - vece";
            this.rbnVece.UseVisualStyleBackColor = true;
            this.rbnVece.CheckedChanged += new System.EventHandler(this.rbnVece_CheckedChanged);
            // 
            // rbnManje
            // 
            this.rbnManje.AutoSize = true;
            this.rbnManje.Location = new System.Drawing.Point(207, 31);
            this.rbnManje.Name = "rbnManje";
            this.rbnManje.Size = new System.Drawing.Size(68, 17);
            this.rbnManje.TabIndex = 1;
            this.rbnManje.TabStop = true;
            this.rbnManje.Text = "< - manje";
            this.rbnManje.UseVisualStyleBackColor = true;
            this.rbnManje.CheckedChanged += new System.EventHandler(this.rbnManje_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 506);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // ZaposleniVreme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 696);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gBoxVrednost);
            this.Controls.Add(this.gBoxGodine);
            this.Controls.Add(this.btnGodina);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ZaposleniVreme";
            this.Text = "ZaposleniVreme";
            this.Load += new System.EventHandler(this.ZaposleniVreme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gBoxGodine.ResumeLayout(false);
            this.gBoxGodine.PerformLayout();
            this.gBoxVrednost.ResumeLayout(false);
            this.gBoxVrednost.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.Button btnGodina;
        private System.Windows.Forms.GroupBox gBoxGodine;
        private System.Windows.Forms.RadioButton rbn20Godina;
        private System.Windows.Forms.RadioButton rbn15Godina;
        private System.Windows.Forms.RadioButton rbn10Godina;
        private System.Windows.Forms.RadioButton rbn5Godina;
        private System.Windows.Forms.RadioButton rbn2Godine;
        private System.Windows.Forms.GroupBox gBoxVrednost;
        private System.Windows.Forms.RadioButton rbnManje;
        private System.Windows.Forms.RadioButton rbnVece;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}