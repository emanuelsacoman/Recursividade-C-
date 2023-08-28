using System;

class MainClass {
    public static int MDecRecursive(string s) {
        if (s.Length == 1) {
            Console.WriteLine($"Mdec(<{s}>) = {s}");
            return int.Parse(s);
        } else {
            string prefix = s.Substring(0, s.Length - 1);
            char lastDigit = s[s.Length - 1];

            int subResult = MDecRecursive(prefix);
            int result = 10 * subResult + (int)char.GetNumericValue(lastDigit);

            Console.WriteLine($"Mdec(<{prefix}> '{lastDigit}') = 10 * Mdec(<{prefix}>) + {lastDigit} = {result}");
            return result;
        }
    }

    public static void Main(string[] args) {
        string number = "724822";
        int result = MDecRecursive(number);
        Console.WriteLine($"Final result: {result}");
    }
}
