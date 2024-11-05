namespace ConsoleApp1;

class Program
{
    // 문제: 숫자 키 입력 받아 요일 출력
    //    Q.사용자로부터 1에서 7 사이의 숫자를 Console.ReadKey() 로 입력받아 해당 숫자에 맞는 요일을 출력하는 switch문을 작성하세요.
    // 1: "월요일"
    // 2: "화요일"
    // 3: "수요일"
    // 4: "목요일"
    // 5: "금요일"
    // 6: "토요일"
    // 7: "일요일"
    //그 외의 숫자가 입력되면 "잘못된 입력"을 출력하세요.
    static void Main(string[] args)
    {
        {
            Console.WriteLine("1 ~ 7 중 하나를 입력시오.");
            ConsoleKeyInfo keyInfo = Console.ReadKey(); //사용자의 키보드 입력을 받은 문자를 처리
            Console.WriteLine();
            Console.WriteLine("입력: " + keyInfo.KeyChar);//사용자 키보드 입력한거 출력
            if (keyInfo.KeyChar == '1')
                Console.WriteLine("월요일");
            else if (keyInfo.KeyChar == '2')
                Console.WriteLine("화요일");
            else if (keyInfo.KeyChar == '3')
                Console.WriteLine("수요일");
            else if (keyInfo.KeyChar == '3')
                Console.WriteLine("목요일");
            else if (keyInfo.KeyChar == '4')
                Console.WriteLine("금요일");
            else if (keyInfo.KeyChar == '6')
                Console.WriteLine("토요일");
            else if (keyInfo.KeyChar == '7')
                Console.WriteLine("일요일");
            else
                Console.WriteLine("다른 키를 입력하셨습니다.\n1 ~ 7 중 하나를 입력해 주십시오.");

            switch (keyInfo.KeyChar)
            {
                case '1':
                    Console.WriteLine("월요일");
                    break;
                case '2':
                    Console.WriteLine("화요일");
                    break;
                case '3':
                    Console.WriteLine("수요일");
                    break;
                case '4':
                    Console.WriteLine("목요일");
                    break;
                case '5':
                    Console.WriteLine("금요일");
                    break;
                case '6':
                    Console.WriteLine("토요일");
                    break;
                case '7':
                    Console.WriteLine("일요일");
                    break;
                default:
                    Console.WriteLine("다른 키를 입력하셨습니다.\n1 ~ 7 중 하나를 입력해 주십시오.");
                    break;
            }



        }

        /*문제: 간단한 메뉴 선택
         * Q.상용자에게 간단한 메뉴를 보여주고,Console.ReadKey()를 이용하여 메뉴를 선택하게 한 후
         * 해당 동작을 수행하는 코드 작성
         * 메뉴:
         * 1.프로그램 시작
         * 2.설정변경
         * 3.프로그램 종료
         * 사용자가 숫자 키 (1,2,3)를 누르면 각 동작에 맞는 메시지를 출력하세요.*/


        {
            Console.WriteLine("\n1, 2, 3 중 하나를 입력하시오.");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("입력: " + keyInfo.KeyChar);
            if (keyInfo.KeyChar == '1')
                Console.WriteLine("프로그램 시작");
            else if (keyInfo.KeyChar == '2')
                Console.WriteLine("설정변경");
            else if (keyInfo.KeyChar == '3')
                Console.WriteLine("프로그램 종료");
            else
                Console.WriteLine("다른 키를 입력하셨습니다.\n1, 2, 3 중 하나를 입력해 주십시오.");
            switch (keyInfo.KeyChar)
            {
                case '1':
                    Console.WriteLine("프로그램 시작");
                    break;
                case '2':
                    Console.WriteLine("설정변경");
                    break;
                case '3':
                    Console.WriteLine("프로그램 종료");
                    break;
                default:
                    Console.WriteLine("다른 키를 입력하셨습니다.\n1, 2, 3 중 하나를 입력해 주십시오.");
                    break;
            }

        }

        {


            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("입력: " + keyInfo.KeyChar);
            //문자 ->숫자
            int ketDigit = int.Parse(keyInfo.KeyChar.ToString());
            switch (ketDigit)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break;
                case 2:
                    Console.WriteLine("화요일");
                    break;
                case 3:
                    Console.WriteLine("수요일");
                    break;
                case 4:
                    Console.WriteLine("목요일");
                    break;
                case 5:
                    Console.WriteLine("금요일");
                    break;
                case 6:
                    Console.WriteLine("토요일");
                    break;
                case 7:
                    Console.WriteLine("일요일");
                    break;
                default:
                    Console.WriteLine("다른 키를 입력하셨습니다.\n1 ~ 7 중 하나를 입력해 주십시오.");
                    break;
            }
            //숫자 -> 문자 혹은 문자열
            string keyStr1 = ketDigit.ToString();//문자열
            Console.WriteLine("keyStr1: " + keyStr1);
            char keyChar1 = ketDigit.ToString()[0]; //문자
            Console.WriteLine("keyChar1: " + keyChar1);
        }
    



    }
}