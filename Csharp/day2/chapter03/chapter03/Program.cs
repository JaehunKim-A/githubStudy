//문자형 기본타입
//1. char : 유니코드 16bit 문자 (cf) 8bit(256ro) ASCII코드
//2. string

//boolean
//1. bool : ture, false만 가능
namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        char ch1 = 'A';
        char ch2 = 'b';
        char ch3 = '\\';
        string text1 = @"\t hello\";         //tab 문자 표현 \t
        string text2 = "\tMissing \nHello";     //행 변경 \n
        string text3 = "HI";
        string str1 = "\"hello world\"";
        string str2 = "dasdaddd";
        string str3 = "\tdsadsa";


        Console.WriteLine(str2);
        Console.Write(str3);
        Console.WriteLine(str1);
        Console.WriteLine(text3 + " " + "lol");
        Console.WriteLine(ch1);
        Console.WriteLine(ch2);
        Console.WriteLine(ch3);
        Console.WriteLine(text1);
        Console.WriteLine(text2);

        char ch4 = '\t';
        char ch5 = 't';
        char ch6 = '\n';
        char ch7 = 'o';

        Console.Write(ch4);
        Console.Write(ch5);
        Console.Write(ch6);
        Console.Write(ch7 + "\n");

        char ch8 = 'h';
        char ch9 = 'i';

        Console.Write(ch8); 
        Console.Write(ch9);

        char ch10 = '\u0021';

        Console.WriteLine(ch10);

        string sp1 = "▶";

        Console.WriteLine(sp1);

        bool bl1 = true;
        Console.WriteLine("bl1의 값은 " + bl1);

    }
}