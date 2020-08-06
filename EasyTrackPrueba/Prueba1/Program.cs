using System;
using System.Linq;

namespace Prueba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format("Promedio: {0}", avg(98)));

            Console.ReadLine();
        }

        private static double avg(int items)
        {
            try
            {
                return new double[] { 50, 80, 95, 40, 100, 90, 90, 100, 85 }.ToList().GetRange(0, items).Average();
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Ha ocurrido un error: {0}", ex.Message));
                return 0;
            }
        }
    }
}
