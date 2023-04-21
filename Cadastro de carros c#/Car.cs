using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_de_carros_c_
{
    public class Car
    {
        public string Placa{get; set;}
        public string Modelo{get; set;}
        public string Marca{get; set;}
        public string Cor {get; set;}
        

        public Car( string placa, string modelo, string marca, string cor)
        {
            Placa=placa;
            Modelo=modelo;
            Marca=marca;
            Cor=cor;
           

        }

        public void AtualizarCarro(string newPlaca, string newModelo, string newMarca, string newCor)
        {
            this.Placa = newPlaca;
            this.Modelo = newModelo;
            this.Marca = newMarca;
            this.Cor = newCor;
           
        }

        

        
    }
}