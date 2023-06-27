using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Controllers
{
    public class ClinicaController
    {
        private string directoryName = "ReportFiles";
        private string fileName = "Clinicas.txt";
        public List<Clinica> List()
        {
            return DataSet.Clinicas;
        }


        public bool Insert(Clinica clinica)
        {
            if( clinica == null )
                return false;

            if( clinica.Id <= 0 )
                return false;

            if( string.IsNullOrWhiteSpace(clinica.Name) )
                return false;

            DataSet.Clinicas.Add(clinica);

            return true;
        }

        public bool ExportToTextFile()
        {
            if(!Directory.Exists(directoryName))
                Directory.CreateDirectory(directoryName);

            string fileContent = string.Empty;
            foreach(Clinica cl in DataSet.Clinicas)
            {
              fileContent += $"{cl.Id};{cl.Name};{cl.Endereco}";   
              fileContent += "\n";
            }

            try
            {
            StreamWriter sw = File.CreateText( $"{directoryName}\\{fileName}" );

            sw.Write(fileContent);
            sw.Close();
            }
            catch(IOException ioEx)
            {
                Console.WriteLine("Erro ao manipular o arquivo.");
                Console.WriteLine(ioEx.Message);
                return false;
            }

            return true;
        }



        public bool ImportFromTxtFile()
        {
            try
            {
                StreamReader sr = new StreamReader( $"{directoryName}\\{fileName}" );

                string line = string.Empty;
                line = sr.ReadLine();
                while( line != null )
                {
                    Client client = new Client();
                    string[] clientData = line.Split(';');
                    client.Id = Convert.ToInt32 ( clientData[0] );
                    client.CPF = clientData[1];
                    client.FirstName = clientData[2];
                    client.LastName = clientData[3];
                    client.Email = clientData[4];

                    DataSet.Clients.Add(client);

                    line = sr.ReadLine();
                } 

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ooops. Ocorreu um erro ao tentar importar os dados.");
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public List<Clinica> SearchByName(string name)
        {
            if ( string.IsNullOrEmpty(name) ||
                 string.IsNullOrWhiteSpace (name) 
               )
               return null;

            List<Clinica> clinicas = new List<Clinica>();
            for(int i = 0; i < DataSet.Clients.Count; i++)
            {
                var cl = DataSet.Clinicas[i];
                if( cl.Name.ToLower().Contains(name.ToLower()))
                {
                    clinicas.Add(cl);
                }
            }
            return clinicas;
        }

        public int GetNextId()
        {
            int tam = DataSet.Clients.Count;

            if( tam > 0 )
                return DataSet.Clients[tam - 1].Id + 1;
            else
                return 1;
        }
    }
}