using InvoiceCalculator.Contracts;

namespace InvoiceCalculator.Models
{
    public class MonthlyMinutesData : IMonthlyCalculable
    {
        public int UsedA1Minutes { get; set; }

        public int UsedTelenorMinutes { get; set; }

        public int UsedVivacomMinutes { get; set; }

        public int RoamingMinutes { get; set; }

        public decimal CalculateMonthlyPrice()
        {
            return this.UsedA1Minutes * .03m
                + this.UsedTelenorMinutes * .09m
                + this.UsedVivacomMinutes * .09m
                + this.RoamingMinutes * .15m;
        }
    }
}