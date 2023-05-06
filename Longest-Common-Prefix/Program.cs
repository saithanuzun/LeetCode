
class Program
{
    public static void Main(string[] args)
    {
        
    }
}

public class Solution 
{
    public string LongestCommonPrefix(string[] strs)
    {
        string prefix = strs[0];

        if (strs.Length < 1) 
            return "";

        foreach (string str in strs)
        {
            if (!prefix.Equals(str)) 
            {
                if (prefix.Length > str.Length)
                    prefix = prefix.Substring(0, str.Length);

                if (!prefix.Equals(str))
                {
                    for (int i = 0; i < prefix.Length; i++)
                    {
                        if (!prefix[i].Equals(str[i]))
                            prefix = prefix.Substring(0, i);
                    }
                }
            }
        }

        return prefix;
    }
}