using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ExerciciosCursoUdemy
{
    public static class RangeNumbers
    {
       public static void GetNumbersInRange()
        {
            int inNumbers = 0;
            int outNumbers = 0;
            Console.WriteLine("Quantos numeros?");
            int.TryParse(Console.ReadLine(), out int n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite um numero");
                int.TryParse(Console.ReadLine(), out int rNumber);

                if (rNumber >= 10 && rNumber <= 20)
                {
                    inNumbers += 1;
                }
                else
                {
                    outNumbers += 1;
                }
            }
            Console.WriteLine($"{inNumbers} in");
            Console.WriteLine($"{outNumbers} out");
        }
    }
}
