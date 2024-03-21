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
    }
}
