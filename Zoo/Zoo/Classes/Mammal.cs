using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Mammal: Animal
    {
        public abstract string FurColor { get; set; }
        virtual public void Bite(string target)
        {
            Console.WriteLine($"{Identity} bites {target}");
        }
    }
}
