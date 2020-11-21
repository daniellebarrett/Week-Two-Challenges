using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_Two_Challenges
{
    public class Greeter
    {
        public string HelloMethod(string name)
        {
            return "hello " + name;
        }

        public string FarewellMethod(string name)
        {
            return "farewell " + name;
        }

        public void TimedMethod()
        {
            DateTime currentTime = new DateTime();
            currentTime = DateTime.Now;

            if (currentTime.Hour < 12 && currentTime.Hour > 4)
            {
                Console.WriteLine("Good Morning!");
            }

            else if (currentTime.Hour > 12 && currentTime.Hour < 15)
            {
                Console.WriteLine("Good Afternoon!");
            }
            else if (currentTime.Hour > 15 && currentTime.Hour < 20)
            {
                Console.WriteLine("Good Evening!");
            }
            else if (currentTime.Hour > 20 && currentTime.Hour < 4)
            {
                Console.WriteLine("Good Night!");
            }

        }
    }
}
