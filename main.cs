using System;
using System.Threading;
namespace Matatena
{
    class Program
    {
        public static int CurrentNumber = 0;
        static void Main(string[] args)
        {
            int rdnMatch = new Random().Next(1, 6);

            Player player1 = new Player();
            Console.WriteLine("Tell me your name, player 1");
            player1.NickName = Console.ReadLine();

            Player player2 = new Player();
            Console.WriteLine("Tell me your name, player 2");
            player2.NickName = Console.ReadLine();

            do
            {
                if (player1.isFull() || player2.isFull())
                    break;
                if (rdnMatch == 1)
                {
                    mechanics.GameLogic(player1, player2);
                    mechanics.GameLogic(player2, player1);
                }
                else
                {
                    mechanics.GameLogic(player2, player1);
                    mechanics.GameLogic(player1, player2);
                }
            } while (true);
            if (player1.Score() > player2.Score())
                Console.WriteLine("El ganador fue: " + player1.NickName);
            else if (player1.Score() < player2.Score())
                Console.WriteLine("El ganador fue: " + player2.NickName);
            else
                Console.WriteLine("El ganador fue: ninguno, ¡Empate!");
        }
    }
}