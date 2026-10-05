using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exercises
{
   public class Cat
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public string OwnerName { get; set; }
        public GenderType Gender { get; set; }
        public bool IsVaccinated { get; set; }
        public bool IsTrained { get; set; }
        public bool PreviousIllness { get; set; }
        public string OwnerPhoneNumber { get; set; }

        public string Scratch()
        {
            return "The cat is scratching.";
        }
        public string Eat()
        {
            return "The cat is eating.";
        }
        public string GetSick()
        {
            return "The cat is sick.";
        }

    }
}
