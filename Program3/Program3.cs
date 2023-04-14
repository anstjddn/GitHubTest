using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTest.Program3
{
    internal class Program3
    {
        public void Main3()
        {
            int num = int.Parse(Console.ReadLine());
            if (num == 2) { Console.WriteLine("{0}은 소수입니다.", num); }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("{0}은 소수가 아닙니다.", num);
                }
                else Console.WriteLine("{0}은 소수입니다.", num);
            }
        }
    }
}
