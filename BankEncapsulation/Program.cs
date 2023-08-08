namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            var account = new BankAccount();

            Console.WriteLine("Welcome to TrueCoders Banking!");
            Console.WriteLine("-------------------------------");

            while(true)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1: Deposit money");
                Console.WriteLine("2: Check balance");
                Console.WriteLine("3: Exit");

                int option;
                if(!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid input. Please enter vaild option.");
                    continue;
                }

                switch(option)
                {
                    case 1:
                        Console.Write("Enter an amount to deposit: ");
                        double amount;
                        if(!double.TryParse(Console.ReadLine(), out amount))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid amount.");
                            continue;
                        }

                        account.Deposit(amount);

                        Thread.Sleep(1000);
                        Console.WriteLine("Deposit successful!");
                        break;
                    case 2:
                        Console.WriteLine($"Current balance: ${account.GetBalance()}");
                        break;
                    case 3:
                        Console.WriteLine("Thank you for banking with TrueCoders!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please enter a valid option.");
                        break;
                }

            }
        }
    }
}
