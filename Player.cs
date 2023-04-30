using System;
using System.Collections.Generic;
namespace Matatena
{

    public class Player
    {
        public string NickName = "User";
        public int[,] Board = new int[3, 3];

        public double Score()
        {
            /*Score tiene varios parametros al momento de puntear estos son:
            - Casillas en blanco cuentan como 0
            - El número de cada columna será elevado a la cantidad de duplicados haya en esa columna
                -Sí tengo numeros diferentes solo se sumaran con los numeros de esta misma columna
                -Sí tengo 2 o 3 números de igual valor este numero se elevara la cantidad de veces que este 
                    duplicado en esa columna
                -Al final se sumara el resultado dado por cada columna
            */
            double result = 0;

            for (int i = 0; i < Board.GetLength(0); i++)
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    if (dict.ContainsKey(Board[i, j]))
                        dict[Board[i, j]]++;
                    else
                        dict[Board[i, j]] = 1;
                }
                foreach (KeyValuePair<int, int> pair in dict)
                {
                    if (pair.Value > 1)
                    {
                        if (pair.Key == 1)
                            result += pair.Key * pair.Value;
                        else
                            result += Math.Pow(pair.Key, pair.Value);
                    }
                    else if (pair.Value == 1)
                        result += pair.Key;
                }
            }
            return result;
        }
        public bool isFull()
        {
            int count = 0;
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    if (Board[i, j] >= 1 && Board[i, j] <= 6)
                        count++;
                }
            }
            Console.WriteLine(NickName + count);
            return count == 9 ? true : false;
        }
    }
}