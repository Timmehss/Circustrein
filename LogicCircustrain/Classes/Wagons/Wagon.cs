﻿using System;
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
        public List<Animal> AnimalsInWagon = new List<Animal>();

        public int Capacity = 10;

        private int SMALL_SIZE_POINTS = 1;
        private int MEDIUM_SIZE_POINTS = 3;
        private int LARGE_SIZE_POINTS = 5;

        public Wagon() {  }

        public Wagon(List<Animal> Animals)
        {
            ChangeWagonCapacity(Animals);
            //CheckAnimalCompatibility();
            //AddAnimalsToWagon(animals);              
        }

        //public Wagon(List<Animal> Animals)
        //{
        //    ChangeWagonCapacity(Animals);
        //}

        //TODO: Controleren op capacity 
        public void ChangeWagonCapacity(List<Animal> Animals)
        {
            foreach (Animal animal in Animals)
            {
                int CapacityCheck = (int)(Capacity - animal.animalSize);

                if (CapacityCheck >= 0)
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
                    AnimalsInWagon.Add(animal);
                    //AnimalsInWagon.Remove(animal);
                }
                if (CapacityCheck < 0)
                {
                    foreach (Animal animal1 in AnimalsInWagon)
                    {
                        Animals.Remove(animal1);
                    }

                    new Wagon(Animals);
                }
            }
        }
    }
}
