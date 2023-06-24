namespace calculator_windows_form
{
    public enum CalcOperationType
    {
        Add,
        Sub,
        Multiply,
        Division,
        Modulus
    }
    public partial class Calculator : Form
    {
        private decimal num1 = 0.0m;
        private decimal num2 = 0.0m;
        private string symbol = "";
        private decimal Result = 0;
        //CalcOperationType.operationType = CalcOperationType.Add();
        //CalcOperationType.operationType = CalcOperationType.Add;


        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void grpcalc_Enter(object sender, EventArgs e)
        {

        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "0";
            }
            else
            {
                txtdisplay.Text += "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "1";
            }
            else
            {
                txtdisplay.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "2";
            }
            else
            {
                txtdisplay.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "")
            {
                txtdisplay.Text = "3";
            }
            else
            {
                txtdisplay.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "4";
            }
            else
            {
                txtdisplay.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "5";
            }
            else
            {
                txtdisplay.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "6";
            }
            else
            {
                txtdisplay.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "7";
            }
            else
            {
                txtdisplay.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "8";
            }
            else
            {
                txtdisplay.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = "9";
            }
            else
            {
                txtdisplay.Text += "9";
            }
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (!txtdisplay.Text.Contains("."))
            {
                txtdisplay.Text += ".";
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(txtdisplay.Text);
            txtdisplay.Clear();
            symbol = "-";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(txtdisplay.Text);
            txtdisplay.Clear();
            symbol = "+";
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(txtdisplay.Text);
            txtdisplay.Clear();
            symbol = "*";
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(txtdisplay.Text);
            txtdisplay.Clear();
            symbol = "/";
        }

        private void btnmodulo_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(txtdisplay.Text);
            txtdisplay.Clear();
            symbol = "%";
        }


        private void btnequal_Click(object sender, EventArgs e)
        {
            switch (symbol)
            {
                case "-":
                    {
                        num2 = decimal.Parse(txtdisplay.Text);
                        Result = num1 - num2;
                        txtdisplay.Text = Result.ToString();
                        break;
                    }
                case "+":
                    {

                        num2 = decimal.Parse(txtdisplay.Text);
                        Result = num1 + num2;
                        txtdisplay.Text = Result.ToString();
                        break;
                    }
                case "*":
                    {

                        num2 = decimal.Parse(txtdisplay.Text);
                        Result = num1 * num2;
                        txtdisplay.Text = Result.ToString();
                        break;
                    }
                case "/":
                    {

                        num2 = decimal.Parse(txtdisplay.Text);
                        Result = num1 / num2;
                        txtdisplay.Text = Result.ToString();
                        break;
                    }
                case "%":
                    {

                        num2 = decimal.Parse(txtdisplay.Text);
                        Result = num1 % num2;
                        txtdisplay.Text = Result.ToString();
                        break;
                    }
            }
        }

        private void btnminusplus_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text.Contains("-"))
            {
                txtdisplay.Text = txtdisplay.Text.Trim('-');
            }
            else
            {
                txtdisplay.Text = "-" + txtdisplay.Text;
            }
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            num1 = 0.0m;
            num2 = 0.0m;
            txtdisplay.Text = "0";
            txtdisplay.Text = "0";
        }
    }
}