using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Time_With_Overloaded_Constructor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var t1 = new GetTime();
            var t2 = new GetTime(2);
            var t3 = new GetTime(21, 34);
            var t4 = new GetTime(12, 25, 42);
            var t5 = new GetTime(t4);

            Console.WriteLine("Constructed with:\n");
            Console.WriteLine("t1: All arguments defaulted.");
            Console.WriteLine($" {t1.ToUniversalString()}");
            Console.WriteLine($" {t1.ToString()}\n");

            Console.WriteLine("t2: hour specified, minute and second defaulted.");
            Console.WriteLine($" {t2.ToUniversalString()}");
            Console.WriteLine($" {t2.ToString()}\n");

            Console.WriteLine("t3: hour and minute specified, second defaulted.");
            Console.WriteLine($" {t3.ToUniversalString()}");
            Console.WriteLine($" {t3.ToString()}\n");

            Console.WriteLine("t4: hour, minute, and second specified.");
            Console.WriteLine($" {t4.ToUniversalString()}");
            Console.WriteLine($" {t4.ToString()}\n");

            Console.WriteLine("t5: GetTime object t4 specified");
            Console.WriteLine($" {t5.ToUniversalString()}");
            Console.WriteLine($" {t5.ToString()}\n");

            // Attempt to initialize with invalid values
            try
            {
                var t6 = new GetTime(27, 74, 99);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("\n Exception while initializing t6:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
