namespace task1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string empName = "employee";
            string empPassword = "emp123";
            string customerName = "customer";
            string customerPassword = "customer123";

            int chances = 0;
        login:
            if (chances < 3)
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter username: ");
                string username = Console.ReadLine();
                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (username == empName && password == empPassword)
                {
                    Console.WriteLine("login successfully");
                }
                else if (username == customerName && password == customerPassword)
                {
                    Console.WriteLine("login successfully");
                }
                else
                {
                    chances++;
                    Console.WriteLine("invalid try again");
                    goto login;
                }
            }
            else
            {
                Console.WriteLine("no more chances");
            }
        }
    }
}
