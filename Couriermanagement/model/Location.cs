

namespace Couriermanagement.model
{
        public class Location
        {
            private int locationID;
            private string locationName;
            private string address;

        // Default constructor
         public Location() { }

        // Parameterized constructor
        public Location(int locationID, string locationName, string address)
            {
                this.locationID = locationID;
                this.locationName = locationName;
                this.address = address;
            }

            // Getters and Setters
            public int LocationID { get => locationID; set => locationID = value; }
            public string LocationName { get => locationName; set => locationName = value; }
            public string Address { get => address; set => address = value; }

            // toString method
            public override string ToString()
            {
                return $"LocationID: {locationID}, LocationName: {locationName}, Address: {address}";
            }
        }
}



   