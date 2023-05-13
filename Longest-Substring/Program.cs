
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(new Solution().LengthOfLongestSubstring("bbbbbb"));
    }
}

public class Solution 
{
    public int LengthOfLongestSubstring(string s)
    {
        List<char> list = new();
        int maxLength = 0;

        for (int i = 0; i < s.Length;i++)
        {
            char c = s[i];

            if (!list.Contains(c))
            {
                list.Add(c);
            }
            else
            {
                maxLength = maxLength > list.Count ? maxLength : list.Count;

                while (list.Contains(c))
                {
                    list.RemoveAt(0);
                }
                list.Add(c);
            }

        }

        return maxLength > list.Count ? maxLength : list.Count;
    }
}