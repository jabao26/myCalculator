using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace myCal
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || (isOperationPerformed))
                textBox1.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (textBox1.Text == ".")
            {
                if (textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
                textBox1.Text = textBox1.Text + button.Text;

        }
        private void oparetor_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button16.PerformClick();
                operationPerformed = button.Text;
                label1.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }else{

                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox1.Text);
                label1.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;

            }
            resultValue = Double.Parse(textBox1.Text);
            label1.Text = "";
        }
    }
}
