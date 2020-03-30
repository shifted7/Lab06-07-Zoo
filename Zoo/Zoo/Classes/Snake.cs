using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Templates;

namespace Zoo.Classes
{
    public abstract class Snake : Reptile, IHunt
    {
        public string Prey { get => Diet; }
        public abstract void Slither();
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
