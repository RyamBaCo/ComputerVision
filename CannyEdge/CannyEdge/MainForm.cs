using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using OpenCvSharp;

namespace OpenCVWinForm
{
    public partial class MainForm : Form
    {
        private Thread cameraThread;

        public MainForm()
        {
            InitializeComponent();
            trackBarThreshold1.DataBindings.Add("Value", GlobalValues.Instance, "Threshold1", false, DataSourceUpdateMode.OnPropertyChanged);
            trackBarThreshold2.DataBindings.Add("Value", GlobalValues.Instance, "Threshold2", false, DataSourceUpdateMode.OnPropertyChanged);
            cameraThread = new Thread(new ThreadStart(CaptureCameraCallback));
            cameraThread.Start();
        }

        private void CaptureCameraCallback()
        {
            using (CvCapture cameraCapture = CvCapture.FromCamera(CaptureDevice.Any, 1))
            {
                while (CvWindow.WaitKey(10) < 0)
                {
                    IplImage sourceImage = cameraCapture.QueryFrame();
                    IplImage grayImage = new IplImage(sourceImage.Size, BitDepth.U8, 1);
                    IplImage cannyImage = new IplImage(sourceImage.Size, BitDepth.U8, 1);
                    sourceImage.CvtColor(grayImage, ColorConversion.BgrToGray);
                    Cv.Canny(grayImage, cannyImage, GlobalValues.Instance.Threshold1, GlobalValues.Instance.Threshold2, ApertureSize.Size3);

                    Size pictureBoxSize = pictureBoxOpenCVImage.Size;
                    if (pictureBoxSize.Width > 0 && pictureBoxSize.Height > 0)
                    {
                        Bitmap openCVBitmap = BitmapConverter.ToBitmap(cannyImage);
                        openCVBitmap.SetResolution(pictureBoxSize.Width, pictureBoxSize.Height);
                        pictureBoxOpenCVImage.Image = openCVBitmap;
                    }
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cameraThread.IsAlive)
                cameraThread.Abort();
        }
    }

    public class GlobalValues
    {
        private static readonly GlobalValues instance = new GlobalValues();
        public static GlobalValues Instance { get { return instance; } }

        public int Threshold1 { get; set; }
        public int Threshold2 { get; set; }

        private GlobalValues()
        {
            Threshold1 = 50;
            Threshold2 = 50;
        }
    }
}
