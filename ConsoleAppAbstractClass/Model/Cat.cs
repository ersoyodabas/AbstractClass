using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbstractClass.Model
{
    class Cat :AAnimal
    {
        public override int Id { get; set; }
        public override int Name { get; set; }

        public override void Voice()
        {
            Console.WriteLine("miyav");
        }
    }
}
