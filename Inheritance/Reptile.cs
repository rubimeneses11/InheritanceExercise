using System;
namespace Inheritance
{
    // Create a class Reptile
    // give this class 4 members that are specific to Reptile
    // Set this class to inherit from your Animal Class
    public class Reptile : Animal
    {
        public Reptile()
        {
            IsAlive = true;
            NumberOfLegs = 4;
            CarnivoreOmnivoreHerbivore = "Carnivore";
            Age = 0;
        }
        public string ScaleColor { get; set; }
        public bool CanSwim { get; set; }
        public bool IsColdBlooded { get; set; }
        public string Habitat { get; set; }
    }
}

