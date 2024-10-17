using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisonBank
{
    internal class Account
    {
        public string Holder {  get; private set; }
        public string AccountNum {  get; private set; }
        public int Agency { get; private set; }
        public float Balance { get; private set; }

        public Account(string name, int agency, float balance)
        {
            this.Holder = name;
            this.Agency = Agency;
            this.AccountNum = GenerateAccountNum(name, agency);
            this.Balance = Balance;
        }

        private string GenerateAccountNum(string name, int agency)
        {
            char firstChar = name[0];
            char lastChar = name[name.Length - 1];
            return firstChar + lastChar + agency.ToString();
        }

        public bool Withdraw(float value)
        {
            if (this.Balance == 0 || this.Balance - value <= 0) return false;
            this.Balance -= value;
            return true;
        }

        public bool Deposit(float value)
        {
            this.Balance += value;
            return true;
        }

       
    }
}
