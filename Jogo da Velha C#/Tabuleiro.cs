using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogo_da_Velha_C_
{
    
    public class Tabuleiro
    {
        private string[,] tabuleiro = new string[3, 3];
    

      public void Inicializar()
      {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tabuleiro[i, j] = " ";
            }
        }
      }

      public void Exibir(){
        Console.WriteLine("0,1,2");//indices das colunas
        for(int i=0; i<3; i++)
        {
            Console.Write(i+" ");//mostra o indice da linha
            for (int j=0; j<3; j++)
            {
                Console.Write(tabuleiro[i,j]);//exibe oq tem na posição
                if(j<2)
                {
                    Console.WriteLine("|");// exibe a barra vertical separando as colunas
                }                 
            }
            if(i<2)
            {
                Console.WriteLine("-+-+-");// exibe a linha horizontal separando as linhas
            }
        }
      }

      public bool Jogar(int linha, int coluna, string simbolo)
      {
        if(tabuleiro[linha, coluna]==" ")
        {
            tabuleiro[linha,coluna]=simbolo; // coloca o símbolo do jogador na posição escolhida
            return true;
        }
        else{
            return false;//a posição escolhida ja está ocupada
        }
      }

      public bool VerificarVitoria(string simbolo)
      {
        //verifica linhas
        for (int i=0; i<3; i++)  {
            if(tabuleiro[i,0]==simbolo && tabuleiro[i,1]==simbolo && tabuleiro[i,2]==simbolo)
            {
                return true; //jogador venceu na linha i
            }
        }

        for(int j=0; j<3; j++)
        {
            if (tabuleiro[0, j] == simbolo && tabuleiro[1, j] == simbolo && tabuleiro[2, j] == simbolo)
            {
                return true; // o jogador venceu na coluna j
            }
        }

        if (tabuleiro[0,0]==simbolo && tabuleiro[1,1]==simbolo && tabuleiro[3,3]==simbolo)
        {
            return true;//venceu na diagonal
        }
        if (tabuleiro[0, 2] == simbolo && tabuleiro[1, 1] == simbolo && tabuleiro[2, 0] == simbolo)
        {
            return true;
        }
        return false;//empate
    } 

    public bool VerificarEmpate()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (tabuleiro[i, j] == " ")
                {
                    return false;
                }
            }
        }
        return true;
    }

  }




}