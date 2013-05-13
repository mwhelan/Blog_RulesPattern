using RulesPattern.StoreExample.Refactor;

namespace RulesPattern.StoreExample.Rules
{
    public class SeniorDiscountRule : IDiscountRule
    {
        public decimal CalculateCustomerDiscount(Customer customer)
        {
            return customer.IsSenior() ? 0.05m : 0;
        }
    }
}