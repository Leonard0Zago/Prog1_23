// Criar função estática
static void FormatString(string stringToFormat) // Recebe um valor cria uma cópia da 'mensagem'
    stringToFormat.Replace("Mundo" , "Marte");
}

static string FormatReturningString(string stringToFormat) // Recebe uma referência
{
    return stringToFormat.Replace("Mundo" , "Marte");// Substitui a primeira pela segunda
}

var mensagem = "Olá Mundo!";

// Invocando o método sem retorno
FormatString(mensagem);
Console.WriteLine(mensagem);

var outraMensagem = "Bom-dia Mundo!";
Console.WriteLine( FormatReturningString(outraMensagem) );

