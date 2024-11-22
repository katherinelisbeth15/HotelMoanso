namespace proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 30, FontStyle.Regular);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 10, FontStyle.Regular);
        }
    }
}
