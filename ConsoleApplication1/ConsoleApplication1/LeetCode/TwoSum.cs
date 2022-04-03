using System;
using System.Collections.Generic;

namespace ConsoleApplication1.LeetCode
{
    public class TwoSum
    {
        public static void Handle()
        {
            var arr = new int[5];

            // set keys
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Insert array key {i} value");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // set sum
            Console.WriteLine("Insert sum");
            var number = Convert.ToInt32(Console.ReadLine());

            var result = GetIndexes<Array>(arr, number);
            var fail = GetIndexes<string>(arr, number);

            // get result
            Console.WriteLine("massive keys");
            if (result.GetType() == typeof(Array))
            {
                Console.WriteLine("[{0}]", string.Join(", ", result));    
            }
            
        }

        private static dynamic GetIndexes<T>(int[] sourceArr, int number)
        {
            if (sourceArr.Length < 2)
            { 
                return "keys not found";
            }
            
            int[] result = new int[2];

            for (int i = 0; i < sourceArr.Length-1; i++)
            {
                if (sourceArr[i] + sourceArr[i + 1] == number)
                {
                    return result;
                }
            }

            // delete first key from array
            var tmpList = new List<int>(sourceArr); // convert to list
            tmpList.RemoveAt(0); // remove first element
            sourceArr = tmpList.ToArray(); // convert back to array

            GetIndexes<Array>(sourceArr, number);
        }
    }
}