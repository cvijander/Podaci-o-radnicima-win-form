namespace Podaci_o_radnicima__.Net_
{
    partial class Dodaj200Radnika
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
            this.txtPocetnaSifra = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBrojRadnika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pocetna sifra / zadnji sfRadnika na stanju";
            // 
            // txtPocetnaSifra
            // 
            this.txtPocetnaSifra.Location = new System.Drawing.Point(35, 231);
            this.txtPocetnaSifra.Name = "txtPocetnaSifra";
            this.txtPocetnaSifra.Size = new System.Drawing.Size(180, 20);
            this.txtPocetnaSifra.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj radnike u bazu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBrojRadnika
            // 
            this.txtBrojRadnika.Location = new System.Drawing.Point(38, 101);
            this.txtBrojRadnika.Name = "txtBrojRadnika";
            this.txtBrojRadnika.Size = new System.Drawing.Size(180, 20);
            this.txtBrojRadnika.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj radnika koji zelite da dodate";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(326, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 626);
            this.dataGridView1.TabIndex = 5;
            // 
            // Dodaj200Radnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 708);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBrojRadnika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPocetnaSifra);
            this.Controls.Add(this.label1);
            this.Name = "Dodaj200Radnika";
            this.Text = "Dodaj vise radnika";
            this.Load += new System.EventHandler(this.Dodaj200Radnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPocetnaSifra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBrojRadnika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}