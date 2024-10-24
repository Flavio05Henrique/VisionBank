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

        public bool ExcludeAccount(string accontNum)
        {
            if (!checkAccountNum(accontNum)) return false;
            for (int i = 0; i < accounts.Count; i++)
            {
                if(accounts[i].AccountNum == accontNum)
                {
                    accounts.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public bool checkAccountNum(string accountNum)
        {
            bool isValid = true;
            if(accountNum.Length == 4)
            {
                if (!(isLetter(accountNum[0]) && isLetter(accountNum[1]))) isValid = false;
                if (!(isDigit(accountNum[2]) && isDigit(accountNum[3]))) isValid = false;
            }
            return isValid;
        }

        private bool isLetter(char c)
        {
            int valueASCII = (int)c;
            int l = valueASCII;

            return l >= 65 && l <= 90 || l >= 97 && l <= 122;
        }

        private bool isDigit(char c)
        {
            int valueASCII = (int)c;
            int l = valueASCII;

            return l >= 48 && l <= 57;
        }
    }
}
