﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter12_Interface
{
    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Starting car...");
        }
        
        

        public override void Move(Button b)
        {
            Random rand = new Random();
            b.Location = new System.Drawing.Point(rand.Next(MinXY, MaxXY), rand.Next(MinXY, MaxXY));
        }
    }
}