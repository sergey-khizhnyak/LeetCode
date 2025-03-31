namespace LeetCode.Patterns_for_Coding_Questions.Warmup;

public class ValidPalindrome
{
    // Input: sentence = "A man, a plan, a canal, Panama!"
    // Output: true
    // Explanation: "amanaplanacanalpanama" is a palindrome.
    
    // public static bool isPalindrome(string s)
    // {
    //     var pured = s.Where(ch => char.IsLetterOrDigit(ch)).Aggregate(string.Empty, (current, ch) => current + ch);
    //     return pured.ToLower() == new string(pured.Reverse().ToArray()).ToLower();
    // }
    
    public static bool isPalindrome(string s) {
        int i = 0, j = s.Length - 1;  // initialize two pointers, one at the start and one at the end of the string
        
        while (i < j) {  // continue until the two pointers cross over
            while (i < j && !Char.IsLetterOrDigit(s[i])) {  // move i forward until a letter or digit is found
                i++;
            }
            while (i < j && !Char.IsLetterOrDigit(s[j])) {  // move j backward until a letter or digit is found
                j--;
            }

            // compare the characters at i and j after converting them to lowercase
            if (Char.ToLower(s[i]) != Char.ToLower(s[j])) 
                return false;  // if they are not equal, the string is not a palindrome
            i++;  // move i forward
            j--;  // move j backward
        }

        return true;  // if the two pointers have crossed over, the string is a palindrome
    }
}