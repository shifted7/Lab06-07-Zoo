﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class BaldEagle : Eagle
    {
        public override string Identity { get; set; }
        public override string Sex { get; set; }
        public override string Diet { get; set; } = "Carnivore, fish";
        public override string Habitat { get; set; } = "Mountains near bodies of water";
        public override string FeatherPattern { get; set; } = "White head with dark brown body";
        public BaldEagle(string identity, string sex)
        {
            Identity = identity;
            Sex = sex;
        }

        public override void Speak()
        {
            Console.WriteLine("EEE ee E eeee");
        }
    }
}
