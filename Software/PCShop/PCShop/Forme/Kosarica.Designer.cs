namespace PCShop
{
    partial class FrmKosarica
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
            this.Košarica = new System.Windows.Forms.Label();
            this.dgvKosarica = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnOcistiKosaricu = new System.Windows.Forms.Button();
            this.btnBlagajna = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKosarica)).BeginInit();
            this.SuspendLayout();
            // 
            // Košarica
            // 
            this.Košarica.AutoSize = true;
            this.Košarica.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Košarica.Location = new System.Drawing.Point(320, 9);
            this.Košarica.Name = "Košarica";
            this.Košarica.Size = new System.Drawing.Size(120, 31);
            this.Košarica.TabIndex = 1;
            this.Košarica.Text = "Košarica";
            // 
            // dgvKosarica
            // 
            this.dgvKosarica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKosarica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKosarica.Location = new System.Drawing.Point(12, 43);
            this.dgvKosarica.Name = "dgvKosarica";
            this.dgvKosarica.Size = new System.Drawing.Size(776, 342);
            this.dgvKosarica.TabIndex = 2;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(12, 391);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(84, 47);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obrisi artikl";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnOcistiKosaricu
            // 
            this.btnOcistiKosaricu.Location = new System.Drawing.Point(524, 391);
            this.btnOcistiKosaricu.Name = "btnOcistiKosaricu";
            this.btnOcistiKosaricu.Size = new System.Drawing.Size(84, 47);
            this.btnOcistiKosaricu.TabIndex = 4;
            this.btnOcistiKosaricu.Text = "Očisti košaricu";
            this.btnOcistiKosaricu.UseVisualStyleBackColor = true;
            this.btnOcistiKosaricu.Click += new System.EventHandler(this.btnOcistiKosaricu_Click);
            // 
            // btnBlagajna
            // 
            this.btnBlagajna.Location = new System.Drawing.Point(614, 391);
            this.btnBlagajna.Name = "btnBlagajna";
            this.btnBlagajna.Size = new System.Drawing.Size(84, 47);
            this.btnBlagajna.TabIndex = 5;
            this.btnBlagajna.Text = "U blagajnu";
            this.btnBlagajna.UseVisualStyleBackColor = true;
            this.btnBlagajna.Click += new System.EventHandler(this.btnBlagajna_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(704, 391);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(84, 47);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmKosarica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnBlagajna);
            this.Controls.Add(this.btnOcistiKosaricu);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dgvKosarica);
            this.Controls.Add(this.Košarica);
            this.KeyPreview = true;
            this.Name = "FrmKosarica";
            this.Text = "Košarica";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKosarica_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKosarica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Košarica;
        private System.Windows.Forms.DataGridView dgvKosarica;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnOcistiKosaricu;
        private System.Windows.Forms.Button btnBlagajna;
        private System.Windows.Forms.Button btnOdustani;
    }
}