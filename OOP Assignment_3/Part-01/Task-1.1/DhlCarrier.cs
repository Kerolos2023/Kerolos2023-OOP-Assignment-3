using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment_3.Refactoring.Part_01
{
    public class DhlCarrier : IShippingCarrier
    {
        public string Name => "DHL";
        public decimal CalculateCost(decimal weightKg) => weightKg * 10m;
    }
}
