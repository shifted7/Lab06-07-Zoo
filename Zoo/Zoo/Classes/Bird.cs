using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Bird : Animal
    {
        abstract public string FeatherPattern { get; set; }
    }
}
