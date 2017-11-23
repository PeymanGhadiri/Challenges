using System;
using System.Text;

class MainClass
{
    public static string LetterChanges(string str)
    {
        var sb=new StringBuilder();
        for (int i = 0; i < str.Length; i++)
        {

            var c = Convert.ToInt32(str[i]);
            if (IsLetter(c))
            {
                if (c == 90 || c == 122) //for Z & z
                    c -= 25;
                else
                    c += 1;

                if (c == 97 || c == 101 || c == 105 || c == 111 || c==117)
                    c -= 32;
            }
            sb.Append(Convert.ToChar(c));
        }
        return sb.ToString();
    }

    private static bool IsLetter(Int32 c)
    {
        return (c >= 65 && c <= 90) || (c>=97 && c<=122);
    }
    static void Main()
    {
        // keep this function call here
        while (true)
        {
            Console.WriteLine(LetterChanges(Console.ReadLine()));
        }
    }

}