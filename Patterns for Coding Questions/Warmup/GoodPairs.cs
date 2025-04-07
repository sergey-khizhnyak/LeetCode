namespace LeetCode.Patterns_for_Coding_Questions.Warmup;

public class GoodPairs
{
    public static int NumOfGoodPairs(int[] nums) {
        int pairCount = 0;
        Dictionary<int, int> map = new Dictionary<int, int>();
        
        foreach (int n in nums) {
            // increment the count of 'n' in the map
            map[n] = map.GetValueOrDefault(n, 0) + 1; 
            // every new occurrence of a number can be paired with every previous occurrence
            // so if a number has already appeared 'p' times, we will have 'p-1' new pairs
            pairCount += map[n] - 1;
        }
        
        return pairCount;
    }
}