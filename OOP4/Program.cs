using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Версія 1: Базове успадкування класів ===\n");

            // 1. Створення об'єкта класу Fruits
            Console.WriteLine("--- Демонстрація класу Fruits ---");
            Fruits myApple = new Fruits("Яблуко", 8, 120, 52, 30, 25.50, "Гала", "Україна", 3);
            Console.WriteLine($"Назва: {myApple.name}"); // Звертаємось до властивості базового класу
            myApple.PrintInfo();                         // Викликаємо метод похідного класу

            // 2. Створення об'єкта класу Vegetables
            Console.WriteLine("\n--- Демонстрація класу Vegetables ---");
            Vegetables myTomato = new Vegetables("Помідор", 5, 90, 18, 65, 40.00, "Черрі", "Іспанія", 2);
            Console.WriteLine($"Назва: {myTomato.name}");
            myTomato.PrintInfo();

            // 3. Робота з масивом овочів (базовий перебір, без інтерфейсу IEnumerable)
            Console.WriteLine("\n--- Робота з масивом об'єктів ---");
            Vegetables[] myVeggies = new Vegetables[]
            {
                new Vegetables("Огірок", 10, 60, 15, 30, 20.00, "Родничок", "Україна", 5),
                new Vegetables("Капуста", 20, 150, 25, 45, 16.00, "Білокачанна", "Польща", 5)
            };

            // Звичайний цикл for для виведення всіх елементів масиву
            for (int i = 0; i < myVeggies.Length; i++)
            {
                Console.WriteLine($"\nЕлемент {i + 1}: {myVeggies[i].name}");
                myVeggies[i].PrintInfo();
            }

            Console.ReadLine(); // Щоб консоль не закривалася після виконання
        }
    }
}