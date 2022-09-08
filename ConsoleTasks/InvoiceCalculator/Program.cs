using InvoiceCalculator.Contracts;
using InvoiceCalculator.Models;

namespace InvoiceCalculator
{
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