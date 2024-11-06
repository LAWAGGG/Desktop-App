namespace Coba
{
    partial class Form2
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
            this.aplikasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kalkulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bangunDatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bangunRuangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplikasiToolStripMenuItem,
            this.keluarrToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(800, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplikasiToolStripMenuItem
            // 
            this.aplikasiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kalkulatorToolStripMenuItem,
            this.bangunDatarToolStripMenuItem,
            this.bangunRuangToolStripMenuItem});
            this.aplikasiToolStripMenuItem.Name = "aplikasiToolStripMenuItem";
            this.aplikasiToolStripMenuItem.Size = new System.Drawing.Size(75, 44);
            this.aplikasiToolStripMenuItem.Text = "Aplikasi";
            // 
            // kalkulatorToolStripMenuItem
            // 
            this.kalkulatorToolStripMenuItem.Name = "kalkulatorToolStripMenuItem";
            this.kalkulatorToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.kalkulatorToolStripMenuItem.Text = "Kalkulator";
            this.kalkulatorToolStripMenuItem.Click += new System.EventHandler(this.kalkulatorToolStripMenuItem_Click);
            // 
            // bangunDatarToolStripMenuItem
            // 
            this.bangunDatarToolStripMenuItem.Name = "bangunDatarToolStripMenuItem";
            this.bangunDatarToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.bangunDatarToolStripMenuItem.Text = "Bangun Datar";
            this.bangunDatarToolStripMenuItem.Click += new System.EventHandler(this.bangunDatarToolStripMenuItem_Click);
            // 
            // bangunRuangToolStripMenuItem
            // 
            this.bangunRuangToolStripMenuItem.Name = "bangunRuangToolStripMenuItem";
            this.bangunRuangToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.bangunRuangToolStripMenuItem.Text = "Bangun Ruang";
            this.bangunRuangToolStripMenuItem.Click += new System.EventHandler(this.bangunRuangToolStripMenuItem_Click);
            // 
            // keluarrToolStripMenuItem
            // 
            this.keluarrToolStripMenuItem.Name = "keluarrToolStripMenuItem";
            this.keluarrToolStripMenuItem.Size = new System.Drawing.Size(70, 44);
            this.keluarrToolStripMenuItem.Text = "Keluarr";
            this.keluarrToolStripMenuItem.Click += new System.EventHandler(this.keluarrToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 139);
            this.label1.TabIndex = 1;
            this.label1.Text = "Halo Ges";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplikasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kalkulatorToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem bangunDatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bangunRuangToolStripMenuItem;
    }
}