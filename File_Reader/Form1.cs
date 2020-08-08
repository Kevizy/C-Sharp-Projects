using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace File_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWriteText_Click(object sender, EventArgs e)
        {
            try
            {
                // variables used to output to file
                var path = "output.txt";
                var record = txtFirstName.Text + " " + txtLastName.Text + "," + " Phone #:" + txtPhoneNumber.Text;

                // Check if file already exists 
                if (File.Exists(path))
                {
                    // Write out the record using a streamwriter 
                    StreamWriter sw = File.AppendText(path);
                    sw.WriteLine(record);
                    sw.Close(); 
                } else
                {
                    // Create the file and not have to close sw 
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(record); 
                    }
                }

                // Displays a message showing there has been file output 
                MessageBox.Show("File written to " + path);

                // Clears the textboxes 
                txtFirstName.Clear();
                txtLastName.Clear();
                txtPhoneNumber.Clear(); 
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }
    }
}
