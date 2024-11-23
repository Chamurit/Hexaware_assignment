namespace task4_13
{
        public class Program
        {
            public static void Main(string[] args)
            {
                // Sample addresses
                Address sourceAddress = new Address("789 Industrial Rd.", "Springfield", "IL", "62704");
                Address destinationAddress = new Address("123 Main St", "Chicago", "IL", "60616");

                // Parcel weight
                double parcelWeight = 5.0; // Weight in kilograms

                // Calculate shipping cost
                double shippingCost = ShippingCostCalculator.CalculateShippingCost(sourceAddress, destinationAddress, parcelWeight);

                // Display the shipping cost
                Console.WriteLine($"Shipping cost from {sourceAddress} to {destinationAddress} for a parcel weighing {parcelWeight} kg is ${shippingCost:F2}");
            }
        }
    }

