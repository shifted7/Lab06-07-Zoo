using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Tiger : Cat
    {
        public override string Identity { get; set; }
        public override string Sex { get; set; }
        public override string Diet { get; set; } = "Carnivore";
        public override string Habitat { get; set; } = "Jungle";
        public override string FurColor { get; set; } = "Orange and black stripes";
        public Tiger(string identity, string sex)
        {
            Identity = identity;
            Sex = sex;
        }

        public override void Speak()
        {
            Console.WriteLine("Grrr...RAWR!");
        }
    }
}
