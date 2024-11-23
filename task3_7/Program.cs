namespace task3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalUpdates = 10;
            string[] trackingHistory = new string[totalUpdates];

            for (int i = 0; i < totalUpdates; i++)
            {
                trackingHistory[i] = "Location Update " + (i + 1) + ": Parcel is at checkpoint " + (i + 1);

            }
            Console.WriteLine("Tracking History of the Parcel:"); foreach (var update in trackingHistory)
            {
                Console.WriteLine(update);

            }
        }
    }
}
