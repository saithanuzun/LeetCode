
class Program
{
    public static void Main()
    {
        //example of overflow
        int x = 2000000000;
        int y = 1900000000;
        int z = x * y;//z = int.max
        
        if (z/y != x) // true
        {
            Console.WriteLine("that's true");
        }
            
        
        Console.WriteLine(new Solution().Reverse(-1388889219));
    }
}

class Solution
{
    public int Reverse(int x)
    {
        int result = 0;

        while (x != 0)
        {
            int remainder = x % 10;
            int temp = result * 10 + remainder;

            if ((temp - remainder) / 10 != result)
            {
                return 0;
            }

            result = temp;
            x /= 10;
        }
        
        return result;
    }
}