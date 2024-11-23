namespace task1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter package weight");
            double weight = Convert.ToDouble(Console.ReadLine());
            switch(weight)
            {
                case <= 1:
                    Console.WriteLine("package weight is light");
                    break;
                case > 1 and <= 2:
                    Console.WriteLine("package weight is medium");
                    break;
                case > 2:
                    Console.WriteLine("package weight is high");
                    break;

            }
        }
    }
}
