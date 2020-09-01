namespace PCShop.Forme
{
    partial class FrmKorisnik
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.lblPotvrdaLozinka = new System.Windows.Forms.Label();
            this.tbxPotvrdaLozinka = new System.Windows.Forms.TextBox();
            this.lblNovaLozinka = new System.Windows.Forms.Label();
            this.tbxNovaLozinka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPostanskiBroj = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxAdresa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxGrad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPromjenaLozinke = new System.Windows.Forms.Label();
            this.lblStaraLozinka = new System.Windows.Forms.Label();
            this.tbxStaraLozinka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(329, 307);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(153, 44);
            this.btnOdustani.TabIndex = 61;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnIzmjeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmjeni.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmjeni.Location = new System.Drawing.Point(329, 358);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(153, 44);
            this.btnIzmjeni.TabIndex = 60;
            this.btnIzmjeni.Text = "Spremi promijene";
            this.btnIzmjeni.UseVisualStyleBackColor = false;
            this.btnIzmjeni.Click += new System.EventHandler(this.BtnIzmjeni_Click);
            // 
            // lblPotvrdaLozinka
            // 
            this.lblPotvrdaLozinka.AutoSize = true;
            this.lblPotvrdaLozinka.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotvrdaLozinka.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPotvrdaLozinka.Location = new System.Drawing.Point(275, 245);
            this.lblPotvrdaLozinka.Name = "lblPotvrdaLozinka";
            this.lblPotvrdaLozinka.Size = new System.Drawing.Size(157, 21);
            this.lblPotvrdaLozinka.TabIndex = 59;
            this.lblPotvrdaLozinka.Text = "Potvrda nove lozinke:";
            this.lblPotvrdaLozinka.Visible = false;
            // 
            // tbxPotvrdaLozinka
            // 
            this.tbxPotvrdaLozinka.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPotvrdaLozinka.Location = new System.Drawing.Point(278, 268);
            this.tbxPotvrdaLozinka.Name = "tbxPotvrdaLozinka";
            this.tbxPotvrdaLozinka.Size = new System.Drawing.Size(205, 21);
            this.tbxPotvrdaLozinka.TabIndex = 58;
            this.tbxPotvrdaLozinka.Visible = false;
            // 
            // lblNovaLozinka
            // 
            this.lblNovaLozinka.AutoSize = true;
            this.lblNovaLozinka.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaLozinka.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNovaLozinka.Location = new System.Drawing.Point(275, 193);
            this.lblNovaLozinka.Name = "lblNovaLozinka";
            this.lblNovaLozinka.Size = new System.Drawing.Size(103, 21);
            this.lblNovaLozinka.TabIndex = 57;
            this.lblNovaLozinka.Text = "Nova lozinka:";
            this.lblNovaLozinka.Visible = false;
            // 
            // tbxNovaLozinka
            // 
            this.tbxNovaLozinka.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNovaLozinka.Location = new System.Drawing.Point(278, 215);
            this.tbxNovaLozinka.Name = "tbxNovaLozinka";
            this.tbxNovaLozinka.Size = new System.Drawing.Size(205, 21);
            this.tbxNovaLozinka.TabIndex = 56;
            this.tbxNovaLozinka.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(33, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 55;
            this.label6.Text = "Poštanski broj:";
            // 
            // tbxPostanskiBroj
            // 
            this.tbxPostanskiBroj.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPostanskiBroj.Location = new System.Drawing.Point(36, 370);
            this.tbxPostanskiBroj.Name = "tbxPostanskiBroj";
            this.tbxPostanskiBroj.Size = new System.Drawing.Size(205, 21);
            this.tbxPostanskiBroj.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(33, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 21);
            this.label7.TabIndex = 53;
            this.label7.Text = "Adresa:";
            // 
            // tbxAdresa
            // 
            this.tbxAdresa.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAdresa.Location = new System.Drawing.Point(36, 319);
            this.tbxAdresa.Name = "tbxAdresa";
            this.tbxAdresa.Size = new System.Drawing.Size(205, 21);
            this.tbxAdresa.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(33, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 21);
            this.label8.TabIndex = 51;
            this.label8.Text = "Grad:";
            // 
            // tbxGrad
            // 
            this.tbxGrad.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGrad.Location = new System.Drawing.Point(36, 266);
            this.tbxGrad.Name = "tbxGrad";
            this.tbxGrad.Size = new System.Drawing.Size(205, 21);
            this.tbxGrad.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(33, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 49;
            this.label5.Text = "E-mail:";
            // 
            // tbxMail
            // 
            this.tbxMail.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMail.Location = new System.Drawing.Point(36, 215);
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.Size = new System.Drawing.Size(205, 21);
            this.tbxMail.TabIndex = 48;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnickoIme.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(214, 53);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(97, 26);
            this.lblKorisnickoIme.TabIndex = 47;
            this.lblKorisnickoIme.Text = "XXXXX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(33, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 46;
            this.label3.Text = "Prezime:";
            // 
            // tbxPrezime
            // 
            this.tbxPrezime.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrezime.Location = new System.Drawing.Point(36, 164);
            this.tbxPrezime.Name = "tbxPrezime";
            this.tbxPrezime.Size = new System.Drawing.Size(205, 21);
            this.tbxPrezime.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(33, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Ime:";
            // 
            // tbxIme
            // 
            this.tbxIme.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIme.Location = new System.Drawing.Point(36, 111);
            this.tbxIme.Name = "tbxIme";
            this.tbxIme.Size = new System.Drawing.Size(205, 21);
            this.tbxIme.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 32);
            this.label1.TabIndex = 42;
            this.label1.Text = "Informacije o korisniku";
            // 
            // lblPromjenaLozinke
            // 
            this.lblPromjenaLozinke.AutoSize = true;
            this.lblPromjenaLozinke.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromjenaLozinke.Location = new System.Drawing.Point(262, 100);
            this.lblPromjenaLozinke.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromjenaLozinke.Name = "lblPromjenaLozinke";
            this.lblPromjenaLozinke.Size = new System.Drawing.Size(242, 31);
            this.lblPromjenaLozinke.TabIndex = 62;
            this.lblPromjenaLozinke.Text = "Promijena lozinke?";
            this.lblPromjenaLozinke.Click += new System.EventHandler(this.LblZaboravljenaLozinka_Click);
            // 
            // lblStaraLozinka
            // 
            this.lblStaraLozinka.AutoSize = true;
            this.lblStaraLozinka.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaraLozinka.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStaraLozinka.Location = new System.Drawing.Point(276, 141);
            this.lblStaraLozinka.Name = "lblStaraLozinka";
            this.lblStaraLozinka.Size = new System.Drawing.Size(101, 21);
            this.lblStaraLozinka.TabIndex = 64;
            this.lblStaraLozinka.Text = "Stara lozinka:";
            this.lblStaraLozinka.Visible = false;
            // 
            // tbxStaraLozinka
            // 
            this.tbxStaraLozinka.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStaraLozinka.Location = new System.Drawing.Point(279, 164);
            this.tbxStaraLozinka.Name = "tbxStaraLozinka";
            this.tbxStaraLozinka.Size = new System.Drawing.Size(205, 21);
            this.tbxStaraLozinka.TabIndex = 63;
            this.tbxStaraLozinka.Visible = false;
            // 
            // FrmKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(519, 427);
            this.Controls.Add(this.lblStaraLozinka);
            this.Controls.Add(this.tbxStaraLozinka);
            this.Controls.Add(this.lblPromjenaLozinke);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.lblPotvrdaLozinka);
            this.Controls.Add(this.tbxPotvrdaLozinka);
            this.Controls.Add(this.lblNovaLozinka);
            this.Controls.Add(this.tbxNovaLozinka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxPostanskiBroj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxAdresa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxGrad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxMail);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxIme);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmKorisnik";
            this.Text = "FrmKorisnik";
            this.Load += new System.EventHandler(this.FrmKorisnik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Label lblPotvrdaLozinka;
        private System.Windows.Forms.TextBox tbxPotvrdaLozinka;
        private System.Windows.Forms.Label lblNovaLozinka;
        private System.Windows.Forms.TextBox tbxNovaLozinka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxPostanskiBroj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxAdresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxGrad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPromjenaLozinke;
        private System.Windows.Forms.Label lblStaraLozinka;
        private System.Windows.Forms.TextBox tbxStaraLozinka;
    }
}