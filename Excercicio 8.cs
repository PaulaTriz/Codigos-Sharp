using System;

class Progama
{
    static void Main(string[] args)
    {
        Console.Write("Digite o preço do produto: ");
        double preço = double.Parse(Console.ReadLine());

        Console.Write("Digite o desconto do produto: ");
        double desconto = double.Parse(Console.ReadLine());

        double precoFinal = preço - (preço * (desconto / 100));
        Console.Write("Preço final com desconto: R$ " + precoFinal);
    }
}
