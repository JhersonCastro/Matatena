using System;
using System.Collections.Generic;
namespace Matatena
{

    public class Player
    {
        public string NickName = "User";
        public int[,] Board = new int[3, 3];
        public void SetPositionOnTheBoard(int value)
        {
            int c, f, hasEmpty = 0;
            do
            {
                c = Styles.GetNumber("Dime en que columna quieres posicionar 1, 2, 3", 1, 3); c--;
                for (int i = 0; i < Board.GetLength(0); i++)
                    hasEmpty = Board[i, c] != 0 ? hasEmpty++ : hasEmpty;
                if (hasEmpty == 3){
                    Console.WriteLine("¡No hay espacio aquí, busca otra fila!");
                    continue;
                }
                f = Styles.GetNumber("Dime en que fila quieres posicionar 1, 2, 3", 1, 3); f--;
                if (Board[c, f]!=0)
                {
                    Console.WriteLine("¡Espacio ocupado!");
                    continue;
                }
                break;
            } while (true);
            Board[c,f] = value;
            Console.WriteLine("Se ha guardado el número: "+ value + "En la columna "+ c + " fila "+ f+ " SATISFACTORIAMENTE.");
        }
        public void PrintBoard()
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