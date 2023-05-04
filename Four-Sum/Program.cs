using System.Diagnostics.CodeAnalysis;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        var response = new Solution().FourSum(new int[] { 2, 2, 2, 2, 2 }, 8);

        foreach (var var in response)
        {
            foreach (var x in var)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("--------------");
        }
    }
}

class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        IList<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    for (int l = k + 1; l < nums.Length; l++)
                    {
                        if (target == nums[i] + nums[j] + nums[k] + nums[l])
                        {
                            var node = new List<int>() { nums[i], nums[j], nums[k], nums[l] };
                            node.Sort();

                            if (!result.Any(node2 => node.SequenceEqual(node2)))
                            {
                                result.Add(node);
                            }
                        }
                    }
                }
            }
        }

        return result;
    }
}