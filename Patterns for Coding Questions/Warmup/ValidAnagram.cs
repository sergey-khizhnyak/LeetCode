namespace LeetCode.Patterns_for_Coding_Questions.Warmup;

public class ValidAnagram
{
    public static bool isAnagram(string s, string t)
    {
        // if (s.Length != t.Length)
        //     return false;
        // foreach (var t1 in s)
        // {
        //     if (!t.Contains(t1))
        //         return false;
        // }
        //
        // return true;
        
        // Check if the lengths of both strings are equal. If not, return false.
        if (s.Length != t.Length) {
            return false;
        }

        // Create a dictionary to store the frequency of characters in both strings.
        Dictionary<char, int> freqMap = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++) {
            // Increment the frequency of the character in string s.
            freqMap[s[i]] = freqMap.GetValueOrDefault(s[i], 0) + 1;
            // Decrement the frequency of the character in string t.
            freqMap[t[i]] = freqMap.GetValueOrDefault(t[i], 0) - 1;
        }

        // Check if the frequency of all characters is 0.
        foreach (var entry in freqMap) {
            if (entry.Value != 0) {
                return false;
            }
        }

        // If all characters have a frequency of 0, this means that 't' is an anagram of 's'.
        return true;
    }
}