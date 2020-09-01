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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Košarica.Location = new System.Drawing.Point(427, 11);
            this.Košarica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Košarica.Name = "Košarica";
            this.Košarica.Size = new System.Drawing.Size(150, 39);
            this.Košarica.TabIndex = 1;
            this.Košarica.Text = "Košarica";
            // 
            // dgvKosarica
            // 
            this.dgvKosarica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKosarica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKosarica.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKosarica.Location = new System.Drawing.Point(16, 53);
            this.dgvKosarica.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKosarica.Name = "dgvKosarica";
            this.dgvKosarica.RowHeadersWidth = 51;
            this.dgvKosarica.Size = new System.Drawing.Size(1035, 421);
            this.dgvKosarica.TabIndex = 2;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnObrisi.Enabled = false;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(16, 481);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(112, 58);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obrisi artikl";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnOcistiKosaricu
            // 
            this.btnOcistiKosaricu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnOcistiKosaricu.Enabled = false;
            this.btnOcistiKosaricu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcistiKosaricu.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcistiKosaricu.Location = new System.Drawing.Point(699, 481);
            this.btnOcistiKosaricu.Margin = new System.Windows.Forms.Padding(4);
            this.btnOcistiKosaricu.Name = "btnOcistiKosaricu";
            this.btnOcistiKosaricu.Size = new System.Drawing.Size(112, 58);
            this.btnOcistiKosaricu.TabIndex = 4;
            this.btnOcistiKosaricu.Text = "Očisti košaricu";
            this.btnOcistiKosaricu.UseVisualStyleBackColor = false;
            this.btnOcistiKosaricu.Click += new System.EventHandler(this.btnOcistiKosaricu_Click);
            // 
            // btnBlagajna
            // 
            this.btnBlagajna.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBlagajna.Enabled = false;
            this.btnBlagajna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlagajna.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlagajna.Location = new System.Drawing.Point(819, 481);
            this.btnBlagajna.Margin = new System.Windows.Forms.Padding(4);
            this.btnBlagajna.Name = "btnBlagajna";
            this.btnBlagajna.Size = new System.Drawing.Size(112, 58);
            this.btnBlagajna.TabIndex = 5;
            this.btnBlagajna.Text = "U blagajnu";
            this.btnBlagajna.UseVisualStyleBackColor = false;
            this.btnBlagajna.Click += new System.EventHandler(this.btnBlagajna_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(939, 481);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(112, 58);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmKosarica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnBlagajna);
            this.Controls.Add(this.btnOcistiKosaricu);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dgvKosarica);
            this.Controls.Add(this.Košarica);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmKosarica";
            this.Text = "Košarica";
            this.Load += new System.EventHandler(this.FrmKosarica_Load);
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