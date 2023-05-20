string entrada = string.Empty;// Pode ser também = ""
Console.WriteLine("-------------------");
Console.WriteLine("Veterinária AU AU");
Console.WriteLine("-------------------");

do{
    Console.WriteLine("");
    Console.WriteLine("O que deseja acessar?");
    Console.WriteLine("1 - Cadastros.");
    Console.WriteLine("2 - Relatórios.");
    Console.WriteLine("0 - SAIR");

    entrada = Console.ReadLine();

    switch(entrada)
    {
        case "1":
            bool sair = true;

            while(sair)
            {

                Console.WriteLine("CADASTRO");
                Console.WriteLine("O que deseja acessar?");
                Console.WriteLine("1 - Médicos.");
                Console.WriteLine("2 - Animais.");
                Console.WriteLine("2 - Atendimentos.");
                Console.WriteLine("0 - SAIR");
                
                int opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                    Console.WriteLine("MÉDICOS");

                    break;

                    case 2:
                    Console.WriteLine("ANIMAIS");

                    break;

                    case 3:
                    Console.WriteLine("ATENDIMENTOS");

                    break;

                    case 0:
                    sair = false;
                    break;
                
                    default:
                        Console.WriteLine("ATENÇÃO: Opção inválida!");
                    break;
                }
            }
        break;

        case "2":
            bool sairr = true;

            while(sairr)
            {
                Console.WriteLine("RELATÓRIOS");
                Console.WriteLine("O que deseja acessar?");
                Console.WriteLine("1 - Animais.");
                Console.WriteLine("2 - Atendimentos.");
                Console.WriteLine("0 - SAIR");

                int opcaoo = int.Parse(Console.ReadLine());

                switch(opcaoo)
                {
                    case 1:
                    Console.WriteLine("ANIMAIS");

                    break;

                    case 2:
                    Console.WriteLine("ATENDIMENTOS");

                    break;

                    case 0:
                    sairr = false;
                    break;
                
                    default:
                        Console.WriteLine("ATENÇÃO: Opção inválida!");
                    break;
                }
            }

        break;

    }
}while( !entrada.Equals("0") &&
        !string.IsNullOrWhiteSpace(entrada));