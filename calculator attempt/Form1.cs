using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_attempt
{
    public partial class frmCalc : Form
    {
        float total;
        string sign;
        List<float> numbers = new List<float>();

        public frmCalc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + 1.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + 2.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + 3.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + 4.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + 5.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + 6.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + 7.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + 8.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + 9.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + 0.ToString();
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + ".";
        }

        public void btnPlus_Click(object sender, EventArgs e)
        {
            numbers.Add(float.Parse(calcDisplay.Text));
            sign = "+";
            calcDisplay.Text = "";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            numbers.Add(float.Parse(calcDisplay.Text));
            sign = "-";
            calcDisplay.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            
            if(sign == "+")
            {
                numbers.Add(float.Parse(calcDisplay.Text));
                foreach(float number in numbers)
                {
                    total = total + number;
                }
            }
            else if(sign == "*")
            {
                total = float.Parse(calcDisplay.Text);


                foreach(float number in numbers)
                {
                    total = total * number;
                }
            }
            else if(sign == "/")
            {
                numbers.Add(float.Parse(calcDisplay.Text));
                total = numbers[0];
                numbers.RemoveAt(0);
                foreach(float number in numbers)
                {
                    total = total / number;
                }
            }
            else
            {
                Console.WriteLine("Len numbers: " + numbers.Count());
                 total = numbers.ElementAt(0);
                numbers.Remove(0);
                foreach(float number in numbers)
                {
                    total -= number;
                }
            }
            calcDisplay.Text = total.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            numbers.Add(float.Parse(calcDisplay.Text));
            sign = "*";
            calcDisplay.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            numbers.Add(float.Parse(calcDisplay.Text));
            sign = "/";
            calcDisplay.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            total = 0f;
            numbers.Clear();
        }
    }
}
