Console.WriteLine("Digite o valor a ser escrito por extenso:");
string Valor = Console.ReadLine();
int ValorInt = Convert.ToInt32(Valor);

string Value = Convert.ToString(ValorInt);
int qtdChars = Value.Length;

int Dez = 0;
int ValorCem = ValorInt;
int Cent =0;

if (ValorCem <= 1000)
{
    while (ValorCem >= 100)
    {
    ValorCem = ValorCem - 100;
    Cent++;
    }
    string Centena = Convert.ToString(Cent);

    if (Cent == 2){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("2" , "Duzentos e");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Centena) );
    }
    if (Cent == 3){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("3" , "Trezentos e");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Centena) );
    }
    if (Cent == 4){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("4" , "Quatrocentos e");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Centena) );
    }
    if (Cent == 5){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("5" , "Quinhentos e");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Centena) );
    }
    if (Cent == 6){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("6" , "Seicentos e");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Centena) );
    }
    if (Cent == 7){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("7" , "Setecentos e");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Centena) );
    }
    if (Cent == 8){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("8" , "Oitocentos e");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Centena) );
    }
    if (Cent == 9){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("9" , "Novecentos e");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Centena) );
    }
    

}

if (ValorCem <= 100)
{
if (ValorCem == 100)
{
    if (Cent >1)
    {
    Console.WriteLine("Cem");
    return;
    }
}
    while (ValorCem > 10)
    {
    ValorCem = ValorCem - 10;
    Dez++;
    }

    string Dezena = Convert.ToString(Dez);

    if (Dez == 2){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("2" , "Vinte e");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Dezena) );
    }
    if (Dez == 3){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("3" , "Trinta e");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Dezena) );
    }
    if (Dez == 4){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("4" , "Quarenta e");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Dezena) );
    }
    if (Dez == 5){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("5" , "Cinquenta e");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Dezena) );
    }
    if (Dez == 6){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("6" , "Sesenta e");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Dezena) );
    }
    if (Dez == 7){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("7" , "Setenta e");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Dezena) );
    }
    if (Dez == 8){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("8" , "Oitenta e");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Dezena) );
    }
    if (Dez == 9){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("9" , "Noventa e");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Dezena) );
    }

    string Deze = Convert.ToString(ValorCem);

if (ValorCem < 10)
{
if (Dez != 1)
{
    if (ValorCem == 1){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("1" , "Um");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Deze) );
    }
    if (ValorCem == 2){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("2" , "Dois");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Deze) );
    }
    if (ValorCem == 3){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("3" , "Tres");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Deze) );
    }
    if (ValorCem == 4){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("4" , "Quatro");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Deze) );
    }
    if (ValorCem == 5){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("5" , "Cinco");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Deze) );
    }
    if (ValorCem == 6){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("6" , "Seis");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Deze) );
    }
    if (ValorCem == 7){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("7" , "Sete");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Deze) );
    }
    if (ValorCem == 8){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("8" , "Oito");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Deze) );
    }
    if (ValorCem == 9){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("9" , "Nove");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Deze) );
    }
     if (ValorCem == 10){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("10" , "Dez");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Deze) );
    }
}
}

if (Dez == 1)
{
    if (ValorCem == 1){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("1" , "Onze");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Deze) );
    }
    if (ValorCem == 2){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("2" , "Doze");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Deze) );
    }
    if (ValorCem == 3){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("3" , "Treze");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Deze) );
    }
    if (ValorCem == 4){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("4" , "Quatorze");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Deze) );
    }
    if (ValorCem == 5){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("5" , "Quinze");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Deze) );
    }
    if (ValorCem == 6){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("6" , "Dezeseis");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Deze) );
    }
    if (ValorCem == 7){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("7" , "Dezesete");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Deze) );
    }
    if (ValorCem == 8){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("8" , "Dezoito");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Deze) );
    }
    if (ValorCem == 9){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("9" , "Dezenove");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Deze) );
    }
    if (ValorCem == 10){
        static string FormatReturningString(string stringToFormat) // Recebe uma referência
    {
    return stringToFormat.Replace("10" , "Vinte");// Substitui a primeira pela segunda
    }
    Console.WriteLine( FormatReturningString(Deze) );
    }
}    
}