using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelEconomy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles, gallons, mpg;

            if (double.TryParse(milesTextBox.Text, out miles))
            {
                if (double.TryParse(gallonsTextBox.Text, out gallons))
                {
                    mpg = miles / gallons;

                    mpgLabel.Text = mpg.ToString("n1");
                }
                else
                {
                    MessageBox.Show("Invalid input for gallons.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input for miles.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
