namespace LeetCode.Patterns_for_Coding_Questions.Warmup;

public class Pangram
{
    // Input: sentence = "TheQuickBrownFoxJumpsOverTheLazyDog"
    // Output: true
    // Explanation: The sentence contains at least one occurrence of every letter of the English alphabet either in lower or upper case.
    
    public static bool CheckIfPangramFunc(string sentence) {
        HashSet<char> hs = new HashSet<char>();
        foreach (var ch in sentence.ToLower().ToCharArray())
        {
            if (char.IsLetter(ch))
            {
                hs.Add(ch);
            }
        }
        return hs.Count == 26;
    }
    
    // Time complexity: O(N)
    // Space complexity: O(1)
}