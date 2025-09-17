namespace ConsoleApp1;

//Quando o usuário abrir o jogo deverá ser solicitado o nome do primeiro e do segundo jogador.
//Não será possível jogar com mais do que dois jogadores.
//O jogo deverá solicitar um nome para cada jogador e os nome não podem ser iguais.
//O jogo terá 3 rodadas, o jogador que tirar o maior número no dados na maioria das jogadas vence a partida.
//Em caso de empate (onde os dois tiram o mesmo número) nenhum jogador pontuará.
//A cada rodada a aplicação deve informar quem foi o jogador vencedor.
//Um placar sempre deve ser exibido até o final do jogo para que os jogadores acompanhem o resultado
//Ao final da rodada 3 a aplicação deve informar quem foi o vencedor ou se foi um empate.

public class JogoDados
{
    private int partida;
    

    public static void Main(string[] args)
    {
        string jogadorUm;
        string jogadorDois;
        
        
        Console.WriteLine("========Bem-Vindo ao Jogo...=========");
        
        //Informar nomes dos jogadores
        Console.WriteLine("Informe o nome do primeiro jogador: ");
        jogadorUm = Console.ReadLine();
        
        Console.WriteLine("Informe o nome do Segundo jogador: ");
        jogadorDois = Console.ReadLine();

        //Tratação de nomes
        while (jogadorUm == jogadorDois)
        {
            Console.WriteLine("Os nomes não podem ser iguais!");
            Console.WriteLine("Informe nome do Segundo jogador: ");
            jogadorDois = Console.ReadLine();
        }

        int pontosJogador1 = 0;
        int pontosJogador2 = 0;

        Random gerador = new Random();

        //Lógica do Game
        for (int i = 1; i <= 3; i++)
        {
           int valor1 = gerador.Next(1, 7);
           int valor2 = gerador.Next(1, 7);
            
            Console.WriteLine($"O número do jogador {jogadorUm} é {valor1} o número do jogador {jogadorDois} é {valor2}");

            if (valor1 > valor2)
            {
                Console.WriteLine($"{jogadorUm} venceu a rodada {i}");
                pontosJogador1 ++;
            } else if (valor2 > valor1)
            {
                Console.WriteLine($"{jogadorDois} venceu a rodada {i}");
                pontosJogador2 ++;
            } else
            {
                Console.WriteLine($"Empate na rodada {i}.");
            }

            Console.WriteLine($"Placar: {jogadorUm} = {pontosJogador1}");
            Console.WriteLine($"Placar: {jogadorDois} = {pontosJogador2}");

            if (pontosJogador1 > pontosJogador2)
            {
                Console.WriteLine($"{jogadorUm} é campeão");
            } else if (pontosJogador2 > pontosJogador1)
            {
                Console.WriteLine($"{jogadorDois} é campeão");
            }
            else
            {
                Console.WriteLine($"Empate dos jogadores {jogadorUm} e {jogadorDois}");
            }

        }
    }
}