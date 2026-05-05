public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string longest = string.Empty;
        for(var i = 0 ; i < strs.Length; i++)
        {
            var target = strs[i];
            if(i == 0) 
            {
                longest = target;
            } else
            {
                var minSize = Math.Min(target.Length, longest.Length);
                int shortIndex = minSize;
                for(int j = 0; j < minSize; j++) 
                {
                    if(target[j] != longest[j]) {
                        shortIndex = j;
                        break;
                    }
                }
                longest = longest.Substring(0, shortIndex);
            }
        }
        return longest;
    }
}