using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Templates;

namespace Zoo.Classes
{
    public abstract class Cat : Mammal, IHunt
    {
        public string Prey { get => Diet; }
        virtual public void Pounce(string targetId)
        {
            Console.WriteLine($"{Identity} pounces at {targetId}");
        }
        public bool SmellForPrey()
        {
            return false;
        }
        public bool CatchPrey()
        {
            return false;
        }
    }
}
