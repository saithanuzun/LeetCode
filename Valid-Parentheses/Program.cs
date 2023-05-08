/*
 * 
 */

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(new Solution().IsValid("(()[]())"));
    }
}

class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> st = new();
        var charArray = s.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (charArray[i] == '(' || charArray[i] == '[' || charArray[i] == '{')
            {
                st.Push(charArray[i]);
                continue;
            }

            if (st.Count == 0)
                return false;

            char top = st.Pop();
            
            if (top == '(' && charArray[i] != ')')
                return false;

            if (top == '[' && charArray[i] != ']')
                return false;

            if (top == '{' && charArray[i] != '}')
                return false;
        }

        return st.Count == 0;
    }
}