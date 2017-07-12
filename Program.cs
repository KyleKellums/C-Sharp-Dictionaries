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

            purchases.Add((ticker: "GE", shares: 150, price: 23.21));
            purchases.Add((ticker: "GE", shares: 32, price: 17.87));
            purchases.Add((ticker: "GE", shares: 80, price: 19.02));
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
            // This is the basic relational database join algorithm between two tables.

            /* 
                Define a new Dictionary to hold the aggregated purchase information.
                - The key should be a string that is the full company name.
                - The value will be the valuation of each stock (price*amount)
            */

            // string GM = stocks["GM"];   <--- "General Motors"
            
            Dictionary<string, int> aggPurchases = new Dictionary<string, int>();
            
            /* 
                {
                    "General Electric": 35900,
                    "AAPL": 8445,
                    ...
                }
            */

            // Iterate over the purchases and 
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                // Does the company name key already exist in the report dictionary?

                // If it does, update the total valuation

                // If not, add the new key and set its value
            }

            Console.WriteLine("Hello World!");
        }
    }
}
