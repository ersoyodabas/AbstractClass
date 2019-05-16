using ConsoleAppAbstractClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog a = new Dog();
            a.Voice();

            Cat b = new Cat();
            b.Voice();

            Bird c = new Bird();
            c.Voice();

            Console.ReadLine();

        }
    }
}
