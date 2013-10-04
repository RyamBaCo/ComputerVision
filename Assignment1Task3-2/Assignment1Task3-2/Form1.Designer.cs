namespace Assignment1Task3_2
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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.numericUpDownThreshold = new System.Windows.Forms.NumericUpDown();
            this.labelThreshold = new System.Windows.Forms.Label();
            this.tabControlImages = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxComponents = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).BeginInit();
            this.tabControlImages.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 12);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load Image";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Location = new System.Drawing.Point(6, 3);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxPreview.TabIndex = 1;
            this.pictureBoxPreview.TabStop = false;
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.Filter = "Image Files|*.jpeg;*.png;*.jpg;*.gif;*.bmp";
            // 
            // numericUpDownThreshold
            // 
            this.numericUpDownThreshold.Location = new System.Drawing.Point(213, 15);
            this.numericUpDownThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownThreshold.Name = "numericUpDownThreshold";
            this.numericUpDownThreshold.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownThreshold.TabIndex = 2;
            this.numericUpDownThreshold.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
            // 
            // labelThreshold
            // 
            this.labelThreshold.AutoSize = true;
            this.labelThreshold.Location = new System.Drawing.Point(153, 17);
            this.labelThreshold.Name = "labelThreshold";
            this.labelThreshold.Size = new System.Drawing.Size(54, 13);
            this.labelThreshold.TabIndex = 3;
            this.labelThreshold.Text = "Threshold";
            // 
            // tabControlImages
            // 
            this.tabControlImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlImages.Controls.Add(this.tabPage1);
            this.tabControlImages.Controls.Add(this.tabPage2);
            this.tabControlImages.Location = new System.Drawing.Point(12, 41);
            this.tabControlImages.Name = "tabControlImages";
            this.tabControlImages.SelectedIndex = 0;
            this.tabControlImages.Size = new System.Drawing.Size(260, 208);
            this.tabControlImages.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBoxPreview);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(252, 182);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "B/W Image";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBoxComponents);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(252, 182);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Connected Components";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBoxComponents
            // 
            this.richTextBoxComponents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxComponents.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxComponents.Location = new System.Drawing.Point(3, 6);
            this.richTextBoxComponents.Name = "richTextBoxComponents";
            this.richTextBoxComponents.ReadOnly = true;
            this.richTextBoxComponents.Size = new System.Drawing.Size(243, 170);
            this.richTextBoxComponents.TabIndex = 0;
            this.richTextBoxComponents.Text = "";
            this.richTextBoxComponents.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControlImages);
            this.Controls.Add(this.labelThreshold);
            this.Controls.Add(this.numericUpDownThreshold);
            this.Controls.Add(this.buttonLoad);
            this.Name = "Form1";
            this.Text = "Assignment #1, Task 3-2, Christian Mayr";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreshold)).EndInit();
            this.tabControlImages.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.NumericUpDown numericUpDownThreshold;
        private System.Windows.Forms.Label labelThreshold;
        private System.Windows.Forms.TabControl tabControlImages;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxComponents;
    }
}

