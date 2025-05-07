namespace LeetCode.Patterns_for_Coding_Questions.Two_Pointers;

public class MakeSquares
{
    // Input: [-2, -1, 0, 2, 3]
    // Output: [0, 1, 4, 4, 9]
    
    public static int[] MakeSquaresFunc(int[] arr) {
        int n = arr.Length;
        int[] squares = new int[n];
        int highestSquareIdx = n - 1;
        int left = 0, right = n - 1;
        while (left <= right)
        {
            int leftSquare = arr[left] * arr[left];
            int rightSquare = arr[right] * arr[right];
            if (leftSquare > rightSquare)
            {
                squares[highestSquareIdx] = leftSquare;
                left++;
            }
            else
            {
                squares[highestSquareIdx] = rightSquare;
                right--;
            }
            highestSquareIdx--;
        }
        return squares;
    }
}