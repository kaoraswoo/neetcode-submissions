public class Solution {
    // 한개의 배열에서, 새로운 배열할당없이 덮어씌우는 부분
    // 덮어씌우는것을 다른값이 진행되었던(k)에 iterator의 값을 넣으면 된다.
    // k가 카운트도 되고, 다음들어갈 index도 겸하게 된다
    public int RemoveElement(int[] nums, int val) {
        int k = 0;
        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] != val) {
                // 다를때 iterator의 값을 넣고 k를 증가시킨다
                // i는 계속 증가하며, k는 다른값에 대해서만 증가하는 index
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}