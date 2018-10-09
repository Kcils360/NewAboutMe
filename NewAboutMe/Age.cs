using System;
using System.Collections.Generic;
using System.Text;

namespace NewAboutMe
{
    class Age
    {
        public int Handle(string a)
        {
            try
            {
                return Convert.ToInt16(a);                
            }
            catch (Exception e)
            {
                Console.WriteLine("Why would you enter that? Clearly I'm asking for a integer. ", e);
                Console.WriteLine("Please enter an integer that reflects your age, dummy.");
                var again = Console.ReadLine();
                return Handle(again);
            }
        }

        public int Old(string o)
        {
            return Handle(o);
        }
    }
}
