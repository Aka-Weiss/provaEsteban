using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a primeira data (dd/mm/aaaa): ");
        string data1Input = Console.ReadLine();

        Console.Write("Digite a segunda data (dd/mm/aaaa): ");
        string data2Input = Console.ReadLine();

        DateTime data1, data2;
        bool data1Valida = DateTime.TryParseExact(data1Input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data1);
        bool data2Valida = DateTime.TryParseExact(data2Input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data2);

        if (data1Valida && data2Valida)
        {
            TimeSpan diferenca = data2 - data1;

            Console.WriteLine($"A quantidade de dias entre as datas é: {Math.Abs(diferenca.Days)} dias");
        }
        else
        {
            Console.WriteLine("A data ta errada sô. Insira as datas no formato dd/mm/aaaa.");
        }
    }
}
