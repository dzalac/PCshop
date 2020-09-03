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
            this.lblKategorije = new System.Windows.Forms.Label();
            this.lblGrafickeKartice = new System.Windows.Forms.Label();
            this.lblProcesori = new System.Windows.Forms.Label();
            this.lblRadnaMemorija = new System.Windows.Forms.Label();
            this.lblTvrdiDiskovi = new System.Windows.Forms.Label();
            this.lblMaticnePloce = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.flpPosebna = new System.Windows.Forms.FlowLayoutPanel();
            this.flpArtikli = new System.Windows.Forms.FlowLayoutPanel();
            this.rbtnPopust = new System.Windows.Forms.RadioButton();
            this.rbtnNoviProizodi = new System.Windows.Forms.RadioButton();
            this.btnSortNazivUzlazno = new System.Windows.Forms.Button();
            this.btnSortCijenaUzlazno = new System.Windows.Forms.Button();
            this.btnOsvjeziPopis = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSortNazivSilazno = new System.Windows.Forms.Button();
            this.btnSortCijenaSilazno = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPC = new System.Windows.Forms.Label();
            this.pnKategorije1 = new System.Windows.Forms.Panel();
            this.pbKorisnik = new System.Windows.Forms.PictureBox();
            this.lblKorisnikoIme = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbPretraga = new System.Windows.Forms.TextBox();
            this.btnUpravljajNarudzbama = new System.Windows.Forms.Button();
            this.btnPregledajNarudzbe = new System.Windows.Forms.Button();
            this.btnArtikli = new System.Windows.Forms.Button();
            this.btnKosarica = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.btnKontakt = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.pnKategorije1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKorisnik)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKategorije
            // 
            this.lblKategorije.AutoSize = true;
            this.lblKategorije.BackColor = System.Drawing.Color.Transparent;
            this.lblKategorije.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorije.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKategorije.Location = new System.Drawing.Point(14, 24);
            this.lblKategorije.Name = "lblKategorije";
            this.lblKategorije.Size = new System.Drawing.Size(127, 23);
            this.lblKategorije.TabIndex = 10;
            this.lblKategorije.Text = "KATEGORIJE";
            // 
            // lblGrafickeKartice
            // 
            this.lblGrafickeKartice.AutoSize = true;
            this.lblGrafickeKartice.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrafickeKartice.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGrafickeKartice.Location = new System.Drawing.Point(9, 70);
            this.lblGrafickeKartice.Name = "lblGrafickeKartice";
            this.lblGrafickeKartice.Size = new System.Drawing.Size(170, 33);
            this.lblGrafickeKartice.TabIndex = 11;
            this.lblGrafickeKartice.Text = "Grafičke kartice";
            this.lblGrafickeKartice.Click += new System.EventHandler(this.LblGrafickeKartice_Click);
            // 
            // lblProcesori
            // 
            this.lblProcesori.AutoSize = true;
            this.lblProcesori.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcesori.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProcesori.Location = new System.Drawing.Point(9, 118);
            this.lblProcesori.Name = "lblProcesori";
            this.lblProcesori.Size = new System.Drawing.Size(104, 33);
            this.lblProcesori.TabIndex = 12;
            this.lblProcesori.Text = "Procesori\r\n";
            this.lblProcesori.Click += new System.EventHandler(this.LblProcesori_Click);
            // 
            // lblRadnaMemorija
            // 
            this.lblRadnaMemorija.AutoSize = true;
            this.lblRadnaMemorija.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadnaMemorija.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRadnaMemorija.Location = new System.Drawing.Point(9, 168);
            this.lblRadnaMemorija.Name = "lblRadnaMemorija";
            this.lblRadnaMemorija.Size = new System.Drawing.Size(179, 33);
            this.lblRadnaMemorija.TabIndex = 13;
            this.lblRadnaMemorija.Text = "Radna memorija\r\n";
            this.lblRadnaMemorija.Click += new System.EventHandler(this.LblRadnaMemorija_Click);
            // 
            // lblTvrdiDiskovi
            // 
            this.lblTvrdiDiskovi.AutoSize = true;
            this.lblTvrdiDiskovi.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTvrdiDiskovi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTvrdiDiskovi.Location = new System.Drawing.Point(9, 227);
            this.lblTvrdiDiskovi.Name = "lblTvrdiDiskovi";
            this.lblTvrdiDiskovi.Size = new System.Drawing.Size(140, 33);
            this.lblTvrdiDiskovi.TabIndex = 14;
            this.lblTvrdiDiskovi.Text = "Tvrdi diskovi";
            this.lblTvrdiDiskovi.Click += new System.EventHandler(this.LblTvrdiDiskovi_Click);
            // 
            // lblMaticnePloce
            // 
            this.lblMaticnePloce.AutoSize = true;
            this.lblMaticnePloce.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaticnePloce.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMaticnePloce.Location = new System.Drawing.Point(9, 277);
            this.lblMaticnePloce.Name = "lblMaticnePloce";
            this.lblMaticnePloce.Size = new System.Drawing.Size(148, 33);
            this.lblMaticnePloce.TabIndex = 15;
            this.lblMaticnePloce.Text = "Matične ploče";
            this.lblMaticnePloce.Click += new System.EventHandler(this.LblMaticnePloce_Click);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Panel.Controls.Add(this.flpPosebna);
            this.Panel.Controls.Add(this.flpArtikli);
            this.Panel.Controls.Add(this.rbtnPopust);
            this.Panel.Controls.Add(this.rbtnNoviProizodi);
            this.Panel.Controls.Add(this.btnSortNazivUzlazno);
            this.Panel.Controls.Add(this.btnSortCijenaUzlazno);
            this.Panel.Controls.Add(this.btnOsvjeziPopis);
            this.Panel.Controls.Add(this.label4);
            this.Panel.Controls.Add(this.label3);
            this.Panel.Controls.Add(this.btnSortNazivSilazno);
            this.Panel.Controls.Add(this.btnSortCijenaSilazno);
            this.Panel.Controls.Add(this.label2);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(192, 64);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(865, 602);
            this.Panel.TabIndex = 17;
            // 
            // flpPosebna
            // 
            this.flpPosebna.AutoScroll = true;
            this.flpPosebna.Location = new System.Drawing.Point(39, 34);
            this.flpPosebna.Margin = new System.Windows.Forms.Padding(2);
            this.flpPosebna.Name = "flpPosebna";
            this.flpPosebna.Size = new System.Drawing.Size(816, 154);
            this.flpPosebna.TabIndex = 28;
            // 
            // flpArtikli
            // 
            this.flpArtikli.AutoScroll = true;
            this.flpArtikli.Location = new System.Drawing.Point(38, 228);
            this.flpArtikli.Margin = new System.Windows.Forms.Padding(2);
            this.flpArtikli.Name = "flpArtikli";
            this.flpArtikli.Size = new System.Drawing.Size(817, 315);
            this.flpArtikli.TabIndex = 27;
            // 
            // rbtnPopust
            // 
            this.rbtnPopust.AutoSize = true;
            this.rbtnPopust.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPopust.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnPopust.Location = new System.Drawing.Point(243, 12);
            this.rbtnPopust.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnPopust.Name = "rbtnPopust";
            this.rbtnPopust.Size = new System.Drawing.Size(114, 19);
            this.rbtnPopust.TabIndex = 26;
            this.rbtnPopust.TabStop = true;
            this.rbtnPopust.Text = "Sniženi proizvodi";
            this.rbtnPopust.UseVisualStyleBackColor = true;
            this.rbtnPopust.Click += new System.EventHandler(this.RbtnPopust_Click);
            // 
            // rbtnNoviProizodi
            // 
            this.rbtnNoviProizodi.AutoSize = true;
            this.rbtnNoviProizodi.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNoviProizodi.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnNoviProizodi.Location = new System.Drawing.Point(356, 12);
            this.rbtnNoviProizodi.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnNoviProizodi.Name = "rbtnNoviProizodi";
            this.rbtnNoviProizodi.Size = new System.Drawing.Size(102, 19);
            this.rbtnNoviProizodi.TabIndex = 26;
            this.rbtnNoviProizodi.TabStop = true;
            this.rbtnNoviProizodi.Text = "Novi proizvodi";
            this.rbtnNoviProizodi.UseVisualStyleBackColor = true;
            this.rbtnNoviProizodi.Click += new System.EventHandler(this.RbtnNoviProizodi_Click);
            // 
            // btnSortNazivUzlazno
            // 
            this.btnSortNazivUzlazno.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSortNazivUzlazno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortNazivUzlazno.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortNazivUzlazno.Location = new System.Drawing.Point(481, 554);
            this.btnSortNazivUzlazno.Name = "btnSortNazivUzlazno";
            this.btnSortNazivUzlazno.Size = new System.Drawing.Size(75, 37);
            this.btnSortNazivUzlazno.TabIndex = 24;
            this.btnSortNazivUzlazno.Text = "Uzlazno";
            this.btnSortNazivUzlazno.UseVisualStyleBackColor = false;
            this.btnSortNazivUzlazno.Click += new System.EventHandler(this.BtnSortNazivUzlazno_Click);
            // 
            // btnSortCijenaUzlazno
            // 
            this.btnSortCijenaUzlazno.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSortCijenaUzlazno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortCijenaUzlazno.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortCijenaUzlazno.Location = new System.Drawing.Point(205, 554);
            this.btnSortCijenaUzlazno.Name = "btnSortCijenaUzlazno";
            this.btnSortCijenaUzlazno.Size = new System.Drawing.Size(75, 37);
            this.btnSortCijenaUzlazno.TabIndex = 23;
            this.btnSortCijenaUzlazno.Text = "Uzlazno";
            this.btnSortCijenaUzlazno.UseVisualStyleBackColor = false;
            this.btnSortCijenaUzlazno.Click += new System.EventHandler(this.BtnSortCijenaUzlazno_Click);
            // 
            // btnOsvjeziPopis
            // 
            this.btnOsvjeziPopis.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnOsvjeziPopis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsvjeziPopis.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOsvjeziPopis.Location = new System.Drawing.Point(748, 550);
            this.btnOsvjeziPopis.Name = "btnOsvjeziPopis";
            this.btnOsvjeziPopis.Size = new System.Drawing.Size(107, 44);
            this.btnOsvjeziPopis.TabIndex = 22;
            this.btnOsvjeziPopis.Text = "Osvježi katalog";
            this.btnOsvjeziPopis.UseVisualStyleBackColor = false;
            this.btnOsvjeziPopis.Click += new System.EventHandler(this.BtnOsvjeziPopis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(296, 565);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sortiraj po nazivu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(26, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sortiraj po cijeni\r\n";
            // 
            // btnSortNazivSilazno
            // 
            this.btnSortNazivSilazno.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSortNazivSilazno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortNazivSilazno.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortNazivSilazno.Location = new System.Drawing.Point(400, 554);
            this.btnSortNazivSilazno.Name = "btnSortNazivSilazno";
            this.btnSortNazivSilazno.Size = new System.Drawing.Size(75, 37);
            this.btnSortNazivSilazno.TabIndex = 7;
            this.btnSortNazivSilazno.Text = "Silazno";
            this.btnSortNazivSilazno.UseVisualStyleBackColor = false;
            this.btnSortNazivSilazno.Click += new System.EventHandler(this.BtnSortNazivSilazno_Click);
            // 
            // btnSortCijenaSilazno
            // 
            this.btnSortCijenaSilazno.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSortCijenaSilazno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortCijenaSilazno.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortCijenaSilazno.Location = new System.Drawing.Point(124, 554);
            this.btnSortCijenaSilazno.Name = "btnSortCijenaSilazno";
            this.btnSortCijenaSilazno.Size = new System.Drawing.Size(75, 37);
            this.btnSortCijenaSilazno.TabIndex = 5;
            this.btnSortCijenaSilazno.Text = "Silazno";
            this.btnSortCijenaSilazno.UseVisualStyleBackColor = false;
            this.btnSortCijenaSilazno.Click += new System.EventHandler(this.BtnSortCijenaSilazno_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(38, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artikli";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Posebna ponuda";
            // 
            // lblPC
            // 
            this.lblPC.AutoSize = true;
            this.lblPC.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPC.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPC.Location = new System.Drawing.Point(9, 324);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(129, 33);
            this.lblPC.TabIndex = 18;
            this.lblPC.Text = "Prebuild PC\r\n";
            this.lblPC.Click += new System.EventHandler(this.LblPC_Click);
            // 
            // pnKategorije1
            // 
            this.pnKategorije1.BackColor = System.Drawing.Color.Teal;
            this.pnKategorije1.Controls.Add(this.pbKorisnik);
            this.pnKategorije1.Controls.Add(this.lblKorisnikoIme);
            this.pnKategorije1.Controls.Add(this.lblPC);
            this.pnKategorije1.Controls.Add(this.lblKategorije);
            this.pnKategorije1.Controls.Add(this.lblMaticnePloce);
            this.pnKategorije1.Controls.Add(this.lblTvrdiDiskovi);
            this.pnKategorije1.Controls.Add(this.lblGrafickeKartice);
            this.pnKategorije1.Controls.Add(this.lblRadnaMemorija);
            this.pnKategorije1.Controls.Add(this.lblProcesori);
            this.pnKategorije1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnKategorije1.Location = new System.Drawing.Point(0, 64);
            this.pnKategorije1.Margin = new System.Windows.Forms.Padding(2);
            this.pnKategorije1.Name = "pnKategorije1";
            this.pnKategorije1.Size = new System.Drawing.Size(192, 602);
            this.pnKategorije1.TabIndex = 26;
            // 
            // pbKorisnik
            // 
            this.pbKorisnik.Location = new System.Drawing.Point(57, 471);
            this.pbKorisnik.Name = "pbKorisnik";
            this.pbKorisnik.Size = new System.Drawing.Size(72, 72);
            this.pbKorisnik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKorisnik.TabIndex = 20;
            this.pbKorisnik.TabStop = false;
            // 
            // lblKorisnikoIme
            // 
            this.lblKorisnikoIme.BackColor = System.Drawing.Color.Turquoise;
            this.lblKorisnikoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnikoIme.Location = new System.Drawing.Point(12, 558);
            this.lblKorisnikoIme.Name = "lblKorisnikoIme";
            this.lblKorisnikoIme.Size = new System.Drawing.Size(167, 26);
            this.lblKorisnikoIme.TabIndex = 19;
            this.lblKorisnikoIme.Text = "Gost";
            this.lblKorisnikoIme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKorisnikoIme.Click += new System.EventHandler(this.LblKorisnikoIme_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.txbPretraga);
            this.panel2.Controls.Add(this.btnKontakt);
            this.panel2.Controls.Add(this.btnUpravljajNarudzbama);
            this.panel2.Controls.Add(this.btnPregledajNarudzbe);
            this.panel2.Controls.Add(this.btnArtikli);
            this.panel2.Controls.Add(this.btnKosarica);
            this.panel2.Controls.Add(this.btnOdjava);
            this.panel2.Controls.Add(this.btnTrazi);
            this.panel2.Controls.Add(this.btnPrijava);
            this.panel2.Controls.Add(this.btnRegistracija);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 64);
            this.panel2.TabIndex = 27;
            // 
            // txbPretraga
            // 
            this.txbPretraga.Location = new System.Drawing.Point(397, 23);
            this.txbPretraga.Name = "txbPretraga";
            this.txbPretraga.Size = new System.Drawing.Size(331, 20);
            this.txbPretraga.TabIndex = 9;
            this.txbPretraga.Text = "Pretraži...";
            this.txbPretraga.Click += new System.EventHandler(this.TxbPretraga_Click);
            // 
            // btnUpravljajNarudzbama
            // 
            this.btnUpravljajNarudzbama.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpravljajNarudzbama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpravljajNarudzbama.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpravljajNarudzbama.Location = new System.Drawing.Point(221, 12);
            this.btnUpravljajNarudzbama.Name = "btnUpravljajNarudzbama";
            this.btnUpravljajNarudzbama.Size = new System.Drawing.Size(83, 41);
            this.btnUpravljajNarudzbama.TabIndex = 8;
            this.btnUpravljajNarudzbama.Text = "Upravljaj narudžbama";
            this.btnUpravljajNarudzbama.UseVisualStyleBackColor = false;
            this.btnUpravljajNarudzbama.Visible = false;
            this.btnUpravljajNarudzbama.Click += new System.EventHandler(this.BtnUpravljajNarudzbama_Click);
            // 
            // btnPregledajNarudzbe
            // 
            this.btnPregledajNarudzbe.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPregledajNarudzbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregledajNarudzbe.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledajNarudzbe.Location = new System.Drawing.Point(146, 12);
            this.btnPregledajNarudzbe.Name = "btnPregledajNarudzbe";
            this.btnPregledajNarudzbe.Size = new System.Drawing.Size(69, 41);
            this.btnPregledajNarudzbe.TabIndex = 8;
            this.btnPregledajNarudzbe.Text = "Pregledaj narudžbe";
            this.btnPregledajNarudzbe.UseVisualStyleBackColor = false;
            this.btnPregledajNarudzbe.Visible = false;
            this.btnPregledajNarudzbe.Click += new System.EventHandler(this.BtnPregledajNarudzbe_Click);
            // 
            // btnArtikli
            // 
            this.btnArtikli.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnArtikli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtikli.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtikli.Location = new System.Drawing.Point(310, 12);
            this.btnArtikli.Name = "btnArtikli";
            this.btnArtikli.Size = new System.Drawing.Size(69, 41);
            this.btnArtikli.TabIndex = 8;
            this.btnArtikli.Text = "Upravljaj artiklima";
            this.btnArtikli.UseVisualStyleBackColor = false;
            this.btnArtikli.Visible = false;
            this.btnArtikli.Click += new System.EventHandler(this.BtnArtikli_Click);
            // 
            // btnKosarica
            // 
            this.btnKosarica.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnKosarica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKosarica.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKosarica.Location = new System.Drawing.Point(811, 12);
            this.btnKosarica.Name = "btnKosarica";
            this.btnKosarica.Size = new System.Drawing.Size(78, 41);
            this.btnKosarica.TabIndex = 6;
            this.btnKosarica.Text = "Košarica";
            this.btnKosarica.UseVisualStyleBackColor = false;
            this.btnKosarica.Click += new System.EventHandler(this.BtnKosarica_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.Location = new System.Drawing.Point(978, 12);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(62, 41);
            this.btnOdjava.TabIndex = 1;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Visible = false;
            this.btnOdjava.Click += new System.EventHandler(this.BtnOdjava_Click);
            // 
            // btnTrazi
            // 
            this.btnTrazi.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrazi.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrazi.Location = new System.Drawing.Point(734, 12);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(71, 41);
            this.btnTrazi.TabIndex = 4;
            this.btnTrazi.Text = "Pretraga";
            this.btnTrazi.UseVisualStyleBackColor = false;
            this.btnTrazi.Click += new System.EventHandler(this.BtnTrazi_Click);
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijava.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.Location = new System.Drawing.Point(978, 12);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(62, 41);
            this.btnPrijava.TabIndex = 1;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.BtnPrijava_Click);
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRegistracija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistracija.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistracija.Location = new System.Drawing.Point(895, 12);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(77, 41);
            this.btnRegistracija.TabIndex = 3;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = false;
            this.btnRegistracija.Click += new System.EventHandler(this.BtnRegistracija_Click);
            // 
            // btnKontakt
            // 
            this.btnKontakt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnKontakt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKontakt.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKontakt.Location = new System.Drawing.Point(12, 12);
            this.btnKontakt.Name = "btnKontakt";
            this.btnKontakt.Size = new System.Drawing.Size(101, 41);
            this.btnKontakt.TabIndex = 7;
            this.btnKontakt.Text = "Kontakt";
            this.btnKontakt.UseVisualStyleBackColor = false;
            this.btnKontakt.Click += new System.EventHandler(this.BtnKontakt_Click);
            // 
            // FrmKatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1057, 666);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.pnKategorije1);
            this.Controls.Add(this.panel2);
            this.KeyPreview = true;
            this.Name = "FrmKatalog";
            this.Text = "Katalog proizvoda";
            this.Load += new System.EventHandler(this.FrmKatalog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKatalog_KeyDown);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.pnKategorije1.ResumeLayout(false);
            this.pnKategorije1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKorisnik)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.Button btnOsvjeziPopis;
        private System.Windows.Forms.Button btnSortNazivUzlazno;
        private System.Windows.Forms.Button btnSortCijenaUzlazno;
        private System.Windows.Forms.Panel pnKategorije1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnArtikli;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Button btnKosarica;
        private System.Windows.Forms.Button btnKontakt;
        private System.Windows.Forms.TextBox txbPretraga;
        private System.Windows.Forms.RadioButton rbtnPopust;
        private System.Windows.Forms.RadioButton rbtnNoviProizodi;
        private System.Windows.Forms.FlowLayoutPanel flpArtikli;
        private System.Windows.Forms.FlowLayoutPanel flpPosebna;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.PictureBox pbKorisnik;
        private System.Windows.Forms.Label lblKorisnikoIme;
        private System.Windows.Forms.Button btnPregledajNarudzbe;
        private System.Windows.Forms.Button btnUpravljajNarudzbama;
    }
}

