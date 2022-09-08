using InvoiceCalculator.Common;
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
            return this.UsedA1Minutes * Constants.MONTHLY_MINUTE_DATA_A1
                + this.UsedTelenorMinutes * Constants.MONTHLY_MINUTE_DATA_TELENOR
                + this.UsedVivacomMinutes * Constants.MONTHLY_MINUTE_DATA_VIVACOM
                + this.RoamingMinutes * Constants.MONTHLY_MINUTE_DATA_ROAMING;
        }
    }
}