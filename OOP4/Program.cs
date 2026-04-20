using System;

namespace OOP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Фінальна Версія: Абстрактні класи та Інтерфейси сортування ===\n");

            Fruits myApple = new Fruits("Яблуко", 8, 120, 52, 30, 25.50, "Гала", "Україна", 3);
            Vegetables myTomato = new Vegetables("Помідор", 5, 90, 18, 65, 40.00, "Черрі", "Іспанія", 2);

            // 1. ДЕМОНСТРАЦІЯ АБСТРАКТНОГО КЛАСУ
            Console.WriteLine("--- Доступ через абстрактний базовий клас ---");
            Plant[] basket = new Plant[] { myApple, myTomato };
            foreach (Plant p in basket)
            {
                // Викликаємо метод, який гарантовано є у всіх нащадків завдяки абстракції
                Console.WriteLine($"Рослина '{p.name}' має статус: {p.CheckToxicity()}");
            }

            // 2. ДЕМОНСТРАЦІЯ СОРТУВАННЯ ТА КОЛЕКЦІЙ (Версія 4)
            Vegetables[] myVeggies = new Vegetables[]
            {
                new Vegetables("Помідор", 5, 90, 18, 65, 40.00, "Черрі", "Іспанія", 2),    // Ціна: 80
                new Vegetables("Огірок", 10, 60, 15, 30, 20.00, "Родничок", "Україна", 5), // Ціна: 100
                new Vegetables("Капуста", 20, 150, 25, 45, 16.00, "Білокачанна", "Польща", 5) // Ціна: 80 (Енергія більша)
            };

            Console.WriteLine("\n--- Сортування за замовчуванням (IComparable: За ціною) ---");
            Array.Sort(myVeggies);
            foreach (var v in myVeggies) { v.PrintInfo(); }

            Console.WriteLine("\n--- Кастомне сортування (IComparer: Ціна -> Енергія) ---");
            Array.Sort(myVeggies, new VeggieComparer());
            foreach (var v in myVeggies) { v.PrintInfo(); }

            Console.WriteLine("\n--- Перебір власної колекції (IEnumerable) ---");
            VeggieBox vegBox = new VeggieBox(myVeggies);
            foreach (Vegetables v in vegBox)
            {
                Console.WriteLine($"У коробці лежить: {v.name}");
            }

            Console.ReadLine();
        }
    }
}