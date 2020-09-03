namespace PCShop
{
    partial class FrmBlagajna
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
            this.btnNaruci = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKontrolniBroj = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBrojRacuna = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPostanskiBroj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbtnPouzece = new System.Windows.Forms.RadioButton();
            this.rbtnKartica = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpVrijediDo = new System.Windows.Forms.DateTimePicker();
            this.cbPostojecaAdresa = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOdustani.Location = new System.Drawing.Point(410, 488);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(228, 67);
            this.btnOdustani.TabIndex = 40;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // btnNaruci
            // 
            this.btnNaruci.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNaruci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNaruci.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNaruci.Location = new System.Drawing.Point(134, 488);
            this.btnNaruci.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(228, 67);
            this.btnNaruci.TabIndex = 39;
            this.btnNaruci.Text = "Naruči proizvod";
            this.btnNaruci.UseVisualStyleBackColor = false;
            this.btnNaruci.Click += new System.EventHandler(this.BtnNaruci_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(406, 397);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Vrijedi Do:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(406, 318);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Kontrolni broj:";
            // 
            // txtKontrolniBroj
            // 
            this.txtKontrolniBroj.Enabled = false;
            this.txtKontrolniBroj.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKontrolniBroj.Location = new System.Drawing.Point(409, 355);
            this.txtKontrolniBroj.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKontrolniBroj.Name = "txtKontrolniBroj";
            this.txtKontrolniBroj.Size = new System.Drawing.Size(304, 25);
            this.txtKontrolniBroj.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(406, 237);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Broj računa:";
            // 
            // txtBrojRacuna
            // 
            this.txtBrojRacuna.Enabled = false;
            this.txtBrojRacuna.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojRacuna.Location = new System.Drawing.Point(409, 272);
            this.txtBrojRacuna.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBrojRacuna.Name = "txtBrojRacuna";
            this.txtBrojRacuna.Size = new System.Drawing.Size(304, 25);
            this.txtBrojRacuna.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(54, 397);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Poštanski broj:";
            // 
            // txtPostanskiBroj
            // 
            this.txtPostanskiBroj.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostanskiBroj.Location = new System.Drawing.Point(58, 432);
            this.txtPostanskiBroj.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPostanskiBroj.Name = "txtPostanskiBroj";
            this.txtPostanskiBroj.Size = new System.Drawing.Size(304, 25);
            this.txtPostanskiBroj.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(54, 318);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Adresa:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresa.Location = new System.Drawing.Point(58, 355);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(304, 25);
            this.txtAdresa.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(54, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Grad:";
            // 
            // txtGrad
            // 
            this.txtGrad.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrad.Location = new System.Drawing.Point(58, 272);
            this.txtGrad.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(304, 25);
            this.txtGrad.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 28);
            this.label1.TabIndex = 41;
            this.label1.Text = "Podaci o plaćanju:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 28);
            this.label5.TabIndex = 42;
            this.label5.Text = "Adresa dostave:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(309, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 37);
            this.label9.TabIndex = 43;
            this.label9.Text = "Blagajna";
            // 
            // rbtnPouzece
            // 
            this.rbtnPouzece.AutoSize = true;
            this.rbtnPouzece.Location = new System.Drawing.Point(409, 148);
            this.rbtnPouzece.Name = "rbtnPouzece";
            this.rbtnPouzece.Size = new System.Drawing.Size(166, 24);
            this.rbtnPouzece.TabIndex = 44;
            this.rbtnPouzece.TabStop = true;
            this.rbtnPouzece.Text = "Plaćanje pouzećem";
            this.rbtnPouzece.UseVisualStyleBackColor = true;
            this.rbtnPouzece.CheckedChanged += new System.EventHandler(this.RbtnPouzece_CheckedChanged);
            // 
            // rbtnKartica
            // 
            this.rbtnKartica.AutoSize = true;
            this.rbtnKartica.Location = new System.Drawing.Point(589, 148);
            this.rbtnKartica.Name = "rbtnKartica";
            this.rbtnKartica.Size = new System.Drawing.Size(154, 24);
            this.rbtnKartica.TabIndex = 44;
            this.rbtnKartica.TabStop = true;
            this.rbtnKartica.Text = "Kartično plaćanje";
            this.rbtnKartica.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(406, 117);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 28);
            this.label10.TabIndex = 41;
            this.label10.Text = "Način plaćanja:";
            // 
            // dtpVrijediDo
            // 
            this.dtpVrijediDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVrijediDo.Location = new System.Drawing.Point(411, 434);
            this.dtpVrijediDo.Name = "dtpVrijediDo";
            this.dtpVrijediDo.Size = new System.Drawing.Size(302, 27);
            this.dtpVrijediDo.TabIndex = 45;
            // 
            // cbPostojecaAdresa
            // 
            this.cbPostojecaAdresa.AutoSize = true;
            this.cbPostojecaAdresa.Location = new System.Drawing.Point(58, 165);
            this.cbPostojecaAdresa.Name = "cbPostojecaAdresa";
            this.cbPostojecaAdresa.Size = new System.Drawing.Size(276, 24);
            this.cbPostojecaAdresa.TabIndex = 46;
            this.cbPostojecaAdresa.Text = "Koristi adresu definiranu na profilu";
            this.cbPostojecaAdresa.UseVisualStyleBackColor = true;
            this.cbPostojecaAdresa.CheckedChanged += new System.EventHandler(this.CbPostojecaAdresa_CheckedChanged);
            // 
            // FrmBlagajna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(807, 582);
            this.Controls.Add(this.cbPostojecaAdresa);
            this.Controls.Add(this.dtpVrijediDo);
            this.Controls.Add(this.rbtnKartica);
            this.Controls.Add(this.rbtnPouzece);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKontrolniBroj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBrojRacuna);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPostanskiBroj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGrad);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmBlagajna";
            this.Text = "Blagajna";
            this.Load += new System.EventHandler(this.FrmBlagajna_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Blagajna_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKontrolniBroj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBrojRacuna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPostanskiBroj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbtnPouzece;
        private System.Windows.Forms.RadioButton rbtnKartica;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpVrijediDo;
        private System.Windows.Forms.CheckBox cbPostojecaAdresa;
    }
}