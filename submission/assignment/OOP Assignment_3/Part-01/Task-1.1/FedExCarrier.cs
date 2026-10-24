using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment_3.Refactoring.Part_01
{
    public class FedExCarrier : IShippingCarrier
    {
        public string Name => "FedEx";

        public decimal CalculateCost(decimal weightKg) => weightKg * 15m;
    }
}
