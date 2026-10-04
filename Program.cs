using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Körkort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Whats your name?");
            string name = Console.ReadLine();

            Console.WriteLine("How old are you!");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("I need to check if you have a valid liecens! (true/false)");
            bool Liecens = bool.Parse(Console.ReadLine());

            if (age >= 18 && Liecens)
            {
                Console.WriteLine("You have a valid liecens!");
            }
           
            else if (age < 18)
            {
                Console.WriteLine("You have a unvalid liecens");
            }

            else
            {
                Console.WriteLine("I need to verify your liecens!");
            }
        }
    }
}
