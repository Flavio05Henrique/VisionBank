using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisonBank.Accounts
{
    internal class Account
    {
        public string Holder { get; private set; }
        public string AccountNum { get; private set; }
        public int Agency { get; private set; }
        public float Balance { get; private set; }

        public Account(string name, int agency, float balance)
        {
            Holder = name;
            Agency = agency;
            AccountNum = GenerateAccountNum(name, agency);
            Balance = balance;
        }
        private string GenerateAccountNum(string name, int agency)
        {
            char firstChar = name[0];
            char lastChar = name[name.Length - 1];
            return firstChar.ToString() + lastChar.ToString() + agency.ToString();
        }

        public bool Withdraw(float value)
        {
            if (Balance == 0 || Balance - value <= 0) return false;
            Balance -= value;
            return true;
        }

        public bool Deposit(float value)
        {
            Balance += value;
            return true;
        }


    }
}
