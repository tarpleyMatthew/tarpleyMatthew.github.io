using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tips_Calculator
{
    public partial class Form1 : Form
    {
        const int DIVISOR = 100;
        double bill, percent;
        public Form1()
        {
            InitializeComponent();
            percentControl.Maximum = 100;
            percentControl.Minimum = 0;
            percentControl.TickFrequency = 5;
            percentControl.LargeChange = 5;
            percentControl.SmallChange= 5;
        }
        
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                bill = Convert.ToDouble(billAmountBox.Text);
                if (!(bill <= 0))
                {
                    percent = (double)percentControl.Value / DIVISOR;

                    tipLabel.Text = (bill * percent).ToString("c");
                    totalLabel.Text = (bill + (bill * percent)).ToString("c");
                    billAmountBox.Clear();
                }
                else
                {
                    billAmountBox.Clear();
                    MessageBox.Show("Please enter a number greater than 0!", "Oops!");
                }
            }
            catch(Exception)
            {

                billAmountBox.Clear();
                MessageBox.Show("Looks like you entered something incorrectly..", "Oops!");
            }
        }

        private void percentControl_Scroll(object sender, EventArgs e)
        {
            percentLabel.Text = percentControl.Value.ToString() + "%";
            
        }
    }
}
