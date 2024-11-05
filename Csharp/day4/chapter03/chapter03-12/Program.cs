﻿namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        /*증감연산자(++, --)
        ++ : 피연산자의 값을 1 증가
        -- : 피연산자의 값을 1 감소*/
        int n1 = 50;
        n1++; Console.WriteLine(n1); //n+1    51
        n1--; Console.WriteLine(n1); //n-1    50
        ++n1; Console.WriteLine(n1); //n+1    51 
        --n1; Console.WriteLine(n1); //n-1    50

        //증감연산자 실행 순서 파악
        int n2 = 50;
        Console.WriteLine(n2++); //50
        Console.WriteLine(n2++); //51
        Console.WriteLine(n2); //52

        int n3 = 50;
        Console.WriteLine(n3++); //50
        Console.WriteLine(++n3); //52
        Console.WriteLine(n3); //52

        Console.WriteLine("-----------------------------------------------------");
        int n = 50;
        int result;
        result = n++; // result에 50을 대입한 후 값을 51로 증가, result의 값은 50
        // 1. result = n
        // 2. n = n + 1
        Console.WriteLine(result);
        Console.WriteLine(n);

        n = 50;
        result = ++n; // n의 값을 51로 증가시킨 후에 result에 값을 대입, result의 값은 51
        //1. n = n + 1
        //2. result = n
        Console.WriteLine(result);
        Console.WriteLine(n);
        n = 50;
        result = n--; // result에 50을 대입한 후에 값을 49로 감소, result의 값은 50
        Console.WriteLine(result);
        Console.WriteLine(n);
        n = 50;
        result = --n; // n의 값을 49로 감소한 후에 result에 값을 대입, result의 값은 49
        Console.WriteLine(result);
        Console.WriteLine(n);


    }


}