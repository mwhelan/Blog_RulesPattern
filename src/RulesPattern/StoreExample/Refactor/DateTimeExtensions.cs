using System;

namespace RulesPattern.StoreExample.Refactor
{
    public static class DateTimeExtensions
    {
        public static DateTime ToValueOrDefault(this DateTime? dateTime, DateTime? defaultValue = null)
        {
            defaultValue = defaultValue.HasValue ? defaultValue.Value : DateTime.Now;
            return dateTime.HasValue ? dateTime.Value : defaultValue.Value;
        }
    }
}