/*
Colleen is having a birthday! She will have a cake with one candle for each year of her age. When she blows out the candles, she’ll only be able to blow out the tallest ones.

Find and print the number of candles she can successfully blow out.

Input Format

The first line contains a single integer, n, denoting the number of candles on the cake. 
The second line contains n space-separated integers, where each integer i describes the height of candle i.

Output Format 
Print the number of candles the can be blown out on a new line.

Sample Input 0

4
3 2 1 3
Sample Output 0

2
Explanation 0

The maximum candle height is 3 and there are two candles of that height.
*/

//Finished it in  5 minutes.
using System;

namespace Birthday_Cake_Candles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = birthdayCakeCandles(n, ar);

            Console.WriteLine(result);
        }

        static int birthdayCakeCandles(int n, int[] ar)
        {
            Array.Sort(ar);
            int max = ar[ar.Length - 1];
            int count = 0;

            foreach (var item in ar)
            {
                if (item == max)
                    count++;
            }
            return count;
        }
    }
}
