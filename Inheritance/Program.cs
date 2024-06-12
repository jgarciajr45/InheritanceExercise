using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird parrot = new Bird
            {
                Name = "Parrot",
                Age = 2,
                Weight = 1.5,
                Habitat = "Tropical Rainforest",
                WingSpan = 0.5,
                CanFly = true,
                BeakType = "Curved",
                FeatherColor = "Green"
            };
            Console.WriteLine("Bird Info:");
            Console.WriteLine($"Name: {parrot.Name}");
            Console.WriteLine($"Age: {parrot.Age}");
            Console.WriteLine($"Weight: {parrot.Weight} kg");
            Console.WriteLine($"Habitat: {parrot.Habitat}");
            Console.WriteLine($"Wing Span: {parrot.WingSpan} meters");
            Console.WriteLine($"Can Fly: {parrot.CanFly}");
            Console.WriteLine($"Beak Type: {parrot.BeakType}");
            Console.WriteLine($"Feather Color: {parrot.FeatherColor}");
            Console.WriteLine();
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile snake = new Reptile
            {
                Name = "Snake",
                Age = 4,
                Weight = 2.3,
                Habitat = "Desert",
                IsVenomous = true,
                ScaleType = "Smooth AF",
                ReproductionMethod = "Eggs",
                Length = 1.2
            };
            Console.WriteLine("Reptile Info:");
            Console.WriteLine($"Name: {snake.Name}");
            Console.WriteLine($"Age: {snake.Age}");
            Console.WriteLine($"Weight: {snake.Weight} kg");
            Console.WriteLine($"Habitat: {snake.Habitat}");
            Console.WriteLine($"Is Venomous: {snake.IsVenomous}");
            Console.WriteLine($"Scale Type: {snake.ScaleType}");
            Console.WriteLine($"Reproduction Method: {snake.ReproductionMethod}");
            Console.WriteLine($"Length: {snake.Length} meters");
        }
    }
}
