using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Тестирование паттерна Prototype
            Console.WriteLine("Тестирование паттерна Prototype:");
            Client client = new Client();
            client.Operation();
            Console.WriteLine();

            // Тестирование паттерна Factory Method
            Console.WriteLine("Тестирование паттерна Factory Method:");
            Creator creatorA = new ConcreteCreatorA();
            Product productA = creatorA.FactoryMethod();
            productA.Use();

            Creator creatorB = new ConcreteCreatorB();
            Product productB = creatorB.FactoryMethod();
            productB.Use();
            Console.WriteLine();

            // Тестирование паттерна Singleton
            Console.WriteLine("Тестирование паттерна Singleton:");
            Singleton singleton = Singleton.Instance;
            singleton.DoSomething();
        }
    }
}
