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
        private List<Wagon> Wagons = new List<Wagon>();

        public Train() { }

        //Eerste wagon word toegevoegd aan de wagons lijst, de tweede die word aangemaakt als de eerste vol zit...
        //Word nog niet toegevoegd aan de lijst.
        public Train(List<Animal> animals) 
        {
            Wagons.Add(new Wagon(animals)); 
        }

        public void AddWagonsToTrain(List<Wagon> wagons)
        {

        }

        public void ShowAllWagonsAndAnimals()
        {
            int i = 0;
            foreach (Wagon wagon in Wagons)
            {
                i++;
                Console.WriteLine($"Wagon ({i})");
                //foreach (Animal animal in Animals)
                //{
                //    Console.WriteLine($"{animal.animalType} ({animal.animalSize})");
                //}
            }
        }
    }
}
