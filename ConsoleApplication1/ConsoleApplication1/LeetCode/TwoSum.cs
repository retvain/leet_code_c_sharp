using System;

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

            var result = GetIndexes(arr, number);

            // get result
            Console.WriteLine("massive keys");
            Console.WriteLine("[{0}]", string.Join(", ", result));
        }

        private static int[] GetIndexes(int[] sourceArr, int number)
        {
            int[] result = new int[2];

            for (int i = 0; i < sourceArr.Length; i++)
            {
                if (sourceArr[i] + sourceArr[i + 1] == number)
                {
                    return result;
                }
            }

            // delete first key from array
            var tmpList = new List(sourceArr);
        }
    }
}