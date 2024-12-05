using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        string[] palavras = frase.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        int numeroDePalavras = palavras.Length;

        Console.WriteLine($"O número de palavras é de: {numeroDePalavras}");
    }
}