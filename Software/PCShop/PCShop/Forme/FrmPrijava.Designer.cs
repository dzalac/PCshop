namespace PCShop
{
    partial class FrmPrijava
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.tbxLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(249, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prijava";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(129, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Korisničko ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(129, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lozinka:";
            // 
            // tbxKorisnickoIme
            // 
            this.tbxKorisnickoIme.Location = new System.Drawing.Point(135, 107);
            this.tbxKorisnickoIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxKorisnickoIme.Name = "tbxKorisnickoIme";
            this.tbxKorisnickoIme.Size = new System.Drawing.Size(345, 22);
            this.tbxKorisnickoIme.TabIndex = 3;
            // 
            // tbxLozinka
            // 
            this.tbxLozinka.Location = new System.Drawing.Point(135, 175);
            this.tbxLozinka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxLozinka.Name = "tbxLozinka";
            this.tbxLozinka.Size = new System.Drawing.Size(345, 22);
            this.tbxLozinka.TabIndex = 4;
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijava.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.Location = new System.Drawing.Point(141, 272);
            this.btnPrijava.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(141, 46);
            this.btnPrijava.TabIndex = 5;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(316, 272);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(141, 46);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(639, 354);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.tbxLozinka);
            this.Controls.Add(this.tbxKorisnickoIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPrijava";
            this.Text = "Prijava";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPrijava_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxKorisnickoIme;
        private System.Windows.Forms.TextBox tbxLozinka;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnOdustani;
    }
}