﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Reptile: Animal
    {
        abstract public string ScalePattern { get; set; }
        public override bool ColdBlooded { get; set; } = true;
    }
}
