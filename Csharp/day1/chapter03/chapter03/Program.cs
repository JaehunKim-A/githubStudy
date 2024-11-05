//3.1 기본 자료형
//3.1.1 정수형 기본 타입


/* signed > 부호가 있는 ex) (s)byte, unsigned  > 부호가 없는 ex) byte
 * byte만 반대(s 표시)
 * int -> (u)int
 */
namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 100;
        long sum;

        int n1 = 50;
        int n2;
        n2 = 101;
        sum = 50;

        sum = n1 + n2;
        sum = 14; // 위에 저장된 sum이 없어짐 마지막에 저장된 값이 나옴
        Console.WriteLine(sum);

        System.Int32 c1 = 10;
        System.Int32 c2;
        c2 = 100;

        System.Int32 sum2 = c1 + c2;
        Console.WriteLine(sum2);
    }
}
