using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Time_With_Overloaded_Constructor
{
    public class GetTime
    {
        private int hour;
        private int second;
        private int minute;

        // constructor can be called with zero, one, two or three arguments
        public GetTime(int hour = 0, int second = 0, int minute = 0)
        {
            SetTime(hour, minute, second); 
        }

        // Another object supplied as an argument 
        public GetTime(GetTime time)
            : this(time.Hour, time.Minute, time.Second) { }

        // Set a new time value using universal time
        // Invalid values cause properties set accessors to throw exeptions
        public void SetTime(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second; 

        }

        public int Hour
        {
            get
            {
                return hour; 
            }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), 
                        value, $"nameof(Hour) must be between 0-23"); 
                }

                hour = value; 
            }
        } // End hour 

        public int Minute
        {
            get
            {
                return minute; 
            } 
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"nameof(Minute) must be beween 0-59");
                }

                minute = value; 
            }

        } // End minute
        
        public int Second
        {
            get
            {
                return second; 
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"nameof(Second) must be between 0-59"); 
                }

                second = value; 
            }
        } // End second

        // Convert to string in universal time format (HH:MM:SS)
        public string ToUniversalString() =>
            $"{Hour:D2}:{Minute:D2}:{Second:D2}";

        // Convert to string in standard time format (HH:MM:SS AM or PM)
        public override string ToString() =>
        
            $"{((Hour == 0 || Hour == 12) ? 12 : Hour % 12)}:" +
            $"{Minute:D2}:{Second:D2} {(Hour < 12 ? "AM" : "PM")}";
        
    }
}
