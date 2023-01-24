/*
Topic: The main file for the program.
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
    class Program
    {
        static void Main(string[] args)
        {
            World Earth = new World();
            Earth.Main();
            Console.ReadKey();
        }
    }
}
