// See https://aka.ms/new-console-template for more information
using System.Reflection.PortableExecutable;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to KNN Classifier Project by Rookie Developers");

        // This project deals with the investigation and implementation of KNN Classfiers.
        static double Distance(double[] unknown, double[] data)
        {
            double sum = 0.0;
            for (int i = 0; i < unknown.Length; ++i)
                sum += (unknown[i] - data[i]) * (unknown[i] - data[i]);
            return Math.Sqrt(sum);
        }

    }
}