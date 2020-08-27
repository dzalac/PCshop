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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblKategorije = new System.Windows.Forms.Label();
            this.lblGrafickeKartice = new System.Windows.Forms.Label();
            this.lblProcesori = new System.Windows.Forms.Label();
            this.lblRadnaMemorija = new System.Windows.Forms.Label();
            this.lblTvrdiDiskovi = new System.Windows.Forms.Label();
            this.lblMaticnePloce = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.rbtnPopust = new System.Windows.Forms.RadioButton();
            this.rbtnNoviProizodi = new System.Windows.Forms.RadioButton();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnArtikli = new System.Windows.Forms.Button();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.btnKosarica = new System.Windows.Forms.Button();
            this.btnKontakt = new System.Windows.Forms.Button();
            this.txbPretraga = new System.Windows.Forms.TextBox();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosebna)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKategorije
            // 
            this.lblKategorije.AutoSize = true;
            this.lblKategorije.BackColor = System.Drawing.Color.Transparent;
            this.lblKategorije.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorije.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKategorije.Location = new System.Drawing.Point(18, 30);
            this.lblKategorije.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKategorije.Name = "lblKategorije";
            this.lblKategorije.Size = new System.Drawing.Size(159, 29);
            this.lblKategorije.TabIndex = 10;
            this.lblKategorije.Text = "KATEGORIJE";
            // 
            // lblGrafickeKartice
            // 
            this.lblGrafickeKartice.AutoSize = true;
            this.lblGrafickeKartice.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrafickeKartice.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGrafickeKartice.Location = new System.Drawing.Point(29, 70);
            this.lblGrafickeKartice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrafickeKartice.Name = "lblGrafickeKartice";
            this.lblGrafickeKartice.Size = new System.Drawing.Size(127, 23);
            this.lblGrafickeKartice.TabIndex = 11;
            this.lblGrafickeKartice.Text = "Grafičke kartice";
            this.lblGrafickeKartice.Click += new System.EventHandler(this.LblGrafickeKartice_Click);
            // 
            // lblProcesori
            // 
            this.lblProcesori.AutoSize = true;
            this.lblProcesori.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcesori.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProcesori.Location = new System.Drawing.Point(29, 102);
            this.lblProcesori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcesori.Name = "lblProcesori";
            this.lblProcesori.Size = new System.Drawing.Size(80, 23);
            this.lblProcesori.TabIndex = 12;
            this.lblProcesori.Text = "Procesori\r\n";
            this.lblProcesori.Click += new System.EventHandler(this.LblProcesori_Click);
            // 
            // lblRadnaMemorija
            // 
            this.lblRadnaMemorija.AutoSize = true;
            this.lblRadnaMemorija.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadnaMemorija.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRadnaMemorija.Location = new System.Drawing.Point(29, 135);
            this.lblRadnaMemorija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRadnaMemorija.Name = "lblRadnaMemorija";
            this.lblRadnaMemorija.Size = new System.Drawing.Size(135, 23);
            this.lblRadnaMemorija.TabIndex = 13;
            this.lblRadnaMemorija.Text = "Radna memorija\r\n";
            this.lblRadnaMemorija.Click += new System.EventHandler(this.LblRadnaMemorija_Click);
            // 
            // lblTvrdiDiskovi
            // 
            this.lblTvrdiDiskovi.AutoSize = true;
            this.lblTvrdiDiskovi.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTvrdiDiskovi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTvrdiDiskovi.Location = new System.Drawing.Point(29, 170);
            this.lblTvrdiDiskovi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTvrdiDiskovi.Name = "lblTvrdiDiskovi";
            this.lblTvrdiDiskovi.Size = new System.Drawing.Size(102, 23);
            this.lblTvrdiDiskovi.TabIndex = 14;
            this.lblTvrdiDiskovi.Text = "Tvrdi diskovi";
            this.lblTvrdiDiskovi.Click += new System.EventHandler(this.LblTvrdiDiskovi_Click);
            // 
            // lblMaticnePloce
            // 
            this.lblMaticnePloce.AutoSize = true;
            this.lblMaticnePloce.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaticnePloce.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMaticnePloce.Location = new System.Drawing.Point(29, 200);
            this.lblMaticnePloce.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaticnePloce.Name = "lblMaticnePloce";
            this.lblMaticnePloce.Size = new System.Drawing.Size(119, 23);
            this.lblMaticnePloce.TabIndex = 15;
            this.lblMaticnePloce.Text = "Matične ploče";
            this.lblMaticnePloce.Click += new System.EventHandler(this.LblMaticnePloce_Click);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Panel.Controls.Add(this.rbtnPopust);
            this.Panel.Controls.Add(this.rbtnNoviProizodi);
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
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(258, 79);
            this.Panel.Margin = new System.Windows.Forms.Padding(4);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1301, 715);
            this.Panel.TabIndex = 17;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // rbtnPopust
            // 
            this.rbtnPopust.AutoSize = true;
            this.rbtnPopust.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPopust.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnPopust.Location = new System.Drawing.Point(324, 19);
            this.rbtnPopust.Name = "rbtnPopust";
            this.rbtnPopust.Size = new System.Drawing.Size(144, 24);
            this.rbtnPopust.TabIndex = 26;
            this.rbtnPopust.TabStop = true;
            this.rbtnPopust.Text = "Sniženi proizvodi";
            this.rbtnPopust.UseVisualStyleBackColor = true;
            this.rbtnPopust.CheckedChanged += new System.EventHandler(this.rbtnPopust_CheckedChanged);
            // 
            // rbtnNoviProizodi
            // 
            this.rbtnNoviProizodi.AutoSize = true;
            this.rbtnNoviProizodi.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNoviProizodi.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnNoviProizodi.Location = new System.Drawing.Point(474, 19);
            this.rbtnNoviProizodi.Name = "rbtnNoviProizodi";
            this.rbtnNoviProizodi.Size = new System.Drawing.Size(128, 24);
            this.rbtnNoviProizodi.TabIndex = 26;
            this.rbtnNoviProizodi.TabStop = true;
            this.rbtnNoviProizodi.Text = "Novi proizvodi";
            this.rbtnNoviProizodi.UseVisualStyleBackColor = true;
            // 
            // btnOtvoriArtikl
            // 
            this.btnOtvoriArtikl.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnOtvoriArtikl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtvoriArtikl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtvoriArtikl.Location = new System.Drawing.Point(1019, 623);
            this.btnOtvoriArtikl.Margin = new System.Windows.Forms.Padding(4);
            this.btnOtvoriArtikl.Name = "btnOtvoriArtikl";
            this.btnOtvoriArtikl.Size = new System.Drawing.Size(134, 46);
            this.btnOtvoriArtikl.TabIndex = 25;
            this.btnOtvoriArtikl.Text = "Pregledaj Artikl";
            this.btnOtvoriArtikl.UseVisualStyleBackColor = false;
            this.btnOtvoriArtikl.Click += new System.EventHandler(this.BtnOtvoriArtikl_Click);
            // 
            // btnSortNazivUzlazno
            // 
            this.btnSortNazivUzlazno.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSortNazivUzlazno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortNazivUzlazno.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortNazivUzlazno.Location = new System.Drawing.Point(640, 623);
            this.btnSortNazivUzlazno.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortNazivUzlazno.Name = "btnSortNazivUzlazno";
            this.btnSortNazivUzlazno.Size = new System.Drawing.Size(100, 46);
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
            this.btnSortCijenaUzlazno.Location = new System.Drawing.Point(272, 623);
            this.btnSortCijenaUzlazno.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortCijenaUzlazno.Name = "btnSortCijenaUzlazno";
            this.btnSortCijenaUzlazno.Size = new System.Drawing.Size(100, 46);
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
            this.btnOsvjeziPopis.Location = new System.Drawing.Point(1161, 623);
            this.btnOsvjeziPopis.Margin = new System.Windows.Forms.Padding(4);
            this.btnOsvjeziPopis.Name = "btnOsvjeziPopis";
            this.btnOsvjeziPopis.Size = new System.Drawing.Size(127, 46);
            this.btnOsvjeziPopis.TabIndex = 22;
            this.btnOsvjeziPopis.Text = "Osvježi katalog";
            this.btnOsvjeziPopis.UseVisualStyleBackColor = false;
            this.btnOsvjeziPopis.Click += new System.EventHandler(this.BtnOsvjeziPopis_Click);
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AllowUserToAddRows = false;
            this.dgvArtikli.AllowUserToDeleteRows = false;
            this.dgvArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtikli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArtikli.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArtikli.EnableHeadersVisualStyles = false;
            this.dgvArtikli.Location = new System.Drawing.Point(52, 228);
            this.dgvArtikli.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtikli.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArtikli.RowHeadersWidth = 51;
            this.dgvArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtikli.Size = new System.Drawing.Size(1209, 353);
            this.dgvArtikli.TabIndex = 21;
            // 
            // dgvPosebna
            // 
            this.dgvPosebna.AllowUserToAddRows = false;
            this.dgvPosebna.AllowUserToDeleteRows = false;
            this.dgvPosebna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPosebna.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPosebna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPosebna.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPosebna.EnableHeadersVisualStyles = false;
            this.dgvPosebna.Location = new System.Drawing.Point(52, 47);
            this.dgvPosebna.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPosebna.Name = "dgvPosebna";
            this.dgvPosebna.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPosebna.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPosebna.RowHeadersWidth = 51;
            this.dgvPosebna.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvPosebna.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPosebna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosebna.Size = new System.Drawing.Size(1209, 137);
            this.dgvPosebna.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(399, 636);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sortiraj po nazivu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(47, 636);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sortiraj po cijeni\r\n";
            // 
            // btnSortNazivSilazno
            // 
            this.btnSortNazivSilazno.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSortNazivSilazno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortNazivSilazno.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortNazivSilazno.Location = new System.Drawing.Point(532, 623);
            this.btnSortNazivSilazno.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortNazivSilazno.Name = "btnSortNazivSilazno";
            this.btnSortNazivSilazno.Size = new System.Drawing.Size(100, 46);
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
            this.btnSortCijenaSilazno.Location = new System.Drawing.Point(164, 623);
            this.btnSortCijenaSilazno.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortCijenaSilazno.Name = "btnSortCijenaSilazno";
            this.btnSortCijenaSilazno.Size = new System.Drawing.Size(100, 46);
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
            this.label2.Location = new System.Drawing.Point(47, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artikli";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(46, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Posebna ponuda";
            // 
            // lblPC
            // 
            this.lblPC.AutoSize = true;
            this.lblPC.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPC.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPC.Location = new System.Drawing.Point(29, 237);
            this.lblPC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(99, 23);
            this.lblPC.TabIndex = 18;
            this.lblPC.Text = "Prebuild PC\r\n";
            this.lblPC.Click += new System.EventHandler(this.LblPC_Click);
            // 
            // lblKorisnikoIme
            // 
            this.lblKorisnikoIme.AutoSize = true;
            this.lblKorisnikoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnikoIme.Location = new System.Drawing.Point(16, 751);
            this.lblKorisnikoIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKorisnikoIme.Name = "lblKorisnikoIme";
            this.lblKorisnikoIme.Size = new System.Drawing.Size(157, 25);
            this.lblKorisnikoIme.TabIndex = 19;
            this.lblKorisnikoIme.Text = "Ne ulogirani gost";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblPC);
            this.panel1.Controls.Add(this.lblKategorije);
            this.panel1.Controls.Add(this.lblMaticnePloce);
            this.panel1.Controls.Add(this.lblTvrdiDiskovi);
            this.panel1.Controls.Add(this.lblGrafickeKartice);
            this.panel1.Controls.Add(this.lblRadnaMemorija);
            this.panel1.Controls.Add(this.lblProcesori);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 715);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnArtikli);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1559, 79);
            this.panel2.TabIndex = 27;
            // 
            // btnArtikli
            // 
            this.btnArtikli.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnArtikli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtikli.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtikli.Location = new System.Drawing.Point(258, 15);
            this.btnArtikli.Margin = new System.Windows.Forms.Padding(4);
            this.btnArtikli.Name = "btnArtikli";
            this.btnArtikli.Size = new System.Drawing.Size(133, 50);
            this.btnArtikli.TabIndex = 8;
            this.btnArtikli.Text = "Upravljaj artiklima";
            this.btnArtikli.UseVisualStyleBackColor = false;
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijava.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.Location = new System.Drawing.Point(1439, 15);
            this.btnPrijava.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(104, 50);
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
            this.btnRegistracija.Location = new System.Drawing.Point(1327, 15);
            this.btnRegistracija.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(104, 50);
            this.btnRegistracija.TabIndex = 3;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = false;
            this.btnRegistracija.Click += new System.EventHandler(this.BtnRegistracija_Click);
            // 
            // btnTrazi
            // 
            this.btnTrazi.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrazi.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrazi.Location = new System.Drawing.Point(1083, 15);
            this.btnTrazi.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(95, 50);
            this.btnTrazi.TabIndex = 4;
            this.btnTrazi.Text = "Pretraga";
            this.btnTrazi.UseVisualStyleBackColor = false;
            this.btnTrazi.Click += new System.EventHandler(this.BtnTrazi_Click);
            // 
            // btnKosarica
            // 
            this.btnKosarica.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnKosarica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKosarica.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKosarica.Location = new System.Drawing.Point(1215, 15);
            this.btnKosarica.Margin = new System.Windows.Forms.Padding(4);
            this.btnKosarica.Name = "btnKosarica";
            this.btnKosarica.Size = new System.Drawing.Size(104, 50);
            this.btnKosarica.TabIndex = 6;
            this.btnKosarica.Text = "Košarica";
            this.btnKosarica.UseVisualStyleBackColor = false;
            this.btnKosarica.Click += new System.EventHandler(this.BtnKosarica_Click);
            // 
            // btnKontakt
            // 
            this.btnKontakt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnKontakt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKontakt.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKontakt.Location = new System.Drawing.Point(23, 15);
            this.btnKontakt.Margin = new System.Windows.Forms.Padding(4);
            this.btnKontakt.Name = "btnKontakt";
            this.btnKontakt.Size = new System.Drawing.Size(133, 50);
            this.btnKontakt.TabIndex = 7;
            this.btnKontakt.Text = "Kontakt";
            this.btnKontakt.UseVisualStyleBackColor = false;
            this.btnKontakt.Click += new System.EventHandler(this.BtnKontakt_Click);
            // 
            // txbPretraga
            // 
            this.txbPretraga.Location = new System.Drawing.Point(449, 28);
            this.txbPretraga.Margin = new System.Windows.Forms.Padding(4);
            this.txbPretraga.Name = "txbPretraga";
            this.txbPretraga.Size = new System.Drawing.Size(624, 22);
            this.txbPretraga.TabIndex = 9;
            this.txbPretraga.Text = "Pretraži...";
            // 
            // FrmKatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1559, 794);
            this.Controls.Add(this.txbPretraga);
            this.Controls.Add(this.btnKosarica);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.lblKorisnikoIme);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.btnKontakt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmKatalog";
            this.Text = "Katalog proizvoda";
            this.Load += new System.EventHandler(this.FrmKatalog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKatalog_KeyDown);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosebna)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.DataGridView dgvPosebna;
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.Button btnOsvjeziPopis;
        private System.Windows.Forms.Button btnSortNazivUzlazno;
        private System.Windows.Forms.Button btnSortCijenaUzlazno;
        private System.Windows.Forms.Button btnOtvoriArtikl;
        private System.Windows.Forms.Label lblKorisnikoIme;
        private System.Windows.Forms.Panel panel1;
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
    }
}

