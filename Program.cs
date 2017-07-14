using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("NAP", "Napster");
            stocks.Add("SRS", "Sears");
            stocks.Add("HRTZ", "Hertz");
            // Add a few more of your favorite stocks

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "GM", shares: 32, price: 17.87));
            purchases.Add((ticker: "GM", shares: 80, price: 19.02));
            purchases.Add((ticker: "CAT", shares: 90, price: 21.04));
            purchases.Add((ticker: "CAT", shares: 47, price: 21.04));
            purchases.Add((ticker: "NAP", shares: 129, price: 1.04));
            purchases.Add((ticker: "NAP", shares: 237, price: 0.10));
            purchases.Add((ticker: "NAP", shares: 350, price: 0.02));
            purchases.Add((ticker: "SRS", shares: 130, price: 5.54));
            purchases.Add((ticker: "SRS", shares: 260, price: 0.75));
            purchases.Add((ticker: "SRS", shares: 330, price: 0.25));
            purchases.Add((ticker: "HRTZ", shares: 70, price: 8.28));
            purchases.Add((ticker: "HRTZ", shares: 330, price: 0.99));
            purchases.Add((ticker: "HRTZ", shares: 330, price: 0.05));

            // Create a total ownership report that computes the total value of each stock that you have purchased. 

            Dictionary<string, double> aggPurchases = new Dictionary<string, double>();

            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                string comName = stocks[purchase.ticker];
                // Does the company name key already exist in the report dictionary?
                if (stocks.ContainsKey(purchase.ticker)) {
                    
                    // If it does, update the total valuation
                    if (aggPurchases.ContainsKey(comName)) {
                        aggPurchases[comName] += (purchase.price * purchase.shares);
                    // If not, add the new key and set its value
                    }else{
                        aggPurchases.Add(comName, purchase.price * purchase.shares);
                    }
                }
            }
            foreach(KeyValuePair<string, double> aggTots in aggPurchases) {
            Console.WriteLine($"{aggTots.Key}, {aggTots.Value}");
            }
        }
    }
}
