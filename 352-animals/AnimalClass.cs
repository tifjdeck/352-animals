/*
Topic: The abstract class for animals.
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
    abstract class Animal
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private string noise;
        public string Noise
        {
            get { return noise; }
            set { noise = value; }
        }
        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        //Learned to use properties from www.w3schools.com/cs/cs_properties.php

        protected Animal(string newName, int newAge, string newNoise, double newWeight)
        {
            name = newName;
            age = newAge;
            noise = newNoise;
            weight = newWeight;
        }

        public abstract void printInfo();
        // prints the info for the animal of choice
        public abstract void makeNoise();
        // prints the noise for the animal of choice
        public abstract void ageUp();
        // performs the action of adding one to the animal of choice's age
    }

}
