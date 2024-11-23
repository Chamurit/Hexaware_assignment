namespace Courier_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the order status:");
            string status = Console.ReadLine();
            if(status =="Processing")
            {
                Console.WriteLine("order is still in processing");
            }
            else if (status=="Delivered")
            {
                Console.WriteLine("order has been delivered ");
            }
            else
            {
                Console.WriteLine("order has been cancelled");
            }
          

        }
    }
}
