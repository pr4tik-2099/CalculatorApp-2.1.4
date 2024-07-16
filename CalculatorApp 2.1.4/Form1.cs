namespace CalculatorApp_2._1._4
{
    public partial class Form1 : Form
    {
        public double num1;
        public double num2;
        public string opt;
        public double result;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Num_disalay.Enabled = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Num_disalay.Text = Num_disalay.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Num_disalay.Text = Num_disalay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Num_disalay.Text = Num_disalay.Text + "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Num_disalay.Text = Num_disalay.Text + "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Num_disalay.Text = Num_disalay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Num_disalay.Text = Num_disalay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Num_disalay.Text = Num_disalay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Num_disalay.Text = Num_disalay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Num_disalay.Text = Num_disalay.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Num_disalay.Text = Num_disalay.Text + "0";
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            Num_disalay.Clear();
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            opt = "+";
            num1 = double.Parse(Num_disalay.Text);
            Num_disalay.Clear();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            opt = "-";
            num1 = double.Parse(Num_disalay.Text);
            Num_disalay.Clear();
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            opt = "x";
            num1 = double.Parse(Num_disalay.Text);
            Num_disalay.Clear();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            opt = "/";
            num1 = double.Parse(Num_disalay.Text);
            Num_disalay.Clear();
        }

        private void btneql_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(Num_disalay.Text);

            if (opt == "+")
            {
                result = num1 + num2;
                Num_disalay.Text = Convert.ToString(result);
            }
            else if (opt == "-")
            {
                result = num1 - num2;
                Num_disalay.Text = Convert.ToString(result);
            }
            else if (opt == "x")
            {
                result = num1 * num2;
                Num_disalay.Text = Convert.ToString(result);
            }
            else if (opt == "/")
            {
                result = num1 / num2;
                Num_disalay.Text = Convert.ToString(result);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Num_disalay.Text = Num_disalay.Text + ".";
        }
    }
}
