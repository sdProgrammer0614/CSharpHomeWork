using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primefactor
{
    class Program
    {
        public static bool AcceptNumber(out int number)
        {
            bool flag = true;       //标志输入是否正确
            Console.Write("Please enter a number: ");
            if(!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please try again!");
                flag = false;       //输入格式错误时，flag置为false
            }
            return flag;
        }

        public static void GetPrimeFactor(int number, List<int> list)
        {
            for(int i = 2; i <= number; i++)
            {
                if(number % i == 0)
                {
                    list.Add(i);
                    do
                    {
                        number /= i;
                    } while (number % i == 0);
                }
            }
        }

        public static void PrintPrime(List<int> list)
        {
            Console.Write("All prime factor are: ");
            foreach(int number in list)
            {
                Console.Write(number + " ");
            }
        }

        static void Main(string[] args)
        {
            int number;
            List<int> list = new List<int>();

            while (!AcceptNumber(out number))
                AcceptNumber(out number);       //获取用户的输入

            GetPrimeFactor(number, list);         //获取number的所有质数因子

            PrintPrime(list);       //输出list数组
        }
    }
}
