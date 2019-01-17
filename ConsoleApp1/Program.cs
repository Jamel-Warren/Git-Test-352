using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            

            Random rnd = new Random();
            Console.WriteLine("give me a Minimum number: ");
            string tempmin = Console.ReadLine();
            int min = Convert.ToInt32(tempmin);

            Console.WriteLine("give me a maximum number: ");
            string tempmax = Console.ReadLine();
            int max = Convert.ToInt32(tempmax);
            Console.WriteLine("I am thinking of a number between " + tempmin +" and " + tempmax +". What is it?");
            int x = rnd.Next(min, max);
            string y = Console.ReadLine();
            int z = Convert.ToInt32(y);
            while (x != z)
            {


                if (x > z)
                    Console.WriteLine("This is too LOW!");
                else
                    Console.WriteLine("This is too High!");
                y = Console.ReadLine();
                z = Convert.ToInt32(y);
            }
            Console.WriteLine("This is correct! :)");
            Console.ReadKey();
        }
    }
}
