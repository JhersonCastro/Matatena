using System;
namespace Matatena
{

    public class mechanics
    {
        static void SetPositionOnTheBoard(Player player, int value)
        {
            int c, f, hasEmpty = 0;
            do
            {
                c = (int)Styles.GetNumber("Dime en que columna quieres posicionar 1, 2, 3", 1, 3); c--;
                for (int i = 0; i < player.Board.GetLength(0); i++)
                    hasEmpty = player.Board[i, c] != 0 ? hasEmpty++ : hasEmpty;
                if (hasEmpty == 3)
                {
                    Console.WriteLine("¡No hay espacio aquí, busca otra fila!");
                    continue;
                }
                f = (int)Styles.GetNumber("Dime en que fila quieres posicionar 1, 2, 3", 1, 3); f--;
                if (player.Board[c, f] != 0)
                {
                    Console.WriteLine("¡Espacio ocupado!");
                    continue;
                }
                break;
            } while (true);
            player.Board[c, f] = value;
            Console.WriteLine("Se ha guardado el número: " + value + "En la columna " + (c++) + " fila " + (f++) + " SATISFACTORIAMENTE.");
        }

        static void isAPosibleAttack(Player Attacker, Player Enemy)
        {
            int[] arrAttaker1 = new int[3];
            int[] arrEnemy1 = new int[3];
            int[] arrAttaker2 = new int[3];
            int[] arrEnemy2 = new int[3];
            int[] arrAttaker3 = new int[3];
            int[] arrEnemy3 = new int[3];

            for (int i = 0; i < Attacker.Board.GetLength(0); i++)
            {
                arrAttaker1[i] = Attacker.Board[i, 0];
                arrEnemy1[i] = Enemy.Board[i, 0];
                arrAttaker2[i] = Attacker.Board[i, 1];
                arrEnemy2[i] = Enemy.Board[i, 1];
                arrAttaker3[i] = Attacker.Board[i, 2];
                arrEnemy3[i] = Enemy.Board[i, 2];
            }
            for (int i = 0; i < arrAttaker1.Length; i++)
            {
                for (int j = 0; j < arrEnemy1.Length; j++)
                {
                    if (arrAttaker1[i] == arrEnemy1[j] && arrEnemy1[j] != 0)
                        Enemy.Board[j, 0] = 0;
                    if (arrAttaker2[i] == arrEnemy2[j] && arrEnemy2[j] != 0)
                        Enemy.Board[j, 1] = 0;
                    if (arrAttaker3[i] == arrEnemy3[j] && arrEnemy3[j] != 0)
                        Enemy.Board[j, 2] = 0;
                }
            }

        }
        public static void GameLogic(Player player1, Player player2){
            Console.WriteLine(player1.NickName + " Turn!");
            Program.CurrentNumber = new Random().Next(1,6);
            Console.WriteLine(player1.NickName + " has rolled a value of " + Program.CurrentNumber + " on the dice!");
            Styles.PrintBoard(player1.Board);
            SetPositionOnTheBoard(player1, Program.CurrentNumber);
            Styles.PrintBoard(player1.Board);
            
            isAPosibleAttack(player1, player2);
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
        }
    }
}