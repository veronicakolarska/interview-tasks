using InvoiceCalculator.Common;
using InvoiceCalculator.Contracts;

namespace InvoiceCalculator.Models
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
                return this.SentSmsCount * Constants.MONTHLY_MESSAGES_SENT_SMS_BELOW;
            }

            if (this.SentSmsCount >= 50 && this.SentSmsCount <= 100)
            {
                return this.SentSmsCount * Constants.MONTHLY_MESSAGES_SENT_SMS_ABOVE;
            }

            return this.SentSmsCount * Constants.MONTHLY_MESSAGES_SENT_SMS;
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
}