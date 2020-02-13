using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter12_Interface
{
    public partial class Form1 : Form
    {
        // Declare objects 
        private Boat myBoat;
        private Car myCar;
        private Bicycle myBike;
        private Random rand; 

        public Form1()
        {
            InitializeComponent();

            // Creating objects
            myBike = new Bicycle();
            myCar = new Car();
            myBoat = new Boat();
            rand = new Random();

            // Place buttons in starting position 
            btn3Bicycle.Location = new Point(25, 10);
            btn2Car.Location = new Point(25, 90);
            btn1Boat.Location = new Point(25, 170); 
        }

        private void btn1Boat_Click(object sender, EventArgs e)
        {
            MoveVehicle(myBoat);
        }

        private void btn2Car_Click(object sender, EventArgs e)
        {
            MoveVehicle(myCar);
        }

        private void btn3Bicycle_Click(object sender, EventArgs e)
        {
            MoveVehicle(myBike); 
        }

        private void MoveVehicle(IMovable vehicle)
        {
            if(vehicle is Boat)
            {
                var b = (Boat)vehicle;
                b.MaxXY = 200;
                b.MinXY = 100;
                b.Move(btn1Boat);
            } else if (vehicle is Car)
            {
                var c = (Car)vehicle; 
                c.MinXY = 699; 
                c.MaxXY = 699;
                c.Move(btn2Car); 
            } else if (vehicle is Bicycle)
            {
                var d = (Bicycle)vehicle; 
                d.MinXY = 200;
                d.MaxXY = 500;
                d.Move(btn3Bicycle);
            }
        }
    }
}
