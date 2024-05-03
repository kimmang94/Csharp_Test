using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("이름을 입력하세요");
            string name = Console.ReadLine();
            Console.Write(name);
            Console.WriteLine("님! 안녕하세요");

            Console.ReadKey();
        }
    }
}
