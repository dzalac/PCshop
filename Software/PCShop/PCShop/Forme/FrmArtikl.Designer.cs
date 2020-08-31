namespace PCShop
{
    partial class FrmArtikl
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.rtbxOpis = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblStaraCijena = new System.Windows.Forms.Label();
            this.lblStaraCijenaIznos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(571, 411);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Kolicina:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(644, 411);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(4);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(132, 22);
            this.txtKolicina.TabIndex = 28;
            this.txtKolicina.Text = "1";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(785, 393);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(103, 57);
            this.btnDodaj.TabIndex = 27;
            this.btnDodaj.Text = "Dodaj u košaricu";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(896, 393);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(103, 57);
            this.btnOdustani.TabIndex = 26;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // rtbxOpis
            // 
            this.rtbxOpis.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxOpis.Location = new System.Drawing.Point(537, 80);
            this.rtbxOpis.Margin = new System.Windows.Forms.Padding(4);
            this.rtbxOpis.Name = "rtbxOpis";
            this.rtbxOpis.ReadOnly = true;
            this.rtbxOpis.Size = new System.Drawing.Size(460, 286);
            this.rtbxOpis.TabIndex = 25;
            this.rtbxOpis.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(545, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Opis artikla:";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCijena.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCijena.Location = new System.Drawing.Point(107, 379);
            this.lblCijena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(48, 32);
            this.lblCijena.TabIndex = 23;
            this.lblCijena.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(26, 382);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cijena: ";
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(32, 80);
            this.pbSlika.Margin = new System.Windows.Forms.Padding(4);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(387, 283);
            this.pbSlika.TabIndex = 21;
            this.pbSlika.TabStop = false;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNaziv.Location = new System.Drawing.Point(36, 23);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(213, 39);
            this.lblNaziv.TabIndex = 20;
            this.lblNaziv.Text = "Naziv artikla";
            // 
            // lblStaraCijena
            // 
            this.lblStaraCijena.AutoSize = true;
            this.lblStaraCijena.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaraCijena.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStaraCijena.Location = new System.Drawing.Point(26, 411);
            this.lblStaraCijena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaraCijena.Name = "lblStaraCijena";
            this.lblStaraCijena.Size = new System.Drawing.Size(118, 25);
            this.lblStaraCijena.TabIndex = 22;
            this.lblStaraCijena.Text = "Stara cijena: ";
            this.lblStaraCijena.Visible = false;
            // 
            // lblStaraCijenaIznos
            // 
            this.lblStaraCijenaIznos.AutoSize = true;
            this.lblStaraCijenaIznos.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaraCijenaIznos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStaraCijenaIznos.Location = new System.Drawing.Point(136, 411);
            this.lblStaraCijenaIznos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaraCijenaIznos.Name = "lblStaraCijenaIznos";
            this.lblStaraCijenaIznos.Size = new System.Drawing.Size(39, 25);
            this.lblStaraCijenaIznos.TabIndex = 23;
            this.lblStaraCijenaIznos.Text = "???";
            this.lblStaraCijenaIznos.Visible = false;
            // 
            // FrmArtikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1029, 471);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.rtbxOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStaraCijenaIznos);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblStaraCijena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.lblNaziv);
            this.Name = "FrmArtikl";
            this.Text = "FrmArtikl";
            this.Load += new System.EventHandler(this.FrmArtikl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.RichTextBox rtbxOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblStaraCijena;
        private System.Windows.Forms.Label lblStaraCijenaIznos;
    }
}