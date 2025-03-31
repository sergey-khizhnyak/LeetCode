namespace LeetCode.Patterns_for_Coding_Questions.Warmup;

public class ReverseVowels
{
    /*public static string ReverseVowelsFunc(string s) {
        var stack = new Stack<char>();
        var result = "";
        foreach (var ch in s.ToCharArray())
        {
            if (IsVowel(ch))
            {
                stack.Push(ch);
            }
        }

        foreach (var t in s)
        {
            if (IsVowel(t))
            {
                result += stack.Pop();
                continue;
            }
            result += t;
        }
        return result;
    }
    
    private static bool IsVowel(char c)
    {
        c = char.ToLower(c);
        return c is 'a' or 'e' or 'i' or 'o' or 'u';
    }*/

    private const string Vowels = "aeiouAEIOU";

    public static string ReverseVowelsFunc(string s) {
        int first = 0, last = s.Length - 1; // Initialize the two pointers
        char[] array = s.ToCharArray();
        while (first < last) {
            while (first < last && !Vowels.Contains(array[first])) {
                first++; // Skip non-vowel characters from the start
            }
            while (first < last && !Vowels.Contains(array[last])) {
                last--; // Skip non-vowel characters from the end
            }
            char temp = array[first]; // Swap the vowels found at first and last
            array[first] = array[last];
            array[last] = temp;
            first++;
            last--;
        }
        return new string(array); // Return the reversed string
    }
}