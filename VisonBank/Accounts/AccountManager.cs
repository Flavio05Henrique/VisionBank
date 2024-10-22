using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisonBank.Accounts
{
    internal class AccountManager
    {
        private static List<Account> accounts = new List<Account>();

        public void CreateAccount(string name, int agency, float balance)
        {
            Account account = new Account(name, agency, balance);
            accounts.Add(account);
        }

        public void ListAccounts()
        {
            foreach (Account account in accounts)
            {
                Console.WriteLine("Nome: " + account.Holder);
                Console.WriteLine("Agencia: " + account.Agency);
                Console.WriteLine("Conta: " + account.AccountNum);
                Console.WriteLine("Saldo: " + account.Balance);
                Console.WriteLine();
            }
        }

        public int ListLength()
        {
            return accounts.Count();
        }

        public void ExcludeAccount(string accontNum)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if(accounts[i].AccountNum == accontNum)
                {
                    accounts.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
