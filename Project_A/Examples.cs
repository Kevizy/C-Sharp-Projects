using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    class Examples
    {
        // Constructor 
        public Examples() {  }

        // Demo for the for loop method 
        public void DemoForLoop(int endValue)
        {
            for (int counter = 0; counter < endValue; counter++)
            {
                Console.Write($"{counter} ");
            }
        } // end demo for loop 

        // Multiplication table method 
        public void MultiplicationTable(int endValue)
        {
            for (int outerCount = 1; outerCount <= endValue; outerCount++)
            {
                for (int innerCount = 1; innerCount <= endValue; innerCount++)
                {
                    Console.Write(innerCount * outerCount + "\t" );
                }

                Console.Write('\n'); 
            }
        } // end multiplication table 

        // Triple for loops 
        public void TripleForLoops(int a, int b, int c)
        {
            for (int x = 0; x < a; x++)
            {
                for (int y = 0; y < b; y++)
                {
                    for (int z = 0; z < c; z++)
                    {
                        Console.Write("#");
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
         // End triple for loops 

        // Demo conditionals method
        public void DemoConditionals(int a, int b)
        {
            // true if a and b are greater than zero (Logical AND)
            if (a > 0 && ++b > 0) 
            {
                Console.WriteLine($"{a} and {b} are greater than zero.");
            }
            if (a > 0 || b > 0)
            {
                Console.WriteLine($"Either {a} or {b} is greater than zero, or both.");
            }
            if (a > 0 && b > 0 || a % 2 == 0 && b % 2 == 0)
            {
                Console.WriteLine($"{a} and {b} are greater than zero and even.");
            }
        }
        // End demo conditionals method

        // Logical Boolean operators 
        public void DemoBooleans(int a, int b)
        {
            // true if a and b are greater than zero (Logical AND)
            if (a > 0 & ++b > 0)
            {
                Console.WriteLine($"{a} and {b} are greater than zero.");
            }
            if (a > 0 | b > 0)
            {
                Console.WriteLine($"Either {a} or {b} is greater than zero, or both.");
            }
            if (a > 0 && b > 0 | a % 2 == 0 && b % 2 == 0)
            {
                Console.WriteLine($"{a} and {b} are greater than zero and even.");
            }

            // xor exclusive 
            // true only if one side is false and the other is true 
            if (a % 2 == 0 ^ b % 2 == 0) {
                Console.WriteLine($"{a} or {b} is even, not both.");
            }
        }
        // End Logical Boolean Method 



    }
}

