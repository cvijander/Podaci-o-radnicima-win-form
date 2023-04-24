namespace Podaci_o_radnicima__.Net_
{
    partial class Upiti
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbnMax = new System.Windows.Forms.RadioButton();
            this.rbtMin = new System.Windows.Forms.RadioButton();
            this.rbtSifraRadnika = new System.Windows.Forms.RadioButton();
            this.rbtPlata = new System.Windows.Forms.RadioButton();
            this.rbnPremija = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(550, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 640);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtMin);
            this.groupBox1.Controls.Add(this.rbnMax);
            this.groupBox1.Location = new System.Drawing.Point(24, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odabrati MAX ili MIN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbnPremija);
            this.groupBox2.Controls.Add(this.rbtPlata);
            this.groupBox2.Controls.Add(this.rbtSifraRadnika);
            this.groupBox2.Location = new System.Drawing.Point(266, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 166);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sifra, Plata, Premija";
            // 
            // rbnMax
            // 
            this.rbnMax.AutoSize = true;
            this.rbnMax.Location = new System.Drawing.Point(18, 40);
            this.rbnMax.Name = "rbnMax";
            this.rbnMax.Size = new System.Drawing.Size(75, 17);
            this.rbnMax.TabIndex = 0;
            this.rbnMax.TabStop = true;
            this.rbnMax.Text = "Maximalna";
            this.rbnMax.UseVisualStyleBackColor = true;
            this.rbnMax.CheckedChanged += new System.EventHandler(this.rbnMax_CheckedChanged);
            // 
            // rbtMin
            // 
            this.rbtMin.AutoSize = true;
            this.rbtMin.Location = new System.Drawing.Point(18, 95);
            this.rbtMin.Name = "rbtMin";
            this.rbtMin.Size = new System.Drawing.Size(72, 17);
            this.rbtMin.TabIndex = 1;
            this.rbtMin.TabStop = true;
            this.rbtMin.Text = "Minimalna";
            this.rbtMin.UseVisualStyleBackColor = true;
            this.rbtMin.CheckedChanged += new System.EventHandler(this.rbtMin_CheckedChanged);
            // 
            // rbtSifraRadnika
            // 
            this.rbtSifraRadnika.AutoSize = true;
            this.rbtSifraRadnika.Location = new System.Drawing.Point(16, 40);
            this.rbtSifraRadnika.Name = "rbtSifraRadnika";
            this.rbtSifraRadnika.Size = new System.Drawing.Size(84, 17);
            this.rbtSifraRadnika.TabIndex = 1;
            this.rbtSifraRadnika.TabStop = true;
            this.rbtSifraRadnika.Text = "Sifra radnika";
            this.rbtSifraRadnika.UseVisualStyleBackColor = true;
            this.rbtSifraRadnika.CheckedChanged += new System.EventHandler(this.rbtSifraRadnika_CheckedChanged);
            // 
            // rbtPlata
            // 
            this.rbtPlata.AutoSize = true;
            this.rbtPlata.Location = new System.Drawing.Point(16, 84);
            this.rbtPlata.Name = "rbtPlata";
            this.rbtPlata.Size = new System.Drawing.Size(49, 17);
            this.rbtPlata.TabIndex = 2;
            this.rbtPlata.TabStop = true;
            this.rbtPlata.Text = "Plata";
            this.rbtPlata.UseVisualStyleBackColor = true;
            this.rbtPlata.CheckedChanged += new System.EventHandler(this.rbtPlata_CheckedChanged);
            // 
            // rbnPremija
            // 
            this.rbnPremija.AutoSize = true;
            this.rbnPremija.Location = new System.Drawing.Point(16, 119);
            this.rbnPremija.Name = "rbnPremija";
            this.rbnPremija.Size = new System.Drawing.Size(59, 17);
            this.rbnPremija.TabIndex = 3;
            this.rbnPremija.TabStop = true;
            this.rbnPremija.Text = "Premija";
            this.rbnPremija.UseVisualStyleBackColor = true;
            this.rbnPremija.CheckedChanged += new System.EventHandler(this.rbnPremija_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 316);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(413, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(411, 64);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(106, 96);
            this.btnIzracunaj.TabIndex = 4;
            this.btnIzracunaj.Text = "Izracunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Odaberite max /min  i neku od sifra /plata /premija da bi videli  najvece /najman" +
    "je vrednosti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Double click na teksualno polje da bi videli koji je to radnik sa datim podatkom " +
    "";
            // 
            // Upiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 704);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Upiti";
            this.Text = "Upiti";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtMin;
        private System.Windows.Forms.RadioButton rbnMax;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbnPremija;
        private System.Windows.Forms.RadioButton rbtPlata;
        private System.Windows.Forms.RadioButton rbtSifraRadnika;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}