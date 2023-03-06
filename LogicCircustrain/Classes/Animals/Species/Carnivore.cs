using CircustreinLogic.Classes.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCircustrain.Classes.Animals.Species
{
    public class Carnivore : Animal
    {
        public Carnivore(string newAnimalSize): base(newAnimalSize) {
            animalType = AnimalType.Carnivore;            
        }
        public override bool CanEat(List<Animal> animals)
        {
            return true;
        }
    }
}
