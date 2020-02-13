using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter12_Interface
{
    public class Boat : Vehicle
    {
        public int MaxKnotPH { get; set; }
        public override void Start()
        {
            Console.WriteLine("Starting the boat... ");
        }

        public override void Move(Button b)
        {
            Random rand = new Random();
            b.Location = new System.Drawing.Point(rand.Next(MinXY, MaxXY), rand.Next(MinXY, MaxXY));
        }
    }
}
