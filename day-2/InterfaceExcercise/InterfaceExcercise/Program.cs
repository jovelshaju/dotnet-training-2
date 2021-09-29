using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExcercise
{   

    class Program
    {
        static int Menu()
        {
            int opt;
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1.Check Balance");
            Console.WriteLine("2.Deposit Amount");
            Console.WriteLine("3.withdraw Amount");
            Console.Write("Enter option: ");
            opt = int.Parse(Console.ReadLine());
            return opt;
        }
        static void Operations(ISavingAccount accType)
        {
            int opt = Menu();
            int amount;
            switch (opt)
            {
                case 1:
                    Console.WriteLine("Current Balance: {0}", accType.Balance);
                    break;
                case 2:
                    Console.Write("Enter Amount to deposit: ");
                    amount = int.Parse(Console.ReadLine());
                    accType.Deposit(amount);
                    Console.WriteLine("Current Balance: {0}", accType.Balance);
                    break;
                case 3:
                    Console.Write("Enter Amount to withdraw: ");
                    amount = int.Parse(Console.ReadLine());
                    accType.Withdraw(amount);
                    Console.WriteLine("Current Balance: {0}", accType.Balance);
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
        static void Operations(ICurrentAccount accType)
        {
            int opt = Menu();
            int amount;
            switch (opt)
            {
                case 1:
                    Console.WriteLine("Current Balance: {0}", accType.Balance);
                    break;
                case 2:
                    Console.Write("Enter Amount to deposit: ");
                    amount = int.Parse(Console.ReadLine());
                    accType.Deposit(amount);
                    Console.WriteLine("Current Balance: {0}", accType.Balance);
                    break;
                case 3:
                    Console.Write("Enter Amount to withdraw: ");
                    amount = int.Parse(Console.ReadLine());
                    accType.Withdraw(amount);
                    Console.WriteLine("Current Balance: {0}", accType.Balance);
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }

        static void Main(string[] args)
        {
            int opt;
            int flag = 1;
            while (flag==1)
            {
                ISavingAccount savingAccount = new BankAccount();
                ICurrentAccount currentAccount = new BankAccount();

                Console.WriteLine("Choose an option");
                Console.WriteLine("1.Saving Account");
                Console.WriteLine("2.Current Account");
                Console.WriteLine("3.Exit");
                Console.Write("Enter option: ");
                opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:  
                        Operations(savingAccount);
                        break;
                    case 2:
                        Operations(currentAccount);
                        break;
                    case 3:
                        flag = 0;
                        break;
                    default:
                        Console.WriteLine("Invalid Option!");
                        break;
                }
                Console.ReadKey();

            }
        }
    }
}
