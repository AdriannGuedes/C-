using Cadastro_de_carros_c_;

// Car carro = new Car("Uno", "Fiat", "Cinza", 2009, 0);
// Car carro1 = new Car("Fusca", "Volks", "Vermelho", 1973, 1);
// Car carro2 = new Car("Palio", "Fiat", "Preto", 2009, 2);


// CarRepository carRepository = new CarRepository();
// //"controle do banco"

// carRepository.Create(carro);
// carRepository.Create(carro1);
// carRepository.Create(carro2);

// foreach (var item in carRepository.GetAll())
// {
//     Show($"O carro é {item.Modelo} e a marca é {item.Marca}");
//     //mostrar os carros da lista
// }


// for (int i=0; i<CarRepository.carros.Count; i++)
// {
//     if (CarRepository.carros[i].Id==2)
//     {
//         Show(CarRepository.carros[i].Modelo);
//     }
//     //modo de buscar pelo Id desejado na lista de objetos com FOR
    
// }

// foreach (var item in CarRepository.carros)
// {
//     if (item.Id==2)
//     {
//         Show(item.Modelo);
//     }
//     //modo de buscar o Id desejado com FOREACH
// }

// Show(CarRepository.carros.Find(x=>x.Id==2).Modelo);
// //modo de buscar o Id desejado com LAMBDA

CarRepository carRepository = new CarRepository();

int op;
int resetop=1;

while (resetop!=0)
{
    Show($"Bem vindo ao seu estacionamento");
    Show($"Selecione uma opção para continuar:");
    Show($"1-Adicionar carro  2-Listar todos os carros 3-Conferir um carro 4-Atualizar carro 5-Remover um carro 0-Sair do estacionamento");
    op=Convert.ToInt32(Console.ReadLine());

    switch (op)
    {
        case 1:
        Limpar();
        Show("Digite a placa do carro:");
        string Placa = Input();
        Show("Digite o Modelo do carro: ");
        string Modelo = Input();
        Show("Digite a Marca do carro:");
        string Marca = Input();
        Show("Digite a Cor do carro:");
        string Cor = Input();
        carRepository.CadastrarCarro(Placa, Modelo, Marca, Cor);
        break;

        case 2:
        List<Car>listcars = carRepository.GetAll();
        foreach (Car carro in listcars)
        {
            Show($"Placa: {carro.Placa} | Modelo: {carro.Modelo} | Marca: {carro.Marca} | Cor: {carro.Cor}");
            
        }

        break;

        case 3:
        Show("Digite a placa do carro que deseja conferir se está no estacionamento:");
        string placa = Input();
        carRepository.GetByPlaca(placa);

        break;

        case 4:
        Show("Digite a placa do carro que você deseja atualizar:");
        string exist= Input();
        if(carRepository.ConferirExist(exist)!= null)
        {
            Show("Digite a nova placa do carro:");
            string newPlaca = Input();
            Show("Digite o novo modelo do carro:");
            string newModelo = Input();
            Show("Digite a nova marca do carro:");
            string newMarca = Input();
            Show("Digite a nova cor do carro:");
            string newCor = Input();
            carRepository.AtualizarCar(exist,newPlaca,newModelo,newMarca,newCor);

        }
        break;

        case 5:
        Show("Digite a placa do carro que deseja remover do estacionamento:");
        string placaa = Input();
        if (carRepository.ConferirExist(placaa)!=null)
        {
            carRepository.DeletarCarro(placaa);
        }

        break;






       
        
        
    }

    

    
}




void Show(string texto)
{
    Console.WriteLine(texto);
}

string Input()
{
    
    return Console.ReadLine();
}

void Limpar()
{
    Console.Clear();
}


