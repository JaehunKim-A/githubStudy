using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        //배열 array
        int[] productPrices = new int[4];
        string[] productNames = new string[4];

        //배열 start number는 0부터 시작

        productPrices[0] = 5000;
        productPrices[1] = 5500;
        productPrices[2] = 6000;
        productPrices[3] = 10000;

        int i = 0;
        productPrices[i] = 5200; //마지막에 넣은 값이 우선

        Console.WriteLine(productPrices[0]);

        int book = productPrices[1] + productPrices[2];
        Console.WriteLine(book);

        //배열선언 및 초기화
        int[] products = new int[5] {1,2,3,4,5};
        int[] products2 = {1,2,3,4,5};

        Console.WriteLine(products[0]);
        Console.WriteLine(products[1]);
        Console.WriteLine(products2[0]);


        //문자열에 대한 배열
        string text = "hello world"; //총 문자가 11개 12번째를 출력하려고하면 오류
        char ch1 = text[10]; 

       Console.WriteLine(ch1);

        //배열의 기본값(int의 경우0, float = 0 string = null)

        int[] students = new int[60];
        Console.WriteLine(students[0]);
        float[] students2 = new float[60];
        Console.WriteLine(students2[0]);
        string[] students3 = new string[60];
        Console.WriteLine(students3[0]);
        double[] students4 = new double[60];
        Console.WriteLine(students4[0]);

        //다차원배열
        //2차원
        int[,] arr2 = new int[60,60]; //60*60 int 2차원 배열

        //3차원
        int[,,] arr3 = new int[60,60,60]; //60*60*60 int 3차원 배열


        int[,] arr4 = new int[2, 3]
        {
            {1,2,3},
            {4,5,6},
         };


        Console.WriteLine(arr4[1,2] + "\n");


        //가변배열
        int[][] arr = new int[5][];
        arr[0] = new int[10]; //0번재 index의 10개의 열을 가진 배열
        arr[1] = new int[8];
        arr[2] = new int[7];
        arr[3] = new int[3];
        arr[4] = new int[2];

        //문제1. int[] arr6 = {1,2,3,4,5,6}; arr6의 평균값을 출력하는 코드를 작성 소수점까지

        int[] arr6 = { 1, 2, 3, 4, 5, 6 };
        int sum = arr6.Sum(); //배열의 숫자의 합
        Console.WriteLine((double)sum/arr6.GetLength(0)); //.GetLength(0) 행의 개수
                                                          //.GetLength(1) 열의 개수
                                                          //.Length() 배열의 전체 원소개수

        Console.WriteLine("\t"+sum);

        int problem1 = arr6[1] + arr6[2] + arr6[3] + arr6[4] + arr6[5] + arr6[0];
        double problem2 = (double)problem1 / 6;
        Console.WriteLine(problem2);

        double problem = (double)(1 + 2 + 3 + 4 + 5 + 6) / 6;
        Console.WriteLine(problem);

        //문제 답
        Console.WriteLine((arr6[0] + arr6[1] + arr6[2] + arr6[3] + arr6[4] + arr6[5])/ 6.0);
        Console.WriteLine((arr6[0] + arr6[1] + arr6[2] + arr6[3] + arr6[4] + arr6[5]) /(double)6);





    }
}