using System;
using System.Collections.Generic;

namespace Models
{
    /// <summary>Represents a defined list of numbers</summary>
    public class Exercise
    {
        // Attributes
        public readonly List<Int32> numberList;

        /// <summary>Construct</summary>
        public Exercise()
        {
            // Initialitation
            this.numberList = new List<Int32>
            {
                18, 32, 39, 52, 70, 44, 15, 62, 50,
                88, 29, 35, 46, 8, 57, 71, 34, 69
            };
        }

        // Methods

        /// <summary>Show the list numbers</summary>
        public Int32 GetTotalRangeNumbers(Int32 min, Int32 max)
        {
            Int32 acc = 0;
            
            this.numberList.ForEach(delegate(Int32 number) {
                if (number >= min && number <= max)
                    acc++;
            });

            return acc;
        }

        /// <summary>Is even the number</summary>
        private Boolean IsEven(Int32 number)
        {
            return number % 2 == 0;
        }

        /// <summary>Is multiple of (number)</summary>
        private Boolean IsMultipleOf(Int32 number, Int32 multiple)
        {
            return number % multiple == 0;
        }

        /// <summary>Show pairs in multiples of (number)</summary>
        public void ShowPairsInMultiplesOf(Int32 multiple)
        {
            Int32 index = 0;

            while (++index < this.numberList.Count)
            {
                Int32 number = this.numberList[index];

                if (
                    this.IsEven(this.numberList[index]) &&
                    this.IsMultipleOf(index, multiple)
                )
                    Console.WriteLine(number);
            }
        }

        /// <summary>Show the list numbers</summary>
        public void ShowNumberList()
        {
            Int32 index = 0;

            this.numberList.ForEach(delegate(Int32 number) {
                Boolean isFinalIndex = index == this.numberList.Count - 1;

                Console.Write(
                    !isFinalIndex ?
                        $"{number}, "
                        : $"{number}."
                );

                index++;

                if (index % 5 == 0) Console.WriteLine("");
            });
        }
    }
}
