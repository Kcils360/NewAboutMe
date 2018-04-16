using System;
using System.Collections.Generic;
using System.Text;

namespace AboutME
{
    public class CityBorn
    {
        public string City(string x)
        {
            if (x == "a")
            {
                return ("Yar, D-town is my home town.");
            }
            else if (x == "b")
            {
                return ("Nope, you suck at this.");
            }
            else
            {
                return ("Simple choices, you suck.");
            }
        }
    }
}
