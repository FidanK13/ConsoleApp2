// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st homework
            int i = 5;

            if (i < 0)
            {
                Console.WriteLine("menfidir");
                Console.ReadKey();
            }
            else if (i == 0)
            {
                Console.WriteLine("0-a beraberdir");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("musbetdir");
            }

            if (i % 2 == 0)
            {
                Console.WriteLine("cut");
            }
            else
            {
                Console.WriteLine("tek");
            }

            switch (i)
            {
                case 1:
                    Console.WriteLine("Monday");
 
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
 
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
 
                    break;
                case 4:
                    Console.WriteLine("Thursday");
 
                    break;
                case 5:
                    Console.WriteLine("Friday");
 
                    break;
                case 6:
                    Console.WriteLine("Saturday");
 
                    break;
                case 7:
                    Console.WriteLine("Sunday");
 
                    break;
                    //Console.ReadKey();
            }
            if (i % 2 == 0)
                    {
                 Console.WriteLine("cut");
                    }
            else
                    {
                Console.WriteLine("tek");
                    }

            //2nd homeowrk
            //faktorial

            int f = 3;
            int s = 1;
            while (f > 0) 
            {
            s = s * f;
            f--;
            }
            Console.WriteLine("faktorial equals "+s);

            //fibonacci
            int fib = 16;
            int a = 0;
            int b = 1;
            int c = 0;
            List<int> fibonacci = [];
            while (c <= fib)
            {
                if (c == 0 )
                {
                    fibonacci.Add(c);
                    //Console.Write(c + ",");
                    c = b;
                }
                else
                {
                    fibonacci.Add(c);
                    //Console.Write(c + ",");
                    c = a + b;
                    a = b;
                    b = c;
                }
            }
            Console.WriteLine(string.Join(",",fibonacci));

            // 3. ededin reqemlerinin cemi
            int reqem = 2345;
            int l = reqem.ToString().Length;
            int p = 0;
            int total = 0;
            do

            { total += (int)Char.GetNumericValue((reqem.ToString()[p]));  

                p++;
            }


            while (l > p);
            Console.WriteLine("ededin reqemlerinin cemi beraberdir - "+total);

            //4. musbet reqem input

            int musbet = -1;

            do

            {

                Console.Write("musbet reqem daxil et - ");
                string musbet1 =  Console.ReadLine();

                musbet = Convert.ToInt32(musbet1);

            }

            while (musbet < 0);

            //5. ededin reqemlerinin nechesinin tek nechesinin cut olmasi

            Console.Write("bir eded daxil et - ");

            string reqem5 = Console.ReadLine();
            int len = reqem5.Length;
            int e = 0;
            int tek = 0;
            int cut = 0;
            do
            { if ((int)Char.GetNumericValue(reqem5[e]) % 2 == 0)
                {
                    cut++;
                    e++;

                }
               else
                { tek++;
                    e++;
                }
            }

            while (e < len);
            Console.WriteLine("tek reqemlerin cemi - " + tek + " ve cut reqemlerin cemi - " + cut);

        }
    }
}