using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Приятно познакомиться, " + name + "!");
            //string age = Console.ReadLine();
            //Console.WriteLine("How old are you?");
            //string age = Console.ReadLine();

            Console.ReadLine();
        }
    }
}
