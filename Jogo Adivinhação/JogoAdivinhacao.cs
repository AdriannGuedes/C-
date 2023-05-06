using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogo_Adivinhação
{
    public class JogoAdivinhacao : IJogoAdivinhacao
    {
        private readonly INumeroAleatorio numeroAleatorio;
        private readonly IJogador jogador;

        public JogoAdivinhacao(INumeroAleatorio numeroAleatorio, IJogador jogador)
        {
            this.numeroAleatorio = numeroAleatorio;
            this.jogador = jogador;
        }

        public void Jogar()
        {
            INumeroAleatorio geradorNumeroAleatorio = new GeradorNumeroAleatorio();
            int numeroAleatorio = geradorNumeroAleatorio.Gerar(1,100);

            while (true)
            {
                int numeroJogador = jogador.TenteAdivinhar();

                if (numeroJogador == numeroAleatorio)
                {
                    Console.WriteLine("Parabens, você acertou o número");
                    break;
                }
                Console.WriteLine(numeroJogador < numeroAleatorio? "O número é maior" : "O número é menor");
            }
        }
    }
}