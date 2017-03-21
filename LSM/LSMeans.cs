using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM
{
    /// <summary>
    /// Данный класс вычисляет оценки линейной регрессии по методу наименьших квадратов
    /// </summary>
    public class LSMeans
    {
        /// <summary>
        /// Для вычисления оценок необходимо передать методу два числовых массива одинаковой длины
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        public static double[] Calc(double[] X, double[] Y)
        {
            try
            {
                if (X.Length == Y.Length)
                {
                    double Xmean = Average(X),
                       Ymean = Average(Y),
                       XYmean = Average(X, Y),
                       XXmean = Average(X, X);

                    double b = (XYmean - Xmean * Ymean) / (XXmean - Xmean * Xmean);

                    double a = Ymean - b * Xmean;

                    return new double[] { a, b };
                }
                else
                    throw new VectorsLengthException("Vectors should have the same length");
            }
            catch (VectorsLengthException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        /// <summary>
        /// Вспомогательный метод вычисления среднего
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        static double Average(double[] v)
        {
            double sum = 0;
            for (int i = 0; i < v.Length; i++)
                sum += v[i];
            return sum / v.Length;
        }

        /// <summary>
        /// Вспомогательный метод вычисления среднего от попарного умножения элементов двух векторов
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        static double Average(double[] v1, double[] v2)
        {
            double[] vv = new double[v1.Length];
            for (int i = 0; i < vv.Length; i++)
                vv[i] = v1[i] * v2[i];
            return Average(vv);
        }
    }
}
