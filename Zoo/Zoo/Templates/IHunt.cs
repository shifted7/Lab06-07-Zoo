using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Templates
{
    interface IHunt
    {
        string Prey { get; }
        bool SmellForPrey() { throw new NotImplementedException("SmellForPrey method not correctly implemented."); }
        bool CatchPrey() { throw new NotImplementedException("CatchPrey method not correctly implemented."); }
    }
}
