using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o nome do usuario: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite a idade do usuario: ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Nome " + nome + " | idade " + idade + " anos ");


    }
}
