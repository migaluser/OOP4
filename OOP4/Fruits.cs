using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class Fruits : Plant
    {
        private double EnergyValue;
        private double NitrateLevel;
        private string Sort;
        private double BasePrice;
        private double Weight;
        private string Producer;

        public double energyValue
        {
            get { return EnergyValue; }
            set { EnergyValue = value; }
        }
        public double nitrateLevel
        {
            get { return NitrateLevel; }
            set { NitrateLevel = value; }
        }
        public string sort
        {
            get { return Sort; }
            set { Sort = value; }
        }
        public double basePrice
        {
            get { return BasePrice; }
            set { BasePrice = value; }
        }
        public double weight
        {
            get { return Weight; }
            set { Weight = value; }
        }
        public string producer
        {
            get { return Producer; }
            set { Producer = value; }
        }

        public Fruits(string N, int S, int T, double E, double NL, double B, string Sr, string P, double W)
            : base(N, S, T)
        {
            EnergyValue = E;
            NitrateLevel = NL;
            Sort = Sr;
            BasePrice = B;
            Weight = W;
            Producer = P;
        }

        public override string CheckToxicity()
        {
            if (nitrateLevel > 40)
            {
                return "Увага! Перевищено норму нітратів.";
            }
            else
            {
                return "Продукт безпечний для споживання.";
            }
        }

        public double CalculateTotalCost()
        {
            return basePrice * weight;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Сорт: {sort}, Виробник: {producer}");
            Console.WriteLine($"Загальна вартість партії: {CalculateTotalCost()} грн");
            Console.WriteLine($"Статус безпеки: {CheckToxicity()}");
        }
    }
}