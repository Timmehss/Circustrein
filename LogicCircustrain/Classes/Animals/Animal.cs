using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircustreinLogic.Classes.Animals;
using LogicCircustrain.Classes.Animals;

namespace CircustreinLogic.Classes.Animals
{
    public class Animal
    {
        public AnimalType animalType { get; set; }
        public AnimalSize animalSize { get; set; }

        public Animal() { } 

        public Animal(string newAnimalType, string newAnimalSize)
        {
            SetAnimalTypeAndSize(newAnimalType, newAnimalSize);
        }

        public void SetAnimalTypeAndSize(string newAnimalType, string newAnimalSize)
        {
            //Set the species of the animal
            if (newAnimalType.ToLower() == "carnivore")
            {
                this.animalType = AnimalType.Carnivore;
            }
            if (newAnimalType.ToLower() == "herbivore")
            {
                this.animalType = AnimalType.Herbivore;
            }

            //Set the size of the animal
            if (newAnimalSize.ToLower() == "small")
            {
                this.animalSize = AnimalSize.Small;
            }
            if (newAnimalSize.ToLower() == "medium")
            {
                this.animalSize = AnimalSize.Medium;
            }
            if (newAnimalSize.ToLower() == "large")
            {
                this.animalSize = AnimalSize.Large;
            }
        }

        public void ShowAllAnimalsInList(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{animal.animalType} ({animal.animalSize})");
            }
        }
    }
}
