using System;
using System.Collections;
using Zoo.Classes;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Animals = new ArrayList();
            
            // Instatiate animals from concrete classes
            PolarBear Branson = new PolarBear("Branson the Polar Bear", "Male");
            BarnOwl Otah = new BarnOwl("Otah the Barn Owl", "Female");
            Tiger Tiaga = new Tiger("Tiaga the Tiger", "Female");
            BaldEagle Glory = new BaldEagle("Glory the Bald Eagle", "Female");
            BoaConstrictor Balthazar = new BoaConstrictor("Balthazar the Boa Constrictor", "Male");
            
            // Add animals to list
            Animals.Add(Branson);
            Animals.Add(Otah);
            Animals.Add(Tiaga);
            Animals.Add(Glory);
            Animals.Add(Balthazar);

            foreach(Animal animal in Animals) // Have each animal identify itself and then speak
            {
                Console.WriteLine($"{animal.Identity}:");
                animal.Speak();
            }
        }
    }
}
