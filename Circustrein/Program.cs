using CircustreinLogic.Classes.Animals;
using CircustreinLogic.Classes;
using CircustreinLogic.Classes.Wagons;
using LogicCircustrain.Classes.Train;
using LogicCircustrain.Classes.Animals.Species;

//TODO: Class diagram (foto) toepassen op mijn eigen classen structuur.
//TODO: Abstracte klassen toepassen op carnivore en herbivore. WouldEat methode maken om te controleren en deze
//in de carnivore klassen overriden.

Train train = new Train();
List<Animal> Animals = new List<Animal>();

Functions functions = new Functions();

string? newAnimalType = null;
string? newAnimalSize = null;
string response;

bool proceed = false;
bool continueAdding = false;

while (proceed == false)
{
    Console.WriteLine("To place an animal in a wagon choose it's species (Carnivore of Herbivore)");
    newAnimalType = Console.ReadLine();

    Console.WriteLine("Choose a size (Small, Medium, Large)");
    newAnimalSize = Console.ReadLine();

    Console.WriteLine($"You want to add a {newAnimalType} with a size of {newAnimalSize}? (Yes / Restart)");
    response = Console.ReadLine();

    proceed = functions.ProceedAdding(response);
}

if (proceed == true)
{
    if (newAnimalType == "carnivore")
    {
        Animals.Add(new Carnivore(newAnimalSize));
    }
    if (newAnimalType == "herbivore")
    {
        Animals.Add(new Herbivore(newAnimalSize));
    }

    Console.WriteLine("Would you like to add another animal? (Yes / No)");

    response = Console.ReadLine();

    if (response.ToLower() == "yes")
    {
        continueAdding = true;

        while (continueAdding == true)
        {
            Console.WriteLine("To add another animal in a wagon choose it's species (Carnivore of Herbivore)");
            newAnimalType = Console.ReadLine();

            Console.WriteLine("Choose a size (Small, Medium, Large)");
            newAnimalSize = Console.ReadLine();

            Console.WriteLine($"You want to add a {newAnimalType} with a size of {newAnimalSize}? (Yes / Restart)");
            response = Console.ReadLine();

            if (response.ToLower() == "yes")
            {
                if (newAnimalType == "carnivore")
                {
                    Animals.Add(new Carnivore(newAnimalSize));
                }
                if (newAnimalType == "herbivore")
                {
                    Animals.Add(new Herbivore(newAnimalSize));
                }                

                Console.WriteLine("Would you like to add another animal? (Yes / No)");
                response = Console.ReadLine();

                if (response.ToLower() == "no")
                {
                    continueAdding = false;
                }
            }

            if (response.ToLower() == "restart")
            {
                continueAdding = false;
                proceed = false;
            }
        }
    }
    if (response.ToLower() == "no")
    {
        continueAdding = false;

        Console.WriteLine("Would you like to see a list of all the animals that you have added to the list? (Yes / No)");
        response = Console.ReadLine();

        if (response.ToLower() == "yes")
        {
            functions.ShowAllAnimalsInList(Animals);         
        }

        Console.WriteLine("Would you like to create a train with wagons and add the animals? (Yes / No)");
        response = Console.ReadLine();

        if (response.ToLower() == "yes")
        {
            new Train(Animals);           
        }
        if (response.ToLower() == "no")
        {
            Environment.Exit(1);
        }

        Console.WriteLine("Here are you wagon(s) and the animals inside of them:");
        train.ShowAllWagonsAndAnimals();
    }
}