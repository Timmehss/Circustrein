using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircustreinLogic.Classes.Animals;
using LogicCircustrain.Classes.Animals;
using LogicCircustrain.Classes.Train;

namespace CircustreinLogic.Classes.Wagons
{
    public class Wagon
    {
        public List<Animal> Animals { get; set; }

        public int Capacity = 10;

        private int SMALL_SIZE_POINTS = 1;
        private int MEDIUM_SIZE_POINTS = 3;
        private int LARGE_SIZE_POINTS = 5;

        public Wagon() {  }

        public Wagon(List<Animal> animals)
        {
            ChangeWagonCapacity(animals);
            //CheckAnimalCompatibility();
            AddAnimalsToWagon(animals);              
        }

        public Wagon(Animal animal)
        {
            this.Animals.Add(animal); 
        }


        //TODO: Controleren op capacity 
        public void ChangeWagonCapacity(List<Animal> Animals)
        {
            foreach (Animal animal in Animals)
            {
                while (Capacity >= 0)
                {
                    if (animal.animalSize == AnimalSize.Small)
                    {
                        Capacity = Capacity - SMALL_SIZE_POINTS;
                    }
                    if (animal.animalSize == AnimalSize.Medium)
                    {
                        Capacity = Capacity - MEDIUM_SIZE_POINTS;
                    }
                    if (animal.animalSize == AnimalSize.Large)
                    {
                        Capacity = Capacity - LARGE_SIZE_POINTS;
                    }
                    Animals.Add(animal);
                }
            }
        }

        //TODO: Steeds controleren per dier of die nog in de wagon past en of het dier niet word opgegeten (geen lijst meegeven).
        public void AddAnimalsToWagon(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                if (Capacity - (int)AnimalSize.Small > 0 || Capacity - (int)AnimalSize.Medium > 0 || Capacity - (int)AnimalSize.Large > 0)
                {
                    Animals.Add(animal);
                }
                if (Capacity < 10)
                {
                    new Wagon(animal);
                }
            }
        }

        public void CheckAnimalCompatibility(List<Animal> animals)
        {

        }

        //public void ShowAllWagonsAndAnimals()
        //{
        //    int i = 0;
        //    foreach (Wagon wagon in Wagons)
        //    {
        //        i++;
        //        Console.WriteLine($"Wagon ({i})");
        //        foreach (Animal animal in Animals)
        //        {
        //            Console.WriteLine($"{animal.animalType} ({animal.animalSize})");
        //        }
        //    }
        //}
    }
}
