﻿using CircustreinLogic.Classes.Animals;
using CircustreinLogic.Classes;
using CircustreinLogic.Classes.Wagons;
using LogicCircustrain.Classes.Train;

List<Train> trains= new List<Train>();
List<Wagon> wagons = new List<Wagon>();
List<Animal> Animals = new List<Animal>();

Functions functions = new Functions();
Train train = new Train();
Wagon wagon = new Wagon();
Animal animal = new Animal();

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
    Animals.Add(new Animal(newAnimalType, newAnimalSize));

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
                Animals.Add(new Animal(newAnimalType, newAnimalSize));

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
            animal.ShowAllAnimalsInList(Animals);            
        }
        //TODO: create a train and not wagons
        Console.WriteLine("Would you like to create a train with wagons and add the animals? (Yes / No)");
        response = Console.ReadLine();

        if (response.ToLower() == "yes")
        {
            //Trein aanmaken en de wagon met de bijbehorende dieren erin stoppen.
            new Train(Animals);
            

        }
        if (response.ToLower() == "no")
        {
            Environment.Exit(1);
        }

        Console.WriteLine("Here are you wagon(s) and the animals inside of them:");
        //wagon.ShowAllWagonsAndAnimals();
    }
}