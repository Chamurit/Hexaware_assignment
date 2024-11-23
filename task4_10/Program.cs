using System.Text.RegularExpressions;

namespace task4_10
{
    public class Program
    {
        public static bool ValidateCustomerData(string data,string detail)
        {
            
                switch (detail.ToLower())
                {
                    case "name":
                        return ValidateName(data);
                    case "address":
                        return ValidateAddress(data);
                    case "phone number":
                        return ValidatePhoneNumber(data);
                    default:
                        throw new ArgumentException("Invalid detail type provided.");
                }
        }

            private static bool ValidateName(string name)
            {
                // Check if the name contains only letters and is properly capitalized
                string pattern = @"^[A-Z][a-zA-Z]*$";
                return Regex.IsMatch(name, pattern);
            }

            private static bool ValidateAddress(string address)
            {
                // Check if the address does not contain special characters
                string pattern = @"^[a-zA-Z0-9\s,]*$";
                return Regex.IsMatch(address, pattern);
            }

            private static bool ValidatePhoneNumber(string phoneNumber)
            {
                // Check if the phone number follows the format ###-###-####
                string pattern = @"^\d{3}-\d{3}-\d{4}$";
                return Regex.IsMatch(phoneNumber, pattern);
            }

            public static void Main(string[] args)
            {
                // Sample data for testing
                string name = "JohnDoe";
                string address = "123MainSt";
                string phoneNumber = "123-456-7890";

                // Validate data
                Console.WriteLine($"Name validation result: {ValidateCustomerData(name, "name")}");
                Console.WriteLine($"Address validation result: {ValidateCustomerData(address, "address")}");
                Console.WriteLine($"Phone number validation result: {ValidateCustomerData(phoneNumber, "phone number")}");
            }
        }

    }

