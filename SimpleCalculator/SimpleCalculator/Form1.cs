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
        //declaring variables
        string selectedOperator = "";
        double value;
        bool operatorPressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (resultWindow.Text == "0" || operatorPressed == true)
                resultWindow.Clear();

            operatorPressed = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!resultWindow.Text.Contains("."))
                resultWindow.Text += b.Text;
            }
            else
                resultWindow.Text += b.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            try
            {
                if (value != 0)
                {
                    equalsButton.PerformClick();
                    operatorPressed = true;
                    selectedOperator = b.Text;
                    equation.Text = value + " " + selectedOperator;
                }
                else
                {
                    value = Convert.ToDouble(resultWindow.Text);
                    selectedOperator = b.Text;

                    operatorPressed = true;
                    equation.Text = value + " " + selectedOperator;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error please enter a number", "oops!");
            }

        }//end operator_Click

        private void equals_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            try
            {
                switch (selectedOperator)
                {
                    case "+":
                        resultWindow.Text = (value + Convert.ToDouble(resultWindow.Text)).ToString();
                        break;
                    case "-":
                        resultWindow.Text = (value - Convert.ToDouble(resultWindow.Text)).ToString();
                        break;
                    case "/":
                        resultWindow.Text = (value / Convert.ToDouble(resultWindow.Text)).ToString();
                        break;
                    case "*":
                        resultWindow.Text = (value * Convert.ToDouble(resultWindow.Text)).ToString();
                        break;
                    default:
                        break;
                } //end switch
                value = Convert.ToDouble(resultWindow.Text);
                selectedOperator = "";
            }
            catch (Exception)
            {
                MessageBox.Show("error please enter a number", "oops!");
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultWindow.Text = "0";
            equation.Text = "";
            value = 0;
        }

        private void CE_click(object sender, EventArgs e)
        {
            resultWindow.Text = "0";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar.ToString())
            {
                case "1": oneButton.PerformClick();
                    break;
                case "2": twoButton.PerformClick();
                    break;
                case "3": threeButton.PerformClick();
                    break;
                case "4": fourButton.PerformClick();
                    break;
                case"5": fiveButton.PerformClick();
                    break;
                case "6": sixButton.PerformClick();
                    break;
                case "7": sevenButton.PerformClick();
                    break;
                case "8": eightButton.PerformClick();
                    break;
                case"9": nineButton.PerformClick();
                    break;
                case "+": plusButton.PerformClick();
                    break;
                case "-": minusButton.PerformClick();
                    break;
                case "*": timesButton.PerformClick();
                    break;
                case "/": divButton.PerformClick();
                    break;
                default:
                    break;

            }
        }
    }
}
