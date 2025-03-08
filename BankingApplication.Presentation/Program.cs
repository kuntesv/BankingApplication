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
                    int mainMenuChoice = -1;

                    do
                    {

                        Console.WriteLine("\n\n:: Main Menu ::");
                        Console.WriteLine("1. Customer");
                        Console.WriteLine("2. Accounts");
                        Console.WriteLine("3. Fund Transfer");
                        Console.WriteLine("4. Fund Transfer statement");
                        Console.WriteLine("5. Account statement");
                        Console.WriteLine("0. Exit");

                        Console.WriteLine("\n Enter the choice : ");
                        mainMenuChoice = int.Parse(System.Console.ReadLine());
                        switch (mainMenuChoice)
                        {

                            case 1:

                                CustomerMenu();

                                break;
                            case 2:
                                AccountMenu();
                                break;

                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
                                break;

                        }
                    }while(mainMenuChoice != 0);


                }
                else
                {
                    Console.WriteLine("Invalid username or password entered.");
                }

            }

            Console.WriteLine("\n\n Thank you ! Visit again....");

            Console.ReadKey();

        }


        static void CustomerMenu()
        {
            int customerChoice = -1;

            do
            {
                Console.WriteLine(":: Customer Menu ::");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Delete Customer");
                Console.WriteLine("3. Update Customer");
                Console.WriteLine("4. View Customer");
                Console.WriteLine("0. Back to Main Menu");

                Console.WriteLine("\n\nEnter your choice : ");
                customerChoice = System.Convert.ToInt32(Console.ReadLine());
            } while (customerChoice != 0);

        }

        static void AccountMenu()
        {
            int accountChoice = -1;

            do
            {
                Console.WriteLine(":: Account Menu ::");
                Console.WriteLine("1. Add Account");
                Console.WriteLine("2. Delete Account");
                Console.WriteLine("3. Update Account");
                Console.WriteLine("4. View Account");
                Console.WriteLine("0. Back to Main Menu");

                Console.WriteLine("\n\nEnter your choice : ");
                accountChoice = System.Convert.ToInt32(Console.ReadLine());
            } while (accountChoice != 0);

        }



















    }
}
