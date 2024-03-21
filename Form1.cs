namespace lab_4___wczytywanie_obrazu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Ola\\OneDrive\\Pulpit\\kwiat.bmp");
            this.Controls.Add(pictureBox1);
            pictureBox1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(this, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bmp = (Bitmap)pictureBox1.Image;

                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color pixelColor = bmp.GetPixel(x, y);
                        if (pixelColor.G < pixelColor.R && pixelColor.G < pixelColor.B) 
                        {
                            bmp.SetPixel(x, y, Color.Black); 
                        }
                    }
                }

                pictureBox1.Image = bmp;
                pictureBox1.Invalidate();
            }
        }
    }
}
