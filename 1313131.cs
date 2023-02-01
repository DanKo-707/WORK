using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZXCBoop228
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнили 2 студента из группы исп211д: Беличенко Александр Андреевич и Кондрученков Даниил Андреевич");
            /*int a = 42;
            int b = 119;
            int Z = a + b;
            int X = 12;
            int Y = 98;
            int Z = ((Y * Y) - (X* X * X));
            Console.WriteLine("X = " + X + ", " + "Y = " + Y);
            double C = Math.Pow(X, 3);
            double V = Math.Pow(Y, 2);
            double Z = V - C;*/
            //double X = 3.14;
            /*double i;
            Double Z;
            Double C;
            for (i = 3.14; i < 3.19; i += 0.01)
            {
                Console.Write(i + "\t" );
                
                //Console.WriteLine(i);
                Z = Math.Pow(i, 2);
                C = Math.Pow(i, 3);
                
                Console.Write(" " + Z + "   ");
                Console.WriteLine();
                Console.Write(" " + C + "   ");
                //Console.Write(i + "  "  + Z + "  " + C);
            }
            Console.WriteLine();*/
            for (int Z = 1; Z <= 3000; Z++)
            {
                if (Z % 4 == 0 & Z % 7 == 0 & Z % 11 == 0)
                {
                    Console.Write(Z + ", ");



                }

            }
            Console.WriteLine();
            for (int X = 2; X <= 3000; X++)
            {
                /*if (Z % 2 == 1 & Z % 3 == 1 & Z % 4 == 1 & Z % 5 == 1 & Z % 6 == 1 & Z % 7 == 1 & Z % 8 == 1 & Z % 9 == 1 & Z % 10 == 1)
                {

                    Console.Write(Z + ", ");
                }*/
                for (int C = 2; C <= 2999 ; C++)
                {
                    if (X % C == 0)
                    {
                        
                        Console.Write(X + ", ");
                        
                    }
                    else
                    {
                        continue;
                    }

                    
                }
            }
            
            Console.ReadKey();
        }
    }
}
