using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlPattern
{
    /*Описание: Этот паттерн позволяет создавать новые объекты, копируя уже существующие. 
        Это особенно полезно, когда создание экземпляра объекта занимает много времени или ресурсов.
      Где использовать: Лучше всего использовать, когда у вас есть множество объектов с похожими свойствами, 
        и вы хотите избежать затрат на их создание. Например, если у вас есть сложный объект, который нужно 
        часто копировать, этот паттерн поможет упростить задачу.*/
    public abstract class Prototype
    {
        public int Id { get; set; }

        public Prototype(int id)
        {
            Id = id;
        }

        public abstract Prototype Clone(); // Метод для клонирования
    }

    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(int id) : base(id) { }

        public override Prototype Clone()
        {
            return new ConcretePrototype1(Id); // Клонирование объекта
        }
    }

    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(int id) : base(id) { }

        public override Prototype Clone()
        {
            return new ConcretePrototype2(Id); // Клонирование объекта
        }
    }

    public class Client
    {
        public void Operation()
        {
            ConcretePrototype1 prototype1 = new ConcretePrototype1(1);
            ConcretePrototype1 clone1 = (ConcretePrototype1)prototype1.Clone();

            Console.WriteLine($"Original ID: {prototype1.Id}, Cloned ID: {clone1.Id}");
        }
    }
}
