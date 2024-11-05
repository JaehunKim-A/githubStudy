//형변환 type converstion
//1.암시적
//2.명시적

namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        byte b = 250;
        short s = b;            //작은거 -> 큰거 암시적 변환


        Console.WriteLine(s);

        short s1 = 25000; //명시적 형변환 -> 표시안함
        byte b1 = (byte)s1;
        Console.WriteLine(b1);

        ushort u =65;  //0~65000
        char c = (char)u; //0000~ffff 정수형 -> 문자형일 겨우 명시적 형변환 허용

        Console.WriteLine(c);

        /*문제1. byte byteValue = 10byte byteValue = 10
         *      char charValue = A
         *      컴파일 에러가 나오는 케이스
         *      1. int intValue - byteValue
         *      2. int intValue = charValue (error
         *      3. short shortValue = charValue (error
         *      4. double doubleValue = byteValue


    }
}