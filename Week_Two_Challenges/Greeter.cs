using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_Two_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name:");
        Greeter greeter = new Greeter();
            string name = Console.ReadLine();
            greeter.HelloMethod(name);
            greeter.FarewellMethod(name);
            greeter.TimedMethod();
            Console.ReadLine();
        }


    }

    public class Greeter
    {
        public void HelloMethod(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        public void FarewellMethod(string name)
        {
            Console.WriteLine($"Farewell {name}");
        }

        public void TimedMethod()
        {
            DateTime currentTime = new DateTime();
            currentTime = DateTime.Now;

            if (currentTime.Hour > 12 && currentTime.Hour > 4)
            {
                Console.WriteLine("Good morning!");
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
