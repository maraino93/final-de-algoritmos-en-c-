using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablas
{
    internal class Program
    {
        /*1.11.2: Pedir al usuario un número y mostrar su tabla de multiplicar,
         * usando {0},{1} y {2}. Por ejemplo, si el número es el 3,
         * debería escribirse algo como
         3 x 0 = 0
         3 x 1 = 3
         3 x 2 = 6*/
        static void Main(string[] args)
        {
            int num1;
            num1 = int.Parse(Console.ReadLine());
            for (int i= 1; i <= 10; i++)
            {
               Console.WriteLine(num1+"x"+i+"="+num1*i);
            }
           Console.ReadKey();
           
           


        }
    }
}
