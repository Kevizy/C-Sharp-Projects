namespace Pizza_Order_Form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbxUser = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.grbxToppings = new System.Windows.Forms.GroupBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.grbxSize = new System.Windows.Forms.GroupBox();
            this.rdoLarge = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoSmall = new System.Windows.Forms.RadioButton();
            this.btnEnter = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.ListBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbxCrust = new System.Windows.Forms.GroupBox();
            this.rdoThin = new System.Windows.Forms.RadioButton();
            this.rdoDeepdish = new System.Windows.Forms.RadioButton();
            this.rdoCheesestuffed = new System.Windows.Forms.RadioButton();
            this.rdoRegular = new System.Windows.Forms.RadioButton();
            this.orderinfo = new System.Windows.Forms.Label();
            this.grbxUser.SuspendLayout();
            this.grbxToppings.SuspendLayout();
            this.grbxSize.SuspendLayout();
            this.grbxCrust.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbxUser
            // 
            this.grbxUser.Controls.Add(this.btnEnter);
            this.grbxUser.Controls.Add(this.txtPassword);
            this.grbxUser.Controls.Add(this.txtUser);
            this.grbxUser.Controls.Add(this.lblPass);
            this.grbxUser.Controls.Add(this.lblUser);
            this.grbxUser.Location = new System.Drawing.Point(24, 23);
            this.grbxUser.Name = "grbxUser";
            this.grbxUser.Size = new System.Drawing.Size(557, 123);
            this.grbxUser.TabIndex = 0;
            this.grbxUser.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(107, 78);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(290, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(107, 26);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(290, 20);
            this.txtUser.TabIndex = 2;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(26, 78);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(56, 13);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(23, 29);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(58, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username:";
            // 
            // grbxToppings
            // 
            this.grbxToppings.Controls.Add(this.chkOlives);
            this.grbxToppings.Controls.Add(this.chkMushrooms);
            this.grbxToppings.Controls.Add(this.chkSausage);
            this.grbxToppings.Controls.Add(this.chkPepperoni);
            this.grbxToppings.Location = new System.Drawing.Point(24, 176);
            this.grbxToppings.Name = "grbxToppings";
            this.grbxToppings.Size = new System.Drawing.Size(446, 82);
            this.grbxToppings.TabIndex = 1;
            this.grbxToppings.TabStop = false;
            this.grbxToppings.Text = "Toppings";
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(305, 33);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(55, 17);
            this.chkOlives.TabIndex = 3;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(197, 33);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(80, 17);
            this.chkMushrooms.TabIndex = 2;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Location = new System.Drawing.Point(107, 33);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(68, 17);
            this.chkSausage.TabIndex = 1;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(15, 33);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(74, 17);
            this.chkPepperoni.TabIndex = 0;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // grbxSize
            // 
            this.grbxSize.Controls.Add(this.rdoLarge);
            this.grbxSize.Controls.Add(this.rdoMedium);
            this.grbxSize.Controls.Add(this.rdoSmall);
            this.grbxSize.Location = new System.Drawing.Point(24, 288);
            this.grbxSize.Name = "grbxSize";
            this.grbxSize.Size = new System.Drawing.Size(446, 67);
            this.grbxSize.TabIndex = 2;
            this.grbxSize.TabStop = false;
            this.grbxSize.Text = "Size";
            // 
            // rdoLarge
            // 
            this.rdoLarge.AutoSize = true;
            this.rdoLarge.Location = new System.Drawing.Point(294, 31);
            this.rdoLarge.Name = "rdoLarge";
            this.rdoLarge.Size = new System.Drawing.Size(52, 17);
            this.rdoLarge.TabIndex = 2;
            this.rdoLarge.TabStop = true;
            this.rdoLarge.Text = "Large";
            this.rdoLarge.UseVisualStyleBackColor = true;
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Location = new System.Drawing.Point(161, 31);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(62, 17);
            this.rdoMedium.TabIndex = 1;
            this.rdoMedium.TabStop = true;
            this.rdoMedium.Text = "Medium";
            this.rdoMedium.UseVisualStyleBackColor = true;
            // 
            // rdoSmall
            // 
            this.rdoSmall.AutoSize = true;
            this.rdoSmall.Location = new System.Drawing.Point(39, 31);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(50, 17);
            this.rdoSmall.TabIndex = 0;
            this.rdoSmall.TabStop = true;
            this.rdoSmall.Text = "Small";
            this.rdoSmall.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(425, 26);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(113, 74);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Order
            // 
            this.Order.FormattingEnabled = true;
            this.Order.Location = new System.Drawing.Point(609, 52);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(178, 342);
            this.Order.TabIndex = 3;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(518, 412);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(115, 92);
            this.btnPlaceOrder.TabIndex = 4;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(672, 412);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 92);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grbxCrust
            // 
            this.grbxCrust.Controls.Add(this.rdoRegular);
            this.grbxCrust.Controls.Add(this.rdoCheesestuffed);
            this.grbxCrust.Controls.Add(this.rdoDeepdish);
            this.grbxCrust.Controls.Add(this.rdoThin);
            this.grbxCrust.Location = new System.Drawing.Point(24, 384);
            this.grbxCrust.Name = "grbxCrust";
            this.grbxCrust.Size = new System.Drawing.Size(446, 53);
            this.grbxCrust.TabIndex = 6;
            this.grbxCrust.TabStop = false;
            this.grbxCrust.Text = "Crust Type";
            // 
            // rdoThin
            // 
            this.rdoThin.AutoSize = true;
            this.rdoThin.Location = new System.Drawing.Point(26, 23);
            this.rdoThin.Name = "rdoThin";
            this.rdoThin.Size = new System.Drawing.Size(46, 17);
            this.rdoThin.TabIndex = 0;
            this.rdoThin.TabStop = true;
            this.rdoThin.Text = "Thin";
            this.rdoThin.UseVisualStyleBackColor = true;
            // 
            // rdoDeepdish
            // 
            this.rdoDeepdish.AutoSize = true;
            this.rdoDeepdish.Location = new System.Drawing.Point(107, 23);
            this.rdoDeepdish.Name = "rdoDeepdish";
            this.rdoDeepdish.Size = new System.Drawing.Size(75, 17);
            this.rdoDeepdish.TabIndex = 1;
            this.rdoDeepdish.TabStop = true;
            this.rdoDeepdish.Text = "Deep Dish";
            this.rdoDeepdish.UseVisualStyleBackColor = true;
            // 
            // rdoCheesestuffed
            // 
            this.rdoCheesestuffed.AutoSize = true;
            this.rdoCheesestuffed.Location = new System.Drawing.Point(215, 23);
            this.rdoCheesestuffed.Name = "rdoCheesestuffed";
            this.rdoCheesestuffed.Size = new System.Drawing.Size(98, 17);
            this.rdoCheesestuffed.TabIndex = 2;
            this.rdoCheesestuffed.TabStop = true;
            this.rdoCheesestuffed.Text = "Cheese Stuffed";
            this.rdoCheesestuffed.UseVisualStyleBackColor = true;
            // 
            // rdoRegular
            // 
            this.rdoRegular.AutoSize = true;
            this.rdoRegular.Location = new System.Drawing.Point(347, 23);
            this.rdoRegular.Name = "rdoRegular";
            this.rdoRegular.Size = new System.Drawing.Size(62, 17);
            this.rdoRegular.TabIndex = 3;
            this.rdoRegular.TabStop = true;
            this.rdoRegular.Text = "Regular";
            this.rdoRegular.UseVisualStyleBackColor = true;
            // 
            // orderinfo
            // 
            this.orderinfo.AutoSize = true;
            this.orderinfo.Location = new System.Drawing.Point(606, 23);
            this.orderinfo.Name = "orderinfo";
            this.orderinfo.Size = new System.Drawing.Size(88, 13);
            this.orderinfo.TabIndex = 7;
            this.orderinfo.Text = "Order Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 532);
            this.Controls.Add(this.orderinfo);
            this.Controls.Add(this.grbxCrust);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.grbxSize);
            this.Controls.Add(this.grbxToppings);
            this.Controls.Add(this.grbxUser);
            this.Name = "Form1";
            this.Text = "Pizza Order Form";
            this.grbxUser.ResumeLayout(false);
            this.grbxUser.PerformLayout();
            this.grbxToppings.ResumeLayout(false);
            this.grbxToppings.PerformLayout();
            this.grbxSize.ResumeLayout(false);
            this.grbxSize.PerformLayout();
            this.grbxCrust.ResumeLayout(false);
            this.grbxCrust.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.GroupBox grbxToppings;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.GroupBox grbxSize;
        private System.Windows.Forms.RadioButton rdoLarge;
        private System.Windows.Forms.RadioButton rdoMedium;
        private System.Windows.Forms.RadioButton rdoSmall;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ListBox Order;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grbxCrust;
        private System.Windows.Forms.RadioButton rdoRegular;
        private System.Windows.Forms.RadioButton rdoCheesestuffed;
        private System.Windows.Forms.RadioButton rdoDeepdish;
        private System.Windows.Forms.RadioButton rdoThin;
        private System.Windows.Forms.Label orderinfo;
    }
}

