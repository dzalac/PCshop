namespace PCShop.Forme
{
    partial class FrmArtikli
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbxOpis = new System.Windows.Forms.RichTextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.tbxKolicina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(29, 28);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(163, 31);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv artikla";
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(35, 89);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(290, 230);
            this.pbSlika.TabIndex = 1;
            this.pbSlika.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cijena(kn): ";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCijena.Location = new System.Drawing.Point(142, 354);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(40, 24);
            this.lblCijena.TabIndex = 3;
            this.lblCijena.Text = "???";
            this.lblCijena.Click += new System.EventHandler(this.LblCijena_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Opis artikla:";
            // 
            // rtbxOpis
            // 
            this.rtbxOpis.Location = new System.Drawing.Point(414, 89);
            this.rtbxOpis.Name = "rtbxOpis";
            this.rtbxOpis.Size = new System.Drawing.Size(346, 233);
            this.rtbxOpis.TabIndex = 5;
            this.rtbxOpis.Text = "";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(683, 344);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(77, 46);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(600, 344);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(77, 46);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj u košaricu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // tbxKolicina
            // 
            this.tbxKolicina.Location = new System.Drawing.Point(494, 358);
            this.tbxKolicina.Name = "tbxKolicina";
            this.tbxKolicina.Size = new System.Drawing.Size(100, 20);
            this.tbxKolicina.TabIndex = 8;
            this.tbxKolicina.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kolicina:";
            // 
            // FrmArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxKolicina);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.rtbxOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.lblNaziv);
            this.KeyPreview = true;
            this.Name = "FrmArtikli";
            this.Text = "Artikl";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmArtikl_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbxOpis;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox tbxKolicina;
        private System.Windows.Forms.Label label3;
    }
}