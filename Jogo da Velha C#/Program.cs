using Jogo_da_Velha_C_;




    {
        Jogador jogador1 = new Jogador();
        jogador1.nome = "Jogador 1";
        jogador1.simbolo = "X";

        Jogador jogador2 = new Jogador();
        jogador2.nome = "Jogador 2";
        jogador2.simbolo = "o";

        Tabuleiro tabuleiro = new Tabuleiro();
        tabuleiro.Inicializar();
        
         
        bool vezDoJogador1 = true;
       

        while (true)
        {   
            Console.Clear();
            tabuleiro.Exibir();

            Jogador jogadorDaVez = vezDoJogador1 ? jogador1 : jogador2;

            Console.WriteLine($"Vez do {jogadorDaVez.nome} ({jogadorDaVez.simbolo})");

            Console.Write("Digite a linha (0 a 2): ");
            int linha = int.Parse(Console.ReadLine());

            Console.Write("Digite a coluna (0 a 2): ");
            int coluna = int.Parse(Console.ReadLine());

            if (!tabuleiro.Jogar(linha, coluna, jogadorDaVez.simbolo))
            {
                Console.WriteLine("Jogada inválida! Pressione qualquer tecla para tentar novamente...");
                Console.ReadKey();
                continue;
            }

            if (tabuleiro.VerificarVitoria(jogadorDaVez.simbolo))
            {
                Console.Clear();
                tabuleiro.Exibir();
                Console.WriteLine($"O jogador {jogadorDaVez.nome} venceu!");
                break;
            }

            if (tabuleiro.VerificarEmpate())
            {
                Console.Clear();
                tabuleiro.Exibir();
                Console.WriteLine("O jogo terminou empatado!");
                break;
            }

            vezDoJogador1 = !vezDoJogador1;
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }

        
    