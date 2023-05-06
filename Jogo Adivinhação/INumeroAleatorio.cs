using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogo_Adivinhação
{
    public interface INumeroAleatorio
    {
        int  Gerar(int minimo, int maximo);
    }
}