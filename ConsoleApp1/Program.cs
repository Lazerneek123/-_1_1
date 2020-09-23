using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i_A = 5;
            int j_A = 5;

            int[,] array_A = new int[i_A, j_A];

            Console.WriteLine("Ведіть: (1 - рандом)!");

            while (true)
            {
                int key_1 = Int32.Parse(Console.ReadLine());

                if (key_1 == 1)
                {
                    Console.WriteLine("Ваш масив A: ");
                    array_A = Fill_The_Array_Random(i_A, j_A);
                    break;
                }

                else
                {
                    Console.WriteLine("Введіть 1!");
                }
            }

            Console.WriteLine("Ваш масив A (перероблений): ");

            array_A = Replaced_Array(array_A);

            int[] array_B = Creat_Array_B(array_A);

            Print_Array_B(array_B);

            Console.ReadKey();

        }

        /*static int[,] Fill_The_Array_KeyBoard(int i_A, int j_A)
        {

            //Random random = new Random();


            int[,] array_A = new int[i_A, j_A];




            for (int i = 0; i < i_A; i++)
            {

                for (int j = 0; j < j_A; j++)
                {
                    int key = Int32.Parse(Console.ReadLine());

                    array_A[i, j] = key;

                    Console.Write("{0, 4}", array_A[i, j]);
                }

                Console.WriteLine();
            }



            return array_A;


        }*/

        static int[,] Fill_The_Array_Random(int i_A, int j_A)
        {

            Random random = new Random();


            int[,] array_A = new int[i_A, j_A];


            for (int i = 0; i < i_A; i++)
            {

                for (int j = 0; j < j_A; j++)
                {

                    array_A[i, j] = random.Next(-10, 10);

                    Console.Write("{0, 4}", array_A[i, j]);
                }

                Console.WriteLine();
            }


            return array_A;
        }

        static int[,] Replaced_Array(int[,] array_A)
        {

            int n = 0;
            int m = 0;

            for (int i_A = 0; i_A < array_A.GetLength(0); i_A++)  //цыкл 1 и 2 елем
            {
                for (int i = i_A; i < array_A.GetLength(0) - (array_A.GetLength(0) - (i_A + 1)); i++)
                {

                    for (int j = 1; j < array_A.GetLength(1) - (array_A.GetLength(1) - 2); j++)
                    {

                        if (array_A[i, j - 1] < array_A[i, j])
                        {
                            n = array_A[i, j - 1];
                            m = j;
                        }
                        else
                        {
                            n = array_A[i, j];
                            m = j;
                        }


                    }

                }


                for (int i = i_A; i < array_A.GetLength(0) - (array_A.GetLength(0) - (i_A + 1)); i++) // остал
                {

                    for (int j = 2; j < array_A.GetLength(1); j++)
                    {

                        if (n > array_A[i, j])
                        {
                            n = array_A[i, j];
                            m = j;
                        }


                    }


                }

                int o = array_A[i_A, 0];
                array_A[i_A, 0] = n;
                array_A[i_A, m] = o;




            }

            for (int i = 0; i < array_A.GetLength(0); i++)
            {

                for (int j = 0; j < array_A.GetLength(1); j++)
                {

                    Console.Write("{0, 4} ", array_A[i, j]);


                }

                Console.WriteLine();
            }

            return array_A;
        }


        static int[] Creat_Array_B(int[,] array_A)
        {
            int[] array_B = new int[array_A.GetLength(0)];

            for (int i = 0; i < array_A.GetLength(0); i++)
            {

                for (int j = 0; j < array_A.GetLength(1) - (array_A.GetLength(1) - 1); j++)
                {

                    array_B[i] = array_A[i, j];


                }


            }

            Console.WriteLine("Ваш масив B:");

            for (int i = 0; i < array_B.Length - 1; i++)
            {

                int m = i;
                for (int j = i + 1; j < array_B.Length; j++)
                {
                    if (array_B[j] < array_B[m])
                    {
                        m = j;
                    }
                }

                int n = array_B[m];
                array_B[m] = array_B[i];
                array_B[i] = n;
            }

            return array_B;
        }

        static void Print_Array_B(int[] array_B)
        {
            for (int i = 0; i < array_B.Length; i++)
            {

                Console.Write("{0, 4}", array_B[i]);


            }

        }


    }
}
