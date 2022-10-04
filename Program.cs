using System;
using Models;

namespace ListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constants
            const Int32 MIN = 21;
            const Int32 MAX = 40;
            
            // Variables
            var   exercise     = new Models.Exercise();
            Int32 totalNumbers = exercise.GetTotalRangeNumbers(MIN, MAX);

            // Invoking the methods
            Console.WriteLine("Lista de números:");
            exercise.ShowNumberList();

            Console.WriteLine(
                $"\n\nLa cantidad de números entre {{ {MIN} & {MAX} }} " +
                $"es: {totalNumbers}\n"
            );

            Console.WriteLine(
                "Números pares en la que su posición es " +
                "múltiplo de 3:"
            );

            exercise.ShowPairsInMultiplesOf(3);
        }
    }
}
