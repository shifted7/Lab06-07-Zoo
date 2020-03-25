using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Cat : Mammal
    {
        virtual public void Pounce(string targetId)
        {
            Console.WriteLine($"{Identity} pounces at {targetId}");
        }
    }
}
