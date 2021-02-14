using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxSum = 0, sum, n;              // инициализация переменных
            n = Convert.ToInt32(Console.ReadLine()); // ввод n (к-во строк)

            int[][] mass = new int[10][]; // инициализация и выдиление памяти для масива массивов
            mass[0] = new int[1] { 0 };
            mass[1] = new int[2] { 0, 0 };
            mass[2] = new int[3] { 0, 0, 0 };
            mass[3] = new int[4] { 0, 0, 0, 0 };
            mass[4] = new int[5] { 0, 0, 0, 0, 0 };
            mass[5] = new int[6] { 0, 0, 0, 0, 0, 0 };
            mass[6] = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
            mass[7] = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            mass[8] = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            mass[9] = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < n; i++)                              //
            {                                                        //
                for (int j = 0; j < mass[i].Length; j++)             // for - заполнение массива в пределах n
                {                                                    //
                    mass[i][j] = Convert.ToInt32(Console.ReadLine());//
                }
            }
            sum = mass[0][0];                                  //стартовое значение суммы -> самый первый элемент массива (самый верхний)

            int sum1, sum2, sum3, sum4, sum5, sum6, sum7, sum8, sum9, sum10, sum11, sum12, sum13, sum14, sum15;          // ГОВНОКОД ТОШИКА (начало конца)
            int sum16, sum17, sum18, sum19, sum20, sum21, sum22, sum23, sum24, sum25, sum26, sum27, sum28, sum29, sum30;
            int max1, max2, max3, max4, max5, max6, max7, max8;
            if (n <= 5)                                                 
            {
                sum1 = mass[0][0] + mass[1][0];//2
                sum2 = mass[0][0] + mass[1][1];//2
                sum3 = mass[0][0] + mass[1][0] + mass[2][0];//3
                sum4 = mass[0][0] + mass[1][0] + mass[2][1];//3
                sum5 = mass[0][0] + mass[1][1] + mass[2][1];//3
                sum6 = mass[0][0] + mass[1][1] + mass[2][2];//3
                sum7 = mass[0][0] + mass[1][0] + mass[2][0] + mass[3][0];//4
                sum8 = mass[0][0] + mass[1][0] + mass[2][0] + mass[3][1];//4
                sum9 = mass[0][0] + mass[1][0] + mass[2][1] + mass[3][1];//4
                sum10 = mass[0][0] + mass[1][0] + mass[2][1] + mass[3][2];//4
                sum11 = mass[0][0] + mass[1][1] + mass[2][2] + mass[3][2];//4
                sum12 = mass[0][0] + mass[1][1] + mass[2][2] + mass[3][3];//4
                sum13 = mass[0][0] + mass[1][1] + mass[2][1] + mass[3][1];//4
                sum14 = mass[0][0] + mass[1][1] + mass[2][1] + mass[3][2];//4
                sum15 = mass[0][0] + mass[1][0] + mass[2][0] + mass[3][0] + mass[4][0];//5
                sum16 = mass[0][0] + mass[1][0] + mass[2][0] + mass[3][0] + mass[4][1];//5
                sum17 = mass[0][0] + mass[1][0] + mass[2][0] + mass[3][1] + mass[4][1];//5
                sum18 = mass[0][0] + mass[1][0] + mass[2][0] + mass[3][1] + mass[4][2];//5
                sum19 = mass[0][0] + mass[1][0] + mass[2][1] + mass[3][1] + mass[4][1];//5
                sum20 = mass[0][0] + mass[1][0] + mass[2][1] + mass[3][1] + mass[4][2];//5
                sum21 = mass[0][0] + mass[1][0] + mass[2][1] + mass[3][2] + mass[4][2];//5
                sum22 = mass[0][0] + mass[1][0] + mass[2][1] + mass[3][2] + mass[4][3];//5
                sum23 = mass[0][0] + mass[1][1] + mass[2][1] + mass[3][1] + mass[4][1];//5
                sum24 = mass[0][0] + mass[1][1] + mass[2][1] + mass[3][1] + mass[4][2];//5
                sum25 = mass[0][0] + mass[1][1] + mass[2][1] + mass[3][2] + mass[4][3];//5
                sum26 = mass[0][0] + mass[1][1] + mass[2][1] + mass[3][2] + mass[4][2];//5
                sum27 = mass[0][0] + mass[1][1] + mass[2][2] + mass[3][2] + mass[4][2];//5
                sum28 = mass[0][0] + mass[1][1] + mass[2][2] + mass[3][2] + mass[4][3];//5
                sum29 = mass[0][0] + mass[1][1] + mass[2][2] + mass[3][3] + mass[4][3];//5
                sum30 = mass[0][0] + mass[1][1] + mass[2][2] + mass[3][3] + mass[4][4];//5

                if (n == 1)
                {
                    MaxSum = mass[0][0];

                    Console.WriteLine(MaxSum);
                }
                else if (n == 2)
                {
                    MaxSum = Math.Max(sum1, sum2);

                    Console.WriteLine(MaxSum);
                }
                else if (n == 3)
                    {
                        max1 = Math.Max(sum3, sum4);
                        max2 = Math.Max(sum5, sum6);
                        MaxSum = Math.Max(max1, max2);

                    Console.WriteLine(MaxSum);
                }
                else if (n == 4)
                {
                    max1 = Math.Max(sum7, sum8);
                    max2 = Math.Max(sum9, sum10);
                    max3 = Math.Max(sum11, sum12);
                    max4 = Math.Max(sum13, sum14);

                    max1 = Math.Max(max1, max2);
                    max2 = Math.Max(max2, max3);
                    MaxSum = Math.Max(max1, max2);

                    Console.WriteLine(MaxSum);
                }
                else if (n == 5)
                {
                    max1 = Math.Max(sum15, sum16);
                    max2 = Math.Max(sum17, sum18);
                    max3 = Math.Max(sum19, sum20);
                    max4 = Math.Max(sum21, sum22);
                    max5 = Math.Max(sum23, sum24);
                    max6 = Math.Max(sum25, sum26);
                    max7 = Math.Max(sum27, sum28);
                    max8 = Math.Max(sum29, sum30);

                    max1 = Math.Max(max1, max2);
                    max2 = Math.Max(max3, max4);
                    max3 = Math.Max(max5, max6);
                    max4 = Math.Max(max7, max8);

                    max1 = Math.Max(max1, max2);
                    max2 = Math.Max(max3, max4);

                    MaxSum = Math.Max(max1, max2);

                    Console.WriteLine(MaxSum);
                }
            }                                             //конец кода ТОШИКА


            if (n > 5)                                    // костыль Ивана
            {
                int i = 0, j = 0;
                for (int h = 0; i < n - 1; h++)
                {
                    if (mass[i + 1][j] >= mass[i + 1][j + 1])
                    {
                        sum += mass[i + 1][j];
                        i = i + 1;
                    }
                    else if (mass[i + 1][j] < mass[i + 1][j + 1])
                    {
                        sum += mass[i + 1][j + 1];
                        i = i + 1;
                        j = j + 1;
                    }
                }
                Console.WriteLine(sum);
            }                                                           

            Console.ReadKey();
        }
    }
}
