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
        int[] array1 = new[] { 2, 4, 3 };
        int[] array2 = new[] { 5, 6, 4 };

        ListNode l1 = null, l2 = null;

        for (int i = 0; i < array1.Length; i++)
        {
            Solution.AddNode(array1[i], ref l1);
        }

        for (int i = 0; i < array2.Length; i++)
        {
            ListNode node = new() { value = array2[i] };
            Solution.AddNode(array2[i], ref l2);
        }

        var sum = Solution.AddTwoNumbers(l1, l2);


        while (sum is not null)
        {
            Console.WriteLine(sum.value);
            sum = sum.next;
        }
    }
}

public class ListNode
{
    public int value;
    public ListNode next;
}

public class Solution
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode listNode = null;

        var number1 = GetNumber(l1);
        var number2 = GetNumber(l2);

        var sum = number1 + number2;
        var sumString = sum.ToString().Reverse();
        var sumArray = sumString.ToArray();


        for (int i = 0; i < sumArray.Length; i++)
        {
            AddNode(int.Parse(sumArray[i].ToString()), ref listNode);
        }

        return listNode;
    }

    public static void AddNode(int val, ref ListNode Head)
    {
        if (Head is null)
        {
            Head = new ListNode() { value = val, next = null };
            return;
        }

        ListNode iter = Head;

        while (iter.next is not null)
        {
            iter = iter.next;
        }

        iter.next = new ListNode() { value = val, next = null };
    }

    public static int GetNumber(ListNode list)
    {
        StringBuilder sb = new();

        ListNode iter = list;

        while (iter is not null)
        {
            sb.Append(iter.value.ToString());
            iter = iter.next;
        }

        var number = sb.ToString();
        var reverseNumber = number.Reverse();
        sb.Clear();
        foreach (var c in reverseNumber)
        {
            sb.Append(c);
        }

        return int.Parse(sb.ToString());
    }
}