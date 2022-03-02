using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_in_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[][] a = new int[3][];
            //Console.WriteLine("enter size of first arry a row");
            //a[0] = new int[int.Parse(Console.ReadLine())];
            //Console.WriteLine("enter size of second row");
            //a[1] = new int[int.Parse(Console.ReadLine())];
            //Console.WriteLine("enter size of third row");
            //a[2] = new int[int.Parse(Console.ReadLine())];
            //Console.ReadLine();
            //ANY example of params array
            int[] y = new int [] { 1, 2, 3, 4, 5 };
            Program obj = new Program();
            int result = obj.add(1,2,3,4,5);
            Console.WriteLine(result);
            Console.ReadLine();

        }
        public  int add ( params int[] list)
        {
            int total = 0;
            foreach (int i in list)
            {
                total = i + total;
            }
            return total;
           


        }

    }
}
