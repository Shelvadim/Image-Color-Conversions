using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;

namespace Image_Color_Conversions
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> imgInput;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                imgInput = new Image<Bgr, byte>(ofd.FileName);
                pictureBox1.Image = imgInput.ToBitmap();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bGRGreyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput==null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }

            Image<Gray, byte> imgOutput = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray(0));
            //imgOutput = imgInput.Convert<Gray, byte>();

            CvInvoke.CvtColor(imgInput, imgOutput, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);

            pictureBox2.Image = imgOutput.ToBitmap();
        }

        private void bGRYCrCbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }

            Image<Ycc, byte> imgOutput = new Image<Ycc, byte>(imgInput.Width, imgInput.Height);
            Image<Bgr, byte> imgFinalOutput = new Image<Bgr, byte>(imgInput.Width, imgInput.Height);

            CvInvoke.CvtColor(imgInput, imgOutput, Emgu.CV.CvEnum.ColorConversion.Bgr2YCrCb);
            imgFinalOutput.Data = imgOutput.Data;
            pictureBox2.Image = imgFinalOutput.ToBitmap();
        }

        private void bGRHSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }

            Image<Hsv, byte> imgOutput = new Image<Hsv, byte>(imgInput.Width, imgInput.Height);
            Image<Bgr, byte> imgFinalOutput = new Image<Bgr, byte>(imgInput.Width, imgInput.Height);

            CvInvoke.CvtColor(imgInput, imgOutput, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);
            imgFinalOutput.Data = imgOutput.Data;
            pictureBox2.Image = imgFinalOutput.ToBitmap();
        }

        private void bGRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }

            Image<Luv, byte> imgOutput = new Image<Luv, byte>(imgInput.Width, imgInput.Height);
            Image<Bgr, byte> imgFinalOutput = new Image<Bgr, byte>(imgInput.Width, imgInput.Height);

            CvInvoke.CvtColor(imgInput, imgOutput, Emgu.CV.CvEnum.ColorConversion.Bgr2Luv);
            imgFinalOutput.Data = imgOutput.Data;
            pictureBox2.Image = imgFinalOutput.ToBitmap();
        }

        private void bGRLubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }

            Image<Lab, byte> imgOutput = new Image<Lab, byte>(imgInput.Width, imgInput.Height);
            Image<Bgr, byte> imgFinalOutput = new Image<Bgr, byte>(imgInput.Width, imgInput.Height);

            CvInvoke.CvtColor(imgInput, imgOutput, Emgu.CV.CvEnum.ColorConversion.Bgr2Lab);
            imgFinalOutput.Data = imgOutput.Data;
            pictureBox2.Image = imgFinalOutput.ToBitmap();
        }

        private void bGRHSLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }

            Image<Hls, byte> imgOutput = new Image<Hls, byte>(imgInput.Width, imgInput.Height);
            Image<Bgr, byte> imgFinalOutput = new Image<Bgr, byte>(imgInput.Width, imgInput.Height);

            CvInvoke.CvtColor(imgInput, imgOutput, Emgu.CV.CvEnum.ColorConversion.Bgr2Hls);
            imgFinalOutput.Data = imgOutput.Data;
            pictureBox2.Image = imgFinalOutput.ToBitmap();
        }
    }
}
