using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircustreinLogic.Classes.Animals;
using CircustreinLogic.Classes.Wagons;

namespace CircustreinLogic.Classes
{
    public class Functions
    {
        public bool ProceedAdding(string response)
        {
            if (response.ToLower() == "continue")
            {
                return true;
            }
            if (response.ToLower() == "restart")
            {
                return false;
            }

            Console.WriteLine("Dat is geen geldig antwoord!");
            return false;
        }
    }
}
