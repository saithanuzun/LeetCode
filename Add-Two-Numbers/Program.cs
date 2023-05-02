/*
 * You are given two non-empty linked lists representing two non-negative integers.
 * The digits are stored in reverse order, and each of their nodes contains a single digit.
 * Add the two numbers and return the sum as a linked list.
 * You may assume the two numbers do not contain any leading zero, except the number 0 itself.
 * 
 */

using System.Text;
class Program
{
    public static void Main(string[] args)
    {
        ListNode iter = new();
        
        var sum = new Solution().ReverseSum("243", "564");
        

        ListNode Head = null;

        for (int i = 0; i < sum.Length ; i++)
        {
            Head = new Solution().AddNode(sum[i] - '0', Head);
        }

        
        Console.WriteLine(sum);
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
}

public class Solution
{
    
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var number1 = GetListString(l1);
        var number2 = GetListString(l2);

        var sum = ReverseSum(number1, number2);

        
        ListNode Head = null;

        for (int i = 0; i < sum.Length ; i++)
        {
            Head = AddNode(sum[i] - '0', Head);
        }

        return Head;
    }

    public ListNode AddNode(int val,ListNode Head)
    {
        ListNode node = new() { val = val, next = null };

        if (Head is null)
            return node;

        ListNode iter = Head;

        while (iter.next is not null)
        {
            iter = iter.next;
        }

        iter.next = node;

        return Head;

    }

    public string GetListString(ListNode list)
    {
        StringBuilder sb = new();
        ListNode iter = list;

        while (iter.next is not null)
        {
            sb.Append(iter.val);
            iter = iter.next;
        }

        return sb.ToString();
    }

    public string ReverseSum(string num1, string num2)
    {
        StringBuilder sb = new();

        int i = num1.Length-1;
        int j = num2.Length-1;

        int carry = 0;

        while (i >= 0 || j >= 0)
        {
            int number1 = i >= 0 ? num1[i] - '0' : 0;
            int number2 = j >= 0 ? num2[j] - '0' : 0;
            i--;
            j--;
            int sum = number1 + number2 + carry;
            carry = sum / 10;
            sb.Append(sum % 10);
            
        }

        if (carry > 0)
        {
            sb.Append( 1);
        }

        return sb.ToString();
    }
    
}