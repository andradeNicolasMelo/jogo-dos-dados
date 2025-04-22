internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            int linhaDeChegada = 30;
            int posicaoJogador = 0;
            string[] posicaoMarcadaJogador = new string[linhaDeChegada];
            int posicaoComputador = 0;
            string[] posicaoMarcadaComputador = new string[linhaDeChegada];
            string posicaoDoComputador = string.Join("", posicaoMarcadaComputador);

            bool jogoRodando = true;

            while (jogoRodando)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Vez do Jogador jogar o dado");

                //Dado vai ser jogado
                int jogadorJogouDado = Dado();
                Console.WriteLine($"O numero deu: {jogadorJogouDado}");
                Console.WriteLine();

                //Competidor vai andar pela linha de chegada e o resultado sera mostrado
                posicaoJogador += jogadorJogouDado;

                if (jogadorJogouDado == 6)
                {
                    Console.WriteLine($"O Dado caiu na posição 6, você tem direito a mais 1 jogada");
                    jogadorJogouDado = Dado();
                    posicaoJogador += jogadorJogouDado;
                }

                Console.WriteLine();

                if (posicaoJogador == 5 || posicaoJogador == 10 || posicaoJogador == 15)
                {
                    Console.WriteLine($"Sua posição é {posicaoJogador}, mova 3 casas a mais");
                    posicaoJogador += 3;
                }

                else if (posicaoJogador == 7 || posicaoJogador == 13 || posicaoJogador == 20)
                {
                    Console.WriteLine($"Sua posição é {posicaoJogador}, recue 2 casas");
                    posicaoJogador -= 2;
                }

                if (posicaoJogador < linhaDeChegada)
                {
                    Console.WriteLine($"O jogador andou {posicaoJogador} casas! A linha de chegada esta na casa {linhaDeChegada}");
                }
                else
                {
                    Console.WriteLine($"Parabens! Você ganhou o jogo");
                    jogoRodando = false;
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("");

                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Vez do Computador jogar o dado");

                //Dado vai ser jogado
                int computadorJogouDado = Dado();
                Console.WriteLine($"O numero deu: {computadorJogouDado}");
                Console.WriteLine();

                //Competidor vai andar pela linha de chegada e o resultado sera mostrado
                posicaoComputador += computadorJogouDado;

                if (computadorJogouDado == 6)
                {
                    Console.WriteLine($"O Dado caiu na posição 6, o computador tem direito a mais 1 jogada");
                    computadorJogouDado = Dado();
                    posicaoComputador += computadorJogouDado;
                }

                Console.WriteLine();

                if (posicaoComputador == 5 || posicaoComputador == 10 || posicaoComputador == 15)
                {
                    Console.WriteLine($"Posição do computador é {posicaoComputador}, computador será movido 3 casas a mais");
                    posicaoComputador += 3;
                }

                else if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 20)
                {
                    Console.WriteLine($"Posição do computador é {posicaoComputador}, computador será recuado 2 casas");
                    posicaoComputador -= 2;
                }

                if (posicaoComputador < linhaDeChegada)
                {
                    Console.WriteLine($"O computador andou {posicaoComputador} casas! A linha de chegada esta na casa {linhaDeChegada}");
                }
                else
                {
                    Console.WriteLine($"Lamento, O computador chegou na linha de chegada");
                    jogoRodando = false;
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("");

                GeradorDaLinha(posicaoMarcadaJogador, posicaoMarcadaComputador, posicaoJogador,posicaoComputador);


                Console.WriteLine("Clique ENTER para continuar");

                Console.ReadLine();
            }
        }
    }

    static int Dado()
    {
        return new Random().Next(1,7);
    }

    static void GeradorDaLinha(string[] jogador, string[] computador, int posicaoJogador, int posicaoComputador)
    {
        for (int i = 0; i < computador.Length; i++)
        {
            jogador[i] = "-";
            computador[i] = "-";
        }

        jogador[posicaoJogador - 1] = "v";
        computador[posicaoComputador - 1] = "c";
        string posicaoDoJogador = string.Join("", jogador);
        string posicaoDoComputador = string.Join("", computador);
        Console.WriteLine($"Você:       {posicaoDoJogador}");
        Console.WriteLine($"Computador: {posicaoDoComputador}");
    }

 
}