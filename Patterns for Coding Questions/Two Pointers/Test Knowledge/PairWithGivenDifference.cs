namespace LeetCode.Patterns_for_Coding_Questions.Two_Pointers.Test_Knowledge;

public class PairWithGivenDifference
{
    public static int FindPair(List<int> A, int B) {
        A.Sort();
        int n = A.Count;
        int i = 0, j = 1;

        while (i < n && j < n)
        {
            int diff = A[j] - A[i];

            if (i != j && diff == B)
            {
                return 1;
            }
            else if (diff < B)
            {
                j++;
            }
            else
            {
                i++;
            }

            // If i and j become equal, move j ahead
            if (i == j)
            {
                j++;
            }
        }

        return 0;
    }
}