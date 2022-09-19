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

