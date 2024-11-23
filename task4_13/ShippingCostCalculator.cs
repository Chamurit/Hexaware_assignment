using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_13
{
        public class ShippingCostCalculator
        {
            public static double CalculateShippingCost(Address source, Address destination, double weight)
            {
                // Define rates
                const double ratePerKilometer = 0.5; // Rate per kilometer
                const double ratePerKilogram = 2.0;  // Rate per kilogram

                // Get the distance between source and destination (mocked for demo)
                double distance = GetDistance(source, destination);

                // Calculate cost
                double cost = (distance * ratePerKilometer) + (weight * ratePerKilogram);

                return cost;
            }

            private static double GetDistance(Address source, Address destination)
            {
                // Mocked distance for demonstration (e.g., 150 km)
                return 150.0;
            }
        } 
}

