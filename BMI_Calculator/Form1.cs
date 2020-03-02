using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            double height;
            double weight;
            double totalBMI;
            double roundBMI;

            height = Convert.ToDouble(txtHeight.Text);
            weight = Convert.ToDouble(txtWeight.Text);

            totalBMI = weight / (height * height);
            roundBMI = (Math.Round(totalBMI, 2));

            // Unhides the textbox and displays the result 
            txtBMI.Visible = true;
            txtBMI.Text = $"{roundBMI}";

            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program will now close.");
            Application.Exit(); 
        }
    }
}
