using System;
using System.Threading;
namespace Matatena
{
    class Program
    {

        static void Main(string[] args)
        {
            for (double y = 1.5; y > -1.5; y -= 0.1)
        {
            for (double x = -1.5; x < 1.5; x += 0.05)
            {
                double a = x * x + y * y - 1;
                Console.Write(a * a * a - x * x * y * y * y <= 0.0 ? "*" : " ");
            }
            Console.WriteLine();
        }
            Random die = new Random();
            int CurrentNumber = 0;
            Player player1 = new Player();
            Console.WriteLine("Tell me your name, player 1");
            player1.NickName = Console.ReadLine();

            Player player2 = new Player();
            Console.WriteLine("Tell me your name, player 2");
            player2.NickName = Console.ReadLine();
            
            
            Styles.PrintBoard(player1.Board);
            System.Console.WriteLine("============================================");
            Styles.PrintBoard(player2.Board);
            mechanics.isAPosibleAttack(player1, player2);
            
            System.Console.WriteLine("============================================");
            Styles.PrintBoard(player1.Board);
            System.Console.WriteLine("============================================");
            Styles.PrintBoard(player2.Board);
            do
            {
                mechanics.isAPosibleAttack(player2, player1);
                mechanics.isAPosibleAttack(player1, player2);
                mechanics.isAPosibleAttack(player2, player1);
                mechanics.isAPosibleAttack(player1, player2);
                if (player1.isFull() || player2.isFull())
                    break;
                
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
                Console.WriteLine("¡EMPATE!");
        }
    }
}


Daniela, se que te molesta que no te haya dado verga por 2 años, pero parametros
:;D y arregla mi codigo mujer