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
        public Train(List<Animal> animals) 
        {
            wagons.Add(new Wagon(animals)); 
        }
    }
}
