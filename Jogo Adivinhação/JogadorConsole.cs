using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogo_Adivinhação
{
    public class JogadorConsole : IJogador
    {
        public int TenteAdivinhar()
        {
            Console.WriteLine("Digite um número entre 1 e 100: ");
            string entrada = Console.ReadLine();

            if(!int.TryParse(entrada, out int numero))
            {
                Console.WriteLine("Número inválido, tente um número válido");
                return TenteAdivinhar();
            }
            return numero;
        }
    }
}