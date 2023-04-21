
Console.WriteLine("Informe um número:");
int nro = Convert.ToInt32(Console.ReadLine());
int i = 0;
Tabuada(nro, i);


static int Tabuada(int number, int i)
{
     if(i >= 11 && number < 11)
    {
        return 0;
    }
    else
    Console.WriteLine($"{i} x {number} = {i * number}");
    i++;
    return Tabuada(number, i);
}