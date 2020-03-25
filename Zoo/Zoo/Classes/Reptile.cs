using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Reptile: Animal
    {
        abstract public string ScaleColor { get; set; }
        public override bool ColdBlooded { get; set; } = true;
    }
}
