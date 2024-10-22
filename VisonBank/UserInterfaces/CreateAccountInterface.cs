using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisonBank.Accounts;

namespace VisonBank.UserInterfaces
{
    internal class CreateAccountInterface : UserInterface
    {
        private AccountManager accountManager;
        public CreateAccountInterface(string title, AccountManager accm) : base(title)
        {
            accountManager = accm;
        }

        public override void Interface()
        {
            Console.Clear();
            Console.WriteLine("*Caso queira sair digite 'end'.");
            Console.WriteLine("Digite seu nome: ");
            string name = Console.ReadLine();
            Console.WriteLine("Digite número da agencia: ");
            string agenceNum = Console.ReadLine();
            Console.WriteLine("Digite número saldo inicial: ");
            string balance = Console.ReadLine();
            accountManager.CreateAccount(name, int.Parse(agenceNum), float.Parse(balance));
            Console.WriteLine("Conta criada, precione qualquer tecla");
            Console.ReadLine();
            ReturToTheBeginning();
        }
    }
}
