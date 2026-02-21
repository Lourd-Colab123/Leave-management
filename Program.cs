namespace Leave_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> fileleave = new List<string>();
            string leavereason;

      
                Console.WriteLine("--------Leave Management system-------");
                Console.Write("Enter A reason for leave: ");
                leavereason = Console.ReadLine();

                fileleave.Add(leavereason);

                



        }
    }
}
