using System;

namespace finalnum2
{
    class Program
    {
        static void Main(string[] args)
        {
            //            จงเขียนโปรแกรมภาษา C# สำหรับการเรียงตัวเลข โดยมีรายละเอียดดังนี้
            //2.1 ให้รับค่าจากผู้ใช้เป็นจำนวนเต็มบวก 1 จำนวน คือ จำนวนตัวเลขที่ต้องการจะนำมาเรียงลำดับ 
            //แล้วรับค่าจากผู้ใช้อีกเป็นจำนวนเต็มอีกเท่ากับจำนวนที่กรอกเข้ามาก่อนหน้า จากนั้นแสดงผลลัพธ์เป็นชื่อวิธีการเรียงตัวเลข(ตามความเหมาะสม) ตามด้วยตัวเลขเหล่านั้นที่เรียงจากน้อยไปหามาก
            //2.2 เพิ่มวิธีการเรียงตัวเลขที่ไม่ซ้ำกับข้อ 2.1 แล้วแสดงผลลัพธ์ต่อจากข้อ 2.1
            //2.3 เพิ่มวิธีการเรียงตัวเลขที่ไม่ซ้ำกับข้อ 2.1 และ 2.2 แล้วแสดงผลลัพธ์ต่อจากข้อ 2.2
            //2.4 เพิ่มวิธีการเรียงตัวเลขที่ไม่ซ้ำกับข้อ 2.1, 2.2 และ 2.3 แล้วแสดงผลลัพธ์ต่อจากข้อ 2.3
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

