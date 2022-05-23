namespace PoljoprivredniKombinat
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sadrzajMagacinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magacinpodaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.saradniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sadrzajMagacinaToolStripMenuItem,
            this.magacinpodaciToolStripMenuItem,
            this.proizvodiToolStripMenuItem,
            this.kategorijeToolStripMenuItem,
            this.saradniciToolStripMenuItem});
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.pregledToolStripMenuItem.Text = "Pregled";
            // 
            // sadrzajMagacinaToolStripMenuItem
            // 
            this.sadrzajMagacinaToolStripMenuItem.Name = "sadrzajMagacinaToolStripMenuItem";
            this.sadrzajMagacinaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sadrzajMagacinaToolStripMenuItem.Text = "Sadrzaj magacina";
            this.sadrzajMagacinaToolStripMenuItem.Click += new System.EventHandler(this.sadrzajMagacinaToolStripMenuItem_Click);
            // 
            // magacinpodaciToolStripMenuItem
            // 
            this.magacinpodaciToolStripMenuItem.Name = "magacinpodaciToolStripMenuItem";
            this.magacinpodaciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.magacinpodaciToolStripMenuItem.Text = "Magacin-podaci";
            this.magacinpodaciToolStripMenuItem.Click += new System.EventHandler(this.magacinpodaciToolStripMenuItem_Click);
            // 
            // proizvodiToolStripMenuItem
            // 
            this.proizvodiToolStripMenuItem.Name = "proizvodiToolStripMenuItem";
            this.proizvodiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proizvodiToolStripMenuItem.Text = "Proizvodi";
            this.proizvodiToolStripMenuItem.Click += new System.EventHandler(this.proizvodiToolStripMenuItem_Click);
            // 
            // kategorijeToolStripMenuItem
            // 
            this.kategorijeToolStripMenuItem.Name = "kategorijeToolStripMenuItem";
            this.kategorijeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kategorijeToolStripMenuItem.Text = "Kategorije";
            this.kategorijeToolStripMenuItem.Click += new System.EventHandler(this.kategorijeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 120);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dobrodošli";
            // 
            // saradniciToolStripMenuItem
            // 
            this.saradniciToolStripMenuItem.Name = "saradniciToolStripMenuItem";
            this.saradniciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saradniciToolStripMenuItem.Text = "Saradnici";
            this.saradniciToolStripMenuItem.Click += new System.EventHandler(this.saradniciToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sadrzajMagacinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magacinpodaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saradniciToolStripMenuItem;
    }
}

