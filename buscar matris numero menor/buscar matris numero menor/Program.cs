using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buscar_matris_numero_menor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matris = new int[4,4];
            int[] sumaMenor= new int[4];
            int menor = 200,f,c, pos=0, pos1=0;
            for (f = 0; f < 4; f++)
            {
                for (c = 0; c < 4; c++)
                {
                    matris[f,c] = int.Parse(Console.ReadLine());
                }
            }
            for (f = 0; f < 4; f++)
            {
                for (c = 0; c < 4; c++)
                {
                   Console.Write(" "+matris[f,c]+" ");
                }
                Console.WriteLine();
            }
            for (f = 0; f < 4; f++)
            {
                for (c = 0; c < 4; c++)
                {
                    if (matris[f, c] < menor)
                    {
                        menor = matris[f,c];
                        pos = f;
                        pos1 = c;
                    }
                }
            }
            Console.WriteLine("el numero menor es: "+menor+" se encuentra en la posicion: "+pos+" "+pos1);
            Console.ReadKey();
          

        }
    }
}
