using System.ComponentModel.DataAnnotations.Schema;

namespace OffersDatabase.Models
{
    public class Offer
    {
        public Offer()
        {
        }

        public Offer(string csvLine)
        {
            var values = csvLine.Split(';', StringSplitOptions.RemoveEmptyEntries);

            var offerId = int.Parse(values[0]);
            var monthlyFee = decimal.Parse(values[1]);
            var newContractsForMonth = int.Parse(values[2]);
            var sameContractsForMonth = int.Parse(values[3]);
            var cancelledContractsForMonth = int.Parse(values[4]);

            this.OfferId = offerId;
            this.MonthlyFee = monthlyFee;
            this.NewContractsForMonth = newContractsForMonth;
            this.SameContractsForMonth = sameContractsForMonth;
            this.CancelledContractsForMonth = cancelledContractsForMonth;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OfferId { get; set; }

        public decimal MonthlyFee { get; set; }

        public int NewContractsForMonth { get; set; }

        public int SameContractsForMonth { get; set; }

        public int CancelledContractsForMonth { get; set; }
    }
}
