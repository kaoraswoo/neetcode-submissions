public class Solution {
    public int MajorityElement(int[] nums) {
        // 과반수(다수)를 찾는것인데, 쉬운것은 dictionary지만 그것을 유도한 문제가 아님.
        // O(N)시간에,   O(1) 이므로 변수 하나먼 써야함.

        // 도저히 해답을 몰라서 gpt랑 학습하게됨.
        // 정답은 후보로 유지하는것의 수명을 같이 유지하고, 다른값이 나오면 상쇄시키는것임
        // 가령 BBAAAMMMMMM 였다면 처음에 BB진행하면서 B,+2, AAA되면서 A,+1. 그리고 MM진행하면서 후보 바뀌는거네

        var candidate = nums[0];
        var weight = 1;
        for(int i = 1; i < nums.Length; i++) {
            if(nums[i] != candidate) {
                weight -= 1;
            } else {
                weight += 1;
            }

            if(weight < 0) {
                candidate = nums[i];
                weight = 1;
            }
        }
        return candidate;
    }
}