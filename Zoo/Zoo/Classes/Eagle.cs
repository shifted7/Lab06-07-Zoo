using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Templates;

namespace Zoo.Classes
{
    public abstract class Eagle : Bird, IHunt, IFly
    {
        public string Prey { get => Diet; }
        public bool SmellForPrey()
        {
            return false;
        }
        public bool CatchPrey()
        {
            return false;
        }

        public int TopFlySpeed { get; set; }
        public int TakeOff()
        {
            Console.WriteLine($"{Identity} flaps their wings and takes flight.");
            return TopFlySpeed;
        }
        public bool Land()
        {
            Console.WriteLine($"{Identity} lands.");
            return true;
        }
    }
}
