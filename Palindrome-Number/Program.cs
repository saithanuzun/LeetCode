using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(new Solution().IsPalindrome(101));
    }
}

class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;

        int number = x;
        int number2 = 0;
        int i = 0;

        while (x != 0)
        {
            number2 = number2 * 10 + x % 10;
            i++;
            x /= 10;
        }

        return number == number2;
    }
}