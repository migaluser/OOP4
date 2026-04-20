using System;

namespace OOP4
{
    interface IPlant
    {
        string CheckToxicity();
        double CalculateTotalCost();
        void PrintInfo();
    }
}