namespace Count_The_Coins
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuarters = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDimes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNickels = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPennies = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCointotal = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Quarters: ";
            // 
            // txtQuarters
            // 
            this.txtQuarters.Location = new System.Drawing.Point(204, 21);
            this.txtQuarters.Name = "txtQuarters";
            this.txtQuarters.Size = new System.Drawing.Size(100, 20);
            this.txtQuarters.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Dimes:";
            // 
            // txtDimes
            // 
            this.txtDimes.Location = new System.Drawing.Point(204, 55);
            this.txtDimes.Name = "txtDimes";
            this.txtDimes.Size = new System.Drawing.Size(100, 20);
            this.txtDimes.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Nickels:";
            // 
            // txtNickels
            // 
            this.txtNickels.Location = new System.Drawing.Point(204, 91);
            this.txtNickels.Name = "txtNickels";
            this.txtNickels.Size = new System.Drawing.Size(100, 20);
            this.txtNickels.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter Pennies:";
            // 
            // txtPennies
            // 
            this.txtPennies.Location = new System.Drawing.Point(204, 126);
            this.txtPennies.Name = "txtPennies";
            this.txtPennies.Size = new System.Drawing.Size(100, 20);
            this.txtPennies.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Coins: ";
            // 
            // txtCointotal
            // 
            this.txtCointotal.Location = new System.Drawing.Point(204, 162);
            this.txtCointotal.Name = "txtCointotal";
            this.txtCointotal.Size = new System.Drawing.Size(100, 20);
            this.txtCointotal.TabIndex = 9;
            this.txtCointotal.Visible = false;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(84, 217);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(96, 41);
            this.btnCount.TabIndex = 10;
            this.btnCount.Text = "Count Coins";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(232, 217);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 41);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 288);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtCointotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPennies);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNickels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDimes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuarters);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Count The Coins";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuarters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDimes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNickels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPennies;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCointotal;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnExit;
    }
}

