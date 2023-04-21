using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_de_carros_c_
{
    public class CarRepository
    {
        public static List<Car> listcars = new List<Car>();
        //lista de objetos

        public List<Car>GetAll()
        {
            return listcars;
            //método que lista todos os carros
        }

        public Car GetByPlaca(string placa)
        {
            var ConferindoCarro = listcars.Find(ca=>ca.Placa==placa);
            if (ConferindoCarro!=null)
            {
                Console.WriteLine($"Placa: {ConferindoCarro.Placa} | Modelo: {ConferindoCarro.Modelo} | Marca: {ConferindoCarro.Marca} | Cor: {ConferindoCarro.Cor} ");
            }
            else
            {
                Console.WriteLine("Placa inexistente");
            }
            return ConferindoCarro;
            //método que retorna apenas um carro através da placa
        }

        public bool UnicPlaca(string placa)
        {
            return listcars.Any(exist=>exist.Placa ==placa);

        }
        public void CadastrarCarro(string modelo, string marca, string cor, string placa)
        {
            Car newcar = new Car(modelo, marca,  cor, placa);
            
            if(UnicPlaca(newcar.Placa))
            {
                Console.WriteLine("Já Possui um carro com esta placa");
            }
            listcars.Add(newcar);
            Console.WriteLine("Carro cadastrado!");

        }

        public Car ConferirExist(string placa)
        {
            var exist = listcars.Find(plac=>plac.Placa==placa);
            if (exist==null)
            {
                Console.WriteLine("Não existe carro com esta placa no estacionamento");
            }
            return exist;
        }

        public void AtualizarCar(string placa, string newPlaca, string newModelo, string newMarca, string newCor)
        {
            int checkPlaca = listcars.FindIndex(check=>check.Placa==placa);

            if (checkPlaca==-1)
            {
                Console.WriteLine("Não existe carro com esta placa no estacionamento");
            }
            if (UnicPlaca(newPlaca))
            {
                Console.WriteLine("Já existe um carro com essa placa no estacionamento");
                return;
            }
            listcars[checkPlaca].AtualizarCarro(newPlaca,newModelo,newMarca,newCor);
            Console.WriteLine("Carro atualizado:");
            Console.WriteLine("Placa: "+newPlaca+" | Modelo: "+newModelo+" | Marca: "+newMarca+" | Cor: "+newCor+"");

        }

        public void DeletarCarro(string placa)
        {
            Car carRemoval= null;

            foreach (Car carroPLaca in listcars)
            {
                if (carroPLaca.Placa==placa)
                {
                    carRemoval=carroPLaca;
                    break;
                }
            }
            if (carRemoval!=null)
            {
                listcars.Remove(carRemoval);
                Console.WriteLine("Carro removido do sistema");
            }

        }
    }
}