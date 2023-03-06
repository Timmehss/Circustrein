using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircustreinLogic.Classes.Animals;
using LogicCircustrain.Classes.Animals;

namespace CircustreinLogic.Classes.Animals
{
    public abstract class Animal
    {
        public AnimalType animalType { get; set; }
        public AnimalSize animalSize { get; set; }

        public Animal() { } 

        public Animal(string newAnimalSize)
        {
            SetAnimalTypeAndSize(newAnimalSize);
        }

        public abstract bool CanEat(List<Animal> animals);

        public void SetAnimalTypeAndSize(string newAnimalSize)
        {
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
    }
}
