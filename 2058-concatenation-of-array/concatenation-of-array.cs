public class Solution {
    public int[] GetConcatenation(int[] nums) {

        //sample copy submission
        int n = nums.Length;
        int [] res = new int[2 * n];

        for(int i=0;i<n; i++){
            res[i] = nums[i];
            res[i+n] = nums[i];
        }

        return res;
    }
}
