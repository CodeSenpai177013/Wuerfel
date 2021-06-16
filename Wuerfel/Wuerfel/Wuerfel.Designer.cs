namespace Wuerfel
{
    partial class Wuerfel
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startMS = new System.Windows.Forms.ToolStripMenuItem();
            this.start1MS = new System.Windows.Forms.ToolStripMenuItem();
            this.start10MS = new System.Windows.Forms.ToolStripMenuItem();
            this.start100MS = new System.Windows.Forms.ToolStripMenuItem();
            this.start1000MS = new System.Windows.Forms.ToolStripMenuItem();
            this.start10000MS = new System.Windows.Forms.ToolStripMenuItem();
            this.endeMS = new System.Windows.Forms.ToolStripMenuItem();
            this.lblah = new System.Windows.Forms.Label();
            this.cbbxwa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblrh = new System.Windows.Forms.Label();
            this.lblahe = new System.Windows.Forms.Label();
            this.lblrhe = new System.Windows.Forms.Label();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startMS,
            this.löschenToolStripMenuItem,
            this.endeMS});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(466, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startMS
            // 
            this.startMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.start1MS,
            this.start10MS,
            this.start100MS,
            this.start1000MS,
            this.start10000MS});
            this.startMS.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startMS.Name = "startMS";
            this.startMS.Size = new System.Drawing.Size(87, 34);
            this.startMS.Text = "Würfel";
            // 
            // start1MS
            // 
            this.start1MS.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start1MS.Name = "start1MS";
            this.start1MS.Size = new System.Drawing.Size(181, 34);
            this.start1MS.Text = "1 mal";
            this.start1MS.Click += new System.EventHandler(this.start1MS_Click);
            // 
            // start10MS
            // 
            this.start10MS.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start10MS.Name = "start10MS";
            this.start10MS.Size = new System.Drawing.Size(181, 34);
            this.start10MS.Text = "10 mal";
            this.start10MS.Click += new System.EventHandler(this.start10MS_Click);
            // 
            // start100MS
            // 
            this.start100MS.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start100MS.Name = "start100MS";
            this.start100MS.Size = new System.Drawing.Size(181, 34);
            this.start100MS.Text = "100 mal";
            this.start100MS.Click += new System.EventHandler(this.start100MS_Click);
            // 
            // start1000MS
            // 
            this.start1000MS.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start1000MS.Name = "start1000MS";
            this.start1000MS.Size = new System.Drawing.Size(181, 34);
            this.start1000MS.Text = "1000 mal";
            this.start1000MS.Click += new System.EventHandler(this.start1000MS_Click);
            // 
            // start10000MS
            // 
            this.start10000MS.Name = "start10000MS";
            this.start10000MS.Size = new System.Drawing.Size(181, 34);
            this.start10000MS.Text = "10000 mal";
            this.start10000MS.Click += new System.EventHandler(this.start10000MS_Click);
            // 
            // endeMS
            // 
            this.endeMS.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endeMS.Name = "endeMS";
            this.endeMS.Size = new System.Drawing.Size(71, 34);
            this.endeMS.Text = "Ende";
            this.endeMS.Click += new System.EventHandler(this.endeMS_Click);
            // 
            // lblah
            // 
            this.lblah.AutoSize = true;
            this.lblah.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblah.Location = new System.Drawing.Point(22, 122);
            this.lblah.Name = "lblah";
            this.lblah.Size = new System.Drawing.Size(204, 25);
            this.lblah.TabIndex = 3;
            this.lblah.Text = "Absolute Häufigkeit:";
            // 
            // cbbxwa
            // 
            this.cbbxwa.FormattingEnabled = true;
            this.cbbxwa.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbbxwa.Location = new System.Drawing.Point(168, 59);
            this.cbbxwa.Name = "cbbxwa";
            this.cbbxwa.Size = new System.Drawing.Size(121, 21);
            this.cbbxwa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ergebnis für :";
            // 
            // lblrh
            // 
            this.lblrh.AutoSize = true;
            this.lblrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrh.Location = new System.Drawing.Point(22, 159);
            this.lblrh.Name = "lblrh";
            this.lblrh.Size = new System.Drawing.Size(198, 25);
            this.lblrh.TabIndex = 6;
            this.lblrh.Text = "Relative Häufigkeit:";
            // 
            // lblahe
            // 
            this.lblahe.AutoSize = true;
            this.lblahe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblahe.Location = new System.Drawing.Point(232, 122);
            this.lblahe.Name = "lblahe";
            this.lblahe.Size = new System.Drawing.Size(30, 25);
            this.lblahe.TabIndex = 7;
            this.lblahe.Text = "   ";
            // 
            // lblrhe
            // 
            this.lblrhe.AutoSize = true;
            this.lblrhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrhe.Location = new System.Drawing.Point(232, 159);
            this.lblrhe.Name = "lblrhe";
            this.lblrhe.Size = new System.Drawing.Size(30, 25);
            this.lblrhe.TabIndex = 8;
            this.lblrhe.Text = "   ";
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(101, 34);
            this.löschenToolStripMenuItem.Text = "Löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // Wuerfel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 229);
            this.Controls.Add(this.lblrhe);
            this.Controls.Add(this.lblahe);
            this.Controls.Add(this.lblrh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbxwa);
            this.Controls.Add(this.lblah);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Wuerfel";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startMS;
        private System.Windows.Forms.ToolStripMenuItem endeMS;
        private System.Windows.Forms.Label lblah;
        private System.Windows.Forms.ToolStripMenuItem start1MS;
        private System.Windows.Forms.ToolStripMenuItem start10MS;
        private System.Windows.Forms.ToolStripMenuItem start100MS;
        private System.Windows.Forms.ToolStripMenuItem start1000MS;
        private System.Windows.Forms.ToolStripMenuItem start10000MS;
        private System.Windows.Forms.ComboBox cbbxwa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblrh;
        private System.Windows.Forms.Label lblahe;
        private System.Windows.Forms.Label lblrhe;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
    }
}

