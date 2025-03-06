namespace LeetCode.Curated_LeetCode_Problems;

public class MajorityElement
{
    public static int MajorityElementFunc(int[] nums) {
        int count = 0;
        int candidate = 0;
        
        // Boyer-Moore Voting Algorithm
        foreach(int num in nums) {
            if(count == 0) {
                candidate = num; // Choose a new candidate
            }
            count += (num == candidate) ? 1 : -1; // Adjust the count
        }
        
        return candidate;
    }
}