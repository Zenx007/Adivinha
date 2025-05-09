using System;

namespace adivinhar
{
    class JogoAdivinha
    {
        static void Main()
        {
            Console.WriteLine("Bem-vindo ao jogo!!! Tente acertar o número certo!");
            Console.WriteLine("O número que estou pensando está entre 1 e 100. Tente adivinhar!");

            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int tentativa;
            int tentativasRestantes = 10;

            while (tentativasRestantes > 0)
            {
                Console.Write($"\nVocê tem {tentativasRestantes} tentativa(s). Digite seu palpite: ");
                if (!int.TryParse(Console.ReadLine(), out tentativa))
                {
                    Console.WriteLine("Por favor, insira um número válido.");
                    continue;
                }

                if (tentativa == numeroSecreto)
                {
                    Console.WriteLine("Parabéns! Você acertou o número!");
                    break;
                }
                else if (tentativa < numeroSecreto)
                {
                    Console.WriteLine("Muito baixo!");
                }
                else
                {
                    Console.WriteLine("Muito alto!");
                }

                tentativasRestantes--;
            }

            if (tentativasRestantes == 0)
            {
                Console.WriteLine($"\nSuas tentativas acabaram! O número era: {numeroSecreto}");
            }

            Console.WriteLine("Obrigado por jogar!");
        }
    }
}