using System;

namespace OOP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Версія 2: Використання Інтерфейсів ===\n");

            // Створюємо окремі об'єкти
            Fruits myApple = new Fruits("Яблуко", 8, 120, 52, 30, 25.50, "Гала", "Україна", 3);
            Vegetables myTomato = new Vegetables("Помідор", 5, 90, 18, 65, 40.00, "Черрі", "Іспанія", 2);

            // ГОЛОВНА ФІШКА ВЕРСІЇ 2: 
            // Створюємо масив типу ІНТЕРФЕЙСУ IPlant
            IPlant[] plantBasket = new IPlant[]
            {
                myApple,
                myTomato
            };

            Console.WriteLine("--- Демонстрація доступу через посилання на інтерфейс ---");

            // Перебираємо масив. Програма сама визначає, метод якого класу викликати.
            foreach (IPlant item in plantBasket)
            {
                item.PrintInfo();
                Console.WriteLine("--------------------------------------------------");
            }

            Console.ReadLine();
        }
    }
}