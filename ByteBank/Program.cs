using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank {
    internal class Program {
        static void Main(string[] args) {
            Client victor = new Client();
            Account victorAccount = new Account(456, 123);

            Console.WriteLine("Owner before definition: " + victorAccount.Owner);
            Console.WriteLine("Balance before definition: " + victorAccount.Balance);

            Console.WriteLine();

            //victorAccount.owner = "Victor";
            victor.Name = "Victor";
            victor.Cpf = "123.234.423-10";
            victor.Profession = "Developer";

            victorAccount.Owner = victor;
            victorAccount.Balance = 100;

            Console.WriteLine("Owner name: " + victorAccount.Owner.Name);
            Console.WriteLine("Number: " + victorAccount.Number);
            Console.WriteLine("Agency: " + victorAccount.Agency);
            Console.WriteLine("Balance: " + victorAccount.Balance);

            Console.WriteLine();

            Account hugoAccount = new Account(862, 093);

            hugoAccount.Owner = new Client();
            hugoAccount.Owner.Name = "Hugo";
            hugoAccount.Owner.Cpf = "123.234.423-10";
            hugoAccount.Owner.Profession = "Developer";
            hugoAccount.Balance = 1000;

            Console.WriteLine("Owner name: " + hugoAccount.Owner.Name);
            Console.WriteLine("Number: " + hugoAccount.Number);
            Console.WriteLine("Agency: " + hugoAccount.Agency);
            Console.WriteLine("Balance: " + hugoAccount.Balance);

            hugoAccount.WithDraw(2000);
            Console.WriteLine("New balance: " + hugoAccount.Balance);

            hugoAccount.Deposit(100);
            Console.WriteLine("New balance: " + hugoAccount.Balance);

            hugoAccount.Transfer(100, victorAccount);
            Console.WriteLine("New Hugo's balance: " + hugoAccount.Balance);

            Console.WriteLine("New Victor's balance: " + victorAccount.Balance);

            Console.WriteLine("Total accounts: " + Account.TotalAccounts);

            Console.ReadLine();
        }
    }
}
