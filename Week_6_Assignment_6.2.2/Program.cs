using System.Globalization;

namespace Week_6_Assignment_6._2._2
{
    internal class Program
    {
        static int[] ProductPrefixSuffix(int[] nums)
        {
            int n = nums.Length;
            int[] answer = new int[n];

            // Fill with left element
            answer[0] = 1;
            for (int i = 1; i < n; i++)
            {
                answer[i] = answer[i - 1] * nums[i - 1];
            }

            // Multiply with right element
            int right = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                answer[i] *= right;
                right *= nums[i];
            }
            return answer;
        }

        // Display O(n)
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            int[] result = ProductPrefixSuffix(nums);
            Console.WriteLine("[" + string.Join(", ", result) + " ]");
        } 
    }
}

