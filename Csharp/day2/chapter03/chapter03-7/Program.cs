namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        //제어문(control statment)
        //0.관계 및 논리연산자
        //  -관계연산자: >(초과), >=(이상), <=(이하), <(미만), ==(같다), !=(다르다)
       

        bool result1 = 10 > 20;
        Console.WriteLine(result1); //false
        
        bool result2 = 10 < 20;
        Console.WriteLine(result2); //true

        int value1 = 6;
        int n1 = value1 % 3; // % 나누고 나머지
        bool result3 = (n1 == 0);
        Console.WriteLine(result3);

        //  -논리연산자: &&(and) 둘중 하나가 fasle면 false
        //               ||(or) 둘중 하나가 true면 true
        //               !(not) ->!()앞에 써야함, 반대값이 나옴

        int value2 = 10;
        int n2 = value2 % 3;
        int n3 = value2 % 5;

        bool orResult1 = (n2 == 0 || n3 == 0); //n3가 0이라 true가 나온다
        bool orResult2 = (n2 == 0 && n3 == 0); //n2이 1이라 false가 나온다
        bool orResult3 = !(n2 == 0); //나머지가 1이라 false지만 !로 반대인 true가 나온다
        Console.WriteLine(orResult1);
        Console.WriteLine(orResult2);
        Console.WriteLine(orResult3);


        int n11 = 6;
        int n12 = 10;
        bool result11 = (n11 % 3 == 0 || n12 % 3 == 0); //6은 3의 배수이거나 10이 3의 배수이면 true
        Console.WriteLine("n11 또는 (or) n12 는 3의 배수 : " + result11);
        bool result12 = (n12 %  3 == 0 && n11 % 3 == 0);
        Console.WriteLine("n11갑이 3의 배수이고(and) n12는 3의 배수 : "+ result12);

        /* 문제1. 다음 조건을 만족하는 논리 연산을 사용하여 맞으면 '운전 가능' 출력
         * 틀리면 '운전 불가능' 출력
         * 조건 : 변수 age가 70이상이고 hasLicense가 true일 경우 true, 틀리면 false 출력*/

        int age = 40;
        bool hasLicense = true;
        bool Presult = (age >= 70 && hasLicense);
        Console.WriteLine(age >= 70 && hasLicense);

        switch (Presult)
        {
            case true:
                Console.WriteLine("운전 불가능");
                break;

            case false:
                Console.WriteLine("운전 가능");
                break;

        } 

        /* 문제2. 아래 변수 isWeekend와 isHoliday 중 하나라도 true일 겨우 true를 출력 아니면 
         * false를 출력*/
        bool isWeekend = false;
        bool isHoliday =true;
        Console.WriteLine(isWeekend || isHoliday); 

        /*문제3. 아래 변수를 사용하여 조건을 만족할 때true 아니면 false
         * temperatur 20이상 30이하
         * isRainy는 false*/

        // true 가 나왔을때 온도가 20도이상 30도이하 비가 오지않음
        int temperatur = 25;
        bool isRainy = false;
        Console.WriteLine(temperatur>=20 && temperatur <= 30 && isRainy);
      





    }
}