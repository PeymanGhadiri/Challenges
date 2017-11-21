using System;
using System.Text;

class MainClass
{
    private static Int16 isNumber=2;
    private static Int16 numberLowerLimit=48;
    private static Int16 numberUperLimit=57;
    
    private static Int16 isLowerLetter=3;
    private static Int16 lowerLetterLowerLimit=65;
    private static Int16 lowerLetterUpperLimit=90;

    private static Int16 isUpperLetter=5;
    private static Int16 upperLetterLowerLimit=97;
    private static Int16 upperLetterUpperLimit=122;
    
    private static Int16 isSpecial=7;
     
    private static Int16 GetType(char c)
    {
        if (c >= 48 && c <= 57)
            return isNumber;
        else if (c >= 65 && c <= 90)
            return isLowerLetter;
        else if (c >= 97 && c <= 122)
            return isUpperLetter;

        return isSpecial;
    }

    public static string LongestWord(string sen)
    {
        var res = new StringBuilder();
        var current = new StringBuilder();
        Int16 lastCharType = 0;

        var len = sen.Length;
        for (var i = 0; i < len; i++)
        {
            var c = sen[i];
            var cType = GetType(c);

            if (cType == isSpecial ||
                (cType == isNumber && (lastCharType != isNumber && lastCharType != 0))
                || i == (len - 1))
            {
                if (i == (len - 1) && 
                    ((cType == isNumber && lastCharType == isNumber) || 
                        ((cType == isLowerLetter || cType == isUpperLetter) && 
                            (lastCharType == isLowerLetter || lastCharType == isUpperLetter) )))
                {
                    current.Append(c);
                }

                if (res.Length < current.Length)
                {
                    res.Clear();
                    res.Append(current);
                }

                current.Clear();
                lastCharType = 0;
            }
            else
            {
                current.Append(c);
                lastCharType = cType;
            }
        }

        return res.ToString();

    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine(LongestWord(Console.ReadLine()));
        }
    }

    
}