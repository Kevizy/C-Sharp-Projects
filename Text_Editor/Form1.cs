using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace Text_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sets default font size and font style
        int fontsize = 8;
        string fontName = "MS Sans Serif"; 

        // method to change the font 
        public void ChangeFont()
        {
            FontStyle newFont;
            newFont = FontStyle.Regular; 

            // Checks if font buttons are clicked 
            if (mnuBold.Checked)
            {
                newFont = newFont | FontStyle.Bold; 
            }

            if (mnuItalic.Checked)
            {
                newFont = newFont | FontStyle.Italic; 
            }

            if (mnuIUnderline.Checked)
            {
                newFont = newFont | FontStyle.Underline; 
            }

            // Changes the font in text editor 
            txtEditor.Font = new Font(fontName, fontsize, newFont); 
        }

        // Method to create a new file 
        private void mnuNew_Click(object sender, EventArgs e)
        {
            // Ask the user if wants to start a new file 
            if (MessageBox.Show("Are you sure you want to start a new file?", "New File", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtEditor.Text = ""; 
            }
        }

        // Method to close the program 
        private void mnuExit_Click(object sender, EventArgs e)
        {
            // Checks if user wants to close program
            if (MessageBox.Show("Are you sure you want to exit the program??", "Exit Application", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
               Close();
            }
        }



        // Method to save the file 
        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                StreamWriter outputFile = new StreamWriter(dlgSave.FileName);
                outputFile.Write(txtEditor.Text);
                outputFile.Close();
            } 
        }

        private void mnuBold_Click(object sender, EventArgs e)
        {
            // Sets the property to checked if its not checked 
            mnuBold.Checked = !mnuBold.Checked;
            ChangeFont(); 
        }

        private void mnuItalic_Click(object sender, EventArgs e)
        {
            mnuItalic.Checked = !mnuItalic.Checked;
            ChangeFont(); 
        }

        private void mnuIUnderline_Click(object sender, EventArgs e)
        {
            mnuIUnderline.Checked = !mnuIUnderline.Checked;
            ChangeFont();
        }

        private void mnuSizeFormat_Click(object sender, EventArgs e)
        {
            string sizeClicked = ((ToolStripMenuItem)sender).Text;
            mnuFormatSmallSize.Checked = false;
            mnuFormatMediumSize.Checked = false;
            mnuFormatLargeSize.Checked = false; 

            switch (sizeClicked)
            {
                case "&Small":
                    fontsize = 8;
                    mnuFormatSmallSize.Checked = true;
                    break;
                case "&Medium":
                    fontsize = 11;
                    mnuFormatMediumSize.Checked = true;
                    break;
                case "&Large":
                    fontsize = 16;
                    mnuFormatLargeSize.Checked = true;
                    break; 
            }
            ChangeFont(); 
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            // Check if file name is open 
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                // creates a new streamreader and opens text 
                StreamReader inputFile = new StreamReader(dlgOpen.FileName);
                txtEditor.Text = inputFile.ReadToEnd();
                inputFile.Close();
                txtEditor.SelectionLength = 0; 
            }
        }
    }
}
