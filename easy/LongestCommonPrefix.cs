namespace LeetCode.easy;

/*
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

 

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
*/

public class Longest_Common_Prefix
{
    public string LongestCommonPrefix(string[] strs)
    {
        string result = "";

        if (strs == null || strs.Length == 0)
            return result;

        for (int selectetLetter = 0; selectetLetter < strs[0].Length; selectetLetter++) {
            string currentLetter = strs[0][selectetLetter].ToString();

            for (int currentWord = 0; currentWord < strs.Length; currentWord++) {
                if (selectetLetter >= strs[currentWord].Length || 
                    currentLetter != strs[currentWord][selectetLetter].ToString()) {
                    return result;
                }
            }
            result += currentLetter;
        }
        return result;
    }
}