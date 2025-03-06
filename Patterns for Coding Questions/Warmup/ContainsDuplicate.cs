namespace LeetCode.Patterns_for_Coding_Questions.Warmup;

public class ContainsDuplicate
{
    // Input: nums= [1, 2, 3, 1]
    // Output: true  
    // Explanation: '1' is repeating.
    public static bool ContainsDuplicateFunc(int[] nums) {
        HashSet<int> hs = new HashSet<int>();
        foreach (var number in nums)
        {
            if (!hs.Add(number))
            {
                return true;
            }
        }
        return false;
    }
    
    // Time complexity: O(N)
    // Space complexity: O(N)
}