using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Templates
{
    interface IFly
    {
        int TopFlySpeed { get; set; }
        int TakeOff();
        bool Land();
    }
}
