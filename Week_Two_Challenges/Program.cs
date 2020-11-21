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
            Greeter greeter = new Greeter();
            string person = greeter.HelloMethod("betty");
            Console.WriteLine(person);

            string person2 = greeter.FarewellMethod("john");
            Console.WriteLine(person2);

            Console.ReadLine();

            /*string name = Console.ReadLine();
            greeter.HelloMethod(name);
            greeter.FarewellMethod(name);
            greeter.TimedMethod();
            Console.ReadLine();*/
        }


    }



}
