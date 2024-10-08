namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(YourForm_KeyDown);
            this.KeyPreview = true;
            button_0.TabStop = false;
            button_1.TabStop = false;
            button_2.TabStop = false;
            button_3.TabStop = false;
            button_4.TabStop = false;
            button_5.TabStop = false;
            button_6.TabStop = false;
            button_7.TabStop = false;
            button_8.TabStop = false;
            button_9.TabStop = false;
            button_add.TabStop = false;
            button_sub.TabStop = false;
            button_div.TabStop = false;
            button_x.TabStop = false;
            button_del.TabStop = false;
            button_fasila.TabStop = false;
            button_done.TabStop = false;
            textBox1.TabStop = false;
            textBox2.TabStop = false;
            textBox3.TabStop = false;
            textBox_output.TabStop = false;
        }
        //Functions--------------------------------
        private void num_help(int num)
        {
            if (textBox_output.Text != "")
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox_output.Text = "";
                textBox1.Text += num;
            }
            else if (textBox2.Text != "+" && textBox2.Text != "-" && textBox2.Text != "X" && textBox2.Text != "/")
                textBox1.Text += num;
            else
                textBox3.Text += num;
        }
        private void operator_help(string op)
        {
            if (textBox_output.Text != "")
            {
                textBox1.Text = textBox_output.Text;
                textBox_output.Text = "";
                textBox3.Text = "";
                textBox2.Text = op;
            }
            else
                textBox2.Text = op;
        }
        //-----------------------------------------
        private void YourForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    button_0.PerformClick();
                    break;
                case Keys.NumPad1:
                    button_1.PerformClick();
                    break;
                case Keys.NumPad2:
                    button_2.PerformClick();
                    break;
                case Keys.NumPad3:
                    button_3.PerformClick();
                    break;
                case Keys.NumPad4:
                    button_4.PerformClick();
                    break;
                case Keys.NumPad5:
                    button_5.PerformClick();
                    break;
                case Keys.NumPad6:
                    button_6.PerformClick();
                    break;
                case Keys.NumPad7:
                    button_7.PerformClick();
                    break;
                case Keys.NumPad8:
                    button_8.PerformClick();
                    break;
                case Keys.NumPad9:
                    button_9.PerformClick();
                    break;
                case Keys.Add:
                    button_add.PerformClick();
                    break;
                case Keys.Subtract:
                    button_sub.PerformClick();
                    break;
                case Keys.Multiply:
                    button_x.PerformClick();
                    break;
                case Keys.Divide:
                    button_div.PerformClick();
                    break;
                case Keys.Enter:
                    button_done.PerformClick();
                    break;
                case Keys.Delete:
                    button_del.PerformClick();
                    break;
                case Keys.Decimal:
                    button_fasila.PerformClick();
                    break;
                case Keys.Back:
                    button_back.PerformClick();
                    break;
            }
        }
        private void button_0_Click(object sender, EventArgs e)
        {

            num_help(0);
            this.ActiveControl = null;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            num_help(1);
            this.ActiveControl = null;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            num_help(2);
            this.ActiveControl = null;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            num_help(3);
            this.ActiveControl = null;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            num_help(4);
            this.ActiveControl = null;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            num_help(5);
            this.ActiveControl = null;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            num_help(6);
            this.ActiveControl = null;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            num_help(7);
            this.ActiveControl = null;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            num_help(8);
            this.ActiveControl = null;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            num_help(9);
            this.ActiveControl = null;
        }
        //-----------------------------------------------------------------------------------------------------------------
        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                this.ActiveControl = null;
                return;
            }
            else
                operator_help("+");
            this.ActiveControl = null;
        }
        private void button_sub_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                this.ActiveControl = null;
                return;
            }
            else
                operator_help("-");
            this.ActiveControl = null;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                this.ActiveControl = null;
                return;
            }
            else
                operator_help("X");
            this.ActiveControl = null;
        }
        private void button_div_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                this.ActiveControl = null;
                return;
            }
            else
                operator_help("/");
            this.ActiveControl = null;
        }
        //-----------------------------------------------------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox_output_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------------------------------------------------------------

        private void button_done_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith(".") || textBox3.Text.StartsWith(".") || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                this.ActiveControl = null;
                return;
            }
            else
            {
                float num1 = float.Parse(textBox1.Text);
                float num2 = float.Parse(textBox3.Text);
                if (textBox2.Text == "+")
                {
                    textBox_output.Text = (num1 + num2).ToString();
                }
                else if (textBox2.Text == "-")
                {
                    textBox_output.Text = (num1 - num2).ToString();
                }
                else if (textBox2.Text == "X")
                {
                    textBox_output.Text = (num1 * num2).ToString();
                }
                else if (textBox2.Text == "/")
                {
                    textBox_output.Text = (num1 / num2).ToString();
                }
                this.ActiveControl = null;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox_output.Text = "";
            this.ActiveControl = null;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox_output.Text != "")
            {
                return;
            }
            else if (textBox2.Text != "+" && textBox2.Text != "-" && textBox2.Text != "X" && textBox2.Text != "/")
                textBox1.Text += ".";
            else
                textBox3.Text += ".";
            this.ActiveControl = null;
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            if (textBox_output.Text != "")
            {
                textBox1.Text = textBox_output.Text;
                textBox_output.Text = "";
                textBox3.Text = "";
                textBox2.Text = "";
            }
            else if(textBox2.Text == "")
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                }
            }
            else
            {
                if (textBox3.Text.Length > 0)
                {
                    textBox3.Text = textBox3.Text.Substring(0, textBox3.Text.Length - 1);
                }
            }
            this.ActiveControl = null;
        }
    }
}
