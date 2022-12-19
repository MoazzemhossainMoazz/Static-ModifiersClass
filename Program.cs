using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_ModifiersClass
{
    class Animal
    {
        public string name;
        public int age;
        public string voice;
        public static int animalCount = 0;

        public void printDetails()
        {
            Console.WriteLine("Name: " + name + ", " + "Age: " + age + ", Voice: " + voice);
        }

        public Animal(string _name, int _age, string _voice)
        {
            name = _name;
            age = _age;
            voice = _voice;
            animalCount++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal("Audi", 3, "Gheww");
            dog.printDetails();

            Animal cat = new Animal("Tom", 5, "Meww");
            cat.printDetails();

            Animal cow = new Animal("Mohesh", 6, "Hamba");
            cow.printDetails();
            Console.WriteLine("Number of animal: " + Animal.animalCount);
            Console.ReadLine();

        }
    }
}
