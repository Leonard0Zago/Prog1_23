using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{
    public class Animal
    { // Início do ESCOPO da classe
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Raça { get; set; }
        public string? Tipo { get; set; }

        // Os métodos contrutores são responsáveis 
        // por instanciar uma variável do tipo especificado 
        // pela classe.
        // A regra é de que o contrutor tenha o mesmo nome da classe.
        public Animal()
        {

        }
        // Método SEMPRE utiliza ()
        // Método construtor tem o mesmo nome da classe
        public Animal(
            int id
            , string? name
            , string? raça
            , string? tipo
        )
        { // Início do ESCOPO deste método
            Id = id;
            Name = name;
            Raça = raça;
            Tipo = tipo;
        }// Fim do ESCOPO deste método
    } // Fim do ESCOPO da classe
} // Fim do ESCOPO do namespace