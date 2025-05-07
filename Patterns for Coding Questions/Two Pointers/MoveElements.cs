namespace LeetCode.Patterns_for_Coding_Questions.Two_Pointers;

public class MoveElements
{
    public static int MoveElementsFunc(int[] arr)
    {
        int nextNonDuplicate = 1;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != arr[nextNonDuplicate - 1])
            {
                arr[nextNonDuplicate] = arr[i];
                nextNonDuplicate++;   
            }
        }
        return nextNonDuplicate;
    }
    
    public static int RemoveTargetElements(int[] arr, int target)
    {
        int nextElement = 0; // Initialize index for the next element which is not 'key'
        
        // Loop through each element in the 'arr' array
        for (int i = 0; i < arr.Length; i++)
        {
            // Check if the current element is not equal to 'key'
            if (arr[i] != target)
            {
                // If not equal, assign the current element to the position of 'nextElement'
                arr[nextElement] = arr[i];
                nextElement++; // Increment 'nextElement' to the next position
            }
        }

        // 'nextElement' now holds the count of elements remaining after removal of 'key'
        return nextElement;
    }
    
    // Input: nums = [0,0,1,1,1,2,2,3,3,4]
    // Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
    public static int RemoveDuplicates(int[] nums) {
        int lastUniqueElementIndex = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[lastUniqueElementIndex - 1])
            {
                nums[lastUniqueElementIndex] = nums[i];
                lastUniqueElementIndex++;
            }
        }
        return lastUniqueElementIndex;
    }
} 