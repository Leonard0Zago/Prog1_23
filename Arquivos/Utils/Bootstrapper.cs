using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Utils
{
    public static class Bootstrapper
    {
        public static void ChargeClients()
        {
            var c1 =new Client{
                Id = 1,
                FirstName = "Mauricio Roberto",
                LastName = "Gonzatto",
                CPF = "000.000.000-00",
                Email = "mauricio.gonzatto@unoesc.edu.br"
            };
            DataSet.Clients.Add(c1);

            DataSet.Clients.Add(
                new Client{
                    Id = 2,
                    FirstName = "Leonardo",
                    LastName = "Perosa Zago",
                    CPF = "111.111.111-11",
                    Email = "leonardo.perosa@unoesc.edu.br"
                }
            );
                
             DataSet.Clients.Add(
                new Client{
                    Id = 3,
                    FirstName = "Marcos",
                    LastName = "Marcondes",
                    CPF = "222.222.222-22",
                    Email = "marcos.marcodes@unoesc.edu.br"
                }
             );
        }
        public static void ChargeAnimals()
        {
            DataSet.Animals.Add(
                new Animal{
                Id = 1,
                Name = "Pele",
                Raça = "Vira lata",
                Tipo = "Cachorro",
                }
            );
            DataSet.Animals.Add(
                new Animal{
                Id = 2,
                Name = "Bob",
                Raça = "Laranja",
                Tipo = "Gato",
                }
            );
        }
        public static void ChargeVetes()
        {
            DataSet.Vetes.Add(
            new Vete{
                Id = 1,
                FirstName = "Douglas",
                LastName = "Diogenes",
                CPF = "333.333.333-33",
                Espec = "Pequeno porte",
                }
            );
            DataSet.Vetes.Add(
            new Vete{
                Id = 2,
                FirstName = "Pedro",
                LastName = "Pereira",
                CPF = "444.444.444-44",
                Espec = "Grande porte",
                }
            );
        }
        public static void ChargeClinicas()
        {
            DataSet.Clinicas.Add(
            new Clinica{
                Id = 1,
                Name = "Vida Pet",
                Tel = "(00) 0000-1111",
                Endereco = "Rua dos cachorros, 123",
                }
            );
            DataSet.Clinicas.Add(
            new Clinica{
                Id = 2,
                Name = "Dodog",
                Tel = "(01) 1111-0000",
                Endereco = "Rua dos gatos, 321",
                }
            );
        }
    }
}