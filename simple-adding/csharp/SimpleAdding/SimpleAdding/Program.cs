using System;

class MainClass
{
    public static int SimpleAdding(int num)
    {
        var t = 0;
        for (int i = 1; i <= num; i++)
        {
            t += i;
        }
        return t;
    }

    static void Main()
    {
        // keep this function call here
        while (true)
        {
            Console.WriteLine(SimpleAdding(Convert.ToInt32(Console.ReadLine())));
        }
    }

}
