using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumeroPorExtenso
{
    public class Dezena
    {
        public string DezenaPorExtenso(int numero)
        {
            string retorno ="";
             Unidade unidade = new Unidade();

            if (numero == 10)
               return "Dez";
            if (numero == 11)
                return "Onze";
            if (numero == 12)
                return "Doze";
            if (numero == 13)
                return "Treze";
            if (numero == 14)
                return "Quatorze";
            if (numero == 15)
                return "Quinze";
            if (numero == 16)
                return "Dezesseis";
            if (numero == 17)
                return "Dezesete";
            if (numero == 18)
                return "Dezoito";
            if (numero == 19)
                return "Dezenove";
                
           if(numero >= 20 && numero <= 29)
            {
                if(numero == 20)
                    retorno = "Vinte";
                else
                {
                    string und = numero.ToString().Substring(1,1);
                    retorno = "Vinte e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
            }

            //Implementar regra para 30 a 99

            return retorno;
        }
    }
}