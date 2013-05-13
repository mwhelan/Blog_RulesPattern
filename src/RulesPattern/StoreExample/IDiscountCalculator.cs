namespace RulesPattern.StoreExample
{
    public interface IDiscountCalculator
    {
        decimal CalculateDiscountPercentage(Customer customer);
    }
}