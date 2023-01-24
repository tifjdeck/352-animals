/*
Topic: The class for the many animals in the object of the world.
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
    class World
    {
        List<Animal> AnimalList = new List<Animal>();
        // How to use Lists: https://www.c-sharpcorner.com/article/c-sharp-list/ 

        public void Main()
        {
            int MenuInput = 0;
            while (MenuInput != 5)
            {
                Console.WriteLine("Select an option for the world of animals:");
                Console.WriteLine("1.) Add animal.");
                Console.WriteLine("2.) Print Info.");
                Console.WriteLine("3.) Make Noise.");
                Console.WriteLine("4.) Age Up.");
                Console.WriteLine("5.) Exit.");
                MenuInput = Convert.ToInt32(Console.ReadLine());
                if (MenuInput == 1)
                {
                    string tempName = "";
                    int tempAge = 0;
                    double tempWeight = 0.0;
                    Console.WriteLine("Please enter the animal's name: ");
                    tempName = Console.ReadLine();
                    Console.WriteLine("Please enter the animal's age: ");
                    tempAge = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the animal's weight: ");
                    tempWeight = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("What type of animal is it?");
                    Console.WriteLine("1.) Cat");
                    Console.WriteLine("2.) Dog");
                    Console.WriteLine("3.) Cassowary");
                    int tempInput = Convert.ToInt32(Console.ReadLine());
                    if (tempInput == 1)
                    {
                        Cat tempCat = new Cat(tempName, tempAge, tempWeight);
                        AnimalList.Add(tempCat);
                    }
                    else if (tempInput == 2)
                    {
                        Dog tempDog = new Dog(tempName, tempAge, tempWeight);
                        AnimalList.Add(tempDog);
                    }
                    else if (tempInput == 3)
                    {
                        Cassowary tempCass = new Cassowary(tempName, tempAge, tempWeight);
                        AnimalList.Add(tempCass);
                    }
                    else {
                        Console.WriteLine("Invalid Input.");
                    }
                }
                else if (MenuInput == 2)
                {
                    Console.WriteLine("Please select an animal:");
                    for (int i = 0; i < AnimalList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}.) {AnimalList[i].Name}");
                    }
                    int AnimalInput = Convert.ToInt32(Console.ReadLine());
                    AnimalList[AnimalInput - 1].printInfo();
                }
                else if (MenuInput == 3)
                {
                    Console.WriteLine("Please select an animal:");
                    for (int i = 0; i < AnimalList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}.) {AnimalList[i].Name}");
                    }
                    int AnimalInput = Convert.ToInt32(Console.ReadLine());
                    AnimalList[AnimalInput - 1].makeNoise();
                }
                else if (MenuInput == 4)
                {
                    Console.WriteLine("Please select an animal:");
                    for (int i = 0; i < AnimalList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}.) {AnimalList[i].Name}");
                    }
                    int AnimalInput = Convert.ToInt32(Console.ReadLine());
                    AnimalList[AnimalInput - 1].ageUp();
                }
                else if (MenuInput == 5)
                {
                    Console.WriteLine("Goodbye!");
                }
                else {
                    Console.WriteLine("Invalid value.");
                }
            }
        }
        
    }
}
