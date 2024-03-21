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
                if (radioButton1.Checked)
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                else if (radioButton2.Checked)
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                }
                else if (radioButton3.Checked)
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                }
                pictureBox1.Invalidate(); 
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
                
        }
    }
}
