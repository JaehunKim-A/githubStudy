namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {

        /*int sum = 0;
        int n = 1;
        while (n++<=1000)
        {
            if (n % 2 != 0) 
            { 
                continue; 
            }
            sum += n;
        }*/
        

        // 1 ~ 1000까지 사이 수 중에서 2의 배수이고 3의 배수이고 5의 배수만 합산하는 프로그램
        int sum = 0;
        int n = 1;
        while (n++ <= 1000)
        {
            // 첫번째 방법
            //if (((n % 2) == 0) && ((n % 3) == 0) && ((n % 5) == 0)) sum += n;

            // 두번째 방법
            /*if ((n % 2) == 0)
            {
                if ((n % 3) == 0)
                {
                    if ((n % 5) == 0)
                    {
                        sum += n;


                    }
                }
            }*/

            // 세번째 방법
            if ((n % 2) != 0) continue;
            if ((n % 3) != 0) continue;
            if ((n % 5) != 0) continue;
            sum += n;
            Console.WriteLine(n);
        }

        


    }
}