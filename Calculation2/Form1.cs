using Calculation;

namespace Calculation2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculate cal = new Calculate();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = cal.Add(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = i.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = cal.Sub(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = i.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
