using System;

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

            do
            {
                Console.WriteLine(player1.NickName + " Turn!");
                CurrentNumber = die.Next(1,6);
                Console.WriteLine(player1.NickName + " has rolled a value of " + CurrentNumber + " on the dice!");
                player1.PrintBoard();
                player1.SetPositionOnTheBoard(CurrentNumber);
                player1.PrintBoard();
                Threading.Thread.Sleep(5000);
                Console.Clear();

                Console.WriteLine(player2.NickName + " Turn!");
                CurrentNumber = die.Next(1,6);
                Console.WriteLine(player2.NickName + " has rolled a value of " + CurrentNumber + " on the dice!");
                player2.PrintBoard(); 

                Threading.Thread.Sleep(5000);
                Console.Clear();
            } while (!player1.isFull() && !player2.isFull());
        }
    }
}


