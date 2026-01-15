using System;
using System.Collections.Generic;
using System.Text;

namespace POOsuite
{
    internal class Enclos
    {
        //Attributs
        private string name;
        private int capacity;
        private List<Animal> animals;
    

        //Proprietes
        public string Name { get { return name; } set { name = value; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }
        public List<Animal> Animals { get { return animals; } set { animals = value; } }
        //Constructeur
        public Enclos(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
            this.animals = new List<Animal>();
        }
        //Methodes
        public bool AddAnimal(Animal animal)
        {
            if (animals.Count < capacity)
            {
                animals.Add(animal);
                Console.WriteLine($"{animal.Name} a été ajouté à l'enclos {name}.");
                return true;
            }
            else
            {
                Console.WriteLine($"L'enclos {name} est plein. Impossible d'ajouter {animal.Name}.");
                return false;
            }
        }
        public bool RemoveAnimal(Animal animal)
        {
            if (animals.Remove(animal))
            {
                Console.WriteLine($"{animal.Name} a été retiré de l'enclos {name}.");
                return true;
            }
            else
            {
                Console.WriteLine($"{animal.Name} n'est pas dans l'enclos {name}.");
                return false;
            }
        }
        public void GetAnimalList()
        {
            Console.WriteLine($"Animaux dans l'enclos {name} :");
            foreach (var animal in animals)
            {
                Console.WriteLine($"- {animal.Name} ({animal.Species}), Énergie : {animal.Energy}");
            }
        }
        public void PrintEnclosureStatus()
        {
            Console.WriteLine($"Enclos: {name}, Capacité: {capacity}, Nombre d'animaux: {animals.Count}");
    }
}
}
