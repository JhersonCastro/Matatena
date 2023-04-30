using System;
namespace Matatena
{

    public class mechanics
    {
        public static void SetPositionOnTheBoard(Player player, int value)
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

        public static void isAPosibleAttack(Player Attacker, Player Enemy)
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
                    {
                        Enemy.Board[i, 0] = 0;
                        Console.WriteLine("El valor " + arrAttaker1[i] + " se repite en las posiciones " + i + " y " + j);
                    }

                    if (arrAttaker2[i] == arrEnemy2[j] && arrEnemy2[j] != 0)
                    {
                        Enemy.Board[(i), 1] = 0;
                        Console.WriteLine("El valor " + arrAttaker2[i] + " se repite en las posiciones " + i + " y " + j);
                    }
                    if (arrAttaker3[i] == arrEnemy3[j] && arrEnemy3[j] != 0)
                    {
                        Enemy.Board[(i), 2] = 0;
                        Console.WriteLine("El valor " + arrAttaker3[i] + " se repite en las posiciones " + i + " y " + j);
                    }
                }
            }

        }

    }
}