namespace PCShop.Forme
{
    partial class FrmUpravljanjeArtiklima
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIzbrisiArtikl = new System.Windows.Forms.Label();
            this.lblUrediArtikl = new System.Windows.Forms.Label();
            this.lblDodajArtikl = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AllowUserToAddRows = false;
            this.dgvArtikli.AllowUserToDeleteRows = false;
            this.dgvArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtikli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArtikli.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvArtikli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArtikli.EnableHeadersVisualStyles = false;
            this.dgvArtikli.Location = new System.Drawing.Point(263, 0);
            this.dgvArtikli.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtikli.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvArtikli.RowHeadersWidth = 51;
            this.dgvArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtikli.Size = new System.Drawing.Size(967, 474);
            this.dgvArtikli.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOdustani);
            this.panel1.Controls.Add(this.lblIzbrisiArtikl);
            this.panel1.Controls.Add(this.lblUrediArtikl);
            this.panel1.Controls.Add(this.lblDodajArtikl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 474);
            this.panel1.TabIndex = 23;
            // 
            // lblIzbrisiArtikl
            // 
            this.lblIzbrisiArtikl.AutoSize = true;
            this.lblIzbrisiArtikl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzbrisiArtikl.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIzbrisiArtikl.Location = new System.Drawing.Point(12, 133);
            this.lblIzbrisiArtikl.Name = "lblIzbrisiArtikl";
            this.lblIzbrisiArtikl.Size = new System.Drawing.Size(113, 28);
            this.lblIzbrisiArtikl.TabIndex = 0;
            this.lblIzbrisiArtikl.Text = "Izbriši artikl";
            this.lblIzbrisiArtikl.Click += new System.EventHandler(this.lblIzbrisiArtikl_Click);
            // 
            // lblUrediArtikl
            // 
            this.lblUrediArtikl.AutoSize = true;
            this.lblUrediArtikl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrediArtikl.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUrediArtikl.Location = new System.Drawing.Point(12, 76);
            this.lblUrediArtikl.Name = "lblUrediArtikl";
            this.lblUrediArtikl.Size = new System.Drawing.Size(110, 28);
            this.lblUrediArtikl.TabIndex = 0;
            this.lblUrediArtikl.Text = "Uredi artikl";
            this.lblUrediArtikl.Click += new System.EventHandler(this.lblUrediArtikl_Click);
            // 
            // lblDodajArtikl
            // 
            this.lblDodajArtikl.AutoSize = true;
            this.lblDodajArtikl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodajArtikl.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDodajArtikl.Location = new System.Drawing.Point(12, 19);
            this.lblDodajArtikl.Name = "lblDodajArtikl";
            this.lblDodajArtikl.Size = new System.Drawing.Size(115, 28);
            this.lblDodajArtikl.TabIndex = 0;
            this.lblDodajArtikl.Text = "Dodaj artikl";
            this.lblDodajArtikl.Click += new System.EventHandler(this.lblDodajArtikl_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(17, 421);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(224, 41);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmUpravljanjeArtiklima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1230, 474);
            this.Controls.Add(this.dgvArtikli);
            this.Controls.Add(this.panel1);
            this.Name = "FrmUpravljanjeArtiklima";
            this.Text = "FrmUpravljanjeArtiklima";
            this.Load += new System.EventHandler(this.FrmUpravljanjeArtiklima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIzbrisiArtikl;
        private System.Windows.Forms.Label lblUrediArtikl;
        private System.Windows.Forms.Label lblDodajArtikl;
        private System.Windows.Forms.Button btnOdustani;
    }
}