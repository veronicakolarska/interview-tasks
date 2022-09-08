using InvoiceCalculator.Contracts;

namespace InvoiceCalculator
{
    public class MonthlyMessagesData : IMonthlyCalculable
    {
        public int SentSmsCount { get; set; }

        public int SentMmsCount { get; set; }

        public decimal CalculateMonthlyPrice()
        {
            return this.CalculateMonthlyMmsPrice() + this.CalculateMonthlySmsPrice();
        }

        private decimal CalculateMonthlySmsPrice()
        {
            if (this.SentSmsCount < 50)
            {
                return this.SentSmsCount * 0.18m;
            }

            if (this.SentSmsCount >= 50 && this.SentSmsCount <= 100)
            {
                return this.SentSmsCount * 0.16m;
            }

            return this.SentSmsCount * 0.11m;
        }

        private decimal CalculateMonthlyMmsPrice()
        {
            if (this.SentMmsCount < 50)
            {
                return this.SentMmsCount * 0.25m;
            }

            if (this.SentMmsCount >= 50 && this.SentMmsCount <= 100)
            {
                return this.SentMmsCount * 0.23m;
            }

            return this.SentMmsCount * 0.18m;
        }
    }

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

    internal class Program
    {
        static void Main(string[] args)
        {
            var userMonthlyData = new MonthlyUserData
            {
                SubscriptionFee = 9.99m,
                OtherFees = 1.99m,
                Discounts = 1.50m
            };

            var messagesData = new MonthlyMessagesData
            {
                SentSmsCount = 2,
            };

            var minutesData = new MonthlyMinutesData
            {
                UsedA1Minutes = 15,
                UsedTelenorMinutes = 6,
                UsedVivacomMinutes = 32,
            };

            var internetData = new MonthlyInternetData
            {
            };

            var monthlyInvoiceTotal = CalculateMonthlyInvoiceTotalPrice(new IMonthlyCalculable[] { userMonthlyData, messagesData, minutesData, internetData });

            Console.WriteLine($"Monthly total is {monthlyInvoiceTotal}");
        }

        static decimal CalculateMonthlyInvoiceTotalPrice(IEnumerable<IMonthlyCalculable> allMonthlyCosts)
        {
            return allMonthlyCosts.Sum(x => x.CalculateMonthlyPrice());
        }
    }
}