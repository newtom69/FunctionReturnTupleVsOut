using System;
using System.Collections.Generic;

namespace Function
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<double> dataSet = new List<double> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
            double sum1 = GetSumAvegareAndStandardDeviation(dataSet, out double average1, out double standardDeviation1);
            (double sum2, double average2, double standardDeviation2) = GetSumAvegareAndStandardDeviation(dataSet);
            Console.WriteLine($" somme1 : {sum1} somme2 : {sum2}");
            Console.WriteLine($" moyenne1 : {average1} moyenne2 : {average2}");
            Console.WriteLine($" écart type1 : {standardDeviation1} écart type2 : {standardDeviation2}");
        }

        /// <summary>
        /// Calcul de la somme, de la moyenne et de l'écart type d'une liste de nombres réels
        /// </summary>
        /// <param name="dataSet">liste de noombre rééls</param>
        /// <param name="average">moyenne calculée retournée</param>
        /// <param name="standardDeviation">écart type calculée retournée</param>
        /// <returns>somme</returns>
        public static double GetSumAvegareAndStandardDeviation(List<double> dataSet, out double average, out double standardDeviation)
        {
            double sum = 0;
            double sumSquares = 0;
            int dataSetNumber = dataSet.Count;
            foreach (var value in dataSet)
            {
                sum += value;
                sumSquares += value * value;
            }
            average = sum / dataSetNumber;
            double variance = sumSquares / dataSetNumber - average * average;
            standardDeviation = Math.Sqrt(variance);
            return sum;
        }

        /// <summary>
        /// Calcul de la somme, de la moyenne et de l'écart type d'une liste de nombres réels
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns>somme, moyenne et écart type sous forme de tuple</returns>
        public static (double sum, double average, double standardDeviation) GetSumAvegareAndStandardDeviation(List<double> dataSet)
        {
            double sum = 0;
            double sumSquares = 0;
            int dataSetNumber = dataSet.Count;
            foreach (var value in dataSet)
            {
                sum += value;
                sumSquares += value * value;
            }
            double average = sum / dataSetNumber;
            double variance = sumSquares / dataSetNumber - average * average;
            double standardDeviation = Math.Sqrt(variance);
            return (sum, average, standardDeviation);
        }
    }
}
