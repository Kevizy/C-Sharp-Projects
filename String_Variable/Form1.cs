using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Variable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // triggers when the submit button is clicked 
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Declare a string 
            string fullName;

            // Assign values to the first name and last name textboxes 
            fullName = txtFirstName.Text + " " + txtLastName.Text;
            
            // displays the full name 
            dispName.Text = fullName;

        }

        // triggers when the exit button is clicked 
        private void btnExit_Click(object sender, EventArgs e)
        {
            // displays a message before exiting the program 
            MessageBox.Show("This program will now exit.", "Enter Name");

            // closes the program 
            Application.Exit(); 
        }
    }
}
