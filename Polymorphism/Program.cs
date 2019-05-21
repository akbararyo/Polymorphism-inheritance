using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Speak();

            Cat cat = new Cat();
            animal = cat;
            //cat.Speak();
            animal.Speak();

            Chicken chicken = new Chicken();
            chicken.Speak();

            Dog dog = new Dog();
            dog.Speak();

            Console.ReadKey();
        }

    }
    
}
