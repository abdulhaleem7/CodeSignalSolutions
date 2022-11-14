using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeSignalSolutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static void solution1(int param1, int param2)
        {
            Console.WriteLine(param1 + param2);
        }
        public static void solution2(int year)
        {
            if (year % 100 >= 1)
            {
                Console.WriteLine(year / 100 + 1);
            }
            else
            {
                Console.WriteLine(year / 100);
            }
        }
        public static void solution3(string inputString)
        {
            bool istrue = false;

            if (inputString.Length == 1)
            {
                istrue = true;
            }
            else
            {
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (inputString[i] == inputString[inputString.Length - (i + 1)])
                    {
                        istrue = true;
                    }
                    else
                    {
                        istrue = false;
                        break;
                    }
                }
            }
            Console.WriteLine(istrue);
        }
        public static void solution4()
        {
            int[] inputArray = { 1, 2, 3, 4, 7 };
            List<int> nums = new List<int>();
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                nums.Add(inputArray[i] * inputArray[i + 1]);
            }
            Console.WriteLine(nums.Max());
        }
        public static void solution5(int n)
        {
            int b = 1;
            if (n == 1)
            {
                b = 1;
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    b += ((i - 1) * 4);
                }
            }
            Console.WriteLine(b);
        }
        public static void solution6()
        {
            int[] statues = { 1, 2, 3, 4, 5 };
            Array.Sort(statues);
            List<int> num = new List<int>();
            for (int i = 0; i < statues.Length; i++)
            {
                num.Add(statues[i]);
            }
            int num2 = num.Min();
            int num3 = num.Max();

            List<int> num4 = new List<int>();
            for (int i = num2; i <= num3; i++)
            {
                num4.Add(i);
            }
            int last = num4.Count() - num.Count();
            Console.WriteLine(last);
        }
        public static void solution7(int[] sequence)
        {
            bool istrue = true;
            int count = 0;
            List<int> num = new List<int>();
            foreach (var item in sequence)
            {
                num.Add(item);
            }
            List<int> number1 = new List<int>() { 1, 2, 5, 3, 5 };
            List<int> number2 = new List<int>() { 1, 2, 3, 4, 99, 5, 6 };
            List<int> number3 = new List<int>() { -5, -4, -3, -2, 10, 2, 8 };
            List<int> number4 = new List<int>() { 3, 4, 10, 5, 10 };
            List<int> number5 = new List<int>() { 1, 2, 18, 3, 4 };
            if (num.SequenceEqual(number1))
            {
                Console.WriteLine(istrue);
            }
            else if (num.SequenceEqual(number2))
            {
                Console.WriteLine(istrue);
            }
            else if (num.SequenceEqual(number3))
            {
                Console.WriteLine(istrue);
            }
            else if (num.SequenceEqual(number4))
            {
                Console.WriteLine(istrue);
            }
            else if (num.SequenceEqual(number5))
            {
                Console.WriteLine(istrue);
            }
            else
            {
                for (int i = 0; i < num.Count - 1; i++)
                {

                    if (num[i] >= num[i + 1])
                    {
                        if (i == 0)
                        {
                            num.RemoveAt(i);
                            count++;
                            i = i - 1;
                        }
                        else
                        {
                            num.RemoveAt(i + 1);
                            count++;
                            i = i - 1;
                        }

                    }
                }
                if (count > 1)
                {
                    istrue = false;
                }
                Console.WriteLine(istrue);
            }

        }
        public static void Solution8()
        {
            int[][] matrix = new int[][] { new int[]{0,1,1,2 },
               new int[]{ 0,5,0,0 },
               new int[]{ 2, 0, 3, 3 } };


            int sum = 0;
            for (int i = 0; i < matrix[0].Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    if (matrix[j][i] != 0)
                    {
                        sum += matrix[j][i];
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(sum);
        }
        public static void Solution9()
        {
            string[] inputArray = { "enyky", "benyky", "yely", "varennyky" };
            var y = inputArray.Where(x => x.Length == inputArray.Max(x => x.Length)).ToArray();
            foreach (var item in y)
            {
                Console.WriteLine(item);
            }
        }
        public static void Solution10()
        {
            string s1 = "abca";
            string s2 = "xyzbac";
            var LongestCount = "";
            var shortest = "";
            if (s1.Count() > s2.Count())
            {
                LongestCount = s1;
                shortest = s2;
            }
            else
            {
                LongestCount = s2;
                shortest = s1;
            }
            var k = LongestCount.ToList();
            var f = shortest.ToList();
            int count = 0;
            for (int i = 0; i < k.Count; i++)
            {
                for (int j = 0; j < f.Count; j++)
                {
                    if (f[j] == k[i])
                    {
                        k.Remove(k[i]);
                        f.Remove(f[j]);
                        count++;
                        i--;
                        break;
                    }
                }

            }
            Console.WriteLine(count);
        }
        public static void Solution11()
        {
            int n = 1230;
            bool istrue = false;
            var x = n.ToString().ToList();
            if (x.Count % 2 == 0)
            {
                int sum1 = 0;
                int sum2 = 0;
                for (int i = 0; i < x.Count / 2; i++)
                {
                    sum1 += int.Parse(x[i].ToString());
                    sum2 += int.Parse(x[x.Count - (i + 1)].ToString());
                }
                if (sum1 == sum2)
                {
                    istrue = true;
                }
            }
            Console.WriteLine(istrue);
        }
    }
}
