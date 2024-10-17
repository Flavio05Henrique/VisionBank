using VisonBank;

string line = new string('-', 100);

void interfaceInitial()
{
    Console.Clear();
    Console.WriteLine(line);
    Console.WriteLine("- Escolha uma opção -");
    Console.WriteLine(line);
    Console.WriteLine("{0, -20} {1, 20}","Criar conta", "1");
    Console.WriteLine("{0, -20} {1, 20}", "Login", "2");
    Console.WriteLine("{0, -20} {1, 20}", "Sair", "Qualquer tecla");
    char key = Console.ReadKey().KeyChar;
    direct(key);
}

void direct(char key)
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
            Console.WriteLine("tres");
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
    Console.WriteLine("Sucesso");
    Console.WriteLine("Digite qualquer coisa");
    Console.ReadLine();
    interfaceInitial();
}

void createAccountInterfaceClose(string val, bool isNum)
{
    if (val == "end" || val == "") interfaceInitial();
    if(isNum)
    {
        if(!float.TryParse(val, out float n))
        {
            interfaceInitial();
        }
    }

}

interfaceInitial();
