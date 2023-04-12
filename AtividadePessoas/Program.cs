using AtividadePessoas.Classes;

Pessoa[] pessoas = new Pessoa[]
{
    new Operario{
        Name = "Guilherme"
        , Birth = new(year: 1992, month: 3, day: 23)
        , Gender = "Man"
        , Sector = "Maintenance"
        , Function = "Mechanic"
        , Hiring = new(year: 2019, month: 07, day: 03)
    },
    new Supervisor{
        Name = "Leocir"
        , Birth = new(year: 1990, month: 08, day: 13)
        , Gender = "Man"
        , Sector = "Maintenance"
        , Education = "Mechanical Engineer"
    },
    new Gerente{
        Name = "Marcelo"
        , Birth = new(year: 1985, month: 12, day: 24)
        , Gender = "Man"
        , Sector = "Maintenance"
        , Unidade = "Videira"
    },
    new Operario{
        Name = "Wagner"
        , Birth = new(year: 2002, month: 02, day: 15)
        , Gender = "Man"
        , Sector = "Maintenance"
        , Function = "Eletrician"
        , Hiring = new(year: 2020, month: 03, day: 07)
    },
    new Operario{
        Name = "Maiara"
        , Birth = new(year: 1992, month: 3, day: 23)
        , Gender = "Woman"
        , Sector = "Warehouse"
        , Function = "Storekeeper"
        , Hiring = new(year: 2016, month: 02, day: 17)
    },
};

Console.WriteLine ("\n---FOREACH---\n");
foreach( Pessoa pessoa in pessoas )
{
    string message = string.Empty;
    if( pessoa != null )
    {
        message += $"Nome: {pessoa.Name}\nSector: {pessoa.Sector}";
    }
    Console.WriteLine (message);
}