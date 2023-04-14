using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTest.Program2
{
    internal class Program2
    {

        public void Main2()
        {
            Console.Write("문장을 입력하시오. :");
            string sentence = Console.ReadLine();
            string[] sentenceLength = sentence.Split(' ');
            Console.WriteLine(sentenceLength.Length);

        }
    }
}
