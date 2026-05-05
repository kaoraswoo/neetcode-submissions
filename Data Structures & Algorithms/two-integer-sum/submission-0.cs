public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // 가장 작은index로 덮어씌우는 전략
        // key: diff, value: index(작은것)
        var historyDiff = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++) 
        {
            var num = nums[i];
            var diff = target - num;
            if(historyDiff.ContainsKey(diff) == true) 
            {
                return [historyDiff[diff], i];
            }
            historyDiff[num] = i;
        }

        return [0,0];

    }
}
