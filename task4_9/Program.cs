namespace task4_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Initialize 2D array with tracking numbers and statuses
                string[,] parcelTracking = new string[,]
                {
                { "TRK001", "Parcel in transit" },
                { "TRK002", "Parcel out for delivery" },
                { "TRK003", "Parcel delivered" },
                { "TRK004", "Parcel in transit" },
                { "TRK005", "Parcel out for delivery" }
                };

                // Input tracking number from user
                Console.WriteLine("Enter the parcel tracking number:");
                string trackingNumber = Console.ReadLine();

                // Get the parcel status
                string status = GetParcelStatus(parcelTracking, trackingNumber);

                // Display the tracking status
                if (status != null)
                {
                    Console.WriteLine($"Tracking Number: {trackingNumber}");
                    Console.WriteLine($"Status: {status}");
                }
                else
                {
                    Console.WriteLine("Tracking number not found.");
                }
        }

            public static string GetParcelStatus(string[,] parcelTracking, string trackingNumber)
            {
                // Loop through the 2D array to find the tracking number
                for (int i = 0; i < parcelTracking.GetLength(0); i++)
                {
                    if (parcelTracking[i, 0] == trackingNumber)
                    {
                        return parcelTracking[i, 1];
                    }
                }
                return null;
            }
     }
 }

