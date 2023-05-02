class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(new Solution().RomanToInt("MMMDCCXXIV"));
    }
}

public class Solution
{
    public int RomanToInt(string s)
    {
        var array = s.ToArray();
        int result = 0;
        int currentVal = 0;

        for (int i = 0; i < array.Length-1; i++)
        {
            currentVal = RomanNumerals(array[i]);
            result += (RomanNumerals(array[i + 1]) > currentVal ? -1 : 1) * currentVal;
        }


        return result + RomanNumerals(array[array.Length-1]);

    }

    private int RomanNumerals(char c) => (c) switch
    {
        'I' => 1,
        'V' => 5,
        'X' => 10,
        'L' => 50,
        'C' => 100,
        'D' => 500,
        'M' => 1000,
          _ => 0,
    };
}