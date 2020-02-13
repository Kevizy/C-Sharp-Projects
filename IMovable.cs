using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter12_Interface
{
    interface IMovable
    {
        void Move(Button b); 
        int MinXY { get; set; }
        int MaxXY { get; set; }
    }
}
