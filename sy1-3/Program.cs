using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sy1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            while (num < 50)
            {
                if (num % 2 == 1 && num % 3 == 1 && num % 4 == 1)
                {
                    Console.WriteLine("这篮鸡蛋至少有{0}个", num);
                    break;
                }
                num++;
            }
        }
     }
    
}
