using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTest.GameProgram1
{
    internal class GameProgram1
    {
        public void GameMain1()
        {
            int Chance = 10;
            Random random = new Random();
            int RandomNum = random.Next(1000);
            Console.WriteLine(RandomNum);


            while (Chance > 0)
            {
                Console.WriteLine("숫자를 입력하시오:");
                int userNum = int.Parse(Console.ReadLine());
                if (userNum < RandomNum)
                {
                    Console.WriteLine("더 크다.");
                }
                if (userNum > RandomNum)
                {
                    Console.WriteLine("더 작다");

                }
                if (userNum == RandomNum)
                {
                    Console.WriteLine("정답");
                    break;
                }
                Chance--;
                Console.WriteLine(Chance);
                if (Chance == 0)
                {
                    Console.WriteLine("다시하실꺼면 재시작을 입력하시오");
                    string user = Console.ReadLine();
                    if (user == "재시작")
                    {
                        Chance = 10;
                    }
                }
            }
        }
    }
}
