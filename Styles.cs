using System;
namespace Matatena
{

    public class Styles
    {
        public static double GetNumber(string label, int min, int max){
            double rtn;
            Console.WriteLine(label);
            rtn = double.Parse(Console.ReadLine());
            while (rtn<min || rtn>max)
            {
                Console.WriteLine("¡Quedate en los limites!, min:" +min+" max:"+max);
                rtn = double.Parse(Console.ReadLine());
            }
            return rtn;
        }
    }
}