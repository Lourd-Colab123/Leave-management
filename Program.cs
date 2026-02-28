namespace Leave_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> fileleave = new List<string>();
            string leavereason;

      
                Console.WriteLine("--------Leave Management system-------");

                Console.WriteLine();

                Console.WriteLine("Please Choose A Request Leave ");

                Console.WriteLine();

            Console.WriteLine("(Half Day Leave)");

                Console.WriteLine("(1 Day Leave)");

                Console.WriteLine("(3 Days Leave)");

                Console.WriteLine("(5 Days Leave)");

                Console.WriteLine("(Custom Leave)");

                Console.WriteLine();

            Console.Write("Enter Date:");


                leavereason = Console.ReadLine();

                fileleave.Add(leavereason);

                



        }
    }
}
