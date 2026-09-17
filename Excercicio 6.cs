using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número decimal: ");
        decimal Numerodecimal = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Número digitado: " + Numerodecimal);
    }
}