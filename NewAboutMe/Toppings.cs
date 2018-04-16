using System;
using System.Collections.Generic;
using System.Text;

namespace AboutME
{
    class Toppings
    {
        //create a while loop to handle the counter and keep track of correct responses.//
        public void ToppingTypes()
        {
            int c = 0;
            string answer = "";
            while (c <= 5)
            {
                void output()
                {
                    Console.WriteLine(answer);
                }
                string t = Response();

                switch (t)
                {
                    case "cheese":
                        c++;
                        answer = "Well duh, what's a pizza without cheese?";
                        output();
                        break;

                    case "jalepeno":
                        c++;
                        answer = "Aww yeah, spice it up!";
                        output();
                        break;

                    case "pepperoni":
                        c++;
                        answer = "Yep, only the best toppings for my pie!";
                        output();
                        break;
                    default:
                        c++;
                        answer = $"Eww gross.  Who would want {t} on a pizza?";
                        output();
                        break;
                }
            }
        }

        public string Response()
        {
            return Console.ReadLine().ToLower();

        }
    }
}
