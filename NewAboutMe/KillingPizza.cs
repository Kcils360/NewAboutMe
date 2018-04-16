using System;
using System.Collections.Generic;
using System.Text;

namespace AboutME
{
    class KilingPizza
    {
        public string WouldKill(string x)
        {
            if (x == "yes" || x == "y")
            {
                return "No way!  Murder is illegal!\n But I do want some pizza";
            }
            else if (x == "no" || x == "n")
            {
                return "Right, because killing is bad...and wrong.\n It's badong...";
            }
            else
            {
                return "WTF? Whatever you just typed is not a valid answer.  You suck.";
            }
        }
    }
}
