using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlPattern
{
    /*Описание: Этот паттерн определяет интерфейс для создания объектов, но позволяет подклассам решать, 
      какой конкретный объект создавать. Это дает гибкость в создании различных типов объектов.
        Где использовать: Он идеально подходит, когда у вас есть несколько классов, которые реализуют один и тот же интерфейс, 
      и вы не хотите жестко связывать код с конкретными классами. Например, если у вас есть разные типы автомобилей, 
      и вы хотите, чтобы код мог создавать их без знания конкретного типа.*/

    public abstract class Product
    {
        public abstract void Use(); // Метод, который будет реализован в конкретных продуктах
    }

    public class ConcreteProductA : Product
    {
        public override void Use()
        {
            Console.WriteLine("Используется продукт A");
        }
    }

    public class ConcreteProductB : Product
    {
        public override void Use()
        {
            Console.WriteLine("Используется продукт B");
        }
    }

    public abstract class Creator
    {
        public abstract Product FactoryMethod(); // Метод для создания продукта
    }

    public class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA(); // Создание конкретного продукта A
        }
    }

    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB(); // Создание конкретного продукта B
        }
    }
}
