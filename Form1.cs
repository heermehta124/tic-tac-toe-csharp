using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }



        private void Btnclr_Click(object sender, EventArgs e)
        {
            txtresult.Text = "";
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            this.txtresult.Text = "";
            input += btn0.Text;
            this.txtresult.Text = input;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            this.txtresult.Text = "";
            input += btn1.Text;
            this.txtresult.Text = input;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            this.txtresult.Text = "";
            input += btn2.Text;
            this.txtresult.Text = input;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            this.txtresult.Text = "";
            input += btn3.Text;
            this.txtresult.Text = input;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            this.txtresult.Text = "";
            input += btn4.Text;
            this.txtresult.Text = input;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            this.txtresult.Text = "";
            input += btn5.Text;
            this.txtresult.Text = input;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            this.txtresult.Text = "";
            input += btn6.Text;
            this.txtresult.Text = input;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            this.txtresult.Text = "";
            input += btn7.Text;
            this.txtresult.Text = input;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            this.txtresult.Text = "";
            input += btn8.Text;
            this.txtresult.Text = input;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            this.txtresult.Text = "";
            input += btn9.Text;
            this.txtresult.Text = input;
        }

        private void Btndiv_Click(object sender, EventArgs e)
        {
            txtresult.Text += btndiv.Text;
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void Btnmul_Click(object sender, EventArgs e)
        {
            txtresult.Text += btnmul.Text;
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void Btnsub_Click(object sender, EventArgs e)
        {
            txtresult.Text += btnsub.Text;
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {

            txtresult.Text += btnadd.Text;
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void Btneq_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                txtresult.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                txtresult.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                txtresult.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 == 0)
                {
                    txtresult.Text = "Infinite";
                }
                else
                {
                    result = num1 / num2;
                    txtresult.Text = result.ToString();
                }
            }
            else
            {
                txtresult.Text = "ERROR";
            }

        }
    }
}
