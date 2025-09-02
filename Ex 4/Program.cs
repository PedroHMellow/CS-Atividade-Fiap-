using System;

namespace MyApp
{
    internal class Program
    {
        
        static int LerInteiro(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out int num) && num >= min && num <= max)
                    return num;
                Console.WriteLine($"Digite um inteiro entre {min} e {max}.");
            }
        }

        static char LerCaractere(string prompt, char padrao = '*')
        {
            Console.Write(prompt);
            string s = Console.ReadLine();
            return string.IsNullOrEmpty(s) ? padrao : s[0];
        }

        // --------- Triângulo (centrado) ---------
        
        static void DesenharTriangulo(int linhas, char ch)
        {
            for (int i = 1; i <= linhas; i++)
            {
                Console.Write(new string(' ', linhas - i));
                Console.WriteLine(new string(ch, 2 * i - 1));
            }
        }

        // --------- Losango (diamante) ---------
        
        static void DesenharLosango(int linhas, char ch)
        {
           
            for (int i = 1; i <= linhas; i++)
            {
                Console.Write(new string(' ', linhas - i));
                Console.WriteLine(new string(ch, 2 * i - 1));
            }
           
            for (int i = linhas - 1; i >= 1; i--)
            {
                Console.Write(new string(' ', linhas - i));
                Console.WriteLine(new string(ch, 2 * i - 1));
            }
        }

        // --------- Cubo ASCII (wireframe simples) ---------
        
        static void DesenharCubo(int n, int off, char chBorda = '#')
        {
            
            Console.WriteLine(new string(' ', off) + "+" + new string('-', n) + "+");

           
            for (int i = 0; i < off; i++)
            {
                Console.Write(
                    new string(' ', off - 1 - i) + "/" + new string(' ', n) + "/" + new string(' ', i)
                );
                Console.WriteLine("|");
            }

            
            Console.WriteLine("+" + new string('-', n) + "+" + new string(' ', off) + "|");

           
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("|" + new string(' ', n) + "|" + new string(' ', off) + "|");
            }

            
            Console.WriteLine("+" + new string('-', n) + "+" + new string(' ', off) + "+");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Desenho com estruturas repetidas (for/while) ===");
            Console.WriteLine("1) Triângulo");
            Console.WriteLine("2) Cubo (ASCII 3D simples)");
            Console.WriteLine("3) Losango");
            Console.WriteLine("0) Sair");

            while (true)
            {
                int opc = LerInteiro("\nEscolha uma opção: ", 0, 3);
                if (opc == 0) break;

                switch (opc)
                {
                    case 1: 
                        {
                            int linhas = LerInteiro("Quantidade de linhas (1..40): ", 1, 40);
                            char ch = LerCaractere("Caractere para desenhar (ENTER = *): ", '*');
                            Console.WriteLine();
                            DesenharTriangulo(linhas, ch);
                            break;
                        }
                    case 2: 
                        {
                            int n = LerInteiro("Tamanho da face (largura/altura) 3..30: ", 3, 30);
                            int off = LerInteiro("Profundidade (deslocamento) 2..15: ", 2, 15);
                            Console.WriteLine();
                            DesenharCubo(n, off);
                            break;
                        }
                    case 3: 
                        {
                            int linhas = LerInteiro("Metade superior (linhas) 1..30: ", 1, 30);
                            char ch = LerCaractere("Caractere para desenhar (ENTER = *): ", '*');
                            Console.WriteLine();
                            DesenharLosango(linhas, ch);
                            break;
                        }
                }
            }

            Console.WriteLine("\nFim. :)");
        }
    }
}
