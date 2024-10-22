using VisonBank.Accounts;
using VisonBank.UserInterfaces;

string line = new string('-', 100);
List<Account> accounts = new List<Account> {new Account("FLA", 1 , 100), new Account("FLA2", 5, 1000) };

HomeInterface homeInterface = new HomeInterface("Escolha uma opção : ");
homeInterface.Interface();

//Console.WriteLine(UserInterface.Interfaces.ContainsKey(homeInterface.Title));

void createAccountInterface()
{
    Console.Clear();
    Console.WriteLine("*Caso queira sair digite 'end'.");
    Console.WriteLine("Digite seu nome: ");
    string name = Console.ReadLine();
    createAccountInterfaceClose(name, false);
    Console.WriteLine("Digite número da agencia: ");
    string agenceNum = Console.ReadLine();
    createAccountInterfaceClose(agenceNum, true);
    Console.WriteLine("Digite número saldo inicial: ");
    string balance = Console.ReadLine();
    createAccountInterfaceClose(balance, true);
    MenssageAndReturn("Sucesso");
    CreateAccount(name, int.Parse(agenceNum), float.Parse(balance));
}

void CreateAccount(string name, int agency, float balance)
{
    Account act = new Account(name, agency, balance);
    accounts.Add(act);
}

void createAccountInterfaceClose(string val, bool isNum)
{
    if (val == "end" || val == "")
    {
        //InterfaceInitial();
    }

    if(isNum)
    {
        if(!float.TryParse(val, out float n))
        {
            MenssageAndReturn("Valor inválido");
        }
    }

}

void ListAccount()
{
    if (accounts.Count == 0)
    {
        MenssageAndReturn("Lista de contas vazia");
    }
    foreach (Account act in accounts)
    {
        Console.WriteLine("Tirular: " + act.Holder);
        Console.WriteLine("Agencia: " + act.Agency);
        Console.WriteLine("Conta N: " + act.AccountNum);
        Console.WriteLine("Saldo: " + act.Balance);
        Console.WriteLine("");
    }
}

void MenssageAndReturn(string message)
{
    Console.Clear();
    Console.WriteLine(message);
    Console.WriteLine("Digite qualquer coisa");
    Console.ReadLine();
    //InterfaceInitial();
}

//InterfaceInitial();
