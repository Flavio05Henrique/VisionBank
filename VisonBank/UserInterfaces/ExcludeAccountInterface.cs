using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisonBank.UserInterfaces
{
    internal class ExcludeAccountInterface : UserInterface
    {
        public ExcludeAccountInterface(string title) : base(title)
        {
        }

        public override void Interface()
        {
            Console.Clear();
            Console.WriteLine("Digite o numero da conta: ");
            string accountNum = Console.ReadLine() + "";
            if(ExcludeAccount(accountNum))
            {
                Console.WriteLine("Conta excluida!");
                Console.WriteLine("Precione qualque tecla");
                Console.ReadKey();
                ReturToTheBeginning();
            }
            else
            {
                Console.WriteLine("Falha ao excluir");
                Console.WriteLine("*Causas:");
                Console.WriteLine("-- Numero de conta invalido.");
                Console.WriteLine("-- Conta não existe");
                Console.WriteLine("Precione qualque tecla");
                Console.ReadKey();
                ReturToTheBeginning();
            }
        }

        private bool ExcludeAccount(string accountNum)
        {
           return accountManager.ExcludeAccount(accountNum);
        }
    }
}
