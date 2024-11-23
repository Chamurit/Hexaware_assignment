namespace task4_12
{
    public class Program
    {
       public static void Main(string[] args)
        {
         
                // Sample order details
                string customerName = "John Doe";
                string orderNumber = "ORD123456";
                string deliveryAddress = "123 Main St, Springfield, IL";
                DateTime expectedDeliveryDate = DateTime.Now.AddDays(5);

                // Create an Order object
                Order order = new Order(customerName, orderNumber, deliveryAddress, expectedDeliveryDate);

                // Create an instance of EmailGenerator
                EmailGeneration emailGenerator = new EmailGeneration();

                // Generate the order confirmation email
                string emailContent = emailGenerator.GenerateOrderConfirmationEmail(order);

                // Display the email content
                Console.WriteLine("Order Confirmation Email:");
                Console.WriteLine(emailContent);
        }
    }
 }


