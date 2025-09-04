namespace LeetCode.easy;
/*
 * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 */

public class TwoSum {
    public int[] Two_Sum(int[] nums, int target)
    {
        for (int firstNumber = 0; firstNumber < nums.Length; firstNumber++)
        {
            for (int secondNumber = firstNumber + 1; secondNumber < nums.Length; secondNumber++)
            {
                if (nums[firstNumber] + nums[secondNumber] == target)
                {
                    return new int[] { firstNumber, secondNumber };
                }
            }
        }
        throw new ArgumentException("No two sum solution");
    }
}