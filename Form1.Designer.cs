namespace Podaci_o_radnicima__.Net_
{
    partial class Form1
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
            this.btnDodajRadnika = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifraRadnika = new System.Windows.Forms.TextBox();
            this.txtImeRadnika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezimeRadnika = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtPlataRandnika = new System.Windows.Forms.TextBox();
            this.txtPremijaRadnika = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.podaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodaj200RadnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajViseRadnikaUnoseciImeIPrezimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upitiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplikacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plataIPremijaSaIznosomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imeIPrezimeZaSvakogRadnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(511, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 658);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDodajRadnika
            // 
            this.btnDodajRadnika.Location = new System.Drawing.Point(362, 73);
            this.btnDodajRadnika.Name = "btnDodajRadnika";
            this.btnDodajRadnika.Size = new System.Drawing.Size(131, 124);
            this.btnDodajRadnika.TabIndex = 1;
            this.btnDodajRadnika.Text = "Dodaj radnika";
            this.btnDodajRadnika.UseVisualStyleBackColor = true;
            this.btnDodajRadnika.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sifra radnika:";
            // 
            // txtSifraRadnika
            // 
            this.txtSifraRadnika.Location = new System.Drawing.Point(110, 66);
            this.txtSifraRadnika.Name = "txtSifraRadnika";
            this.txtSifraRadnika.Size = new System.Drawing.Size(158, 20);
            this.txtSifraRadnika.TabIndex = 3;
            this.txtSifraRadnika.TextChanged += new System.EventHandler(this.txtSifraRadnika_TextChanged);
            // 
            // txtImeRadnika
            // 
            this.txtImeRadnika.Location = new System.Drawing.Point(110, 110);
            this.txtImeRadnika.Name = "txtImeRadnika";
            this.txtImeRadnika.Size = new System.Drawing.Size(192, 20);
            this.txtImeRadnika.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ime radnika:";
            // 
            // txtPrezimeRadnika
            // 
            this.txtPrezimeRadnika.Location = new System.Drawing.Point(110, 164);
            this.txtPrezimeRadnika.Name = "txtPrezimeRadnika";
            this.txtPrezimeRadnika.Size = new System.Drawing.Size(192, 20);
            this.txtPrezimeRadnika.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prezime radnika:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Datum zaposlenja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Plata radnika:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 221);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // txtPlataRandnika
            // 
            this.txtPlataRandnika.Location = new System.Drawing.Point(110, 272);
            this.txtPlataRandnika.Name = "txtPlataRandnika";
            this.txtPlataRandnika.Size = new System.Drawing.Size(158, 20);
            this.txtPlataRandnika.TabIndex = 12;
            // 
            // txtPremijaRadnika
            // 
            this.txtPremijaRadnika.Location = new System.Drawing.Point(110, 321);
            this.txtPremijaRadnika.Name = "txtPremijaRadnika";
            this.txtPremijaRadnika.Size = new System.Drawing.Size(158, 20);
            this.txtPremijaRadnika.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Premija radnika:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 124);
            this.button2.TabIndex = 15;
            this.button2.Text = "Obrisi radnika";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 63);
            this.button3.TabIndex = 16;
            this.button3.Text = "Obrisi sva polja";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(362, 368);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 124);
            this.button4.TabIndex = 17;
            this.button4.Text = "Azuriraj radnika";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 628);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 53);
            this.button5.TabIndex = 18;
            this.button5.Text = "Zatvori aplikaciju";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1174, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podaciToolStripMenuItem,
            this.upitiToolStripMenuItem,
            this.aplikacijaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1174, 24);
            this.menuStrip2.TabIndex = 20;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // podaciToolStripMenuItem
            // 
            this.podaciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodaj200RadnikaToolStripMenuItem,
            this.dodajViseRadnikaUnoseciImeIPrezimeToolStripMenuItem});
            this.podaciToolStripMenuItem.Name = "podaciToolStripMenuItem";
            this.podaciToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.podaciToolStripMenuItem.Text = "Podaci";
            // 
            // dodaj200RadnikaToolStripMenuItem
            // 
            this.dodaj200RadnikaToolStripMenuItem.Name = "dodaj200RadnikaToolStripMenuItem";
            this.dodaj200RadnikaToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.dodaj200RadnikaToolStripMenuItem.Text = "Dodaj vise radnika odjednom";
            this.dodaj200RadnikaToolStripMenuItem.Click += new System.EventHandler(this.dodaj200RadnikaToolStripMenuItem_Click);
            // 
            // dodajViseRadnikaUnoseciImeIPrezimeToolStripMenuItem
            // 
            this.dodajViseRadnikaUnoseciImeIPrezimeToolStripMenuItem.Name = "dodajViseRadnikaUnoseciImeIPrezimeToolStripMenuItem";
            this.dodajViseRadnikaUnoseciImeIPrezimeToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.dodajViseRadnikaUnoseciImeIPrezimeToolStripMenuItem.Text = "Dodaj vise radnika unoseci ime i prezime";
            this.dodajViseRadnikaUnoseciImeIPrezimeToolStripMenuItem.Click += new System.EventHandler(this.dodajViseRadnikaUnoseciImeIPrezimeToolStripMenuItem_Click);
            // 
            // upitiToolStripMenuItem
            // 
            this.upitiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radniciToolStripMenuItem,
            this.plataIPremijaSaIznosomToolStripMenuItem,
            this.imeIPrezimeZaSvakogRadnikaToolStripMenuItem});
            this.upitiToolStripMenuItem.Name = "upitiToolStripMenuItem";
            this.upitiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.upitiToolStripMenuItem.Text = "Upiti";
            // 
            // radniciToolStripMenuItem
            // 
            this.radniciToolStripMenuItem.Name = "radniciToolStripMenuItem";
            this.radniciToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.radniciToolStripMenuItem.Text = "Max i min za platu, premiju ";
            this.radniciToolStripMenuItem.Click += new System.EventHandler(this.radniciToolStripMenuItem_Click);
            // 
            // aplikacijaToolStripMenuItem
            // 
            this.aplikacijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zatvoriToolStripMenuItem});
            this.aplikacijaToolStripMenuItem.Name = "aplikacijaToolStripMenuItem";
            this.aplikacijaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.aplikacijaToolStripMenuItem.Text = "Aplikacija";
            // 
            // zatvoriToolStripMenuItem
            // 
            this.zatvoriToolStripMenuItem.Name = "zatvoriToolStripMenuItem";
            this.zatvoriToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.zatvoriToolStripMenuItem.Text = "Zatvori ";
            this.zatvoriToolStripMenuItem.Click += new System.EventHandler(this.zatvoriToolStripMenuItem_Click);
            // 
            // plataIPremijaSaIznosomToolStripMenuItem
            // 
            this.plataIPremijaSaIznosomToolStripMenuItem.Name = "plataIPremijaSaIznosomToolStripMenuItem";
            this.plataIPremijaSaIznosomToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.plataIPremijaSaIznosomToolStripMenuItem.Text = "Plata i premija sa iznosom";
            this.plataIPremijaSaIznosomToolStripMenuItem.Click += new System.EventHandler(this.plataIPremijaSaIznosomToolStripMenuItem_Click);
            // 
            // imeIPrezimeZaSvakogRadnikaToolStripMenuItem
            // 
            this.imeIPrezimeZaSvakogRadnikaToolStripMenuItem.Name = "imeIPrezimeZaSvakogRadnikaToolStripMenuItem";
            this.imeIPrezimeZaSvakogRadnikaToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.imeIPrezimeZaSvakogRadnikaToolStripMenuItem.Text = "Ime i prezime za svakog radnika";
            this.imeIPrezimeZaSvakogRadnikaToolStripMenuItem.Click += new System.EventHandler(this.imeIPrezimeZaSvakogRadnikaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 693);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPremijaRadnika);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPlataRandnika);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrezimeRadnika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtImeRadnika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSifraRadnika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajRadnika);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Podaci o radnicima - upravljanje podacima";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDodajRadnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifraRadnika;
        private System.Windows.Forms.TextBox txtImeRadnika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezimeRadnika;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtPlataRandnika;
        private System.Windows.Forms.TextBox txtPremijaRadnika;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem podaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upitiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplikacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zatvoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodaj200RadnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajViseRadnikaUnoseciImeIPrezimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plataIPremijaSaIznosomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imeIPrezimeZaSvakogRadnikaToolStripMenuItem;
    }
}

