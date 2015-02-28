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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.pictureBox1.Location = new System.Drawing.Point(87, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 146);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BuildMatrix
            // 
            this.BuildMatrix.Location = new System.Drawing.Point(160, 207);
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
            this.dataGridView1.Location = new System.Drawing.Point(30, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 258);
            this.dataGridView1.TabIndex = 3;
            // 
            // OpenImageBtn
            // 
            this.OpenImageBtn.Location = new System.Drawing.Point(480, 11);
            this.OpenImageBtn.Name = "OpenImageBtn";
            this.OpenImageBtn.Size = new System.Drawing.Size(97, 23);
            this.OpenImageBtn.TabIndex = 11;
            this.OpenImageBtn.Text = "OpenImage";
            this.OpenImageBtn.UseVisualStyleBackColor = true;
            this.OpenImageBtn.Click += new System.EventHandler(this.OpenImageBtn_Click);
            // 
            // CutAndScalingBtn
            // 
            this.CutAndScalingBtn.Location = new System.Drawing.Point(480, 74);
            this.CutAndScalingBtn.Name = "CutAndScalingBtn";
            this.CutAndScalingBtn.Size = new System.Drawing.Size(97, 23);
            this.CutAndScalingBtn.TabIndex = 12;
            this.CutAndScalingBtn.Text = "CutAndScaling";
            this.CutAndScalingBtn.UseVisualStyleBackColor = true;
            this.CutAndScalingBtn.Click += new System.EventHandler(this.CutAndScalingBtn_Click);
            // 
            // ResultBtn
            // 
            this.ResultBtn.Location = new System.Drawing.Point(480, 128);
            this.ResultBtn.Name = "ResultBtn";
            this.ResultBtn.Size = new System.Drawing.Size(97, 23);
            this.ResultBtn.TabIndex = 13;
            this.ResultBtn.Text = "Result";
            this.ResultBtn.UseVisualStyleBackColor = true;
            this.ResultBtn.Click += new System.EventHandler(this.ResultBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(442, 177);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 163);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // ZondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 548);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ResultBtn);
            this.Controls.Add(this.CutAndScalingBtn);
            this.Controls.Add(this.OpenImageBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BuildMatrix);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OpenButton);
            this.Name = "ZondForm";
            this.Text = "ZondForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

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
    }
}