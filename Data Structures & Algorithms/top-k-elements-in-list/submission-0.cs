public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counts = new ();
        foreach(int num in nums) {
            if (counts.ContainsKey(num) == false) {
                counts[num] = 0;
            }

            counts[num] += 1;
        }

        PriorityQueue<int, int> sorted = new();
        foreach(var pairs in counts) {
            sorted.Enqueue(pairs.Key, -pairs.Value);
        }

        int[] results = new int[k];
        for(int i = 0; i < k; i++) {
            var pop = sorted.Dequeue();
            results[i] = pop;
        }
        return results;
    }
}
