using System;

namespace MyApp
{
    internal class Program
    {
        /// <summary>
        /// Esse método recebe dois números.
        /// </summary>
        /// <param name="num1">O primeiro número.</param>
        /// <param name="num2">O segundo número.</param>
        /// <returns>A soma dos dois números.</returns>
        static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// Esse método gera uma saudação personalizada para o usuário.
        /// </summary>
        /// <param name="Usuario">O nome do usuário.</param>
        /// <returns>Uma string de saudação.</returns>
        static string Saudacao(string Usuario)
        {
            return $"Olá, {Usuario}! Bem-vindo!";
        }

        /// <summary>
        /// Calcula a área de um retângulo.
        /// </summary>
        /// <param name="Altura">O comprimento do retângulo.</param>
        /// <param name="Base">A largura do retângulo.</param>
        /// <returns>A área do retângulo.</returns>
        static double CalculateRectangleArea(double Altura, double Base)
        {
            return Altura * Base;
        }

        /// <summary>
        /// Calcula a área de um triângulo.
        /// </summary>
        /// <param name="BaseTriangulo">A base do triângulo.</param>
        /// <param name="AlturaTriangulo">A altura do triângulo.</param>
        /// <returns>A área do triângulo.</returns>
        static double CalculateTriangleArea(double BaseTriangulo, double AlturaTriangulo)
        {
            return (BaseTriangulo * AlturaTriangulo) / 2;
        }

        /// <summary>
        /// Multiplica dois inteiros e retorna o resultado.
        /// </summary>
        /// <param name="a">Primeiro inteiro.</param>
        /// <param name="b">Segundo inteiro.</param>
        /// <returns>O produto dos inteiros.</returns>
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Multiplica dois números decimais e retorna o resultado.
        /// </summary>
        /// <param name="a">Primeiro double.</param>
        /// <param name="b">Segundo double.</param>
        /// <returns>O produto dos doubles.</returns>
        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Testando os métodos criados ===\n");

            Console.WriteLine("Soma: 5 + 7 = " + AddNumbers(5, 7));

            Console.WriteLine(Saudacao("Pedro"));

            Console.WriteLine("Área do retângulo (5 x 3): " + CalculateRectangleArea(5, 3));
            Console.WriteLine("Área do triângulo (base 10, altura 4): " + CalculateTriangleArea(10, 4));

            Console.WriteLine("Multiplicação int: 4 * 6 = " + Multiply(4, 6));
            Console.WriteLine("Multiplicação double: 4.5 * 2.2 = " + Multiply(4.5, 2.2));

            Console.WriteLine("\n=== Fim dos testes ===");
        }
    }
}