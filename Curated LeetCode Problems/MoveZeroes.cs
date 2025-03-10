namespace LeetCode.Curated_LeetCode_Problems;

public class MoveZeroes
{
    // public static void MoveZeroesFunc(int[] nums) {
    //     var temp = new int[nums.Length];
    //     for (int i = 0, j = 0; i < nums.Length; i++)
    //     {
    //         if (nums[i] != 0) 
    //         {
    //             temp[j] = nums[i];
    //             j++;
    //         }
    //     }
    // }
    
    
    // Two pointers algorithm
    public static void MoveZeroesFunc(int[] nums) {
        int lastNonZeroFoundAt = 0; // This pointer tracks where to place next non-zero element.
    
        // Traverse through the array with the `current` pointer.
        for (int current = 0; current < nums.Length; current++) {
            // If the number is non-zero, we need to move it to the `lastNonZeroFoundAt` index.
            if (nums[current] != 0) {
                // Swap elements at `lastNonZeroFoundAt` and `current` pointers.
                int temp = nums[lastNonZeroFoundAt];
                nums[lastNonZeroFoundAt] = nums[current];
                nums[current] = temp;
            
                // Increment `lastNonZeroFoundAt`.
                lastNonZeroFoundAt++;
            }
        }
    }
}

//Time Complexity: O(n), where n is the number of elements in the array, as we perform a single pass through the array.
//Space Complexity: O(1), since we use only constant extra space (only a few additional variables).