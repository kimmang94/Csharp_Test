using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_TypeVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("이름을 입력하세요");
            string name = Console.ReadLine();
            Console.WriteLine("나이를 입력하세요");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("키를 입력하세요(cm)");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine($"안녕하세요 {name}님, 나이는 {age}세, 키는 {height}cm 이시군요");

            Console.ReadLine();
        }
    }
}
