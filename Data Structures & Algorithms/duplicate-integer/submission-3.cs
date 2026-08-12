public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> stores = new HashSet<int>();
        foreach(var num in nums) 
        {
            if(stores.Contains(num) == true) {
                return true;
            }
            stores.Add(num);
        }
        return false;
    }
}