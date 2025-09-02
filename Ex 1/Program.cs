using System;

class Program
{

    static int LerIdade(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int idade) && idade >= 0 && idade <= 130)
                return idade;

            Console.WriteLine("Entrada inválida. Digite um número inteiro entre 0 e 130.");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Comparador de Idades ===");


        int idade1 = LerIdade("Informe a idade do primeiro aluno: ");
        int idade2 = LerIdade("Informe a idade do segundo aluno: ");


        if (idade1 > idade2)
        {
            Console.WriteLine("Resultado: o primeiro aluno é o mais velho e o segundo é o mais novo.");
        }
        else if (idade2 > idade1)
        {
            Console.WriteLine("Resultado: o segundo aluno é o mais velho e o primeiro é o mais novo.");
        }
        else
        {
            Console.WriteLine("Resultado: ambos os alunos têm a mesma idade.");
        }


        Console.WriteLine($"Diferença de idade: {Math.Abs(idade1 - idade2)} ano(s).");
    }
}