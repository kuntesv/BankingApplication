namespace BankingApplication.Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = null;
            string password = null;

            Console.WriteLine("\n\n ::  Login Page :: ");
            Console.WriteLine("Enter Username : ");
            username = Console.ReadLine();

            if(username != "")
            {
                Console.WriteLine("Enter Password : ");
                password = Console.ReadLine();

                if(username == "system" && password == "manager")
                {
                    Console.WriteLine("\n\n:: Main Menu ::");
                    Console.WriteLine("1. Customer");
                    Console.WriteLine("2. Accounts");
                    Console.WriteLine("3. Fund Transfer");
                    Console.WriteLine("4. Fund Transfer statement");
                    Console.WriteLine("5. Account statement");
                    Console.WriteLine("0. Exit");

                    Console.WriteLine("\n Enter the choice : ");

                }
                else
                {
                    Console.WriteLine("Invalid username or password entered.");
                }

            }

            Console.WriteLine("\n\n Thank you ! Visit again....");

            Console.ReadKey();

        }
    }
}
