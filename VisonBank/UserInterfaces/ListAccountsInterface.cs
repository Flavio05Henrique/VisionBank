using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisonBank.Accounts;

namespace VisonBank.UserInterfaces
{
    internal class ListAccountsInterface : UserInterface
    {
        public ListAccountsInterface(string title) : base(title)
        {
        }

        public override void Interface()
        {
            Console.Clear();
            if (accountManager.ListLength() > 0)
            {
                accountManager.ListAccounts();
                Console.WriteLine("Click em qualquer tecla para voltar");
                Console.ReadKey();
                ReturToTheBeginning();
            }
            else
            {
                Console.WriteLine("Não a contas registradas");
                Console.WriteLine("Click em qualquer tecla para voltar");
                Console.ReadKey();
                ReturToTheBeginning();
            }
        }
    }
}
