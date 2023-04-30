using System;
using System.Threading;
namespace Matatena
{
    class Program
    {

        static void Main(string[] args)
        {
            Random die = new Random();
            int CurrentNumber = 0;
            Player player1 = new Player();
            Console.WriteLine("Tell me your name, player 1");
            player1.NickName = Console.ReadLine();

            Player player2 = new Player();
            Console.WriteLine("Tell me your name, player 2");
            player2.NickName = Console.ReadLine();
            
            player1.Board[0, 0] = 5;
            player1.Board[0, 1] = 2;
            player1.Board[0, 2] = 8;
            player1.Board[1, 0] = 2;
            player1.Board[1, 1] = 1;
            player1.Board[1, 2] = 6;
            player1.Board[2, 0] = 6;
            player1.Board[2, 1] = 9;
            player1.Board[2, 2] = 5;

            player2.Board[0, 0] = 4;
            player2.Board[0, 1] = 8;
            player2.Board[0, 2] = 3;
            player2.Board[1, 0] = 2;
            player2.Board[1, 1] = 4;
            player2.Board[1, 2] = 7;
            player2.Board[2, 0] = 5;
            player2.Board[2, 1] = 2;
            player2.Board[2, 2] = 5;
            Styles.PrintBoard(player1.Board);
            System.Console.WriteLine("============================================");
            Styles.PrintBoard(player2.Board);
            mechanics.isAPosibleAttack(player1, player2);
            
            System.Console.WriteLine("============================================");
            Styles.PrintBoard(player1.Board);
            System.Console.WriteLine("============================================");
            Styles.PrintBoard(player2.Board);
            /*do
            {
                Console.WriteLine(player1.NickName + " Turn!");
                CurrentNumber = die.Next(1,6);
                Console.WriteLine(player1.NickName + " has rolled a value of " + CurrentNumber + " on the dice!");
                Styles.PrintBoard(player1.Board);
                mechanics.SetPositionOnTheBoard(player1, CurrentNumber);
                Styles.PrintBoard(player1.Board);

                System.Threading.Thread.Sleep(5000);
                Console.Clear();

                Console.WriteLine(player2.NickName + " Turn!");
                CurrentNumber = die.Next(1,6);
                Console.WriteLine(player2.NickName + " has rolled a value of " + CurrentNumber + " on the dice!");
                Styles.PrintBoard(player2.Board);
                mechanics.SetPositionOnTheBoard(player2, CurrentNumber);
                Styles.PrintBoard(player2.Board);

                System.Threading.Thread.Sleep(5000);
                Console.Clear();
            } while (!player1.isFull() && !player2.isFull());

            if (player1.Score()>player2.Score())
                Console.WriteLine(player1.NickName + " es el ganador.");
            else if(player1.Score()<player2.Score())
                Console.WriteLine(player2.NickName + " es el ganador.");
            else
                Console.WriteLine("¡EMPATE!");*/
        }
    }
}


