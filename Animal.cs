using System;
using System.Collections.Generic;
using System.Text;

namespace POOsuite
{
    internal class Animal
    {
        //Attributs
        private string name;
        private string species;
        private int energy;


        //Proprietes
        public string Name { get { return name; } set { name = value; } }
        public string Species { get { return species; } set { species = value; } }
        public int Energy { get { return energy; } set { energy = value; } }

        //Constructeur
        public Animal(string name, string species, int energy)
        {
            this.name = name;
            this.species = species;
            this.energy = energy;
        }

        //Methodes

        public void DisplayInfo()
        {
            Console.WriteLine($"Nom: {name}, Espèce: {species}, Énergie: {energy}");
        }
        public void Eat(int foodEnergy)
        {
            energy += foodEnergy;
            Console.WriteLine($"{name} a mangé et a gagné {foodEnergy} points d'énergie.");
        }

        public void Play(int playEnergy)
        {
            if (energy >= playEnergy)
            {
                energy -= playEnergy;
                Console.WriteLine($"{name} a joué et a perdu {playEnergy} points d'énergie.");
            }
            else
            {
                Console.WriteLine($"{name} n'a pas assez d'énergie pour jouer.");
            }
        }

    }
}






