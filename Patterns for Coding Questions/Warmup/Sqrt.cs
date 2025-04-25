namespace LeetCode.Patterns_for_Coding_Questions.Warmup;

public class Sqrt
{
    public static int SqrtFunc(int x) {
        int number = x;
        while (x * x > number)
        {
            x /= 2;
        }
        return 0;
    }
}