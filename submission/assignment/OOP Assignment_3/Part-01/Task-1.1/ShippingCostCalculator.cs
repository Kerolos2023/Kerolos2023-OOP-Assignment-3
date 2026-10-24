using OOP_Assignment_3.Refactoring.Part_01;
namespace OOP_Assignment_3.Refactoring.Part_01;

public class ShippingCostCalculator
{
    private readonly IEnumerable<IShippingCarrier> _carriers;

    public ShippingCostCalculator(IEnumerable<IShippingCarrier> carriers)
    {
        _carriers = carriers;
    }

    public decimal CalculateShippingCost(IShippingCarrier carrier, decimal weightKg)
    {
        try
        {
            if(carrier == null)
            {
                throw new ArgumentNullException(nameof(carrier), "Carrier cannot be null.");
            }
            if (weightKg < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(weightKg), "Weight cannot be negative.");
            }
            return carrier.CalculateCost(weightKg);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error calculating shipping cost: {ex.Message}");
            throw; // Rethrow the exception to propagate it up the call stack)
        }
    }
}
