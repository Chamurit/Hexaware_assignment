namespace Task4_14
{
        public class Program
        {
            public static void Main(string[] args)
            {
            // Sample address
            string address = "123 main street, springfield, illinois, 627012345";

                // Sample user with generated secure password
                User user = new User(1, "John Doe", "john.doe@example.com", "1234567890", address);

                // Display user details with secure password
                Console.WriteLine("User Details:");
                Console.WriteLine($"Name: {user.Name}");
                Console.WriteLine($"Email: {user.Email}");
                Console.WriteLine($"Password: {user.Password}"); // Note: In a real application, you should not display the password
                Console.WriteLine($"Contact Number: {user.ContactNumber}");
                Console.WriteLine($"Address: {user.Address}");
            }
        }
}

