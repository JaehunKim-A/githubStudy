class Program
{
    static void Main(string[] args)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(); // 사용자의 키보드 입력을 받은 문자를 처리
        Console.WriteLine(); // 줄바꿈
        // 입력받은 문자 출력
        Console.WriteLine("입력한 값: " + keyInfo.KeyChar);  // 사용자 키보드 입력한 거 출력


        string keyStr1 = keyDigit.ToString();   // 문자열
        Console.WriteLine("keyStr1: " + keyStr1);
        char keyChar1 = keyDigit.ToString()[0]; // 문자
        Console.WriteLine("keyChar1: " + keyChar1);

        switch (keyStr1)
        {
            case "1": Console.WriteLine("월요일"); break;
            case "2": Console.WriteLine("화요일"); break;
            case "3": Console.WriteLine("수요일"); break;
            case "4": Console.WriteLine("목요일"); break;
            case "5": Console.WriteLine("금요일"); break;
            case "6": Console.WriteLine("토요일"); break;
            case "7": Console.WriteLine("일요일"); break;
            default: Console.WriteLine("잘못된 입력"); break;
        }
    }
}
