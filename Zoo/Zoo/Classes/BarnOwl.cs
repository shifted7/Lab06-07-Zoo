using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class BarnOwl : Owl
    {
        public override string Identity { get; set; }
        public override string Sex { get; set; }
        public override string Diet { get; set; } = "Carnivore, small mammals";
        public override string Habitat { get; set; } = "Forest";
        public override string FeatherPattern { get; set; } = "White, heart-shaped face with mottled brown ";
        public BarnOwl(string identity, string sex)
        {
            Identity = identity;
            Sex = sex;
        }

        public override void Speak()
        {
            Console.WriteLine("EEEEEEEK");
        }
    }
}
