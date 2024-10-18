using VisonBank;

string line = new string('-', 100);
List<Account> accounts = new List<Account> {new Account("FLA", 1 , 100), new Account("FLA2", 5, 1000) };

void InterfaceInitial()
{
    Console.Clear();
    Console.WriteLine(line);
    Console.WriteLine("- Escolha uma opção -");
    Console.WriteLine(line);
    Console.WriteLine("{0, -20} {1, 20}","Criar conta", "1");
    Console.WriteLine("{0, -20} {1, 20}", "Login", "2");
    Console.WriteLine("{0, -20} {1, 20}", "Listar", "3");
    Console.WriteLine("{0, -20} {1, 20}", "Sair", "Qualquer tecla");
    char key = Console.ReadKey().KeyChar;
    Direct(key);
}

void Direct(char key)
{
    switch (key)
    {
        case '1':
            createAccountInterface();
            break;
        case '2':
            Console.WriteLine("dois");
            break;
        case '3':
            ListAccount();
            break;
        default: Console.WriteLine("Encerando");
            break;
    }
}

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
        InterfaceInitial();
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
    InterfaceInitial();
}

InterfaceInitial();
