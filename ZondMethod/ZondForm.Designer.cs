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
            this.OpenImageBtn = new System.Windows.Forms.Button();
            this.CutAndScalingBtn = new System.Windows.Forms.Button();
            this.ResultBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ReadZondBtn = new System.Windows.Forms.Button();
            this.CompareBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(12, 11);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(138, 23);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "OpenZond";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 163);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BuildMatrix
            // 
            this.BuildMatrix.Location = new System.Drawing.Point(12, 210);
            this.BuildMatrix.Name = "BuildMatrix";
            this.BuildMatrix.Size = new System.Drawing.Size(282, 23);
            this.BuildMatrix.TabIndex = 2;
            this.BuildMatrix.Text = "BuildMatrix";
            this.BuildMatrix.UseVisualStyleBackColor = true;
            this.BuildMatrix.Click += new System.EventHandler(this.BuildMatrix_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(282, 223);
            this.dataGridView1.TabIndex = 3;
            // 
            // OpenImageBtn
            // 
            this.OpenImageBtn.Location = new System.Drawing.Point(6, 19);
            this.OpenImageBtn.Name = "OpenImageBtn";
            this.OpenImageBtn.Size = new System.Drawing.Size(97, 23);
            this.OpenImageBtn.TabIndex = 11;
            this.OpenImageBtn.Text = "OpenImage";
            this.OpenImageBtn.UseVisualStyleBackColor = true;
            this.OpenImageBtn.Click += new System.EventHandler(this.OpenImageBtn_Click);
            // 
            // CutAndScalingBtn
            // 
            this.CutAndScalingBtn.Location = new System.Drawing.Point(6, 48);
            this.CutAndScalingBtn.Name = "CutAndScalingBtn";
            this.CutAndScalingBtn.Size = new System.Drawing.Size(97, 23);
            this.CutAndScalingBtn.TabIndex = 12;
            this.CutAndScalingBtn.Text = "CutAndScaling";
            this.CutAndScalingBtn.UseVisualStyleBackColor = true;
            this.CutAndScalingBtn.Click += new System.EventHandler(this.CutAndScalingBtn_Click);
            // 
            // ResultBtn
            // 
            this.ResultBtn.Location = new System.Drawing.Point(6, 77);
            this.ResultBtn.Name = "ResultBtn";
            this.ResultBtn.Size = new System.Drawing.Size(97, 23);
            this.ResultBtn.TabIndex = 13;
            this.ResultBtn.Text = "Result";
            this.ResultBtn.UseVisualStyleBackColor = true;
            this.ResultBtn.Click += new System.EventHandler(this.ResultBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(317, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 163);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(523, 59);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(603, 260);
            this.dataGridView2.TabIndex = 15;
            // 
            // ReadZondBtn
            // 
            this.ReadZondBtn.Location = new System.Drawing.Point(156, 12);
            this.ReadZondBtn.Name = "ReadZondBtn";
            this.ReadZondBtn.Size = new System.Drawing.Size(138, 23);
            this.ReadZondBtn.TabIndex = 16;
            this.ReadZondBtn.Text = "ReadZond";
            this.ReadZondBtn.UseVisualStyleBackColor = true;
            this.ReadZondBtn.Click += new System.EventHandler(this.ReadZondBtn_Click);
            // 
            // CompareBtn
            // 
            this.CompareBtn.Location = new System.Drawing.Point(577, 11);
            this.CompareBtn.Name = "CompareBtn";
            this.CompareBtn.Size = new System.Drawing.Size(127, 23);
            this.CompareBtn.TabIndex = 17;
            this.CompareBtn.Text = "CompareComponents";
            this.CompareBtn.UseVisualStyleBackColor = true;
            this.CompareBtn.Click += new System.EventHandler(this.CompareBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OpenImageBtn);
            this.groupBox1.Controls.Add(this.CutAndScalingBtn);
            this.groupBox1.Controls.Add(this.ResultBtn);
            this.groupBox1.Location = new System.Drawing.Point(317, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 120);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Working with images";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Result ";
            // 
            // ZondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CompareBtn);
            this.Controls.Add(this.ReadZondBtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BuildMatrix);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OpenButton);
            this.Name = "ZondForm";
            this.Text = "ZondForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BuildMatrix;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button OpenImageBtn;
        private System.Windows.Forms.Button CutAndScalingBtn;
        private System.Windows.Forms.Button ResultBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ReadZondBtn;
        private System.Windows.Forms.Button CompareBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}