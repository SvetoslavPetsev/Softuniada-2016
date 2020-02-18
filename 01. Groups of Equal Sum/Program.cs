using System;
using System.Linq;


namespace _01._Groups_of_Equal_Sum
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[4];
            for (int i = 0; i < 4; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            bool evrika = false;

            int sumArr = arr.Sum();
            double halfSum = (double)sumArr / 2;
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                
                int a = arr[i];
                int sum = a;
                for (int j = 0; j < arr.Length; j++)
                {
                    int b = arr[j];

                    if (i == j)
                    {
                        continue;
                    }
                    if (a + b > halfSum)
                    {
                        continue;
                    }
                    else
                    {
                        sum += b;
                    }
                    if (sum == halfSum)
                    {
                        evrika = true;
                        break;
                    }
                }
            }
            
            if (evrika)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(sumArr / 2);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
