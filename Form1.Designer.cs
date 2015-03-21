namespace Lab
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zondMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nearestNeighborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(436, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zondMethodToolStripMenuItem,
            this.nearestNeighborToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // zondMethodToolStripMenuItem
            // 
            this.zondMethodToolStripMenuItem.Name = "zondMethodToolStripMenuItem";
            this.zondMethodToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.zondMethodToolStripMenuItem.Text = "ZondMethod";
            this.zondMethodToolStripMenuItem.Click += new System.EventHandler(this.zondMethodToolStripMenuItem_Click);
            // 
            // nearestNeighborToolStripMenuItem
            // 
            this.nearestNeighborToolStripMenuItem.Name = "nearestNeighborToolStripMenuItem";
            this.nearestNeighborToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.nearestNeighborToolStripMenuItem.Text = "NearestNeighbor";
            this.nearestNeighborToolStripMenuItem.Click += new System.EventHandler(this.nearestNeighborToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 260);
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
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zondMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nearestNeighborToolStripMenuItem;
    }
}

