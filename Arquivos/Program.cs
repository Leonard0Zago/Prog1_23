using Arquivos.Views;
using Arquivos.Utils;

/*
    Programa para leitura de dados de pessoas 
    e exportação um arquivos .txt
*/

Bootstrapper.ChargeClients();
Bootstrapper.ChargeAnimals();
Bootstrapper.ChargeVetes();
Bootstrapper.ChargeClinicas();

int option = 0;

do
{
    Console.WriteLine("*******************************************");
    Console.WriteLine("Programa para leitura e exportação de dados");
    Console.WriteLine("*******************************************");
    Console.WriteLine();
    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Animais");
    Console.WriteLine("3 - Veterinários");
    Console.WriteLine("4 - Clinicas");

    option = Convert.ToInt32(Console.ReadLine());

    switch(option)
    {
        case 1 :
            Console.WriteLine("OPÇÃO CLIENTES");
            ClientView clientView = new ClientView();
        break;
        case 2 :
            Console.WriteLine("OPÇÃO ANIMAIS");
            AnimalView animalView = new AnimalView();
        break;
         case 3 :
            Console.WriteLine("OPÇÃO VETERINARIOS");
            VeteView veteView = new VeteView();
        break;
        case 4 :
            Console.WriteLine("OPÇÃO CLINICAS");
            ClinicaView clinicaView = new ClinicaView();
        break;
    }

}while( option > 0 );


















