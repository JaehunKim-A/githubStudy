namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        ConsoleKeyInfo KeyInfo = Console.ReadKey(); //사용자의 키보드 입력을 받은 문자를 처리
        //입력받은 문자 출력
        Console.WriteLine();
        Console.WriteLine("입력: "+KeyInfo.KeyChar);//사용자 키보드 입력한거 출력

        switch (KeyInfo.KeyChar)
        {
            case 'M':
            case 'm':
                Console.WriteLine("남성");
                break;

            case 'f':
            case 'F':
                Console.WriteLine("여성");
                break;

            default:
                Console.WriteLine("기타성별");
                break;
        }






    }
}