using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{
    public class Clinica
    { // Início do ESCOPO da classe
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Endereco { get; set; }

        // Os métodos contrutores são responsáveis 
        // por instanciar uma variável do tipo especificado 
        // pela classe.
        // A regra é de que o contrutor tenha o mesmo nome da classe.
        public Clinica()
        {

        }
        // Método SEMPRE utiliza ()
        // Método construtor tem o mesmo nome da classe
        public Clinica(
            int id
            , string? name
            , string? endereco
        )
        { // Início do ESCOPO deste método
            Id = id;
            Name = name;
            Endereco = endereco;
        }// Fim do ESCOPO deste método

        public override string ToString()
        {
            return $"Id: {this.Id}; Name: {Name}";
        }
    } // Fim do ESCOPO da classe
} // Fim do ESCOPO do namespace