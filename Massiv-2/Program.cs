using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massiv2x
{
    /* 
     * вывод двумерного массива 
     */

    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[,]
          {
                 {2,45,12,51,51},
                 {6,7,8,3,1},
                 {1,5,65,78,13},
                 {6,3,151,5,65}
          };

            int height = myArray.GetLength(0); //высота таблички 
            int width = myArray.GetLength(1); // кол. ( ширина ) инф 2 изммерения

            for (int y = 0; y < height; y++) // внешний цикл 
            {
                for (int x = 0; x < width; x++) // внутрений цикл
                {
                    Console.Write(myArray[y, x] + "\t");
                }
                Console.WriteLine();
            }


        }



    }
}
