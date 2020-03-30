using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Bird : Animal
    {
        virtual public bool CanFly { get; set; } = true;
        abstract public string FeatherPattern { get; set; }
        
    }
}
