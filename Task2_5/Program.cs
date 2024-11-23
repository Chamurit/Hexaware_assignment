

namespace Task2_5
{
        public class Program
        {
            public static void Main(string[] args)
            {
                // Sample list of couriers
                List<Courier> couriers = new List<Courier>
            {
                new Courier(1, "John Doe", "123 Main St, Springfield", "Jane Smith", "456 Elm St, Chicago", 5.5m, "In Transit", "TRK001", DateTime.Now.AddDays(3)),
                new Courier(2, "John Doe", "123 Main St, Springfield", "Alice Brown", "789 Oak St, New York", 3.2m, "Delivered", "TRK002", DateTime.Now.AddDays(-1)),
                new Courier(3, "Mary Johnson", "234 Pine St, Boston", "John Doe", "123 Main St, Springfield", 2.0m, "Out for Delivery", "TRK003", DateTime.Now.AddDays(1)),
                new Courier(4, "Alice Brown", "789 Oak St, New York", "John Doe", "123 Main St, Springfield", 7.8m, "In Transit", "TRK004", DateTime.Now.AddDays(2))
            };

                // Specific customer to display orders for
                string customerName = "John Doe";

                // Display orders for the specific customer using a for loop
                Console.WriteLine($"Orders for customer: {customerName}");
                for (int i = 0; i < couriers.Count; i++)
                {
                    if (couriers[i].SenderName.Equals(customerName, StringComparison.OrdinalIgnoreCase) ||
                        couriers[i].ReceiverName.Equals(customerName, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(couriers[i]);
                    }
                }
            }
        }
}
