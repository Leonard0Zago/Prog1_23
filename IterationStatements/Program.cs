// Exemplo básico de repetição while

int i = 0;
while (i < 10)
{
    Console.WriteLine(i);
    i = i +1;
}

// Exercício 1: Checando se o número é primo

static bool IsPrime(int number)
{
if (number ==0 || number ==1) return false;
bool isPrime = true;
int counter = 2;

while (counter <= Math.Sqrt(number))
{
    if (number % counter == 0)
{
    isPrime = false;
    break;
}
    counter++;
}
    return isPrime;
}

Console.Write("Enter a number to check whether it is Prime: ");
var input = int.Parse(Console.ReadLine());
Console.WriteLine($"{input} is prime? {IsPrime(input)}.");

// Jump Statements, 

static bool IsPrimeWithContinue(int number)
{
    if (number == 0 || number ==1) return false;
        bool isPrime = true;
        int counter = 2;
while (counter <= Math.Sqrt(number))
{
    if (number % counter != 0)
    {
    counter++;
    continue;
}
    isPrime = false;
    break;
}
    return isPrime;
}

Console.Write("Enter a number to check whether it is Prime(Jump): ");
var inputJ = int.Parse(Console.ReadLine());
Console.WriteLine($"{inputJ} is prime? {IsPrimeWithContinue(inputJ)}.");

// Goto

static bool IsPrimeWithGoTo(int number)
{
if (number == 0 || number ==1) return false;
bool isPrime = true;
int counter = 2;
while (counter <= Math.Sqrt(number))
{
if (number % counter == 0)
{
isPrime = false;
goto isNotAPrime;
}
counter++;
}
isNotAPrime:
return isPrime;
}

Console.Write("Enter a number to check whether it is Prime(Goto): ");
var inputG = int.Parse(Console.ReadLine());
Console.WriteLine($"{inputG} is prime? {IsPrimeWithGoTo(inputG)}.");

// Forma simples de representar a lógica

static bool IsPrimeWithReturn(int number)
{
    if (number == 0 || number ==1) return false;
        int counter = 2;
    while (counter <= Math.Sqrt(number))
{
    if (number % counter == 0)
{
    return false;
}
    counter ++;
}
    return true;
}

Console.Write("Enter a number to check whether it is Prime(Simples): ");
var inputS = int.Parse(Console.ReadLine());
Console.WriteLine($"{inputS} is prime? {IsPrimeWithGoTo(inputS)}.");

// Do While

int t = 0;
do
{
Console.WriteLine($"Do while: {t}");
t++;
} while (t < 5);


// For loop

int[] array = { 1, 2, 3, 4, 5 };
for (int j = 0; j < array.Length - 1; j++)
{
Console.WriteLine($"For loop: {array[j]}");
}

// Bubble sort de um array

static int[] BubbleSort(int[] array)
{
    int temp;

    for (int j = 0; j < array.Length - 1; j++)
    {
        for (int i = 0; i < array.Length - j - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                temp = array[i + 1];
                array[i + 1] = array[i];
                array[i] = temp;
            }
        }
    } 
    return array;
}

int[] randomNumbers = { 123, 22, 53, 91, 787, 0, -23, 5 };
int[] sortedArray = BubbleSort(randomNumbers);

Console.WriteLine("Sorted:");
for (int i = 0; i < randomNumbers.Length; i++)
{
Console.WriteLine(sortedArray[i] + " ");
}