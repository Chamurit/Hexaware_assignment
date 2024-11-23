
namespace task3_8
{
    internal class Courier
    {
            public int CourierID { get; set; }
            public string Name { get; set; }
            public double CurrentLocation { get; set; }

            public Courier(int courierID, string name, double currentLocation)
            {
                CourierID = courierID;
                Name = name;
                CurrentLocation = currentLocation;
            }

            public override string ToString()
            {
                return $"CourierID: {CourierID}, Name: {Name}, CurrentLocation: {CurrentLocation} km";
            }
        }
    }

