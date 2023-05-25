using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;

namespace OpenCVTextDisplayer
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        void UpdateImage()
        {
            string text = textInput.Text;

            if (text.Length == 0)
            {
                text = "Enter some text pls :)";
            }

            Bgr background = new Bgr(186, 226, 65);

            if (discoMode.Checked)
            {
                background = new Bgr(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            }

            Mat img = new Mat(image.Height, image.Width, DepthType.Cv8U, 3);
            img.SetTo(background.MCvScalar);
            CvInvoke.PutText(img, text, new Point(10, 80), FontFace.HersheyComplex, 1.0, new Bgr(255, 255, 255).MCvScalar);

            image.Image = img.ToBitmap();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            UpdateImage();
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {
            UpdateImage();
        }
    }
}