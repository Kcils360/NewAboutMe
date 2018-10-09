using System;
using System.Collections.Generic;
using System.Text;

namespace AboutME
{
    class Responses
    {
        public string R1(string x)
        {
            return $"Cool {x}, let's begin.";
        }

        public string R2(string x)
        {
            return $"Thanks for playing {x}, have a great day";
        }

        public string R3(string x, int y)
        {
            return $"Wow {x}, {y} is a stupid age.";
        }
    }
}
