namespace PCShop.Forme
{
    partial class FrmKontakt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKontakt));
            this.pbPCShop = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPCShop)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPCShop
            // 
            this.pbPCShop.Location = new System.Drawing.Point(16, 3);
            this.pbPCShop.Name = "pbPCShop";
            this.pbPCShop.Size = new System.Drawing.Size(618, 127);
            this.pbPCShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPCShop.TabIndex = 0;
            this.pbPCShop.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(617, 390);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // FrmKontakt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(642, 649);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPCShop);
            this.Name = "FrmKontakt";
            this.Text = "Kontakt";
            this.Load += new System.EventHandler(this.FrmKontakt_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKontakt_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbPCShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPCShop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}