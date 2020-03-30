using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Templates;

namespace Zoo.Classes
{
    public class PolarBear : Bear, IHunt
    {
        public override string Identity { get; set; }
        public override string Sex { get; set; }
        public override string Diet { get; set; } = "Carnivore, medium-sized mammals";
        public override string Habitat { get; set; } = "Arctic";
        public override string FurColor { get; set; } = "White";
        public string Prey { get => Diet; }
        public PolarBear(string identity, string sex)
        {
            Identity = identity;
            Sex = sex;
        }
        public override void Speak()
        {
            Console.WriteLine("RAhr RAhr");
        }
        
        public bool SmellForPrey()
        {
            return false;
        }
        public bool CatchPrey()
        {
            return false;
        }


    }
}
