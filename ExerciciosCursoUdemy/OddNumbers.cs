using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCursoUdemy
{
    public static class OddNumbers
    {
        public static void ListOddNumbers()
        {
            Console.WriteLine("Type a number");
            bool xParse = int.TryParse(Console.ReadLine(), out int x);
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
