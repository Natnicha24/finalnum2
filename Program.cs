using System;

namespace finalnum2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofnum;

            int i = 0;

            numberofnum = int.Parse(Console.ReadLine());
            int[] num = new int[numberofnum];

            for (i = 0; i < numberofnum; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Max to Max");
            MaxtoMin(num, numberofnum);

            Console.Write("\nEvenfirst");//เรียงเอาค่าเลขคู่มาก่อนน้อยไปมาก
            Evenfirst(num, numberofnum); 

            Console.Write("\nMin to Max");
            MintoMax(num, numberofnum);

            Console.Write("\nOddfirst");//เรียงเอาค่าเลขคี่มาก่อนมากไปน้อย
           Oddfirst(num, numberofnum);

        }

        static void Evenfirst(int[] num, int numberofnum)
        {
            int i;
            for (i = 0; i < numberofnum; i++)
            {
                if ((num[i] % 2) == 0)
                {
                    Console.Write(" {0}", num[i]);
                }
            }
            for (i = 0; i < numberofnum; i++)
            {
                if ((num[i] % 2) != 0)
                {
                    Console.Write(" {0}", num[i]);
                }
            }
        }
        static void Oddfirst(int[] num, int numberofnum)
        {
            int i;
            for (i = 0; i < numberofnum; i++)
            {
                if ((num[i] % 2) != 0)
                {
                    Console.Write(" {0}",num[i]);
                }
            }
            for (i = 0; i < numberofnum; i++)
            {
                if ((num[i] % 2) == 0)
                {
                    Console.Write(" {0}",num[i]);
                }
            }
        }

        static void MaxtoMin(int[]num,int numberofnum)
            {
                int stock;//ที่เก็บเลขชั่วคราว
                int i = 0;
                do
                {
                    if (i < numberofnum - 1 && num[i] > num[i + 1])
                    {
                        stock = num[i + 1];
                        num[i + 1] = num[i];
                        num[i] = stock;
                        i = 0;
                    }
                    else
                    {
                        i++;
                    }

                } while (i < numberofnum);

                for (i = 0; i < numberofnum; i++)
                {
                    Console.Write(" {0}", num[i]);
                }

            }

            static void MintoMax(int[] num, int numberofnum)
            {
                int stock;
                int i = 0;
                do
                {
                    if (i < numberofnum - 1 && num[i] < num[i + 1])
                    {
                        stock = num[i + 1];
                        num[i + 1] = num[i];
                        num[i] = stock;
                        i = 0;
                    }
                    else
                    {
                        i++;
                    }

                } while (i < numberofnum);

                for (i = 0; i < numberofnum; i++)
                {
                    Console.Write(" {0}", num[i]);
                }
            }
        }
    }

