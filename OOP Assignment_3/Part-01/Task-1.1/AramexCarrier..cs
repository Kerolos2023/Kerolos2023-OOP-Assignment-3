using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment_3.Refactoring.Part_01
{
    public class AramexCarrier : IShippingCarrier
    {
        public string Name => "Aramex";

        public decimal CalculateCost(decimal weightKg) => weightKg * 12m;
    }
}
