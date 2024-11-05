using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        ConsoleKeyInfo KeyInfo = Console.ReadKey(); //사용자의 키보드 입력을 받은 문자를 처리
        //입력받은 문자 출력
        Console.WriteLine();
        Console.WriteLine(KeyInfo.KeyChar);//사용자 키보드 입력한거 출력





    
        //제어문
        //switch
        /* switch(인스턴스) 인스턴스: 변수명
         * case 상숫식1: 
         *      구문1;
         *      break;
         * case 상숫식2: 
         *      구문1;
         *      break;
         *      .
         *      .
         *      .
         * default:
         *      구문n;
         *      break;
         *      
         *      
         *      case를 여러개 설정가능
         */

        char ch = 'F';
        switch (ch)
        {
            case 'M':
            case '남':
            case '男':
                Console.WriteLine("남성");
                break;

            case 'F':
                Console.WriteLine("여성");
                break;

            default:
                Console.WriteLine("기타성별");
                break;
        }

        //위에거 if로 변경
        if (ch == 'M')
            Console.WriteLine("남성");
        else if (ch == 'F')
            Console.WriteLine("여성");
        else
            Console.WriteLine("기타성별");


        //---------------------------------------

        string text = "C#";
        switch (text)
        {
            case "C#":
            case "VB,NET":
                Console.WriteLine(".NET 호환 언어");
                break;

            case "JAVA":
                Console.WriteLine("JVM언어");
                break;

            default:
                Console.WriteLine("알 수 없음");
                break;
        }
        if (text == "C#" || text == "VB.NET")
            Console.WriteLine(".NET 호환 언어");
        else if (text == "JAVA")
            Console.WriteLine("JAVA 호환 언어");
        else Console.WriteLine("알 수 없음");





    }
}