using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{ // Início do ESCOPO do namespace
    public class Vete
    { // Início do ESCOPO da classe
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CPF { get; set; }
        public string? Espec { get; set; }

        // Os métodos contrutores são responsáveis 
        // por instanciar uma variável do tipo especificado 
        // pela classe.
        // A regra é de que o contrutor tenha o mesmo nome da classe.
        public Vete()
        {

        }
        // Método SEMPRE utiliza ()
        // Método construtor tem o mesmo nome da classe
        public Vete(
            int id
            , string? firstName
            , string? lastName
            , string? cPF
            , string? espec
        )
        { // Início do ESCOPO deste método
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CPF = cPF;
            Espec = espec;
        }// Fim do ESCOPO deste método public string FullName => 

        public string FullName => 
            $"{this.FirstName} {this.LastName}";

        public override string ToString()
        {
            return $"Id: {this.Id}; Name: {FullName}";
        }
    } // Fim do ESCOPO da classe
} // Fim do ESCOPO do namespace