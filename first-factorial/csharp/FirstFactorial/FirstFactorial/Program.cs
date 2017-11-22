using System;

class MainClass
{
    public static int FirstFactorial(int num)
    {
        var f = num;
        for (int i = num-1; i > 1; i--)
        {
            f = f * i;
        }
        return f;
    }

    static void Main()
    {
        while (true)
        {
            // keep this function call here
            Console.WriteLine(FirstFactorial(Convert.ToInt32(Console.ReadLine())));
        }
    }

}