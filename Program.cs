using System;

/*

//Your goal is to create a function that removes the first and last characters of a string. You're given one parameter, the original string. You don't have to worry about strings with less than two characters.

class Program
{
    static void Main()
    {
        var Remove_char = new Kata();
        string res = Kata.Remove_char("Hello, World!");
        System.Console.WriteLine(res);
    }
}

public class Kata
{
    public static string Remove_char(string s)
    {
        return s.Substring(1, s.Length - 2);
    }
}

*/

/*
//This kata is about multiplying a given number by eight if it is an even number and by nine otherwise.

class Program
{
    static void Main()
    {
        var Multiplier = new Multiplier();
        int res = Multiplier.Multiply(3);
System.Console.WriteLine(res);
    }
}

public class Multiplier
{
  public static int Multiply(int x) 
  {
    return x % 2 == 0 ? x * 8 : x * 9;
  }
}  

*/


/*
//Given a random non-negative number, you have to return the digits of this number within an array in reverse order.


namespace Solution
{

    class Program
    {
        static void Main()
        {
            var Digitizer = new Digitizer();
            var res = Digitizer.Digitize(35231);
            System.Console.WriteLine(string.Join(", ", res));
        }
    }

    class Digitizer
    {
        public static long[] Digitize(long n)
        {
            string input = n.ToString();
            var res = new List<long>();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                res.Add(Convert.ToInt64(input.Substring(i, 1)));
            }
            return res.ToArray();
        }
    }
}
*/

