namespace OpenCVWinForm
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarThreshold2 = new System.Windows.Forms.TrackBar();
            this.trackBarThreshold1 = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxOpenCVImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenCVImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBarThreshold2);
            this.panel1.Controls.Add(this.trackBarThreshold1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 37);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Threshold 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Threshold 2";
            // 
            // trackBarThreshold2
            // 
            this.trackBarThreshold2.Location = new System.Drawing.Point(291, 3);
            this.trackBarThreshold2.Maximum = 300;
            this.trackBarThreshold2.Name = "trackBarThreshold2";
            this.trackBarThreshold2.Size = new System.Drawing.Size(124, 45);
            this.trackBarThreshold2.TabIndex = 1;
            // 
            // trackBarThreshold1
            // 
            this.trackBarThreshold1.Location = new System.Drawing.Point(72, 3);
            this.trackBarThreshold1.Maximum = 300;
            this.trackBarThreshold1.Name = "trackBarThreshold1";
            this.trackBarThreshold1.Size = new System.Drawing.Size(124, 45);
            this.trackBarThreshold1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBoxOpenCVImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 313);
            this.panel2.TabIndex = 1;
            // 
            // pictureBoxOpenCVImage
            // 
            this.pictureBoxOpenCVImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxOpenCVImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxOpenCVImage.Name = "pictureBoxOpenCVImage";
            this.pictureBoxOpenCVImage.Size = new System.Drawing.Size(438, 313);
            this.pictureBoxOpenCVImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOpenCVImage.TabIndex = 0;
            this.pictureBoxOpenCVImage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 350);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Canny Edge with OpenCV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpenCVImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxOpenCVImage;
        private System.Windows.Forms.TrackBar trackBarThreshold2;
        private System.Windows.Forms.TrackBar trackBarThreshold1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

