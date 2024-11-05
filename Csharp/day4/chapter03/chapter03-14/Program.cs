namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        //반복문(while, for)
        /*while문 문법 )if문과 마찬가지로 1개 이상의 구문을 실행하려면 중괄호 사용
         * while(조건식)
         * 구문:
         * 
         * while(조건식) 구문;
         * {
         * 
         * }
         */
        //1~1000까지 더하는 while
        int sum = 0;
        int n = 1; //시작값
        while (n <= 1000)
        {
            sum += n; //sum = sum + n
            //Console.WriteLine(n + ":" + sum);
            n++;

        }
        Console.WriteLine(sum);

        //1~1000 짝수만 더한값
        sum = 0;
        n = 1; //시작값
        while (n <= 1000)
        {
            if (n % 2 == 0)//짝수
            {
                sum += n;
                //Console.WriteLine(n + ":" + sum);
                //console.writeline($"{n}:{sum}");
            }
            n++;
        }
        Console.WriteLine(sum);

        //1~1000 짝수 제외 더한 값
        /*sum= 0;
        n = 1;
        while (n <= 1000)
        {
            if (n % 2 == 0)
                sum -= n;
            sum += n;
            Console.WriteLine(n + ":" + sum);
            n++;
        }
        Console.WriteLine(sum);
        */

        //do~while문(do 문이 1번은 실행되는 while 문)
        /* do {
         *     구문1;
         *     구문2;
         *     }while(조건식);
         */
        sum = 0;
        n = 0;

        do { if (n % 2 == 0) sum += n; } while (++n <= 1000);//짝수 합 구하기
        Console.WriteLine(sum);





    }
}