namespace Lab.ZondMethod
{
    partial class ZondForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OpenButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BuildMatrix = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.OpenImageButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CutButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ThinningButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.FindZondButton = new System.Windows.Forms.Button();
            this.CompareButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(145, 12);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "OpenZond";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(66, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 206);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BuildMatrix
            // 
            this.BuildMatrix.Location = new System.Drawing.Point(145, 253);
            this.BuildMatrix.Name = "BuildMatrix";
            this.BuildMatrix.Size = new System.Drawing.Size(75, 23);
            this.BuildMatrix.TabIndex = 2;
            this.BuildMatrix.Text = "BuildMatrix";
            this.BuildMatrix.UseVisualStyleBackColor = true;
            this.BuildMatrix.Click += new System.EventHandler(this.BuildMatrix_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 258);
            this.dataGridView1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(418, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(473, 524);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Controls.Add(this.ThinningButton);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.CutButton);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.OpenImageButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(465, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CompareButton);
            this.tabPage2.Controls.Add(this.FindZondButton);
            this.tabPage2.Controls.Add(this.AddButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(465, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // OpenImageButton
            // 
            this.OpenImageButton.Location = new System.Drawing.Point(36, 66);
            this.OpenImageButton.Name = "OpenImageButton";
            this.OpenImageButton.Size = new System.Drawing.Size(75, 23);
            this.OpenImageButton.TabIndex = 0;
            this.OpenImageButton.Text = "OpenImage";
            this.OpenImageButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(168, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 152);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // CutButton
            // 
            this.CutButton.Location = new System.Drawing.Point(36, 234);
            this.CutButton.Name = "CutButton";
            this.CutButton.Size = new System.Drawing.Size(75, 23);
            this.CutButton.TabIndex = 2;
            this.CutButton.Text = "Cut and Scaling ";
            this.CutButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(168, 167);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(217, 153);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // ThinningButton
            // 
            this.ThinningButton.Location = new System.Drawing.Point(36, 403);
            this.ThinningButton.Name = "ThinningButton";
            this.ThinningButton.Size = new System.Drawing.Size(75, 23);
            this.ThinningButton.TabIndex = 4;
            this.ThinningButton.Text = "Thinning";
            this.ThinningButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(168, 326);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(217, 166);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(338, 40);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 29);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // FindZondButton
            // 
            this.FindZondButton.Location = new System.Drawing.Point(37, 41);
            this.FindZondButton.Name = "FindZondButton";
            this.FindZondButton.Size = new System.Drawing.Size(75, 28);
            this.FindZondButton.TabIndex = 2;
            this.FindZondButton.Text = "Find_Zond";
            this.FindZondButton.UseVisualStyleBackColor = true;
            // 
            // CompareButton
            // 
            this.CompareButton.Location = new System.Drawing.Point(188, 41);
            this.CompareButton.Name = "CompareButton";
            this.CompareButton.Size = new System.Drawing.Size(75, 28);
            this.CompareButton.TabIndex = 3;
            this.CompareButton.Text = "Compare";
            this.CompareButton.UseVisualStyleBackColor = true;
            // 
            // ZondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 548);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BuildMatrix);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OpenButton);
            this.Name = "ZondForm";
            this.Text = "ZondForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BuildMatrix;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button ThinningButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button CutButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button OpenImageButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button FindZondButton;
        private System.Windows.Forms.Button CompareButton;
    }
}