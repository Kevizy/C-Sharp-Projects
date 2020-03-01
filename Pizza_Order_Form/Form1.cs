using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Order_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program will now exit.");
            Application.Exit(); 
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var u = "";
            var p = "";

            if (u.ToLower().Equals(txtUser.Text) && p.Equals(txtPassword.Text))
            {
                btnEnter.Visible = true;
                btnExit.Visible = true;
                grbxUser.Visible = false;
                MessageBox.Show($"Welcome"); 
            } else
            {
                MessageBox.Show("Username or Password is incorrect."); 
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            var size = String.Empty;
            var crust = String.Empty;

            if (rdoSmall.Checked)
            {
                size = rdoSmall.Text; 

            } else if (rdoMedium.Checked)
            {
                size = rdoMedium.Text; 

            } else
            {
                size = rdoLarge.Text; 
            }

            if (rdoThin.Checked)
            {
                
                crust = rdoThin.Text; 

            } else if (rdoDeepdish.Checked)
            {
                crust = rdoDeepdish.Text;

            } else if (rdoCheesestuffed.Checked)
            {
                crust = rdoCheesestuffed.Text;
            } else
            {
                crust = rdoRegular.Text;
            }

            Order.Items.Add($"1 {size} pizza");
            Order.Items.Add($"With {crust} crust");
            if (chkPepperoni.Checked)
            {
                Order.Items.Add($"With {chkPepperoni.Text}");
            }
            if (chkMushrooms.Checked)
            {
                Order.Items.Add($"With {chkMushrooms.Text}");
            }
            if (chkSausage.Checked)
            {
                Order.Items.Add($"With {chkSausage.Text}");
            }
            if (chkOlives.Checked)
            {
                Order.Items.Add($"With {chkOlives.Text}");
            }
        }
    }
}
