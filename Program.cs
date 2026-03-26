namespace Leave_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fileleave = new List<string>();
            string leavereason;

            Console.WriteLine("--------Leave Management system-------");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            string correctPassword = "5 Dollars and 3 Cents";

            if (password == correctPassword)
            {
                Console.WriteLine("Access Granted!");
                Console.WriteLine("Welcome " + name);

                Console.Write("Do you want to apply for leave? (y/n): ");
                string applyLeave = Console.ReadLine().ToLower();

                if (applyLeave == "y")
                {
                    Console.Write("Enter your leave reason: ");
                    leavereason = Console.ReadLine();
                    fileleave.Add(leavereason);
                    Console.WriteLine("Your leave has been recorded: " + leavereason);
                }
                else
                {
                    Console.WriteLine("No leave was applied.");
                }

                Console.WriteLine("All leave requests:");
                foreach (var leave in fileleave)
                {
                    Console.WriteLine("- " + leave);
                }
            }
            else
            {
                Console.WriteLine("Try Again Bro...");
            }

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}