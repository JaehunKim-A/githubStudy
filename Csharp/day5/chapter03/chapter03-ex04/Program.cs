using System.Security.Cryptography;
using System;

namespace ConsoleApp1;

class Program
{
    // 문제: 문자열 배열에서 길이가 4 이상인 문자열 출력
    //   Q: 아래과 같은 문자열 배열이 주어졌을 때,
    //      foreach문을 사용하여 길이가 4 이상인 문자열을 출력하세요.
    static void Main(string[] args)
    {
        string[] words = { "cat", "dog", "elephant", "lion", "tiger" };
        // 코드 작성
        foreach (string elem in words)
        {
            if(elem.Length >= 4)
            Console.WriteLine(elem);
        }
        // 문제2: 배열의 최대값 찾기
        //    Q: 아래와 같은 정수 배열이 주어졌을 때,
        //       foreach문을 사용하여 최대값을 찾아 출력하세요.
        int[] numbers = { 34, 67, 23, 89, 12, 56 };
        // 코드 작성
        int maxnum = numbers[0];
        foreach (int num in numbers)
        {
            if (maxnum < num)
            {
                maxnum = num;
            }
        }
        Console.WriteLine(maxnum);

        int minnum = numbers[0];
        foreach (int num in numbers)
        {
            if (minnum > num)
            {
                minnum = num;
            }
        }
        Console.WriteLine(minnum);
    }
}