using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisonBank.Accounts;

namespace VisonBank.UserInterfaces
{
    internal class HomeInterface : UserInterface
    {
        private CreateAccountInterface createAccountInterface;
        private ListAccountsInterface listAccountsInterface;
        private ExcludeAccountInterface excludeAccountInterface;
        public HomeInterface(string title) : base(title)
        {
            this.createAccountInterface = new CreateAccountInterface("Crie sua conta: ");
            this.listAccountsInterface = new ListAccountsInterface("Lista de contas: ");
            this.excludeAccountInterface = new ExcludeAccountInterface("Ecluindo conta: ");
        }

        public override void Interface()
        {
            Console.Clear();
            Console.WriteLine(line);
            Console.WriteLine(Title);
            Console.WriteLine(line);
            Console.WriteLine(textPattern, "Criar conta", "1");
            Console.WriteLine(textPattern, "Listar", "2");
            Console.WriteLine(textPattern, "Excluir conta", "3");
            Console.WriteLine(textPattern, "Sair", "Qualquer tecla");

            Console.WriteLine(accountManager.checkAccountNum("12aa")); 
            char key = Console.ReadKey().KeyChar;
            this.Redirect(key);
        }

        public override void Redirect(char key)
        {
            switch (key)
            {
                case '1':
                    createAccountInterface.Interface();
                    break;
                case '2':
                    listAccountsInterface.Interface();
                    break;
                case '3':
                    excludeAccountInterface.Interface();
                    break;
                default:
                    Console.WriteLine("Encerando");
                    break;
            }
        }
    }
}
