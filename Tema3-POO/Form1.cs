namespace Tema3_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double a;
        public double b;
        public string operation;


        private void nr1_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void nr2_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void nr3_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void nr4_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void nr5_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void nr6_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void nr7_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void nr8_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void nr9_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void nr0_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
            a = 0;
            b = 0;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            int dot_count = 0;
            foreach (char c in textBox.Text)
            {
                if (c == ',')
                    dot_count++;
            }
            if (dot_count == 0)
                textBox.Text += ",";
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "" && textBox.Text != "Undefined")
            {
                a = double.Parse(textBox.Text);
                textBox.Text = null;
                operation = "+";
            }

        }

        private void substract_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "" && textBox.Text != "Undefined")
            {
                a = double.Parse(textBox.Text);
                textBox.Text = null;
                operation = "-";
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "" && textBox.Text != "Undefined")
            {
                a = double.Parse(textBox.Text);
                textBox.Text = null;
                operation = "*";
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "" && textBox.Text != "Undefined")
            {
                a = double.Parse(textBox.Text);
                textBox.Text = null;
                operation = "/";
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "" && textBox.Text != "Undefined")
            {
                b = double.Parse(textBox.Text);
                if (operation == "+")
                {
                    double result = a + b;
                    textBox.Text = result.ToString();
                }

                if (operation == "-")
                {
                    double result = a - b;
                    textBox.Text = result.ToString();
                }

                if (operation == "*")
                {
                    double result = a * b;
                    textBox.Text = result.ToString();
                }

                if (operation == "/")
                {
                    if (b == 0)
                        textBox.Text = "Undefined";
                    else
                    {
                        double result = a / b;
                        textBox.Text = result.ToString();
                    }
                }
            }

        }
    }
}