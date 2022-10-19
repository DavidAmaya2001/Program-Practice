using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_fuente_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numero = { 21, 56, 18, 124, 11 };

            var consulta = from numeritos in numero where numeritos >50 && numeritos < 90 select numeritos;

            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
