using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Models;

namespace Arquivos.Data
{
    public static class DataSet
    {
        public static List<Client> Clients 
            = new List<Client>();

        // Lista para animais
        public static List<Animal> Animals
            = new List<Animal>();
        
        public static List<Vete> Vetes
            = new List<Vete>();

        public static List<Clinica> Clinicas
            = new List<Clinica>();

    }
}