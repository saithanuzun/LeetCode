/*
 * 
 */

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(new Solution().IsValid("(()())"));
    }
}

class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> st = new();
        
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                st.Push(s[i]);
                continue;
            }

            if (st.Count == 0)
                return false;

            char top = st.Pop();
            
            if (top == '(' && s[i] != ')')
                return false;

            if (top == '[' && s[i] != ']')
                return false;

            if (top == '{' && s[i] != '}')
                return false;
        }

        return st.Count == 0;
    }
}