using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment1Task3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            { 
                Bitmap targetImage = new Bitmap(openFileDialogImage.FileName);
                int threshold = Convert.ToInt32(numericUpDownThreshold.Value);
                for(int x = 0; x < targetImage.Width; ++x)
                    for (int y = 0; y < targetImage.Height; ++y)
                    {
                        Color pixel = targetImage.GetPixel(x, y);
                        pixel = (pixel.GetBrightness() * 255 > threshold) ? Color.White : Color.Black;
                        targetImage.SetPixel(x, y, pixel);
                    }

                pictureBoxPreview.Image = targetImage;
                pictureBoxPreview.Width = targetImage.Width;
                pictureBoxPreview.Height = targetImage.Height;

                richTextBoxComponents.Text = ImageLabeler.LabelImage(ref targetImage);
            }
        }
    }
}
