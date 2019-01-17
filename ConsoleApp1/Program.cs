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
            Console.WriteLine("I am thinking of a number between 0 and 100. What is it?");
            Random rnd = new Random();
            int x = rnd.Next(0, 100);
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
