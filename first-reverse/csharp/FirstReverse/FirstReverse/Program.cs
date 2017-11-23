using System;
using System.Text;

class MainClass
{
    public static string FirstReverse(string str)
    {
        var sb=new StringBuilder();
        for (int i = str.Length-1; i >=0; i--)
        {
            sb.Append(str[i]);
        }
        return sb.ToString();

    }

    static void Main()
    {
        // keep this function call here
        while (true)
        {
            Console.WriteLine(FirstReverse(Console.ReadLine()));
        }
    }

}