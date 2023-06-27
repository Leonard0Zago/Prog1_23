using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Controllers;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Views
{
    public class ClinicaView
    {
        private ClinicaController clinicaController;

        public ClinicaView()
        {
            clinicaController = new ClinicaController();
            this.Init();
        }

        public void Init()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("VOCÊ ESTÁ EM CLINICASS");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Clinicas");
            Console.WriteLine("2 - Listar Clinicas");
            Console.WriteLine("3 - Exportar Clinicas");
            Console.WriteLine("4 - Importar Clinicas");
            Console.WriteLine("5 - Pesquisar Clinicas");
            Console.WriteLine("");
            int option = 0;
            option = Convert.ToInt32( Console.ReadLine() );
            switch(option)
            {
                case 1 :
                    Insert();
                break;

                case 2 :
                    List();
                break;

                case 3 :
                    Export();
                break;

                case 4 :
                    Import();
                break;
                case 5 :
                    SearchByName();
                break;
                default :
                break;
            }
        }

        private void List()
        {
            List<Clinica> listagem = clinicaController.List();

            for(int i = 0; i < listagem.Count; i++)
            {
                Console.WriteLine( Print( listagem[i] ) );
            }

        }


        private string Print(Clinica clinica)
        {
            string retorno = "";
            retorno += $"Id: {clinica.Id} \n";
            retorno += $"Nome: {clinica.Name} \n";
            retorno += "-------------------------------------------";
            

            return retorno;
        }
    

        private void Insert()
        {
            Clinica clinica = new Clinica();

            clinica.Id = clinicaController.GetNextId();

            Console.WriteLine("Informe o nome:");
            clinica.Name = Console.ReadLine();

            Console.WriteLine("Informe o endereço:");
            clinica.Endereco = Console.ReadLine();

            bool retorno = clinicaController.Insert(clinica);

            if( retorno )
                Console.WriteLine("Clinica inserida com sucesso!");
            else
                Console.WriteLine("Falha ao inserir, verifique os dados");

        }
        private void Export()
        {
            if( clinicaController.ExportToTextFile() )
                Console.WriteLine("Arquivo gerado com sucesso!");
            else
                Console.WriteLine("Oooops.");
        }

        private void Import()
        {
            if( clinicaController.ImportFromTxtFile() )
                Console.WriteLine("Dados importado com sucesso!");
            else
                Console.WriteLine("Oooops.");
        }

        private void SearchByName()
        {
            Console.WriteLine("Pesquisar clinicas pelo nome.");
            Console.WriteLine("Digite o nome:");
            string name = Console.ReadLine();

            foreach( Clinica cl in clinicaController.SearchByName(name) )
            {
                Console.WriteLine( cl.ToString() );
            }
        }
    }
}