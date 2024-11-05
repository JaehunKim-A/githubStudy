namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        int n1 = 1;
        int n2;
        n2 = 1;
        long sum = n1 + n2;
        Console.WriteLine(sum);


        /*문제 1 정수형 변수 age에 25할당하고 출력하느 코드 작성
         * 2 소수점 값을 가지는 height변수에 175.5 할당*/
        byte age = 25;
        float height = 175.5f;

        /*문제 2 다음 코드에서 오류를 수정하시오
         * byte num = 300;
           int result = num + 100.5;*/
        int num = 300;
        float result = num + 100.5f;


        Console.WriteLine(age);
        Console.WriteLine(height);
        Console.WriteLine(num);
        Console.WriteLine(result);
    }
}