using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Bear : Mammal
    {
        
        public virtual void Hibernate()
        {
            Console.WriteLine($"{Identity} settles down to hibernate for the winter.");
        }
    }
}
