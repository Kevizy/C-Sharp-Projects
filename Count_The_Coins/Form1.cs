using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Count_The_Coins
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            double quarters;
            double dimes;
            double nickels;
            double pennies;
            double dollars; 

            quarters = Convert.ToDouble(txtQuarters.Text);
            dimes = Convert.ToDouble(txtDimes.Text);
            nickels = Convert.ToDouble(txtNickels.Text);
            pennies = Convert.ToDouble(txtPennies.Text);

            dollars = (0.25 * quarters) + (0.10 * dimes) + (0.05 * nickels) + (0.01 * pennies);

            txtCointotal.Visible = true;
            txtCointotal.Text = String.Format("{0:C2}", dollars);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The program will now exit.");
            Application.Exit(); 
        }
    }
}
