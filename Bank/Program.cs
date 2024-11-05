namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountOwner AccountOwner = new AccountOwner(123456, "Yosef Kasas");
            Account MyAccount = new Account(AccountOwner, 100);
            AccountOwner.UserInfo();

            bool running = true;

            while (running)
            {
                Console.WriteLine("Velkommen til banken!");
                Console.WriteLine("");
                Console.WriteLine("Du kan vælge i mellem at:");
                Console.WriteLine("1. Indsæt penge");
                Console.WriteLine("2. Træk penge");
                Console.WriteLine("3. Vis saldo");
                Console.WriteLine("4. Afslut programmet");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();

                        Console.WriteLine("Indtast beløb for at indsætte det i din konto:");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        MyAccount.Deposit(depositAmount);
                        break;

                    case "2":
                        Console.Clear();

                        Console.WriteLine("Indtast hvor meget du vil gerne træk ud:");
                        double WithdrawAmount = Convert.ToDouble(Console.ReadLine());
                        MyAccount.Withdraw(WithdrawAmount);
                        break;

                    case "3":
                        Console.Clear();

                        MyAccount.ShowBalance();
                        break;

                    case "4":
                        Console.Clear();

                        running = false;
                        Console.WriteLine("Programmet er aflsuttet");
                        break;

                        default:
                        Console.WriteLine("Ugyldit valg. Prøv igen");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
