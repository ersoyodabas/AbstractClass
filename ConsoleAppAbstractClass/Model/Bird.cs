using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbstractClass.Model
{
    class Bird : AAnimal
    {

        public override int Id { get; set; }
        public override int Name { get; set; }


        public override void Voice()
        {
            Console.WriteLine("gag gagG");
        }
    }
}
