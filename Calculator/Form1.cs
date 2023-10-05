namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int result = 0;

        private void add(object sender, EventArgs e)
        {
            result = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
            textBox3.Text = result.ToString();
        }

        private void subtract(object sender, EventArgs e)
        {
            result = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
            textBox3.Text = result.ToString();
        }

        private void multiply(object sender, EventArgs e)
        {
            result = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
            textBox3.Text = result.ToString();
        }

        private void divide(object sender, EventArgs e)
        {
            result = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
            textBox3.Text = result.ToString();
        }
    }
}