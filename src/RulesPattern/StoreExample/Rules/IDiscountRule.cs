namespace RulesPattern.StoreExample.Rules
{
    public interface IDiscountRule
    {
        decimal CalculateCustomerDiscount(Customer customer);
    }
}