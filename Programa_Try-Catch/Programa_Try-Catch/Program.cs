using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Try_Catch
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] Ar = new int[10];
            Random Ra = new Random();

            try
            {
                for (int x = 0; x < Ar.Length; x++)
                {
                    Ar[x] = Ra.Next(10, 99);
                }
                Array.Sort(Ar);
                Console.WriteLine("Lista : ");
                for(int x = 0; x < Ar.Length; x++ )
                {
                    Console.WriteLine("t{0}.-{1}", x + 1, Ar[x]);
                }
                Console.WriteLine("Oprima ENTER para seguir");
                Console.ReadKey();
                Ar[16] = 123456;
                Console.Clear();
            }
            catch(IndexOutOfRangeException L)
            {
                Console.WriteLine("Error: " + L.Message);
                Console.WriteLine("Ruta del Error: " + L.Message);
                Console.WriteLine("Oprima ENTER para salir ");
                Console.ReadKey();
            }
        }
    }
}
