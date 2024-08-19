using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoAcertouPerdeu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Código fonte jogo acertou perdeu;

                int vez = 1, li = 1, ls = 100, palpite, qtd_jogadores;
                 bool acertou = false;

            Console.WriteLine("Bem-vindo ao Jogo do Acertou: Perdeu! - Versão Final");

                Random num_aleatorio = new Random();
                int num_oculto = num_aleatorio.Next(1, 100); 

                do{             
                    Console.Write("Digite a quantidade de jogadores: ");
                    qtd_jogadores = int.Parse(Console.ReadLine());
                }while(qtd_jogadores < 2 || qtd_jogadores > 5);

                String[] nm_j = new String[qtd_jogadores]; 

                do{
                    Console.WriteLine("Digite os nomes dos jogadores: ");
                    nm_j = Console.ReadLine();
                }while(nm_j.lenght == qtd_jogadores);

                while (!acertou)
                {
                    Console.Write($"Jogador {vez}, digite seu palpite: ");
                    palpite = int.Parse(Console.ReadLine());

                    if (palpite == num_oculto)
                    {
                        //Console.Write(num_oculto);
                        Console.WriteLine($"Acertou! Jogador {vez} perdeu!");
                        acertou = true;
                    }else if (palpite < 1 || palpite > 100)
                    {
                        Console.WriteLine("Errado! O palpipe precisar se um número de 1 à 100. ");
                        break;
                     }
                    else
                    {
                        Console.WriteLine($"Errado! Tente novamente. Jogador {vez}");
                        vez = vez % qtd_jogadores + 1;
                    }
                }
        }
    }
}
