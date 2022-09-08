namespace InvoiceCalculator.Common
{
    public class Constants
    {
        public const decimal MONTHLY_INTERNET_DATA_LOCAL = .02m;
        public const decimal MONTHLY_INTERNET_DATA_EU = .05m;
        public const decimal MONTHLY_INTERNET_DATA_OUTSIDE_EU = .20m;

        public const decimal MONTHLY_MINUTE_DATA_A1 = .03m;
        public const decimal MONTHLY_MINUTE_DATA_TELENOR = .09m;
        public const decimal MONTHLY_MINUTE_DATA_VIVACOM = .09m;
        public const decimal MONTHLY_MINUTE_DATA_ROAMING = .15m;

        public const decimal MONTHLY_MESSAGES_SENT_SMS_BELOW = 0.18m;
        public const decimal MONTHLY_MESSAGES_SENT_SMS_ABOVE = 0.16m;
        public const decimal MONTHLY_MESSAGES_SENT_SMS = 0.11m;

    }
}
