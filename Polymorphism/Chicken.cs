using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Chicken : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Chicken says: halo saya ayam");
        }
    }
}
