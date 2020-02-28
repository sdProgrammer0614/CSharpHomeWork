using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPrimeNumber
{
    class Program
    {
        public static void FindPrime(int[] array)
        {
            //“去除”array数组中的约数，即将它们设置为0
            for(int i = 2; i <= array.Length / 2; i++)
            {
                for(int j = 2; j <= array.Length / 2; j++)
                {
                    if(i * j < array.Length)
                    {
                        array[i * j] = 0;
                    }
                    else
                    {
                        break;      //当i * j大于100时，退出内层循环
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = new int[101];
            for(int i = 2; i < array.Length; i++)
            {
                array[i] = i;
            }       //初始化array数组，array数组的值为 0, 0, 2, 3, ..., 100

            FindPrime(array);
            foreach(int number in array)
            {
                if(number != 0)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
