using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes
            //Create an object of your Bird class
            //give values to your members using the object of your Bird class 
            //Creatively display the class member values

            var Parrot = new Bird();
            Parrot.EggsInNest = 2;
            Parrot.BeakColor = "black";
            Parrot.CanFly = true;
            Parrot.FeatherColor = "blue";

            //Create an object of your Reptile class
            //give values to your members using the object of your Reptile class
            //Creatively display the class member values

            var Snake = new Reptile();
            Snake.CanSwim = true;
            Snake.ScaleColor = "red";
            Snake.IsColdBlooded = true;
            Snake.Habitat = "burrow";

            //creating a collection
            var myAnimals = new List<Animal> { Parrot, Snake };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Age: {animal.Age}");
                Console.WriteLine($"Number of Legs: {animal.NumberOfLegs}");
                Console.WriteLine($"Diet: {animal.CarnivoreOmnivoreHerbivore}");
                Console.WriteLine($"Is Alive: {animal.IsAlive}");
                Console.WriteLine();
            }
        }
    }
}
