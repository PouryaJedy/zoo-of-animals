//Pourya Jedy/ Computer engineering/ zoo-management-project
using System;
using System.Collections.Generic;
using System.Linq;


namespace AnimalsZoo
{
    //Parent Class
    public class Animal
    {
        public static int counter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string AnimalType { get; set; }
        public int Age { get; set; }

        public Animal(string name, string animalType, int age)
        {
            Id = ++counter;
            Name = name;
            AnimalType = animalType;
            Age = age;
        }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Age:{Age}, Animal-Type: {AnimalType}";
        }

        // Children Classes
        public class Bird : Animal
        {
            public bool CanFly { get; set; }
            public Bird(string name, string animalType, int age, bool canFly) : base(name, animalType, age)
            {
                CanFly = canFly;
            }
            public override string ToString()
            {
                return base.ToString() + $",Can Fly:{CanFly}";
            }
        }
        public class Snake : Animal
        {
            public bool IsToxic { get; set; }
            public Snake(string name, string animalType, int age, bool isToxic) : base(name, animalType, age)
            {
                IsToxic = isToxic;
            }
            public override string ToString()
            {
                return base.ToString() + $",Is Toxic : {IsToxic}";
            }
        }
        //Managing Zoo
        public class Zoo
        {
            public List<Animal> animals = new List<Animal>();
            public void AddAnimal(Animal animal)
            {
                animals.Add(animal);
            }
            public void RemoveAnimal(int id)
            {
                var animal = animals.FirstOrDefault(a => a.Id == id);
                if (animal != null)
                {
                    animals.Remove(animal);
                }
            }
            public Animal GetAnimal(int id)
            {
                return animals.FirstOrDefault(a => a.Id == id);
            }
            public List<Animal> GetAllAnimals()
            {
                return animals;
            }
            public void UpdateAnimal(int id, string newName, int newAge)
            {
                var animal = animals.FirstOrDefault(a => a.Id == id);
                if (animal != null)
                {
                    animal.Name = newName;
                    animal.Age = newAge;
                }
            }
        }




    }

}

