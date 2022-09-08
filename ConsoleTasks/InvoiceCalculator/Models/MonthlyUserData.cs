using InvoiceCalculator.Contracts;

namespace InvoiceCalculator.Models
{
    public class MonthlyUserData : IMonthlyCalculable
    {
        public decimal SubscriptionFee { get; set; }

        public decimal OtherFees { get; set; }

        public decimal Discounts { get; set; }

        public decimal CalculateMonthlyPrice()
        {
            return this.SubscriptionFee + this.OtherFees - this.Discounts;
        }
    }
}