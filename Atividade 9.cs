using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        Console.WriteLine("A palavra possui " + palavra.Length + " caracteres.");
    }
}
