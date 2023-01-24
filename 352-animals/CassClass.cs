/*
Topic: The class for cassowarys.
Date: 01/24/2023
Name: Tiffany Decker
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _352_animals
{
    class Cassowary : Animal
    {
        public Cassowary(string newName, int newAge, double newWeight) : base(newName, newAge, "Scree", newWeight) { }
        public override void printInfo()
        {
            Console.WriteLine($"{Name} is a cassowary who is {Age} years old and weighs {Weight} lbs.");
        }
        public override void makeNoise()
        {
            Console.WriteLine(Noise);
        }
        public override void ageUp()
        {
            Age++;
            Console.WriteLine($"New age of {Name} is {Age}");
            //Learned string interpolation from https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/string-interpolation
        }

    }
}

