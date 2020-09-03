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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lblIzbrisiArtikl = new System.Windows.Forms.Label();
            this.lblUrediArtikl = new System.Windows.Forms.Label();
            this.lblDodajArtikl = new System.Windows.Forms.Label();
            this.vrstaArtiklaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaArtiklaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AllowUserToAddRows = false;
            this.dgvArtikli.AllowUserToDeleteRows = false;
            this.dgvArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtikli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArtikli.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvArtikli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArtikli.EnableHeadersVisualStyles = false;
            this.dgvArtikli.Location = new System.Drawing.Point(187, 0);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtikli.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvArtikli.RowHeadersWidth = 51;
            this.dgvArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtikli.Size = new System.Drawing.Size(735, 392);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 392);
            this.panel1.TabIndex = 23;
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(13, 342);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(168, 33);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lblIzbrisiArtikl
            // 
            this.lblIzbrisiArtikl.AutoSize = true;
            this.lblIzbrisiArtikl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzbrisiArtikl.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIzbrisiArtikl.Location = new System.Drawing.Point(9, 108);
            this.lblIzbrisiArtikl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIzbrisiArtikl.Name = "lblIzbrisiArtikl";
            this.lblIzbrisiArtikl.Size = new System.Drawing.Size(90, 21);
            this.lblIzbrisiArtikl.TabIndex = 0;
            this.lblIzbrisiArtikl.Text = "Izbriši artikl";
            this.lblIzbrisiArtikl.Click += new System.EventHandler(this.lblIzbrisiArtikl_Click);
            // 
            // lblUrediArtikl
            // 
            this.lblUrediArtikl.AutoSize = true;
            this.lblUrediArtikl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrediArtikl.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUrediArtikl.Location = new System.Drawing.Point(9, 62);
            this.lblUrediArtikl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrediArtikl.Name = "lblUrediArtikl";
            this.lblUrediArtikl.Size = new System.Drawing.Size(87, 21);
            this.lblUrediArtikl.TabIndex = 0;
            this.lblUrediArtikl.Text = "Uredi artikl";
            this.lblUrediArtikl.Click += new System.EventHandler(this.lblUrediArtikl_Click);
            // 
            // lblDodajArtikl
            // 
            this.lblDodajArtikl.AutoSize = true;
            this.lblDodajArtikl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodajArtikl.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDodajArtikl.Location = new System.Drawing.Point(9, 15);
            this.lblDodajArtikl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDodajArtikl.Name = "lblDodajArtikl";
            this.lblDodajArtikl.Size = new System.Drawing.Size(90, 21);
            this.lblDodajArtikl.TabIndex = 0;
            this.lblDodajArtikl.Text = "Dodaj artikl";
            this.lblDodajArtikl.Click += new System.EventHandler(this.lblDodajArtikl_Click);
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(PCShop.Data.Artikl);
            // 
            // FrmUpravljanjeArtiklima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(922, 392);
            this.Controls.Add(this.dgvArtikli);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmUpravljanjeArtiklima";
            this.Text = "Upravljanje artiklima";
            this.Load += new System.EventHandler(this.FrmUpravljanjeArtiklima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaArtiklaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIzbrisiArtikl;
        private System.Windows.Forms.Label lblUrediArtikl;
        private System.Windows.Forms.Label lblDodajArtikl;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.BindingSource vrstaArtiklaBindingSource;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}