using System;
namespace Inheritance
{
    // Create a class Animal
    public class Animal
    {
        public Animal()
        {
        }
        // give this class 4 members that all Animals have in common
        public int NumberOfLegs { get; set; }
        public string CarnivoreOmnivoreHerbivore { get; set; }
        public bool IsAlive { get; set; }
        public int Age { get; set; }
    }
}

