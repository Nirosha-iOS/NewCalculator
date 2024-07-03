using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewCalculator
{
    public partial class Form1 : Form
    {

        public string operators;
        public decimal value1, value2, ans;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            commonFunction("1");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            commonFunction("0");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch(operators)
            {
                case "+":
                    value2 = decimal.Parse(txtBox.Text);
                    ans = value1 + value2;
                    txtBox.Text = ans.ToString();
                    break;
                case "-":
                    value2 = decimal.Parse(txtBox.Text);
                    ans = value1 - value2;
                    txtBox.Text = ans.ToString();
                    break;

                case "*":
                    value2 = decimal.Parse(txtBox.Text);
                    ans = value1 * value2;
                    txtBox.Text = ans.ToString();
                    break;
                case "/":
                    value2 = decimal.Parse(txtBox.Text);
                    ans = value1 / value2;
                    txtBox.Text = ans.ToString();
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            commonFunction("4");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            commonFunction("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            commonFunction("3");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            commonFunction("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            commonFunction("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            commonFunction("7");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            commonFunction("9");
        }

        private void add_Click(object sender, EventArgs e)
        {
            commonOperation("+");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            commonFunction("8");
        }

        private void min_Click(object sender, EventArgs e)
        {
            commonOperation("-");
        }

        private void mul_Click(object sender, EventArgs e)
        {
            commonOperation("*");
        }

        private void div_Click(object sender, EventArgs e)
        {
            commonOperation("/");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            if (txtBox.TextLength > 0)
            {
                txtBox.Text = txtBox.Text.Remove(txtBox.Text.Length-1,1);
            }
           
        }

        private void commonFunction(string txtValue)
        {

            if (txtBox.Text == "0")
            {
                txtBox.Text = txtValue;
            }
            else
            {
                txtBox.Text += txtValue;
            }

        }

        private void commonOperation(string txtOperator)
        {
            value1 = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            operators = txtOperator;
        }
    }
}
