using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double result = 0;
        string opperationPerformed = "";
        bool isOperationPerformed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void butt(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" || isOperationPerformed)
            {
                textBox_Result.Clear();
            }
            isOperationPerformed = false;
            Button btn = (Button)sender;
            if (btn.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                {
                    textBox_Result.Text = textBox_Result.Text + btn.Text;
                }
            }
            else
            {
            textBox_Result.Text = textBox_Result.Text + btn.Text;

            }
        }

        private void opperation_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            if (result!=0)
            {
                button16.PerformClick();
                opperationPerformed = btn.Text;
                label1.Text = result + " " + opperationPerformed;
                isOperationPerformed = true;
            }
            else
            {
            opperationPerformed = btn.Text;
            result = double.Parse(textBox_Result.Text);
            label1.Text = result + " " + opperationPerformed;
            isOperationPerformed = true;                    
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            result = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (opperationPerformed)
            {
                case "+":
                    textBox_Result.Text = (result + double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (result - double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (result * double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (result / double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = double.Parse(textBox_Result.Text);
            label1.Text = "";
        }
    }
}
