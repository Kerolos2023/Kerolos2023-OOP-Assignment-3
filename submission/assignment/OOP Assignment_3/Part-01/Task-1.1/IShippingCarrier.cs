using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment_3.Refactoring.Part_01
{
    public interface IShippingCarrier
    {
        string Name { get; }
        decimal CalculateCost(decimal weightKg);
    }
}
