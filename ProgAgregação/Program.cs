using System;

namespace ProjFutebol_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time1 = new Time("Parmeirass");
            time1.contratarJogador(new Jogador("Alex",     20, 99, 1));
            time1.contratarJogador(new Jogador("Pedro",    22, 96, 2));
            time1.contratarJogador(new Jogador("Leandro",  27, 91, 3));
            time1.contratarJogador(new Jogador("Bruno",    21, 99, 4));
            time1.contratarJogador(new Jogador("Jorge",    23, 99, 5));
            time1.contratarJogador(new Jogador("Eleno",    30, 99, 6));
            time1.contratarJogador(new Jogador("Rodrigo",  33, 99, 7));
            time1.contratarJogador(new Jogador("Antônio",  29, 99, 8));
            time1.contratarJogador(new Jogador("Miguel",   25, 99, 9));
            time1.contratarJogador(new Jogador("Luciano",  28, 99, 10));
            time1.contratarJogador(new Jogador("Alencar",  38, 99, 11));

            Time time2 = new Time("Boa Esporte");
            time1.contratarJogador(new Jogador("Juliano",  20, 99, 1));
            time1.contratarJogador(new Jogador("Matias",   22, 96, 2));
            time1.contratarJogador(new Jogador("Roberto",  27, 91, 3));
            time1.contratarJogador(new Jogador("Carlos",   21, 99, 4));
            time1.contratarJogador(new Jogador("Renato",   23, 99, 5));
            time1.contratarJogador(new Jogador("Fabiano ", 30, 99, 6));
            time1.contratarJogador(new Jogador("Regis ",   33, 99, 7));
            time1.contratarJogador(new Jogador("Otávio",   29, 99, 8));
            time1.contratarJogador(new Jogador("Marcio",   25, 99, 9));
            time1.contratarJogador(new Jogador("Wilson",   28, 99, 10));
            time1.contratarJogador(new Jogador("Marcos",   38, 99, 11));

            Partida p1 = new Partida(DateTime.Now, time1, time2);
            p1.jogar();
            Console.WriteLine(p1.getPalacar());

            Console.WriteLine(time1.getStatus());
            time1.getDescricaoJogadores();

            Console.WriteLine("--------------------------------");

            Console.WriteLine(time2.getStatus());
            time2.getDescricaoJogadores();

            Console.ReadKey();

        }
    }
}
