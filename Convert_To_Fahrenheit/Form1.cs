using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convert_To_Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Declare variables
            double degreesCelsius;
            double degreesFahrenheit; 

            // Receives input and converts value to double
            degreesCelsius = Convert.ToDouble(txtCelsius.Text);

            // Converts from celsius to fahrenheit 
            degreesFahrenheit = degreesCelsius * 9 / 5 + 32;

            // Unhides the textbox and displays the result 
            txtFahrenheit.Visible = true;
            txtFahrenheit.Text = String.Format("{0}°F", degreesFahrenheit); 
        }

        // Triggers when Exit button is pressed 
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Displays a message telling user program will exit
            MessageBox.Show("Program will now exit.");
            
            // Closes the program 
            Application.Exit(); 
        }
    }
}
