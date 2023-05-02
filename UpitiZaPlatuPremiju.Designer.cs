namespace Podaci_o_radnicima__.Net_
{
    partial class UpitiZaPlatuPremiju
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
            this.gBoxVrednost = new System.Windows.Forms.GroupBox();
            this.rbnManje = new System.Windows.Forms.RadioButton();
            this.rbnVece = new System.Windows.Forms.RadioButton();
            this.gboxGrupa = new System.Windows.Forms.GroupBox();
            this.rbnPremija = new System.Windows.Forms.RadioButton();
            this.rbnPlata = new System.Windows.Forms.RadioButton();
            this.gboxIznos = new System.Windows.Forms.GroupBox();
            this.rbn5000 = new System.Windows.Forms.RadioButton();
            this.rbn150000 = new System.Windows.Forms.RadioButton();
            this.rbn125000 = new System.Windows.Forms.RadioButton();
            this.rbn100000 = new System.Windows.Forms.RadioButton();
            this.rbn75000 = new System.Windows.Forms.RadioButton();
            this.rbn50000 = new System.Windows.Forms.RadioButton();
            this.rbn25000 = new System.Windows.Forms.RadioButton();
            this.rbn15000 = new System.Windows.Forms.RadioButton();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gBoxVrednost.SuspendLayout();
            this.gboxGrupa.SuspendLayout();
            this.gboxIznos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite vrednosti koji zelite ili odaberite od ponudjenih ";
            // 
            // gBoxVrednost
            // 
            this.gBoxVrednost.Controls.Add(this.rbnManje);
            this.gBoxVrednost.Controls.Add(this.rbnVece);
            this.gBoxVrednost.Location = new System.Drawing.Point(265, 100);
            this.gBoxVrednost.Name = "gBoxVrednost";
            this.gBoxVrednost.Size = new System.Drawing.Size(200, 100);
            this.gBoxVrednost.TabIndex = 2;
            this.gBoxVrednost.TabStop = false;
            this.gBoxVrednost.Text = "Vrednosti je veca ili manja";
            // 
            // rbnManje
            // 
            this.rbnManje.AutoSize = true;
            this.rbnManje.Location = new System.Drawing.Point(19, 62);
            this.rbnManje.Name = "rbnManje";
            this.rbnManje.Size = new System.Drawing.Size(112, 17);
            this.rbnManje.TabIndex = 1;
            this.rbnManje.TabStop = true;
            this.rbnManje.Text = "manje jednako  <=";
            this.rbnManje.UseVisualStyleBackColor = true;
            this.rbnManje.CheckedChanged += new System.EventHandler(this.rbnManje_CheckedChanged);
            // 
            // rbnVece
            // 
            this.rbnVece.AutoSize = true;
            this.rbnVece.Location = new System.Drawing.Point(19, 20);
            this.rbnVece.Name = "rbnVece";
            this.rbnVece.Size = new System.Drawing.Size(64, 17);
            this.rbnVece.TabIndex = 0;
            this.rbnVece.TabStop = true;
            this.rbnVece.Text = "vece   >";
            this.rbnVece.UseVisualStyleBackColor = true;
            this.rbnVece.CheckedChanged += new System.EventHandler(this.rbnVece_CheckedChanged);
            // 
            // gboxGrupa
            // 
            this.gboxGrupa.Controls.Add(this.rbnPremija);
            this.gboxGrupa.Controls.Add(this.rbnPlata);
            this.gboxGrupa.Location = new System.Drawing.Point(15, 100);
            this.gboxGrupa.Name = "gboxGrupa";
            this.gboxGrupa.Size = new System.Drawing.Size(200, 100);
            this.gboxGrupa.TabIndex = 3;
            this.gboxGrupa.TabStop = false;
            this.gboxGrupa.Text = "plata / premija";
            this.gboxGrupa.Enter += new System.EventHandler(this.gboxGrupa_Enter);
            // 
            // rbnPremija
            // 
            this.rbnPremija.AutoSize = true;
            this.rbnPremija.Location = new System.Drawing.Point(13, 63);
            this.rbnPremija.Name = "rbnPremija";
            this.rbnPremija.Size = new System.Drawing.Size(58, 17);
            this.rbnPremija.TabIndex = 1;
            this.rbnPremija.TabStop = true;
            this.rbnPremija.Text = "premija";
            this.rbnPremija.UseVisualStyleBackColor = true;
            this.rbnPremija.CheckedChanged += new System.EventHandler(this.rbnPremija_CheckedChanged);
            // 
            // rbnPlata
            // 
            this.rbnPlata.AutoSize = true;
            this.rbnPlata.Location = new System.Drawing.Point(13, 31);
            this.rbnPlata.Name = "rbnPlata";
            this.rbnPlata.Size = new System.Drawing.Size(48, 17);
            this.rbnPlata.TabIndex = 0;
            this.rbnPlata.TabStop = true;
            this.rbnPlata.Text = "plata";
            this.rbnPlata.UseVisualStyleBackColor = true;
            this.rbnPlata.CheckedChanged += new System.EventHandler(this.rbnPlata_CheckedChanged);
            // 
            // gboxIznos
            // 
            this.gboxIznos.Controls.Add(this.rbn5000);
            this.gboxIznos.Controls.Add(this.rbn150000);
            this.gboxIznos.Controls.Add(this.rbn125000);
            this.gboxIznos.Controls.Add(this.rbn100000);
            this.gboxIznos.Controls.Add(this.rbn75000);
            this.gboxIznos.Controls.Add(this.rbn50000);
            this.gboxIznos.Controls.Add(this.rbn25000);
            this.gboxIznos.Controls.Add(this.rbn15000);
            this.gboxIznos.Location = new System.Drawing.Point(507, 100);
            this.gboxIznos.Name = "gboxIznos";
            this.gboxIznos.Size = new System.Drawing.Size(550, 100);
            this.gboxIznos.TabIndex = 4;
            this.gboxIznos.TabStop = false;
            this.gboxIznos.Text = "Iznos";
            // 
            // rbn5000
            // 
            this.rbn5000.AutoSize = true;
            this.rbn5000.Location = new System.Drawing.Point(12, 20);
            this.rbn5000.Name = "rbn5000";
            this.rbn5000.Size = new System.Drawing.Size(49, 17);
            this.rbn5000.TabIndex = 7;
            this.rbn5000.TabStop = true;
            this.rbn5000.Text = "5000";
            this.rbn5000.UseVisualStyleBackColor = true;
            this.rbn5000.CheckedChanged += new System.EventHandler(this.rbn5000_CheckedChanged);
            // 
            // rbn150000
            // 
            this.rbn150000.AutoSize = true;
            this.rbn150000.Location = new System.Drawing.Point(427, 63);
            this.rbn150000.Name = "rbn150000";
            this.rbn150000.Size = new System.Drawing.Size(61, 17);
            this.rbn150000.TabIndex = 6;
            this.rbn150000.TabStop = true;
            this.rbn150000.Text = "150000";
            this.rbn150000.UseVisualStyleBackColor = true;
            this.rbn150000.CheckedChanged += new System.EventHandler(this.rbn150000_CheckedChanged);
            // 
            // rbn125000
            // 
            this.rbn125000.AutoSize = true;
            this.rbn125000.Location = new System.Drawing.Point(286, 63);
            this.rbn125000.Name = "rbn125000";
            this.rbn125000.Size = new System.Drawing.Size(61, 17);
            this.rbn125000.TabIndex = 5;
            this.rbn125000.TabStop = true;
            this.rbn125000.Text = "125000";
            this.rbn125000.UseVisualStyleBackColor = true;
            this.rbn125000.CheckedChanged += new System.EventHandler(this.rbn125000_CheckedChanged);
            // 
            // rbn100000
            // 
            this.rbn100000.AutoSize = true;
            this.rbn100000.Location = new System.Drawing.Point(114, 63);
            this.rbn100000.Name = "rbn100000";
            this.rbn100000.Size = new System.Drawing.Size(61, 17);
            this.rbn100000.TabIndex = 4;
            this.rbn100000.TabStop = true;
            this.rbn100000.Text = "100000";
            this.rbn100000.UseVisualStyleBackColor = true;
            this.rbn100000.CheckedChanged += new System.EventHandler(this.rbn100000_CheckedChanged);
            // 
            // rbn75000
            // 
            this.rbn75000.AutoSize = true;
            this.rbn75000.Location = new System.Drawing.Point(12, 63);
            this.rbn75000.Name = "rbn75000";
            this.rbn75000.Size = new System.Drawing.Size(55, 17);
            this.rbn75000.TabIndex = 3;
            this.rbn75000.TabStop = true;
            this.rbn75000.Text = "75000";
            this.rbn75000.UseVisualStyleBackColor = true;
            this.rbn75000.CheckedChanged += new System.EventHandler(this.rbn75000_CheckedChanged);
            // 
            // rbn50000
            // 
            this.rbn50000.AutoSize = true;
            this.rbn50000.Location = new System.Drawing.Point(433, 19);
            this.rbn50000.Name = "rbn50000";
            this.rbn50000.Size = new System.Drawing.Size(55, 17);
            this.rbn50000.TabIndex = 2;
            this.rbn50000.TabStop = true;
            this.rbn50000.Text = "50000";
            this.rbn50000.UseVisualStyleBackColor = true;
            this.rbn50000.CheckedChanged += new System.EventHandler(this.rbn50000_CheckedChanged);
            // 
            // rbn25000
            // 
            this.rbn25000.AutoSize = true;
            this.rbn25000.Location = new System.Drawing.Point(286, 20);
            this.rbn25000.Name = "rbn25000";
            this.rbn25000.Size = new System.Drawing.Size(55, 17);
            this.rbn25000.TabIndex = 1;
            this.rbn25000.TabStop = true;
            this.rbn25000.Text = "25000";
            this.rbn25000.UseVisualStyleBackColor = true;
            this.rbn25000.CheckedChanged += new System.EventHandler(this.rbn25000_CheckedChanged);
            // 
            // rbn15000
            // 
            this.rbn15000.AutoSize = true;
            this.rbn15000.Location = new System.Drawing.Point(114, 20);
            this.rbn15000.Name = "rbn15000";
            this.rbn15000.Size = new System.Drawing.Size(55, 17);
            this.rbn15000.TabIndex = 0;
            this.rbn15000.TabStop = true;
            this.rbn15000.Text = "15000";
            this.rbn15000.UseVisualStyleBackColor = true;
            this.rbn15000.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(15, 217);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(1042, 48);
            this.btnPrikazi.TabIndex = 5;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1042, 334);
            this.dataGridView1.TabIndex = 6;
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(955, 55);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(92, 20);
            this.txtUkupno.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(773, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ukupno radnika sa tom vrednoscu :";
            // 
            // txtUnos
            // 
            this.txtUnos.Location = new System.Drawing.Point(282, 48);
            this.txtUnos.Name = "txtUnos";
            this.txtUnos.Size = new System.Drawing.Size(100, 20);
            this.txtUnos.TabIndex = 9;
            this.txtUnos.TextChanged += new System.EventHandler(this.txtUnos_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(496, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "U tekstualno polje ili unosite vrednosti ili dole odabirom mozete birati neku od " +
    "ponudjenih 5000 ...150000";
            // 
            // UpitiZaPlatuPremiju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 647);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUnos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.gboxIznos);
            this.Controls.Add(this.gboxGrupa);
            this.Controls.Add(this.gBoxVrednost);
            this.Controls.Add(this.label1);
            this.Name = "UpitiZaPlatuPremiju";
            this.Text = "Upit za platu premiju";
            this.Load += new System.EventHandler(this.UpitiZaPlatuPremiju_Load);
            this.gBoxVrednost.ResumeLayout(false);
            this.gBoxVrednost.PerformLayout();
            this.gboxGrupa.ResumeLayout(false);
            this.gboxGrupa.PerformLayout();
            this.gboxIznos.ResumeLayout(false);
            this.gboxIznos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBoxVrednost;
        private System.Windows.Forms.RadioButton rbnManje;
        private System.Windows.Forms.RadioButton rbnVece;
        private System.Windows.Forms.GroupBox gboxGrupa;
        private System.Windows.Forms.RadioButton rbnPremija;
        private System.Windows.Forms.RadioButton rbnPlata;
        private System.Windows.Forms.GroupBox gboxIznos;
        private System.Windows.Forms.RadioButton rbn100000;
        private System.Windows.Forms.RadioButton rbn75000;
        private System.Windows.Forms.RadioButton rbn50000;
        private System.Windows.Forms.RadioButton rbn25000;
        private System.Windows.Forms.RadioButton rbn15000;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbn5000;
        private System.Windows.Forms.RadioButton rbn150000;
        private System.Windows.Forms.RadioButton rbn125000;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnos;
        private System.Windows.Forms.Label label3;
    }
}