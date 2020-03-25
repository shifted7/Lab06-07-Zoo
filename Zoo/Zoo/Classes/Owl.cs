using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Owl : Bird
    {
        override public bool Nocturnal { get; set; } = true;

    }
}
