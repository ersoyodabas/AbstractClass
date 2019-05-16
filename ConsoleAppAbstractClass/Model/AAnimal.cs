using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbstractClass.Model
{
    public abstract class AAnimal
    {
        public abstract int Id { get; set; }
        public abstract int Name { get; set; }

        public abstract void Voice();
    }
}
