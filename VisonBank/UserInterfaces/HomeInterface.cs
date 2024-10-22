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
        private static AccountManager accountManager = new AccountManager();
        private CreateAccountInterface createAccountInterface = new CreateAccountInterface("Crie sua conta: ", accountManager);
        public HomeInterface(string title) : base(title)
        {
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
                    ListAccounts();
                    break;
                case '3':
                    ListAccounts();
                    break;
                default:
                    Console.WriteLine("Encerando");
                    break;
            }
        }

        private void ListAccounts()
        {
            Console.Clear();
            if (accountManager.ListLength() > 0)
            {
                accountManager.ListAccounts();
                Console.WriteLine("Click em qualquer tecla para voltar");
                Console.ReadKey();
                this.Interface();
            } else
            {
                Console.WriteLine("Não a contas registradas");
                Console.WriteLine("Click em qualquer tecla para voltar");
                Console.ReadKey();
                this.Interface();
            }
        }

        private void ExcludeAccount()
        {

        }
    }
}
