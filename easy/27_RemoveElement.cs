namespace LeetCode.easy;

public class RemoveElemente {
    public int RemoveElement(int[] nums, int val) 
    {
        if (nums.Length == 0) return 0;
        if (val == null) return 0;
        
        int counter = 0;
        int nextPosition = 0;
        
        for (int i = 0; i < nums.Length; i++) {
            
            int number = nums[i];
            
            if (number != val) {
                nums[nextPosition] = nums[i];
                nextPosition++;
                counter++;
            }    
        }
        return counter;
    }
}