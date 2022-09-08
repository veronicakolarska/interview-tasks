using InvoiceCalculator.Common;
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
            return this.LocalUsedMb * Constants.MONTHLY_INTERNET_DATA_LOCAL + this.EuUsedMb * Constants.MONTHLY_INTERNET_DATA_EU + this.OutsideEuUsedMb * Constants.MONTHLY_INTERNET_DATA_OUTSIDE_EU;
        }
    }
}