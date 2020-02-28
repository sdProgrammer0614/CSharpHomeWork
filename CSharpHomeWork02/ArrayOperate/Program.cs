using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperate
{
    class Program
    {
        public static void DealArray(int[] arrays, out int min, out int max, out int sum, out double average)
        {
            min = max = sum = 0;

            foreach(int array in arrays)
            {
                if(array < min)
                {
                    min = array;
                }

                if(array > max)
                {
                    max = array;
                }

                sum += array;
            }

            average = (double)sum / arrays.Length;
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arrays = new int[100];
            for(int i = 0; i < arrays.Length; i++)
            {
                arrays[i] = random.Next(100);
            }       //随机生成一个含有100个元素的整形数组

            DealArray(arrays, out int min, out int max, out int sum, out double average);
            Console.WriteLine($"Max: {max}, Min: {min}, Average: {average}, Sum: {sum}");
        }
    }
}
