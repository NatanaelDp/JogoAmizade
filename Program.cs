using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAmizade
{
    internal class Program
    {
        static List<int> placar = new List<int>();

        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Jogo da Amizade!");
            while (true)
            {
                int pontosTotais = 0;

                Console.WriteLine("\nPressione qualquer tecla para jogar um novo jogo");
                Console.ReadKey();
                Console.WriteLine();

                while (true)
                {
                    int dado = JogarDado();
                    pontosTotais += dado;

                    Console.WriteLine("Você jogou o dado e conseguiu: " + dado);
                    Console.WriteLine("Total de pontos: " + pontosTotais);

                    if (pontosTotais == 21)
                    {
                        Console.WriteLine("\nParabéns, você fez 21 pontos!");
                        break;
                    }

                    if (pontosTotais > 21)
                    {
                        Console.WriteLine("\nVocê estourou 21 pontos! Fim de jogo.");
                        break;
                    }

                    Console.WriteLine("\nDeseja jogar novamente? (s/n)");
                    if (Console.ReadLine()!= "s")
                        break;
                }

                placar.Add(pontosTotais);
                Console.WriteLine("\nPlacar atual: " + string.Join(", ", placar));

                Console.WriteLine("\nDeseja jogar outro jogo? (s/n)");
                if (Console.ReadLine() != "s")
                    break;
            }

            Console.WriteLine("\nObrigado por jogar. Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }

        static int JogarDado()
        {
            Random sorteio = new Random();
            return sorteio.Next(1, 7);
        }
    }
}



