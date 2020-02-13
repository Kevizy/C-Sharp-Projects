using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter12_Interface
{
   public abstract class Vehicle : IMovable
    {
        public int MinXY { get; set; }
        public int MaxXY { get; set; }
        public string model { get; set; }

        public abstract void Start();

        public abstract void Move(Button b); 
    }
}
