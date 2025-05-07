namespace LeetCode.Patterns_for_Coding_Questions.Two_Pointers.Test_Knowledge;

public class TwoSumSorted
{
    // Given a sorted array, check if there exist two numbers whose sum is zero.
    //
    //     Example
    //     A: [-3, 1, 3, 4]
    // Answer: true
    
    public static bool HasTwoSumZero (int[] nums) {
        int left = 0;
        int right = nums.Length - 1;
        while (left < right)
        {
            int sum = nums[left] + nums[right];
            if (sum == 0)
                return true;

            if (sum > 0)
                right--;
            else
                left++;
        }
        return false;
    }
}