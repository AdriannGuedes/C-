using Jogo_Adivinhação;

INumeroAleatorio geradorNumeroAleatorio = new GeradorNumeroAleatorio();
IJogador jogador = new JogadorConsole();
IJogoAdivinhacao jogo = new JogoAdivinhacao(geradorNumeroAleatorio, jogador);
jogo.Jogar();
        
    