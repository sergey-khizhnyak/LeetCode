namespace LeetCode.Patterns_for_Coding_Questions.Two_Pointers;

public class TargetSum
{
    // Input: [1, 2, 3, 4, 6], target=6
    // Output: [1, 3]
    // Explanation: The numbers at index 1 and 3 add up to 6: 2+4=6
    
    public static int[] Search(int[] arr, int targetSum)
    {
        int startIndex = 0;
        int endIndex = arr.Length - 1;
        while (startIndex < endIndex)
        {
            int currentSum = arr[startIndex] + arr[endIndex];
            if (currentSum == targetSum)
                return new int[] { startIndex, endIndex }; // found the pair

            if (targetSum > currentSum)
                startIndex++; // we need a pair with a bigger sum
            else
                endIndex--; // we need a pair with a smaller sum
        }

        return new int[] { -1, -1 };
    }
    
    // Alternative approach
    
    // Input: [1, 2, 3, 4, 6], target=6
    // Output: [1, 3]
    // Explanation: The numbers at index 1 and 3 add up to 6: 2+4=6
    
    public static int[] SearchFunc(int[] arr, int targetSum)
    {
        Dictionary<int, int> nums = new Dictionary<int, int>(); // to store numbers and indices
        for (int i = 0; i < arr.Length; i++)
        {
            if (nums.ContainsKey(targetSum - arr[i]))
                return new int[] { nums[targetSum - arr[i]], i };
            else
                nums[arr[i]] = i; // put the number and its index in the dictionary
        }
        return new int[] { -1, -1 }; // pair not found
    }
}