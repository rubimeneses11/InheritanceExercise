using System;
namespace Inheritance
{
    // Create a class Bird
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class
    public class Bird : Animal
    {
        public Bird()
        {
            IsAlive = true;
            NumberOfLegs = 2;
            CarnivoreOmnivoreHerbivore = "Omnivore";
            Age = 2;
        }
        public bool CanFly { get; set; }
        public int EggsInNest { get; set; }
        public string FeatherColor { get; set; }
        public string BeakColor { get; set; }
    }
}

