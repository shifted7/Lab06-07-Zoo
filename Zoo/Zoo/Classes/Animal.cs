using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Animal
    {
        public abstract string Identity { get; set; }
        public abstract string Sex { get; set; }
        public virtual string Habitat { get; set; } = "None";
        public virtual string Diet { get; set; } = "Any";
        public virtual bool Nocturnal { get; set; } = false;
        public virtual bool ColdBlooded { get; set; } = false;

        abstract public void Speak();

        virtual public void Rest()
        {
            Console.WriteLine($"{Identity} falls asleep.");
        }
    }
}
