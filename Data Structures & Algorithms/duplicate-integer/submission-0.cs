public class Solution {
    public bool hasDuplicate(int[] nums) {
        var check = new HashSet<int>();
        foreach(var num in nums) 
        {        
            if(check.Contains(num) == true) 
            {           
                return true;
            }
            check.Add(num);
        }

        return false;
    }
}