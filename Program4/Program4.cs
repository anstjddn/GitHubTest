using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTest.Program4
{
    internal class Program4
    {
        public void Main4()
        {
            int Num2 = 0;
            Console.WriteLine("숫자를 입력하시오:");
            int Num = int.Parse(Console.ReadLine());
            if (Num < 10)
            {
                Console.Write(Num);
            }

            if (Num > 10)
            {
                while (Num > 0)
                {
                    int Num1 = Num % 10;
                    Num = Num / 10;
                    Num2 += Num1;
                }
                Console.WriteLine("자리수합은 :{0}", Num2);
            }
        }
    }
}
