//Pourya Jedy/ Computer engineering/ zoo-management-project
using AnimalsZoo;
using static AnimalsZoo.Animal;

Zoo zoo = new Zoo();
bool exit = false;
while (!exit)
{
    Console.WriteLine("1.Add new animal");
    Console.WriteLine("2.Watch list of all animals");
    Console.WriteLine("3.Watch details of an specific animal");
    Console.WriteLine("4.Edit information of an animal");
    Console.WriteLine("5.Remove an animal");
    Console.WriteLine("6.Exit");

    Console.WriteLine("Please enter your number :");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            AddAnimal(zoo);
            break;
        case 2:
            ViewAllAnimals(zoo);
            break ;
        case 3:
            ViewAnimalDetails(zoo);
            break;
        case 4:
            UpdateAnimal(zoo);
            break;
        case 5:
            RemoveAnimal(zoo);
            break;
        case 6:
            exit = true;
            break;
        default:
            Console.WriteLine("Invalid selection, please try again");
            break;
    }
}
static void AddAnimal(Zoo zoo)
{
    Console.WriteLine("Animal name :");
    string name = Console.ReadLine();
    Console.WriteLine("Animal type :");
    string animalType = Console.ReadLine();
    Console.WriteLine("Animal age :");
    int age = int.Parse(Console.ReadLine());

    if (animalType.ToLower() == "bird")
    {
        Console.WriteLine("Is animal able to fly?(true/false)");
        bool canFly = bool.Parse(Console.ReadLine());
        zoo.AddAnimal(new Bird(name, animalType, age, canFly));
    }
    else if (animalType.ToLower() == "snake")
    {
        Console.WriteLine("Is animal toxic?(true/false)");
        bool isToxic = bool.Parse(Console.ReadLine());
        zoo.AddAnimal(new Snake(name, animalType, age, isToxic));
    }
    else
    {
        zoo.AddAnimal(new Animal(name,animalType, age));
    }
    Console.WriteLine("Animal has been added successfully");
}
static void ViewAllAnimals(Zoo zoo)
{
    foreach (var animal in zoo.GetAllAnimals())
    {
        Console.WriteLine(animal);
    }
}
static void ViewAnimalDetails(Zoo zoo)
{
    Console.WriteLine("Animal's id:");
    int id = int.Parse(Console.ReadLine());
    var animal = zoo.GetAnimal(id);

    if(animal != null)
    {
        Console.WriteLine(animal);
    }
    else
    {
        Console.WriteLine(" An animal with this id wasn't found");
    }
}
static void UpdateAnimal(Zoo zoo)
{
    Console.WriteLine("Animal's id :");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("An animal's new name:");
    string newName = Console.ReadLine();
    Console.WriteLine("An animal's new age:");
    int newAge =int.Parse(Console.ReadLine());
    zoo.UpdateAnimal(id, newName, newAge);
    Console.WriteLine("Animal's Information has been updated successfully");
}
static void RemoveAnimal(Zoo zoo)
{
    Console.WriteLine("Animal's id:");
    int id = int.Parse(Console.ReadLine());
    zoo.RemoveAnimal(id);
    Console.WriteLine("Animal has been removed successfully.");
}