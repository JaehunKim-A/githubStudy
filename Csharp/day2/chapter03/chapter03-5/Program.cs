//예약어, 키워드 (preserved, keyword)
// C#에서 이미 사용하고 있는 단어

namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        //null 키워드 사용
        string? text = null; //null 값이 비워져있음
        int? a1 = 1;
        a1 = null;
        text = "null";

        Console.WriteLine(a1);
        Console.WriteLine(text);

        string text1 = ""; //empty 공백으로 보이지만 값이 존재

        System.Int32 a2 = 1;

        //데이터 타입의 기본값
        bool result; //변수 result 에 false 값이 있음, 이렇게 사용 x
        bool result1  = false;

        Console.WriteLine(result1);

        //상수(변하지 않는 수  const키워드 const 붙으면 값 수정시 error
        const bool result2 = false;
        // result2 = true; const 붙은 변수를 변경해서 에러
        Console.WriteLine(result2);
        //사용 예시)원의 넓이 구할때(PI) 
        double PI = 3.14;
        // PI = 3.25; 바뀌지 않아야 하는 값(PI)을 실수(mistake)로 변경할 수 있음

        //연산자( + - * % / )
        // % 나누었을때 나머지
        int z1 = 3 % 2;
        Console.WriteLine("3 % 2의 나머지는 " + z1);
        int z2 = 4 % 2;
        Console.WriteLine("4 % 2의 나머지는 " + z2);

        double x1 =(double) 3 / 2; //정수/정수 -> 정수, 실수/정수 -> 실수
        double x2 = 3 / 2.0;    //명시적으로 표현하지 않기 위해서는 2.0과 같이 써야함
        Console.WriteLine(x1);
        Console.WriteLine(x2);



    }
}