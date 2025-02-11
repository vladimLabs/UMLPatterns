using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlPattern
{
    /*Описание: Паттерн Singleton гарантирует, что у вас есть только один экземпляр класса и предоставляет к нему 
     глобальную точку доступа.Это удобно, когда нужно управлять общими ресурсами.
        Где использовать: Этот паттерн лучше всего подходит, когда вам нужен единственный экземпляр класса, например, 
     для доступа к настройкам приложения или к базе данных.Он помогает избежать создания нескольких экземпляров одного 
     и того же объекта, что может привести к путанице.*/

    public class Singleton
    {
        private static Singleton _instance;

        // Приватный конструктор
        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton(); // Создание экземпляра, если он не существует
                }
                return _instance;
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("Метод Singleton выполнен.");
        }
    }
}
