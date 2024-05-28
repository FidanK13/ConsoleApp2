// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Numerics;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1st homework
            //int i = 5;

            //if (i < 0)
            //{
            //    Console.WriteLine("menfidir");
            //    Console.ReadKey();
            //}
            //else if (i == 0)
            //{
            //    Console.WriteLine("0-a beraberdir");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("musbetdir");
            //}

            //if (i % 2 == 0)
            //{
            //    Console.WriteLine("cut");
            //}
            //else
            //{
            //    Console.WriteLine("tek");
            //}

            //switch (i)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
 
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
 
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
 
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
 
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
 
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
 
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
 
            //        break;
            //        //Console.ReadKey();
            //}
            //if (i % 2 == 0)
            //        {
            //     Console.WriteLine("cut");
            //        }
            //else
            //        {
            //    Console.WriteLine("tek");
            //        }

            ////2nd homeowrk
            ////faktorial

            //int f = 3;
            //int s = 1;
            //while (f > 0) 
            //{
            //s = s * f;
            //f--;
            //}
            //Console.WriteLine("faktorial equals "+s);

            ////fibonacci
            //int fib = 16;
            //int a = 0;
            //int b = 1;
            //int c = 0;
            //List<int> fibonacci = [];
            //while (c <= fib)
            //{
            //    if (c == 0 )
            //    {
            //        fibonacci.Add(c);
            //        //Console.Write(c + ",");
            //        c = b;
            //    }
            //    else
            //    {
            //        fibonacci.Add(c);
            //        //Console.Write(c + ",");
            //        c = a + b;
            //        a = b;
            //        b = c;
            //    }
            //}
            //Console.WriteLine(string.Join(",",fibonacci));

            ////// 3. ededin reqemlerinin cemi
            ////int reqem = 2345;
            ////int l = reqem.ToString().Length;
            ////int p = 0;
            ////int total = 0;
            ////do

            ////{ total += (int)Char.GetNumericValue((reqem.ToString()[p]));  

            ////    p++;
            ////}


            ////while (l > p);
            ////Console.WriteLine("ededin reqemlerinin cemi beraberdir - "+total);

            ////4. musbet reqem input

            //int musbet = -1;

            //do

            //{

            //    Console.Write("musbet reqem daxil et - ");
            //    string musbet1 =  Console.ReadLine();

            //    musbet = Convert.ToInt32(musbet1);

            //}

            //while (musbet < 0);

            ////5. ededin reqemlerinin nechesinin tek nechesinin cut olmasi

            //Console.Write("bir eded daxil et - ");
             
            //string reqem5 = Console.ReadLine();
            //int len = reqem5.Length;
            //int e = 0;
            //int tek = 0;
            //int cut = 0;
            //do
            //{ if ((int)Char.GetNumericValue(reqem5[e]) % 2 == 0)
            //    {
            //        cut++;
            //        e++;

            //    }
            //   else
            //    { tek++;
            //        e++;
            //    }
            //}

            //while (e < len);
            //Console.WriteLine("tek reqemlerin cemi - " + tek + " ve cut reqemlerin cemi - " + cut);

            //// 3. ededin reqemlerinin cemi 2
            //string reqem = Console.ReadLine();
            //int l = reqem.Length;
            //int p = 0;
            //int total = 0;
            //do

            //{
            //    total += (int)Char.GetNumericValue(reqem[p]);

            //    p++;
            //}


            //while (l > p);
            //Console.WriteLine("ededin reqemlerinin cemi beraberdir - " + total);

            //3rd homework
            //1ci tapshiriq istifadeciden 10 indexli array uchun reqemler daxil etmesini iste
            int[] reqemler = new int[10];
            int i = 0;
            do
            { Console.WriteLine(i + " INDEXI UCHUN BIR EDED DAXIL EDIN");
                reqemler[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            while (i < 10);
            Console.WriteLine(string.Join(",", reqemler));

            //2ci tapshiriq arrayi tersine chevirin
            int r = reqemler.Length-1;
            int s = 0;
            int[] reqemler_reverse = new int[10];
            do
            {
                //reqemler_reverse.Append(reqemler[r]);
                reqemler_reverse[s]=reqemler[r];
                r--;
                s++;
            }
            while (r >= 0);
            Console.WriteLine(string.Join(",", reqemler_reverse));

            //3cu tapshiriq avg of array
            int cnt = reqemler.Length;
            int sum = reqemler.Sum();
            float avg = (float)sum / (float)cnt;
            Console.WriteLine("reqemlerin sayi - "+cnt +", cemi - "+sum+", arrayin ortalamasi - "+avg);

            //4cu array elementlerini cut ve tek olaraq ayirmaq

            int[] arr = new int[20];
            int[] tek_arr = new int[0]; //= new int[20];
            int[] cut_arr = new int[0]; ;// = new int[20];
            int cut_idx = 0;
            int tek_idx = 0;
            int t = 0;
            do
            {
                Console.WriteLine(t + " INDEXI UCHUN BIR EDED DAXIL EDIN");
                arr[t] = Convert.ToInt32(Console.ReadLine());
                if (arr[t] % 2 == 0)
                {
                    Array.Resize(ref cut_arr, cut_arr.Length + 1);
                    cut_arr.SetValue(value: arr[t], index: cut_idx);
                    cut_idx++;
                }
                else {
                    Array.Resize(ref tek_arr, tek_arr.Length + 1);
                    tek_arr[tek_idx] = arr[t];
                    tek_idx++;
                }
                t++;
            }
            while (t < 20);
            Console.WriteLine("ilkin array - "+string.Join(",", arr));
            Console.WriteLine("cut reqemlerin array - "+string.Join(",", cut_arr));
            Console.WriteLine("tek reqemlerin arrayi - "+string.Join(",", tek_arr));


            //5ci tapshiriq 2 olculu matris yaradib setr ve sutunlarin cemini hesablamaq
            int sum_matris = 0;
            int[,] matris = new int[2,2];
            int rows = matris.GetLength(0);
            int cols = matris.GetLength(1);
            int i_r = 0;
            int i_c = 0;

            do
            { if (i_c < cols & i_r<rows)
                {
                    Console.WriteLine("matrisin " + i_r + " ve "+ i_c + " indexleri uchun deyer daxil edin");

                    matris[i_r, i_c] = Convert.ToInt32(Console.ReadLine());
                    sum_matris += matris[i_r, i_c];
                    i_c++;
                }
                else if (i_c == cols & i_r < rows)
                {
                    i_c = 0;
                    i_r++;
                }

            }
            while (i_r < rows );
            Console.WriteLine("setrlerin ve sutunlarin cemi "+ sum_matris);

            //6ci tapshiriq arrayi azalan siraya gore duzmek

            Array.Sort(reqemler);
            Console.WriteLine(string.Join(",", reqemler));

            int[] reqemler_desc= reqemler.OrderByDescending(x => x).ToArray();
            Console.WriteLine(string.Join(",", reqemler_desc)); //azalan sira


        }
    }
}