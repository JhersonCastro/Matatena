using System;
namespace Matatena
{

    public class Styles
    {

        public static double GetNumber(string label, int min, int max)
        {
            double rtn = 0.0;
            Console.WriteLine(label);
            do
            {
                Console.WriteLine("¡Quedate en los limites!, min:" + min + " max:" + max);
                while (true)
                {
                    try
                    {
                        Console.WriteLine(label);
                        rtn = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Es un número, imbecil:3");
                    }
                }
            } while (rtn < min || rtn > max);

            return rtn;
        }
        public static void PrintBoard(int[,] Board)
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Console.Write(Board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}