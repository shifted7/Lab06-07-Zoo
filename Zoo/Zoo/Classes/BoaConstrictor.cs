using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class BoaConstrictor : Snake
    {
        public override string Identity { get; set; }
        public override string Sex { get; set; }
        public override string Diet { get; set; } = "Carnivore, small and medium-sized mammals";
        public override string Habitat { get; set; } = "Jungle";
        public override string ScalePattern { get; set; } = "Brown, gray, or cream base color with brown or reddish-brown saddle patterns";
        public BoaConstrictor(string identity, string sex)
        {
            Identity = identity;
            Sex = sex;
        }

        public override void Speak()
        {
            Console.WriteLine("HSSSSSSSSSSSSsssss");
        }
        public override void Slither()
        {
            Console.WriteLine($"{Identity} slithers across the ground.");
        }
    }
}
