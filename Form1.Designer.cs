namespace Chapter12_Interface
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
            this.btn1Boat = new System.Windows.Forms.Button();
            this.btn2Car = new System.Windows.Forms.Button();
            this.btn3Bicycle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1Boat
            // 
            this.btn1Boat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Boat.Location = new System.Drawing.Point(185, 102);
            this.btn1Boat.Name = "btn1Boat";
            this.btn1Boat.Size = new System.Drawing.Size(75, 23);
            this.btn1Boat.TabIndex = 0;
            this.btn1Boat.Text = "Boat";
            this.btn1Boat.UseVisualStyleBackColor = true;
            this.btn1Boat.Click += new System.EventHandler(this.btn1Boat_Click);
            // 
            // btn2Car
            // 
            this.btn2Car.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Car.Location = new System.Drawing.Point(308, 226);
            this.btn2Car.Name = "btn2Car";
            this.btn2Car.Size = new System.Drawing.Size(75, 23);
            this.btn2Car.TabIndex = 1;
            this.btn2Car.Text = "Car";
            this.btn2Car.UseVisualStyleBackColor = true;
            this.btn2Car.Click += new System.EventHandler(this.btn2Car_Click);
            // 
            // btn3Bicycle
            // 
            this.btn3Bicycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Bicycle.Location = new System.Drawing.Point(432, 478);
            this.btn3Bicycle.Name = "btn3Bicycle";
            this.btn3Bicycle.Size = new System.Drawing.Size(75, 23);
            this.btn3Bicycle.TabIndex = 2;
            this.btn3Bicycle.Text = "Bicycle";
            this.btn3Bicycle.UseVisualStyleBackColor = true;
            this.btn3Bicycle.Click += new System.EventHandler(this.btn3Bicycle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 653);
            this.Controls.Add(this.btn3Bicycle);
            this.Controls.Add(this.btn2Car);
            this.Controls.Add(this.btn1Boat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1Boat;
        private System.Windows.Forms.Button btn2Car;
        private System.Windows.Forms.Button btn3Bicycle;
    }
}

