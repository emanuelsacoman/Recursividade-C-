using System;

class Program
{
    static int MDecRecursive(string s)
    {
        if (s.Length == 1)
        {
            Console.WriteLine($"Mdec(<{s}>) = {s}");
            return Convert.ToInt32(s);
        }
        else
        {
            string prefix = s.Substring(0, s.Length - 1);
            char lastDigit = s[s.Length - 1];

            int subResult = MDecRecursive(prefix);
            int result = 10 * subResult + Convert.ToInt32(lastDigit);

            Console.WriteLine($"Mdec(<{prefix}> '{lastDigit}') = 10 * Mdec(<{prefix}>) + {lastDigit} = {result}");
            return result;
        }
    }

    static void Main(string[] args)
    {
        string number = "853";
        int result = MDecRecursive(number);
        Console.WriteLine($"Final result: {result}");
    }
}