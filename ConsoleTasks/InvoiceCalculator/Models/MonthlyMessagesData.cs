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
            if (this.SentSmsCount < Constants.MONTHLY_MESSAGES_SENT_MIN_RANGE)
            {
                return this.SentSmsCount * Constants.MONTHLY_MESSAGES_SENT_SMS_BELOW;
            }

            if (this.SentSmsCount >= Constants.MONTHLY_MESSAGES_SENT_MIN_RANGE && this.SentSmsCount <= Constants.MONTHLY_MESSAGES_SENT_MAX_RANGE)
            {
                return this.SentSmsCount * Constants.MONTHLY_MESSAGES_SENT_SMS_ABOVE;
            }

            return this.SentSmsCount * Constants.MONTHLY_MESSAGES_SENT_SMS;
        }

        private decimal CalculateMonthlyMmsPrice()
        {
            if (this.SentMmsCount < Constants.MONTHLY_MESSAGES_SENT_MIN_RANGE)
            {
                return this.SentMmsCount * Constants.MONTHLY_MESSAGES_SENT_MMS_BELOW;
            }

            if (this.SentMmsCount >= Constants.MONTHLY_MESSAGES_SENT_MIN_RANGE && this.SentMmsCount <= Constants.MONTHLY_MESSAGES_SENT_MAX_RANGE)
            {
                return this.SentMmsCount * Constants.MONTHLY_MESSAGES_SENT_MMS_ABOVE;
            }

            return this.SentMmsCount * Constants.MONTHLY_MESSAGES_SENT_MMS;
        }
    }
}