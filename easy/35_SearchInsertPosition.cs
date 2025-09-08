namespace LeetCode.easy;

/*
Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.

Example 1:

Input: nums = [1,3,5,6], target = 5
Output: 2
Example 2:

Input: nums = [1,3,5,6], target = 2
Output: 1
Example 3:

Input: nums = [1,3,5,6], target = 7
Output: 4
 */

public class SearchInsertPosition {
 
    public int SearchInsert(int[] nums, int target) {
        int leftPosition = 0;
        int rightPosition = nums.Length - 1;
        
        while (leftPosition <= rightPosition)
        {
            int middlePosition = (leftPosition + rightPosition) / 2;
            
            if (nums[middlePosition] == target)
            {
                return middlePosition;
            }
            else if (nums[middlePosition] < target)
            {
                leftPosition = middlePosition + 1;
            }
            else if (nums[middlePosition] > target)
            {
                rightPosition = middlePosition - 1;
            }
        }

        return leftPosition;
    }
 
}