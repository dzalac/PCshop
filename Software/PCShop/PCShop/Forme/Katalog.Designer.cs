namespace PCShop
{
    partial class FrmKatalog
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
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.btnKosarica = new System.Windows.Forms.Button();
            this.btnArtikli = new System.Windows.Forms.Button();
            this.btnKontakt = new System.Windows.Forms.Button();
            this.txbPretraga = new System.Windows.Forms.TextBox();
            this.lblKategorije = new System.Windows.Forms.Label();
            this.lblGrafickeKartice = new System.Windows.Forms.Label();
            this.lblProcesori = new System.Windows.Forms.Label();
            this.lblRadnaMemorija = new System.Windows.Forms.Label();
            this.lblTvrdiDiskovi = new System.Windows.Forms.Label();
            this.lblMaticnePloce = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.btnOtvoriArtikl = new System.Windows.Forms.Button();
            this.btnSortNazivUzlazno = new System.Windows.Forms.Button();
            this.btnSortCijenaUzlazno = new System.Windows.Forms.Button();
            this.btnOsvjeziPopis = new System.Windows.Forms.Button();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.dgvPosebna = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSortNazivSilazno = new System.Windows.Forms.Button();
            this.btnSortCijenaSilazno = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPC = new System.Windows.Forms.Label();
            this.lblKorisnikoIme = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosebna)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(1079, 12);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(78, 41);
            this.btnPrijava.TabIndex = 1;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.BtnPrijava_Click);
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Location = new System.Drawing.Point(995, 12);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(78, 41);
            this.btnRegistracija.TabIndex = 3;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.BtnRegistracija_Click);
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(812, 12);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(71, 41);
            this.btnTrazi.TabIndex = 4;
            this.btnTrazi.Text = "Pretraga";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.BtnTrazi_Click);
            // 
            // btnKosarica
            // 
            this.btnKosarica.Location = new System.Drawing.Point(911, 12);
            this.btnKosarica.Name = "btnKosarica";
            this.btnKosarica.Size = new System.Drawing.Size(78, 41);
            this.btnKosarica.TabIndex = 6;
            this.btnKosarica.Text = "Košarica";
            this.btnKosarica.UseVisualStyleBackColor = true;
            this.btnKosarica.Click += new System.EventHandler(this.BtnKosarica_Click);
            // 
            // btnArtikli
            // 
            this.btnArtikli.Location = new System.Drawing.Point(231, 12);
            this.btnArtikli.Name = "btnArtikli";
            this.btnArtikli.Size = new System.Drawing.Size(100, 41);
            this.btnArtikli.TabIndex = 8;
            this.btnArtikli.Text = "Upravljaj artiklima";
            this.btnArtikli.UseVisualStyleBackColor = true;
            // 
            // btnKontakt
            // 
            this.btnKontakt.Location = new System.Drawing.Point(17, 12);
            this.btnKontakt.Name = "btnKontakt";
            this.btnKontakt.Size = new System.Drawing.Size(100, 41);
            this.btnKontakt.TabIndex = 7;
            this.btnKontakt.Text = "Kontakt";
            this.btnKontakt.UseVisualStyleBackColor = true;
            this.btnKontakt.Click += new System.EventHandler(this.BtnKontakt_Click);
            // 
            // txbPretraga
            // 
            this.txbPretraga.Location = new System.Drawing.Point(337, 23);
            this.txbPretraga.Name = "txbPretraga";
            this.txbPretraga.Size = new System.Drawing.Size(469, 20);
            this.txbPretraga.TabIndex = 9;
            this.txbPretraga.Text = "Pretraži...";
            // 
            // lblKategorije
            // 
            this.lblKategorije.AutoSize = true;
            this.lblKategorije.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorije.Location = new System.Drawing.Point(12, 87);
            this.lblKategorije.Name = "lblKategorije";
            this.lblKategorije.Size = new System.Drawing.Size(139, 25);
            this.lblKategorije.TabIndex = 10;
            this.lblKategorije.Text = "KATEGORIJE";
            // 
            // lblGrafickeKartice
            // 
            this.lblGrafickeKartice.AutoSize = true;
            this.lblGrafickeKartice.Location = new System.Drawing.Point(30, 125);
            this.lblGrafickeKartice.Name = "lblGrafickeKartice";
            this.lblGrafickeKartice.Size = new System.Drawing.Size(82, 13);
            this.lblGrafickeKartice.TabIndex = 11;
            this.lblGrafickeKartice.Text = "Grafičke kartice";
            this.lblGrafickeKartice.Click += new System.EventHandler(this.LblGrafickeKartice_Click);
            // 
            // lblProcesori
            // 
            this.lblProcesori.AutoSize = true;
            this.lblProcesori.Location = new System.Drawing.Point(30, 151);
            this.lblProcesori.Name = "lblProcesori";
            this.lblProcesori.Size = new System.Drawing.Size(51, 13);
            this.lblProcesori.TabIndex = 12;
            this.lblProcesori.Text = "Procesori\r\n";
            this.lblProcesori.Click += new System.EventHandler(this.LblProcesori_Click);
            // 
            // lblRadnaMemorija
            // 
            this.lblRadnaMemorija.AutoSize = true;
            this.lblRadnaMemorija.Location = new System.Drawing.Point(30, 177);
            this.lblRadnaMemorija.Name = "lblRadnaMemorija";
            this.lblRadnaMemorija.Size = new System.Drawing.Size(83, 13);
            this.lblRadnaMemorija.TabIndex = 13;
            this.lblRadnaMemorija.Text = "Radna memorija\r\n";
            this.lblRadnaMemorija.Click += new System.EventHandler(this.LblRadnaMemorija_Click);
            // 
            // lblTvrdiDiskovi
            // 
            this.lblTvrdiDiskovi.AutoSize = true;
            this.lblTvrdiDiskovi.Location = new System.Drawing.Point(30, 205);
            this.lblTvrdiDiskovi.Name = "lblTvrdiDiskovi";
            this.lblTvrdiDiskovi.Size = new System.Drawing.Size(67, 13);
            this.lblTvrdiDiskovi.TabIndex = 14;
            this.lblTvrdiDiskovi.Text = "Tvrdi diskovi";
            this.lblTvrdiDiskovi.Click += new System.EventHandler(this.LblTvrdiDiskovi_Click);
            // 
            // lblMaticnePloce
            // 
            this.lblMaticnePloce.AutoSize = true;
            this.lblMaticnePloce.Location = new System.Drawing.Point(30, 233);
            this.lblMaticnePloce.Name = "lblMaticnePloce";
            this.lblMaticnePloce.Size = new System.Drawing.Size(74, 13);
            this.lblMaticnePloce.TabIndex = 15;
            this.lblMaticnePloce.Text = "Matične ploče";
            this.lblMaticnePloce.Click += new System.EventHandler(this.LblMaticnePloce_Click);
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.btnOtvoriArtikl);
            this.Panel.Controls.Add(this.btnSortNazivUzlazno);
            this.Panel.Controls.Add(this.btnSortCijenaUzlazno);
            this.Panel.Controls.Add(this.btnOsvjeziPopis);
            this.Panel.Controls.Add(this.dgvArtikli);
            this.Panel.Controls.Add(this.dgvPosebna);
            this.Panel.Controls.Add(this.label4);
            this.Panel.Controls.Add(this.label3);
            this.Panel.Controls.Add(this.btnSortNazivSilazno);
            this.Panel.Controls.Add(this.btnSortCijenaSilazno);
            this.Panel.Controls.Add(this.label2);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Location = new System.Drawing.Point(157, 87);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1000, 552);
            this.Panel.TabIndex = 17;
            // 
            // btnOtvoriArtikl
            // 
            this.btnOtvoriArtikl.Location = new System.Drawing.Point(790, 506);
            this.btnOtvoriArtikl.Name = "btnOtvoriArtikl";
            this.btnOtvoriArtikl.Size = new System.Drawing.Size(75, 37);
            this.btnOtvoriArtikl.TabIndex = 25;
            this.btnOtvoriArtikl.Text = "Pregledaj Artikl";
            this.btnOtvoriArtikl.UseVisualStyleBackColor = true;
            this.btnOtvoriArtikl.Click += new System.EventHandler(this.BtnOtvoriArtikl_Click);
            // 
            // btnSortNazivUzlazno
            // 
            this.btnSortNazivUzlazno.Location = new System.Drawing.Point(480, 506);
            this.btnSortNazivUzlazno.Name = "btnSortNazivUzlazno";
            this.btnSortNazivUzlazno.Size = new System.Drawing.Size(75, 37);
            this.btnSortNazivUzlazno.TabIndex = 24;
            this.btnSortNazivUzlazno.Text = "Uzlazno";
            this.btnSortNazivUzlazno.UseVisualStyleBackColor = true;
            this.btnSortNazivUzlazno.Click += new System.EventHandler(this.BtnSortNazivUzlazno_Click);
            // 
            // btnSortCijenaUzlazno
            // 
            this.btnSortCijenaUzlazno.Location = new System.Drawing.Point(204, 506);
            this.btnSortCijenaUzlazno.Name = "btnSortCijenaUzlazno";
            this.btnSortCijenaUzlazno.Size = new System.Drawing.Size(75, 37);
            this.btnSortCijenaUzlazno.TabIndex = 23;
            this.btnSortCijenaUzlazno.Text = "Uzlazno";
            this.btnSortCijenaUzlazno.UseVisualStyleBackColor = true;
            this.btnSortCijenaUzlazno.Click += new System.EventHandler(this.BtnSortCijenaUzlazno_Click);
            // 
            // btnOsvjeziPopis
            // 
            this.btnOsvjeziPopis.Location = new System.Drawing.Point(871, 506);
            this.btnOsvjeziPopis.Name = "btnOsvjeziPopis";
            this.btnOsvjeziPopis.Size = new System.Drawing.Size(75, 37);
            this.btnOsvjeziPopis.TabIndex = 22;
            this.btnOsvjeziPopis.Text = "Osvjezi katalog";
            this.btnOsvjeziPopis.UseVisualStyleBackColor = true;
            this.btnOsvjeziPopis.Click += new System.EventHandler(this.BtnOsvjeziPopis_Click);
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Location = new System.Drawing.Point(39, 185);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.Size = new System.Drawing.Size(907, 287);
            this.dgvArtikli.TabIndex = 21;
            // 
            // dgvPosebna
            // 
            this.dgvPosebna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosebna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosebna.Location = new System.Drawing.Point(39, 38);
            this.dgvPosebna.Name = "dgvPosebna";
            this.dgvPosebna.Size = new System.Drawing.Size(907, 111);
            this.dgvPosebna.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sortiraj po nazivu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sortiraj po cijeni\r\n";
            // 
            // btnSortNazivSilazno
            // 
            this.btnSortNazivSilazno.Location = new System.Drawing.Point(399, 506);
            this.btnSortNazivSilazno.Name = "btnSortNazivSilazno";
            this.btnSortNazivSilazno.Size = new System.Drawing.Size(75, 37);
            this.btnSortNazivSilazno.TabIndex = 7;
            this.btnSortNazivSilazno.Text = "Silazno";
            this.btnSortNazivSilazno.UseVisualStyleBackColor = true;
            this.btnSortNazivSilazno.Click += new System.EventHandler(this.BtnSortNazivSilazno_Click);
            // 
            // btnSortCijenaSilazno
            // 
            this.btnSortCijenaSilazno.Location = new System.Drawing.Point(123, 506);
            this.btnSortCijenaSilazno.Name = "btnSortCijenaSilazno";
            this.btnSortCijenaSilazno.Size = new System.Drawing.Size(75, 37);
            this.btnSortCijenaSilazno.TabIndex = 5;
            this.btnSortCijenaSilazno.Text = "Silazno";
            this.btnSortCijenaSilazno.UseVisualStyleBackColor = true;
            this.btnSortCijenaSilazno.Click += new System.EventHandler(this.BtnSortCijenaSilazno_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artikli";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Posebna ponuda";
            // 
            // lblPC
            // 
            this.lblPC.AutoSize = true;
            this.lblPC.Location = new System.Drawing.Point(30, 256);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(62, 13);
            this.lblPC.TabIndex = 18;
            this.lblPC.Text = "Prebuild PC\r\n";
            this.lblPC.Click += new System.EventHandler(this.LblPC_Click);
            // 
            // lblKorisnikoIme
            // 
            this.lblKorisnikoIme.AutoSize = true;
            this.lblKorisnikoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnikoIme.Location = new System.Drawing.Point(12, 610);
            this.lblKorisnikoIme.Name = "lblKorisnikoIme";
            this.lblKorisnikoIme.Size = new System.Drawing.Size(127, 20);
            this.lblKorisnikoIme.TabIndex = 19;
            this.lblKorisnikoIme.Text = "Ne ulogirani gost";
            // 
            // FrmKatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1169, 645);
            this.Controls.Add(this.lblKorisnikoIme);
            this.Controls.Add(this.lblPC);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.lblMaticnePloce);
            this.Controls.Add(this.lblTvrdiDiskovi);
            this.Controls.Add(this.lblRadnaMemorija);
            this.Controls.Add(this.lblProcesori);
            this.Controls.Add(this.lblGrafickeKartice);
            this.Controls.Add(this.lblKategorije);
            this.Controls.Add(this.txbPretraga);
            this.Controls.Add(this.btnArtikli);
            this.Controls.Add(this.btnKontakt);
            this.Controls.Add(this.btnKosarica);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.btnPrijava);
            this.KeyPreview = true;
            this.Name = "FrmKatalog";
            this.Text = "Katalog proizvoda";
            this.Load += new System.EventHandler(this.FrmKatalog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKatalog_KeyDown);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosebna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Button btnKosarica;
        private System.Windows.Forms.Button btnArtikli;
        private System.Windows.Forms.Button btnKontakt;
        private System.Windows.Forms.TextBox txbPretraga;
        private System.Windows.Forms.Label lblKategorije;
        private System.Windows.Forms.Label lblGrafickeKartice;
        private System.Windows.Forms.Label lblProcesori;
        private System.Windows.Forms.Label lblRadnaMemorija;
        private System.Windows.Forms.Label lblTvrdiDiskovi;
        private System.Windows.Forms.Label lblMaticnePloce;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button btnSortNazivSilazno;
        private System.Windows.Forms.Button btnSortCijenaSilazno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.DataGridView dgvPosebna;
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.Button btnOsvjeziPopis;
        private System.Windows.Forms.Button btnSortNazivUzlazno;
        private System.Windows.Forms.Button btnSortCijenaUzlazno;
        private System.Windows.Forms.Button btnOtvoriArtikl;
        private System.Windows.Forms.Label lblKorisnikoIme;
    }
}

