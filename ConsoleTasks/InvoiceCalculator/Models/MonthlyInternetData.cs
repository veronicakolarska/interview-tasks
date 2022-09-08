using InvoiceCalculator.Contracts;

namespace InvoiceCalculator.Models
{
    public class MonthlyInternetData : IMonthlyCalculable
    {
        public int LocalUsedMb { get; set; }

        public int EuUsedMb { get; set; }

        public int OutsideEuUsedMb { get; set; }

        public decimal CalculateMonthlyPrice()
        {
            return this.LocalUsedMb * .02m + this.EuUsedMb * .05m + this.OutsideEuUsedMb * .20m;
        }
    }
}