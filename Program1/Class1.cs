using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTest.Program1
{
    internal class Class1
    {
        public void Main1()
        {
            Console.Write("1. 원하는 문장을 입력하시오: ");
            string sentence = Console.ReadLine();
            Console.Write("찾고싶은 문장을 입력하시오:");
            string str = Console.ReadLine();
            Console.WriteLine(sentence.IndexOf(str));
        }
        
    }
}
