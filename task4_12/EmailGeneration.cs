

namespace task4_12
{
    public class EmailGeneration
    {
            public string GenerateOrderConfirmationEmail(Order order)
            {
                string emailContent = $"Dear {order.CustomerName},\n\n" +
                                      "Thank you for your order!\n\n" +
                                      $"Order Number: {order.OrderNumber}\n" +
                                      $"Delivery Address: {order.DeliveryAddress}\n" +
                                      $"Expected Delivery Date: {order.ExpectedDeliveryDate.ToShortDateString()}\n\n" +
                                      "We appreciate your business and hope you enjoy your purchase.\n\n" +
                                      "Best regards,\n" +
                                      "The JoyToys Team";
                return emailContent;
            }
    }
}


