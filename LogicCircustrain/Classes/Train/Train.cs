using CircustreinLogic.Classes.Animals;
using CircustreinLogic.Classes.Wagons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicCircustrain.Classes.Train
{
    public class Train
    {
        private List<Wagon> wagons = new List<Wagon>();

        public Train() { }

        //TODO: List van dieren meegeven aan de constructor. 
        //TODO: Start algorithme.
        //TODO: Hier gaan controleren of de wagon vol zit, zo ja nieuwe wagon toevoegen.
        public Train(List<Animal> animals) 
        {
            wagons.Add(new Wagon(animals)); 
        }

        //public void ShowAllWagonsAndAnimals()
        //{
        //    int i = 0;
        //    foreach (Wagon wagon in wagons)
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
