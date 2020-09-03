namespace PCShop.Forme
{
    partial class FrmIzvjestaj
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
            this.rvIzvjestaj = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvIzvjestaj
            // 
            this.rvIzvjestaj.LocalReport.ReportEmbeddedResource = "PCShop.Izvjestaj.Izvjestaj.rdlc";
            this.rvIzvjestaj.Location = new System.Drawing.Point(12, 3);
            this.rvIzvjestaj.Name = "rvIzvjestaj";
            this.rvIzvjestaj.ServerReport.BearerToken = null;
            this.rvIzvjestaj.Size = new System.Drawing.Size(858, 637);
            this.rvIzvjestaj.TabIndex = 0;
            // 
            // FrmIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 640);
            this.Controls.Add(this.rvIzvjestaj);
            this.Name = "FrmIzvjestaj";
            this.Text = "Izvjestaj";
            this.Load += new System.EventHandler(this.FrmIzvjestaj_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmIzvjestaj_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvIzvjestaj;
    }
}