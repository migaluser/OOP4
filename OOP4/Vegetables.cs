using System;
using System.Collections.Generic;

namespace OOP4
{
    class Vegetables : Plant, IComparable // Підключаємо стандартний IComparable
    {
        private double EnergyValue;
        private double NitrateLevel;
        private string Sort;
        private double BasePrice;
        private double Weight;
        private string Producer;

        public double energyValue { get { return EnergyValue; } set { EnergyValue = value; } }
        public double nitrateLevel { get { return NitrateLevel; } set { NitrateLevel = value; } }
        public string sort { get { return Sort; } set { Sort = value; } }
        public double basePrice { get { return BasePrice; } set { BasePrice = value; } }
        public double weight { get { return Weight; } set { Weight = value; } }
        public string producer { get { return Producer; } set { Producer = value; } }

        public Vegetables(string N, int S, int T, double E, double NL, double B, string Sr, string P, double W)
            : base(N, S, T)
        {
            EnergyValue = E; NitrateLevel = NL; Sort = Sr; BasePrice = B; Weight = W; Producer = P;
        }

        public override string CheckToxicity()
        {
            if (nitrateLevel > 55) return "Увага! Перевищено норму нітратів.";
            else return "Продукт безпечний для споживання.";
        }

        public double CalculateTotalCost() { return basePrice * weight; }

        public void PrintInfo()
        {
            Console.WriteLine($"[Овоч] {name} ({sort}) | Вартість: {CalculateTotalCost()} | Енергія: {energyValue}");
        }

        // Реалізація IComparable
        public int CompareTo(object obj)
        {
            if (obj is Vegetables other)
                return this.CalculateTotalCost().CompareTo(other.CalculateTotalCost());
            throw new ArgumentException("Об'єкт не є овочем!");
        }
    }

    // Клас для IComparer (Сортування за 2 параметрами)
    class VeggieComparer : IComparer<Vegetables>
    {
        public int Compare(Vegetables x, Vegetables y)
        {
            if (x == null || y == null) return 0;
            int priceComparison = x.CalculateTotalCost().CompareTo(y.CalculateTotalCost());

            if (priceComparison != 0) return priceComparison;
            else return x.energyValue.CompareTo(y.energyValue);
        }
    }
}