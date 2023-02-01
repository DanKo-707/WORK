using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнили Беличенко Александр и Кондрученков Даниил, 211д");
            /*double X = 3.14;
            for (double i=3.14; i < 3.19; i += 0.01)
            {
                Console.Write(i + " " + "\t");
                ;
                
               
                
                
            }
            Console.WriteLine();
            for (double i = 3.14; i < 3.19; i += 0.01)
            {
                double C = Math.Pow(i, 2);
                C = Math.Round(C, 2);
                Console.Write(C + " " + "\t");
                
            }
                Console.WriteLine();
            for (double i = 3.14; i < 3.19; i += 0.01)
            {
                double Z = Math.Pow(i, 3);
                Z =Math.Round(Z, 2) ;
                Console.Write(Z + " " + "\t");
            }*/
            //long Z = 9037600125;

            //Console.WriteLine(Z + "-->" + );
            /*string str;
            int n;
            str = Console.ReadLine();
            n = Int32.Parse(str);
            long Z = n;
            long a = n;
            string s = a.ToString();
            char[] ar = s.ToCharArray();
            Array.Reverse(ar);
            s = new String(ar);
            a = Convert.ToInt64(s);
            Console.WriteLine(Z + "-->" + a);
            //Console.WriteLine(n.);
            int length = str.Length;
            Console.WriteLine("Число цифр " + length + ".");
            //Console.WriteLine(n);
            
            double V = 0;
            while (n > 0)
            {

                V = V + n % 10;
                n = n / 10;

            }
            Console.WriteLine(V);
            /*int sum = 0;
            for (int i = 3; i >= 0; i--)
            {
                sum += n;
                n = n % (int)(Math.Pow(10.0, i));
            
            }
            Console.WriteLine(sum);*/

            Console.ReadKey();
        }
    }
}
