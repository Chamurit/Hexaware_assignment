namespace task4_11;


    
        public class Program
        {
            public static void Main(string[] args)
            {
                // Sample address parts
                string street = "123 main street";
                string city = "springfield";
                string state = "illinois";
                string zipCode = "627012345";

                // Create an instance of AddressFormatter
                AddressFormatter addressFormatter = new AddressFormatter();

                // Format the address
                string formattedAddress = addressFormatter.FormatAddress(street, city, state, zipCode);

                // Display the formatted address
                Console.WriteLine("Formatted Address:");
                Console.WriteLine(formattedAddress);
            }
        }
    
    