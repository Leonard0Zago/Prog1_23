using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manipulacao_Arquivos
{
    public partial class Program
    {
        static void SectionTitle(string title)
        {
            ConsoleColor previousColor = ForegroundColor;
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("*");
            WriteLine($"* {title}");
            WriteLine("*");
            ForegroundColor = previousColor;
        }
    }
}