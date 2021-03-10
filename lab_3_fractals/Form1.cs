using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace lab_3_fractals
{
    public partial class Form1 : Form
    {
        string path = "smth_2.jpg";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path2 = "result.jpg";
            Bitmap img = new Bitmap(path);
            pictureBox1.Image = img;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            Image<Bgr, Byte> image = new Image<Bgr, Byte>("smth_2.jpg");
            Image<Gray, Byte> image2 = image.Convert<Gray, Byte>();

            CvInvoke.Imwrite("result.jpg", image2);

            Bitmap img_2 = new Bitmap(path2);
            pictureBox2.Image = img_2;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
