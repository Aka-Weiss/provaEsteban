using System;

class Program
{
    static void Main()
    {
        var ddds = new System.Collections.Generic.Dictionary<int, string>
        {
            { 61, "Brasília" },
            { 71, "Salvador" },
            { 11, "São Paulo" },
            { 21, "Rio de Janeiro" },
            { 32, "Juíz de Fora" },
            { 19, "Campinas" },
            { 27, "Vitória" },
            { 31, "Belo Horizonte" }
        };

        Console.WriteLine("Digite o DDD:");
        int ddd = int.Parse(Console.ReadLine());

        if (ddds.ContainsKey(ddd))
        {
            Console.WriteLine($"O DDD {ddd} é de: {ddds[ddd]}");
        }
        else
        {
            Console.WriteLine("Esse DDD não está em nosso banco de dados!.");
        }
    }
}