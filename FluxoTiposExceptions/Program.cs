﻿
// Operadores Unários
using FluxoTiposExceptions.Classes;

int x = 5;
int incrementoPosfixado = x++; // 6
incrementoPosfixado++;
x++; x = x + 1;
int incrementoPrefixado = ++x;
Console.WriteLine( $"Posfixado: {incrementoPosfixado}" );
Console.WriteLine( $"Prefixado: {incrementoPrefixado}" );

// Como obter o tipo de uma variável
Type tipoDeInteiro = typeof(int);
Type tipoDeX = x.GetType();
// Como obrter o nome de uma variável
string nomeDaVariavel = nameof(x);
int quantosBytes = sizeof(int);

Console.WriteLine( "Nome da var: " + nomeDaVariavel );

// Operadores de atribuição
int p = 6;
p += 3; // Equivalente a p = p + 3;
Console.WriteLine($"+={p}");
p -= 3; // Equivalente a p = p - 3;
Console.WriteLine($"-={p}");
p *= 3; // Equivalente a p = p * 3;
Console.WriteLine($"*={p}");
p /= 3; // Equivalente a p = p / 3;
Console.WriteLine($"/={p}");


// OPERADORES LÓGICOS

bool a = true;
bool b = false;
WriteLine($"AND  | a    | b    ");
WriteLine($"a    |{a & a, -5} | {a & b, -5}");
WriteLine($"b    |{b & a, -5} | {b & b, -5}");
WriteLine();
WriteLine($"OR   | a    | b    ");
WriteLine($"a    |{a | a, -5} | {a | b, -5}");
WriteLine($"b    |{b | a, -5} | {b | b, -5}");
WriteLine();
WriteLine($"XOR  | a    | b    ");
WriteLine($"a    |{a ^ a, -5} | {a ^ b, -5}");
WriteLine($"b    |{b ^ a, -5} | {b ^ b, -5}");

static bool FacaAlgo()
{
    WriteLine("Fazendo alguma coisa");
    return true;
}
WriteLine();
WriteLine($"a & FacaAlgo() = {a & FacaAlgo()}");
WriteLine($"b & FacaAlgo() = {b & FacaAlgo()}");
Console.WriteLine ();
//----------------------------------------------

Animal[] animals = new Animal[]
{
    new Cat{ 
        Name = "Garfield"
        , Born = new(year: 2022, month: 8, day: 23)
        , Legs = 4
        , IsDomestic = true
    },
    new Animal{
        Name = "Humano (eu)"
        , Born = new(year: 2001, month:1, day: 24)
        , Legs = 2
    },
    new Cat{
        Name = "Mimi"
        , Born = new(year: 1994, month: 6, day: 12)
        , Legs = 4
        , IsDomestic = true
    },
    new Spider{
        Name = "Peter Parker"
        , Born = DateTime.Today
        , IsPoisonous = true
        , Legs = 8
    },
    new Spider{
        Name = "Eddie Brock"
        , Born = DateTime.Today
        , IsPoisonous = true
        , Legs = 8
    }
};

// Laços de repetição
// 3 tipos de variáveis para controle de repetição
// 1: Flag - Bandeirinha, booleano que indica se para ou continua
// 2: Counter - Contador, conta quantas vees a repetição ocorreu
// 3: Acumulador - Permite acumular valoreas a cada iteração

// Laço for
Console.WriteLine ("\n---FOR---\n");
for(int i = 0; i < animals.Length; i++)
{
    string message = string.Empty;
    if(animals[i] != null)
    {
        message = $"Nome: {animals[i].Name} ";
        message += $"Data Nasc: {animals[i].Born.ToShortDateString()} ";
    }
    Console.WriteLine (message);
    
}

// LAÇO DE REPETIÇÃO PARA CADA
Console.WriteLine ("\n---FOREACH---\n");
foreach( Animal animal in animals )
{
    string message = string.Empty;
    if( animal != null )
    {
        message += $"Nome: {animal.Name}";
    }
    Console.WriteLine (message);
}

