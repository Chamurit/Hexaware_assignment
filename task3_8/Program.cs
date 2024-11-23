namespace task3_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Sample array of couriers
                Courier[] couriers = new Courier[]
                {
                new Courier(1, "Alice Johnson", 5.0),
                new Courier(2, "Bob Smith", 10.0),
                new Courier(3, "Charlie Brown", 3.5),
                new Courier(4, "David Green", 7.2)
                };

                double newOrderLocation = 4.0; // Location of the new order

                // Find the nearest available courier
                Courier nearestCourier = FindNearestCourier(couriers, newOrderLocation);

                if (nearestCourier != null)
                {
                    Console.WriteLine("Nearest Courier: " + nearestCourier);
                }
                else
                {
                    Console.WriteLine("No couriers available.");
                }
            }

            public static Courier FindNearestCourier(Courier[] couriers, double orderLocation)
            {
                if (couriers == null || couriers.Length == 0)
                {
                    return null;
                }

                Courier nearest = null;
                double minDistance = double.MaxValue;

                foreach (var courier in couriers)
                {
                    double distance = Math.Abs(courier.CurrentLocation - orderLocation);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        nearest = courier;
                    }
                }

                return nearest;
            }
        }
    }


