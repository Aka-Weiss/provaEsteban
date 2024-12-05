using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um valor inteiro (até 1.000.000): ");
        int valor = int.Parse(Console.ReadLine());

        int[] notas = { 100, 50, 20, 10, 5, 2, 1 };
        int[] quantidade = new int[notas.Length];

        for (int i = 0; i < notas.Length; i++)
        {
            quantidade[i] = valor / notas[i];
            valor %= notas[i];
        }

        Console.WriteLine("Resultado:");
        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine($"{quantidade[i]} nota(s) de R$ {notas[i],2}.00");
        }
    }
}
