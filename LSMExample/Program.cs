using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSM;

namespace LSMExample
{
    class Program
    {
        static Random r = new Random();

        static void Main(string[] args)
        {
            double[] X = new double[] { 0, 2, 8 },
                Y = new double[] { -11, 5, -20 };
            Console.Write("X: ");
            PrintVector(X);
            Console.Write("Y: ");
            PrintVector(Y);
            
            double[] coef = LSMeans.Calc(X, Y);
            if (coef != null)
            {
                // Если значение коэффициента b меньше нуля, при выводе уже получим знак
                String sign = coef[1] > 0 ? "+" : "";
                Console.WriteLine($"Equation: y={Math.Round(coef[0], 2)}{sign}{Math.Round(coef[1], 2)}*x");
            }

            Console.ReadKey();
        }

        static void PrintVector(double[] v)
        {
            foreach (var item in v)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}
