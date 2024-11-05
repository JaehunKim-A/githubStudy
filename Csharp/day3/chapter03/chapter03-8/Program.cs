using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        //제어문
        //if문
        //0은 남성 1은 여성
        //조건문이 true면 구문을 실행 false 면 구문 실행 안함


        //프로그램 내용 : 3의 배수일 경우에 3의 배수 출력이 되는 프로그램
        /*if {} 없는 경우 구문을 1개만 실행 가능
          if {} 있는 경우 구문을 1개 이상 실행 가능
          ;까지가 한 덩어리이기에 본인이 원하는 덩어리를 만들 때 확인 잘 해야함*/
        int a = 5;
        int b = 6;
        if (a % 3 == 0)
            Console.WriteLine("a는 3의 배수");
        if ((b % 3 == 0) && (b % 2 == 0))
        {
            Console.WriteLine("b는 3의 배수");
            Console.WriteLine("b는 2의 배수");
        }
        if (6 % 3 == 0)
        {
            Console.WriteLine("6은 3의 배수");
            Console.WriteLine("연산결과 끝!");
        }
        //if문에서 짝수 ㅎㄹ수 구분해서 출력하기

        long value = 5;
        if (value % 2 == 0)
        {
            Console.WriteLine("value는 2의 배수이다.");
            Console.WriteLine("따라서 value는 짝수이다.");
        }
        else
        {
            Console.WriteLine("value는 짝수가 아니다.");
        }

        //else if 사용하기 무한대로 사용 가능
        if (value <= 255)
            Console.WriteLine("byte로 변환가능");
        else if (value <= 65535)
            Console.WriteLine("ushort로 변환가능");
        else if (value <= 2147483647) //문제: 21억 이하면 int타입으로 변환이 가능 출력
            Console.WriteLine("int로 변환가능");
        else
            Console.WriteLine("long타입");


        //삼항연산자
        //문법: (조건식)?표현식 : 표현식2
        // 조건식이 true 이면 표션식1을 실행 false 이면 표현식2 실행
        int value2 = 5;
        string result;
        if (value2 % 2 == 0)
            result = "짝수";
        else
            result = "홀수";
        Console.WriteLine(result);
        //위 코드를 삼항연산자로 변환
        string result1 = (value2 % 2 == 0) ? "짝수" : "홀수";
        Console.WriteLine(result1);

        //문제1. 변수 age가 20이상이고 hasLicense가 ture일 경우 운전가능을 출력

        int age = 20;
        bool hasLicense = true;
        if (age >= 20 && hasLicense)
            Console.WriteLine("운전가능");
        else
            Console.WriteLine("운전불가능");
        string resultprb1 = (age >= 20 && hasLicense)?"운전가능":"운전불가";
        Console.WriteLine(resultprb1);

        /* 문제2: 아래 변수 isWeekend와 isHoliday중 하나라도 true일 경우 쉬는 날입니다 출력
         * false일 경우 일하는 날입니다 출력*/

        bool isWeekend = true;
        bool isHoliday = false;
        if (isWeekend || isHoliday)
            Console.WriteLine("쉬는 날입니다.");
        else
            Console.WriteLine("일하는 날 입니다.");
        string resultprb2 = (isWeekend || isHoliday) ? "쉬는 날입니다" : "일하는 날입니다";
        Console.WriteLine(resultprb2);



    }
}