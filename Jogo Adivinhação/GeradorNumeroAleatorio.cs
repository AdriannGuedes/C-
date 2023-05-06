using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogo_Adivinhação
{
    public class GeradorNumeroAleatorio : INumeroAleatorio
    {
        private readonly Random random = new Random();
        public int Gerar(int minimo, int maximo)
        {
            return random.Next(minimo,maximo +1);
        }
    }
        
    
}