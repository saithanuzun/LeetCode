/*
 * Given two non-negative integers,
 * num1 and num2 represented as string, return the sum of num1 and num2 as a string.
 */

using System.Text;

class Program
{
    public static void Main()
    {
        string input1 = "2355", input2 = "2349";

        Console.WriteLine(Solution.AddStrings(input1, input2));
    }
}

public static class Solution
{
    public static string AddStrings(string num1, string num2)
    {
        StringBuilder sb = new();

        int maxLength = num1.Length > num2.Length ? num1.Length : num2.Length;

        var number1 = num1.Reverse().ToArray().SetArray(maxLength);
        var number2 = num2.Reverse().ToArray().SetArray(maxLength);

        int carry = 0;
        for (int i = 0; i < maxLength; i++)
        {
            int sum = carry + number1[i].GetInt() + number2[i].GetInt();
            carry = 0;

            if (sum > 9)
            {
                carry = sum / 10;
                sb.Insert(0, sum % 10);
                continue;
            }
            
            sb.Insert(0, sum);
        }

        if (carry > 0)
        {
            sb.Insert(0, carry);
        }

        return sb.ToString();
    }

    public static int GetInt(this char chr) => chr - '0';

    public static char[] SetArray(this char[] array, int length)
    {
        if (array.Length >= length)
        {
            return array;
        }

        char[] result = new char[length];

        for (int i = 0; i < array.Length; i++)
        {
            result[i] = array[i];
        }

        for (int i = array.Length; i < length; i++)
        {
            result[i] = '0';
        }

        return result;
    }
}