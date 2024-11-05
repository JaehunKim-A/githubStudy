using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CosnsoleApp1;
class Program
{
    // 문제: 로또 프로그램 만들기
    // 로또 프로그램의 조건
    //   (1) 1 ~ 45까지 랜덤한 숫자 6자리를 출력
    //   (2) 숫자 6개는 같은 숫자가 나올 수 없다.

    // 예시
    //   생성된 로또 번호: 5 6 7 19 44 1
    //   프로그램 종료
    static void Main(string[] args)
    {

        int[] lottoNumbers = new int[6];
        int count = 0;
        // 코드작성(while문과 if문 break를 활용하여 작성)
        while (count <= 6)
        {
            Random random = new Random();
            int lottery = random.Next(1, 7);
            lottoNumbers[count] = lottery;
            bool isDuplicate = false;
            int checkcnt= 0;
            while(checkcnt < 6) 
            {
                if (lottoNumbers[count] == lottery)
                {
                    isDuplicate = true;
                    break;
                }
                checkcnt++;
                if(!isDuplicate)
                {
                    lottoNumbers[count] = lottery;
                    count++;
                }
            }

        }
        Console.WriteLine("생성된 로또 번호: " + string.Join(", ", lottoNumbers));


        /* 답
        Random random = new Random();
        int[] lottoNumbers = new int[6];
        int index = 0;

        // 코드작성(while문과 if문 break를 활용하여 작성)
        while (index < lottoNumbers.Length)
        {
            int newNumber = random.Next(1, 46);

            bool isDuplicate = false;
            // 중복된 값이 있는지 체크하는 코드
            int checkIndex = 0;
            while(checkIndex < index)
            {
                if (lottoNumbers[checkIndex] == newNumber)
                {
                    isDuplicate = true;
                    break;
                }
                checkIndex++;
            }

            if(!isDuplicate)    // 중복된 값이 없으면 로또번호로 저장
            {
                lottoNumbers[index] = newNumber;
                index++;
            }
        }

        Console.WriteLine("생성된 로또 번호");
        int printIndex = 0;
        while(printIndex < lottoNumbers.Length)
        {
            Console.Write(lottoNumbers[printIndex] + " ");
            printIndex++;
        }*/



    }
}

//중복이 나오면 중지 후 다시 실행
//배열 수가 나온 수랑 같을때 없에면 됨