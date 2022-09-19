using System;

/*
//챕터 1 연습문제 5_1
delegate void Delegate();
class ExerciseCH1_5_1
{
    public static void Method1()
    {
        Console.WriteLine("In the method1....");
    }
    public static void Method2()
    {
        Console.WriteLine("In the method2...");
    }
    public static void Main()
    {
        Delegate d = new Delegate(Method1);
        d += new Delegate(Method2);
        d();
    }

}*/

/*
//챕터 1 연습문제 5_2
class ExerciseCH1_5_2
{
    public static void Main()
    {
        int i = 1, j = 0, k;
        try
        {
            Console.WriteLine("Exception checking...");
            k = i / j;
            Console.WriteLine("After Exception happening");
        } catch (Exception e)
        {
            Console.WriteLine("Caught Exception...");
        } finally
        {
            Console.WriteLine("In the finally statement...");
        }

    }
}*/


/*//챕터 1 연습문제 5_3
class ExerciseCH1_5_3
{
    public static void Main(string[] args)
    {
        foreach (string s in args)
            Console.WriteLine(s);
    }
}*/

/*---- 2장 예제 및 실습 문제 -----*/


/* 열거형 
 * 지정어 : enum , 내부의 원소는 0부터 시작하는 순서값을 가진다.
 * 정수형 <-> 열거형 으로 교환 가능하다.*//*

enum Color { Red, Green, Blue };
class EnumTypeApp
{
    public static void Main()
    {
        Color c = Color.Red;
        c++;
        int i = (int)c;
        Console.WriteLine("Cardinality of "+c+" =  "+i);
    }
}*/

