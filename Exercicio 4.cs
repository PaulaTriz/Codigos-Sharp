using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite 'sim' ou 'não' ");
        string entrada = Console.ReadLine().ToLower().Trim();
        bool respostaBool = (entrada == "sim");
        Console.WriteLine(" Valor boleano " + respostaBool);
        {

        }

    }
}
