using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool operationPerformedStatus = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (operationPerformedStatus))
                textBox_Result.Clear();

            operationPerformedStatus = false;
            Button button = (Button)sender;
            if(button.Text==".")
            {
                if(!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;
            }
            else
                textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(resultValue != 0)
            {
                button16.PerformClick();
                operationPerformed = button.Text;
                resultValue = double.Parse(textBox_Result.Text);
                CurentOperation.Text = resultValue + " " + operationPerformed;
                operationPerformedStatus = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = double.Parse(textBox_Result.Text);
                CurentOperation.Text = resultValue + " " + operationPerformed;
                operationPerformedStatus = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
            CurentOperation.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = double.Parse(textBox_Result.Text);
            CurentOperation.Text = "";
        }

        private void textBox_Result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
