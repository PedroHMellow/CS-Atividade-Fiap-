using System;

class Program
{
    static void Main(string[] args)
    {
       
        int[] numerosSecretos = { 3, 8, 11, 14, 19, 22, 27 };

        while (true)
        {
            Console.Write("Digite seu palpite (número negativo para sair): ");
            int palpite = int.Parse(Console.ReadLine());

            
            if (palpite < 0)
            {
                Console.WriteLine("Programa encerrado. Até mais!");
                return;
            }

            bool acertou = false; 

           
            foreach (int numero in numerosSecretos)
            {
                
                if (numero % 2 == 0)
                {
                    continue;
                }

               
                if (palpite == numero)
                {
                    Console.WriteLine("Acertou!");
                    acertou = true;
                    break;
                }
            }

           
            if (!acertou)
            {
                Console.WriteLine("Não acertou, tente outro.");
            }
        }
    }
}
