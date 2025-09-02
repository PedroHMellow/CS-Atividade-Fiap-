using System;

namespace MyApp
{
    internal class Program
    {
        static double CalcularAreaCirculo(double raio)
        {
            return Math.PI * Math.Pow(raio, 2);
        }

        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o raio do círculo: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            double area = CalcularAreaCirculo(raio);

            Console.WriteLine($"{nome}, a área do círculo é: {area:F2}");
        }
    }
}