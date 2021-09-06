using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    public class FindMissingNumber
    {
        //https://study.com/academy/lesson/finding-the-sum-of-consecutive-numbers.html
        //Formulas
        //sumOntheArrayStartingAt1 = (n * (n + 1)) / 2
        //SumIfThereIsStartingAndEnd = (n / 2)(first number + last number) 
        public int findMissingNumberInArray(int[] array)
        {
            var arrayLength = array.Length;
            if (arrayLength == 0)
                return 0;

            var sumOfTheValuesOfTheArray = 0;
            //Normal sum
            foreach (var a in array)
            {
                sumOfTheValuesOfTheArray += a;
            }

            //Using Other Sum
            //var sumWithLinq = array.Sum();

            var sizeOfFinalArray = arrayLength + 1;
            var sumForCompleteArrayValues = (sizeOfFinalArray * (sizeOfFinalArray + 1)) / 2;
            var missingNumber = sumForCompleteArrayValues - sumOfTheValuesOfTheArray;
            return missingNumber;
        }
    }
}
