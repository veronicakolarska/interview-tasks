using OffersDatabase.Data;
using OffersDatabase.Models;

namespace ZooSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var db = new OffersDbContext();

            if (db.Offers.Any())
            {
                Console.WriteLine("Offers already exist!");
                return;
            }

            using var reader = new StreamReader(@"C:\Users\veronica.kolarska\Desktop\offers.csv");
            
            var titleLine = reader.ReadLine();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line is null) 
                {
                    continue;
                }

                var offer = new Offer(line);
                db.Offers.Add(offer);
            }

            db.SaveChanges();
            Console.WriteLine($"Changes saved to the database! Number of offers {db.Offers.Count()}");
        }
    }
}