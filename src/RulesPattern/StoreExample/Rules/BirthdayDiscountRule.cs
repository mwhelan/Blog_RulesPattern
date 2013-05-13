using RulesPattern.StoreExample.Refactor;

namespace RulesPattern.StoreExample.Rules
{
    public class BirthdayDiscountRule : IDiscountRule
    {
        public decimal CalculateCustomerDiscount(Customer customer)
        {
            return customer.IsBirthday() ? 0.10m : 0;
        }
    }
}